namespace 채팅프로그램
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bnt_SeverStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MyPort = new System.Windows.Forms.TextBox();
            this.txt_MyIp = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bnt_SeverAccept = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ServerPort = new System.Windows.Forms.TextBox();
            this.txt_ServerIp = new System.Windows.Forms.TextBox();
            this.txt_View = new System.Windows.Forms.TextBox();
            this.txt_send = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bnt_SeverStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_MyPort);
            this.groupBox1.Controls.Add(this.txt_MyIp);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "서버용";
            // 
            // bnt_SeverStart
            // 
            this.bnt_SeverStart.Location = new System.Drawing.Point(309, 14);
            this.bnt_SeverStart.Name = "bnt_SeverStart";
            this.bnt_SeverStart.Size = new System.Drawing.Size(75, 54);
            this.bnt_SeverStart.TabIndex = 2;
            this.bnt_SeverStart.Text = "서버시작";
            this.bnt_SeverStart.UseVisualStyleBackColor = true;
            this.bnt_SeverStart.Click += new System.EventHandler(this.bnt_SeverStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "My Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "My IP";
            // 
            // txt_MyPort
            // 
            this.txt_MyPort.Location = new System.Drawing.Point(90, 47);
            this.txt_MyPort.Name = "txt_MyPort";
            this.txt_MyPort.Size = new System.Drawing.Size(199, 21);
            this.txt_MyPort.TabIndex = 0;
            // 
            // txt_MyIp
            // 
            this.txt_MyIp.Location = new System.Drawing.Point(90, 14);
            this.txt_MyIp.Name = "txt_MyIp";
            this.txt_MyIp.Size = new System.Drawing.Size(199, 21);
            this.txt_MyIp.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bnt_SeverAccept);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_ServerPort);
            this.groupBox2.Controls.Add(this.txt_ServerIp);
            this.groupBox2.Location = new System.Drawing.Point(12, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 81);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "클라이언트용";
            // 
            // bnt_SeverAccept
            // 
            this.bnt_SeverAccept.Location = new System.Drawing.Point(309, 14);
            this.bnt_SeverAccept.Name = "bnt_SeverAccept";
            this.bnt_SeverAccept.Size = new System.Drawing.Size(75, 54);
            this.bnt_SeverAccept.TabIndex = 2;
            this.bnt_SeverAccept.Text = "서버접속";
            this.bnt_SeverAccept.UseVisualStyleBackColor = true;
            this.bnt_SeverAccept.Click += new System.EventHandler(this.bnt_SeverAccept_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Server Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Server IP";
            // 
            // txt_ServerPort
            // 
            this.txt_ServerPort.Location = new System.Drawing.Point(90, 47);
            this.txt_ServerPort.Name = "txt_ServerPort";
            this.txt_ServerPort.Size = new System.Drawing.Size(199, 21);
            this.txt_ServerPort.TabIndex = 0;
            // 
            // txt_ServerIp
            // 
            this.txt_ServerIp.Location = new System.Drawing.Point(90, 14);
            this.txt_ServerIp.Name = "txt_ServerIp";
            this.txt_ServerIp.Size = new System.Drawing.Size(199, 21);
            this.txt_ServerIp.TabIndex = 0;
            // 
            // txt_View
            // 
            this.txt_View.Location = new System.Drawing.Point(14, 195);
            this.txt_View.Multiline = true;
            this.txt_View.Name = "txt_View";
            this.txt_View.Size = new System.Drawing.Size(398, 384);
            this.txt_View.TabIndex = 4;
            this.txt_View.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_View_KeyDown);
            // 
            // txt_send
            // 
            this.txt_send.Location = new System.Drawing.Point(14, 585);
            this.txt_send.Multiline = true;
            this.txt_send.Name = "txt_send";
            this.txt_send.Size = new System.Drawing.Size(315, 55);
            this.txt_send.TabIndex = 5;
            this.txt_send.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_send_KeyDown);
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(335, 585);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(77, 55);
            this.btn_Send.TabIndex = 6;
            this.btn_Send.Text = "보내기";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 655);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.txt_send);
            this.Controls.Add(this.txt_View);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button bnt_SeverStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MyPort;
        private System.Windows.Forms.TextBox txt_MyIp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bnt_SeverAccept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ServerPort;
        private System.Windows.Forms.TextBox txt_ServerIp;
        private System.Windows.Forms.TextBox txt_View;
        private System.Windows.Forms.TextBox txt_send;
        private System.Windows.Forms.Button btn_Send;
    }
}

