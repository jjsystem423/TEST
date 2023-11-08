using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace LSFENTTEST
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            form(true);
        }
        private void form(bool t)
        {
            BT_Read.Enabled = t;
            BT_Stop.Enabled = !t;
        }

        private void BT_Read_Click(object sender, EventArgs e)
        {
            form(false);
            timer1.Enabled = true;
            timer1.Interval = 100;
        }

        private void BT_Stop_Click(object sender, EventArgs e)
        {
            form(true);
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            byte[] DataFrame = MakeDataFrame();
            byte[] SendFrame = MakecompanyFrame(DataFrame);
            SendFrame = Combine(SendFrame, DataFrame);
            SendMassage(SendFrame);
        }
        private byte[] MakeDataFrame()
        {
            //byte[] CommandCode = new byte[] {0x54, 0x00};                              //명령어(읽기) h5400       
            //byte[] DataType = new byte[] {0x00, 0x00};                                 //bit h0000
            //byte[] Reserved = new byte[] {0x00, 0x00};                                 //예비 h0000
            //byte[] BlockNO = new byte[] {0x08, 0x00};                                  //변수갯수(8)
            
            byte[] DataFrame = new byte[] { 0x54, 0x00, 0x00, 0x00, 0x00, 0x00, 0x08, 0x00 };
            byte[] DataBlock = MakevariableBlock();
            DataFrame = Combine(DataFrame, DataBlock);

            return DataFrame;

        }
        private byte[] MakevariableBlock()
        {
            byte[] VariableBlock = new byte[0];
                VariableBlock = MakeBlock("%MX100", VariableBlock); 
                VariableBlock = MakeBlock("%MX101", VariableBlock); 
                VariableBlock = MakeBlock("%MX102", VariableBlock); 
                VariableBlock = MakeBlock("%MX103", VariableBlock); 
                VariableBlock = MakeBlock("%PX024", VariableBlock); 
                VariableBlock = MakeBlock("%PX025", VariableBlock); 
                VariableBlock = MakeBlock("%PX026", VariableBlock);
                VariableBlock = MakeBlock("%PX027", VariableBlock);

            return VariableBlock;

        }
        private byte[] MakeBlock(string VariableName, byte[] VariableBlock)
        {
            byte[] VariableLenght = new byte[2] { 0x06, 0x00 };    //변수길이
            VariableBlock = Combine(VariableBlock, VariableLenght);

            byte[] VariableFrame = Encoding.Default.GetBytes(VariableName);
            VariableBlock = Combine(VariableBlock, VariableFrame);

            return VariableBlock;
        }

        private byte[] MakecompanyFrame(byte[] DataFrame)
        {
            string Company_ID = "LSIS-XGT";                              //PLC 타입
            byte[] CompanyFrame = Encoding.Default.GetBytes(Company_ID);

            //                      byte[] reserved = new byte[2] { 0x00, 0x00 };              //예비
            //                      byte[] PLC_Info = new byte[2] { 0x00, 0x00 };              //PLC 정보
            //                      byte[] CPU_Info = new byte[1] { 0xB0 };                    //XGB(MK)
            //                      byte[] Source0fFrame = new byte[1] { 0x33 };               //PC->PLC
            //                      byte[] InvokeID = new byte[2] { 0x00, 0x00 };              //인식번호 0번
            byte[] CPU_Info = new byte[] { 0x00, 0x00, 0x00, 0x00, 0xA0, 0X33, 0X00, 0X00 };
            CompanyFrame = Combine(CompanyFrame, CPU_Info);

            byte[] Lenght = new byte[] { (byte)DataFrame.Length, 0x00 };       //데이터의 길이 (바이트수)
            CompanyFrame = Combine(CompanyFrame, Lenght);

            byte[] FEnetPosition = new byte[] { 0x00 };                        //0번베이스, 1번슬롯
            CompanyFrame = Combine(CompanyFrame, FEnetPosition);

            byte[] BCC = new byte[1];
            ushort crc = Calc(CompanyFrame);
            BCC[0] = (byte)crc;
            CompanyFrame = Combine(CompanyFrame, BCC);

            return CompanyFrame;

        }
        private void SendMassage( byte[] SendFrame )
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            sock.SendTimeout = 3000;
            sock.ReceiveTimeout = 3000;

            IPAddress serverIP = IPAddress.Parse("192.168.1.2");
            int serverPort = 2004;
            IPEndPoint ipep = new IPEndPoint(serverIP, serverPort);

            if (sock.IsBound == true) sock.Close();

            sock.Connect(ipep);
            if (sock.Connected)
            {
                sock.Send(SendFrame);
                sendframetb.Text = BitConverter.ToString(SendFrame);
                byte[] Rdata = new byte[100];
                sock.Receive(Rdata);
                readframetb.Text = BitConverter.ToString(Rdata);
                Received_Data_Processing(Rdata);

            }
            sock.Close();

        }
        private void Received_Data_Processing(byte[] Rdata)
        {
            m100cb.Checked = BitConverter.ToBoolean(Rdata, 32);                      //Bool 표현(byte)
            m200cb.Checked = BitConverter.ToBoolean(Rdata, 35);                      //Bool 표현(byte)
            m300cb.Checked = BitConverter.ToBoolean(Rdata, 38);                      //Bool 표현(byte)
            m400cb.Checked = BitConverter.ToBoolean(Rdata, 41);                      //Bool 표현(byte)
            p24cb.Checked = BitConverter.ToBoolean(Rdata, 44);                       //Bool 표현(byte)
            p25cb.Checked = BitConverter.ToBoolean(Rdata, 47);                       //Bool 표현(byte)
            p26cb.Checked = BitConverter.ToBoolean(Rdata, 50);                       //Bool 표현(byte)
            p27cb.Checked = BitConverter.ToBoolean(Rdata, 53);                       //Bool 표현(byte)

        }
        private byte[] Combine(byte[] a, byte[] b)
        {                                                                            //byte 합치기
            byte[] c = new byte[a.Length + b.Length];
            Buffer.BlockCopy(a, 0, c, 0, a.Length);
            Buffer.BlockCopy(b, 0, c, a.Length, b.Length);
            return c;
        }

        private static ushort Calc(byte[] data)
        {                                                                          //crc 코드 생성
            ushort crc = 0xFFFF;
            for (int pos = 0; pos < data.Length; pos++)
            {
                crc ^= (UInt16)data[pos];
                for (int i = 8; i != 0; i--)
                {
                    if ((crc & 0x0001) != 0)
                    {
                        crc >>= 1;
                        crc ^= 0xA001;
                    }
                    else crc >>= 1;
                }
            }
            return crc;
        }

    }
}
