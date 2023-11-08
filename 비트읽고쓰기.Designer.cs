
namespace LSFENTTEST
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.m100cb = new System.Windows.Forms.CheckBox();
            this.m200cb = new System.Windows.Forms.CheckBox();
            this.m300cb = new System.Windows.Forms.CheckBox();
            this.m400cb = new System.Windows.Forms.CheckBox();
            this.p24cb = new System.Windows.Forms.CheckBox();
            this.p25cb = new System.Windows.Forms.CheckBox();
            this.p26cb = new System.Windows.Forms.CheckBox();
            this.p27cb = new System.Windows.Forms.CheckBox();
            this.sendframetb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.readframetb = new System.Windows.Forms.TextBox();
            this.BT_Read = new System.Windows.Forms.Button();
            this.BT_Stop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // m100cb
            // 
            this.m100cb.AutoSize = true;
            this.m100cb.Location = new System.Drawing.Point(93, 258);
            this.m100cb.Name = "m100cb";
            this.m100cb.Size = new System.Drawing.Size(53, 16);
            this.m100cb.TabIndex = 0;
            this.m100cb.Text = "M100";
            this.m100cb.UseVisualStyleBackColor = true;
            // 
            // m200cb
            // 
            this.m200cb.AutoSize = true;
            this.m200cb.Location = new System.Drawing.Point(211, 258);
            this.m200cb.Name = "m200cb";
            this.m200cb.Size = new System.Drawing.Size(53, 16);
            this.m200cb.TabIndex = 1;
            this.m200cb.Text = "M101";
            this.m200cb.UseVisualStyleBackColor = true;
            // 
            // m300cb
            // 
            this.m300cb.AutoSize = true;
            this.m300cb.Location = new System.Drawing.Point(327, 258);
            this.m300cb.Name = "m300cb";
            this.m300cb.Size = new System.Drawing.Size(53, 16);
            this.m300cb.TabIndex = 2;
            this.m300cb.Text = "M102";
            this.m300cb.UseVisualStyleBackColor = true;
            // 
            // m400cb
            // 
            this.m400cb.AutoSize = true;
            this.m400cb.Location = new System.Drawing.Point(443, 258);
            this.m400cb.Name = "m400cb";
            this.m400cb.Size = new System.Drawing.Size(53, 16);
            this.m400cb.TabIndex = 3;
            this.m400cb.Text = "M103";
            this.m400cb.UseVisualStyleBackColor = true;
            // 
            // p24cb
            // 
            this.p24cb.AutoSize = true;
            this.p24cb.Location = new System.Drawing.Point(93, 316);
            this.p24cb.Name = "p24cb";
            this.p24cb.Size = new System.Drawing.Size(44, 16);
            this.p24cb.TabIndex = 4;
            this.p24cb.Text = "P24";
            this.p24cb.UseVisualStyleBackColor = true;
            // 
            // p25cb
            // 
            this.p25cb.AutoSize = true;
            this.p25cb.Location = new System.Drawing.Point(211, 316);
            this.p25cb.Name = "p25cb";
            this.p25cb.Size = new System.Drawing.Size(44, 16);
            this.p25cb.TabIndex = 5;
            this.p25cb.Text = "P25";
            this.p25cb.UseVisualStyleBackColor = true;
            // 
            // p26cb
            // 
            this.p26cb.AutoSize = true;
            this.p26cb.Location = new System.Drawing.Point(327, 316);
            this.p26cb.Name = "p26cb";
            this.p26cb.Size = new System.Drawing.Size(44, 16);
            this.p26cb.TabIndex = 6;
            this.p26cb.Text = "P26";
            this.p26cb.UseVisualStyleBackColor = true;
            // 
            // p27cb
            // 
            this.p27cb.AutoSize = true;
            this.p27cb.Location = new System.Drawing.Point(443, 316);
            this.p27cb.Name = "p27cb";
            this.p27cb.Size = new System.Drawing.Size(44, 16);
            this.p27cb.TabIndex = 7;
            this.p27cb.Text = "P27";
            this.p27cb.UseVisualStyleBackColor = true;
            // 
            // sendframetb
            // 
            this.sendframetb.Font = new System.Drawing.Font("굴림", 12F);
            this.sendframetb.Location = new System.Drawing.Point(61, 134);
            this.sendframetb.Name = "sendframetb";
            this.sendframetb.Size = new System.Drawing.Size(464, 26);
            this.sendframetb.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.Location = new System.Drawing.Point(57, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "송신 Frame";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15F);
            this.label2.Location = new System.Drawing.Point(57, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "수신 Frame";
            // 
            // readframetb
            // 
            this.readframetb.Font = new System.Drawing.Font("굴림", 12F);
            this.readframetb.Location = new System.Drawing.Point(61, 204);
            this.readframetb.Name = "readframetb";
            this.readframetb.Size = new System.Drawing.Size(464, 26);
            this.readframetb.TabIndex = 10;
            // 
            // BT_Read
            // 
            this.BT_Read.Location = new System.Drawing.Point(74, 39);
            this.BT_Read.Name = "BT_Read";
            this.BT_Read.Size = new System.Drawing.Size(202, 43);
            this.BT_Read.TabIndex = 12;
            this.BT_Read.Text = "읽기";
            this.BT_Read.UseVisualStyleBackColor = true;
            this.BT_Read.Click += new System.EventHandler(this.BT_Read_Click);
            // 
            // BT_Stop
            // 
            this.BT_Stop.Location = new System.Drawing.Point(309, 39);
            this.BT_Stop.Name = "BT_Stop";
            this.BT_Stop.Size = new System.Drawing.Size(202, 43);
            this.BT_Stop.TabIndex = 13;
            this.BT_Stop.Text = "정지";
            this.BT_Stop.UseVisualStyleBackColor = true;
            this.BT_Stop.Click += new System.EventHandler(this.BT_Stop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("굴림", 15F);
            this.groupBox1.Location = new System.Drawing.Point(44, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 337);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BIT 개별 읽기";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.BT_Stop);
            this.Controls.Add(this.BT_Read);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.readframetb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendframetb);
            this.Controls.Add(this.p27cb);
            this.Controls.Add(this.p26cb);
            this.Controls.Add(this.p25cb);
            this.Controls.Add(this.p24cb);
            this.Controls.Add(this.m400cb);
            this.Controls.Add(this.m300cb);
            this.Controls.Add(this.m200cb);
            this.Controls.Add(this.m100cb);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox m100cb;
        private System.Windows.Forms.CheckBox m200cb;
        private System.Windows.Forms.CheckBox m300cb;
        private System.Windows.Forms.CheckBox m400cb;
        private System.Windows.Forms.CheckBox p24cb;
        private System.Windows.Forms.CheckBox p25cb;
        private System.Windows.Forms.CheckBox p26cb;
        private System.Windows.Forms.CheckBox p27cb;
        private System.Windows.Forms.TextBox sendframetb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox readframetb;
        private System.Windows.Forms.Button BT_Read;
        private System.Windows.Forms.Button BT_Stop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

