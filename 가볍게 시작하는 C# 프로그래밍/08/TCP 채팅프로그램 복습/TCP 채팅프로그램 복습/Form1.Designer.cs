namespace TCP_채팅프로그램_복습
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
            this.txt_PortNum = new System.Windows.Forms.TextBox();
            this.txt_IPNum = new System.Windows.Forms.TextBox();
            this.btn_ServerStart = new System.Windows.Forms.Button();
            this.btn_ServerClose = new System.Windows.Forms.Button();
            this.bnt_ClientStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_View = new System.Windows.Forms.TextBox();
            this.txt_Send = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_PortNum
            // 
            this.txt_PortNum.Location = new System.Drawing.Point(66, 39);
            this.txt_PortNum.Name = "txt_PortNum";
            this.txt_PortNum.Size = new System.Drawing.Size(260, 21);
            this.txt_PortNum.TabIndex = 0;
            // 
            // txt_IPNum
            // 
            this.txt_IPNum.Location = new System.Drawing.Point(66, 12);
            this.txt_IPNum.Name = "txt_IPNum";
            this.txt_IPNum.Size = new System.Drawing.Size(260, 21);
            this.txt_IPNum.TabIndex = 0;
            // 
            // btn_ServerStart
            // 
            this.btn_ServerStart.Location = new System.Drawing.Point(12, 66);
            this.btn_ServerStart.Name = "btn_ServerStart";
            this.btn_ServerStart.Size = new System.Drawing.Size(102, 39);
            this.btn_ServerStart.TabIndex = 1;
            this.btn_ServerStart.Text = "서버시작";
            this.btn_ServerStart.UseVisualStyleBackColor = true;
            this.btn_ServerStart.Click += new System.EventHandler(this.btn_ServerStart_Click);
            // 
            // btn_ServerClose
            // 
            this.btn_ServerClose.Location = new System.Drawing.Point(118, 66);
            this.btn_ServerClose.Name = "btn_ServerClose";
            this.btn_ServerClose.Size = new System.Drawing.Size(102, 39);
            this.btn_ServerClose.TabIndex = 1;
            this.btn_ServerClose.Text = "서버종료";
            this.btn_ServerClose.UseVisualStyleBackColor = true;
            this.btn_ServerClose.Click += new System.EventHandler(this.btn_ServerClose_Click);
            // 
            // bnt_ClientStart
            // 
            this.bnt_ClientStart.Location = new System.Drawing.Point(224, 66);
            this.bnt_ClientStart.Name = "bnt_ClientStart";
            this.bnt_ClientStart.Size = new System.Drawing.Size(102, 39);
            this.bnt_ClientStart.TabIndex = 2;
            this.bnt_ClientStart.Text = "클라이언트 실행";
            this.bnt_ClientStart.UseVisualStyleBackColor = true;
            this.bnt_ClientStart.Click += new System.EventHandler(this.bnt_ClientStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP주소";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "포트";
            // 
            // txt_View
            // 
            this.txt_View.Location = new System.Drawing.Point(12, 111);
            this.txt_View.Multiline = true;
            this.txt_View.Name = "txt_View";
            this.txt_View.Size = new System.Drawing.Size(314, 208);
            this.txt_View.TabIndex = 4;
            // 
            // txt_Send
            // 
            this.txt_Send.Location = new System.Drawing.Point(12, 325);
            this.txt_Send.Multiline = true;
            this.txt_Send.Name = "txt_Send";
            this.txt_Send.Size = new System.Drawing.Size(234, 65);
            this.txt_Send.TabIndex = 4;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(252, 325);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(74, 65);
            this.btn_Send.TabIndex = 2;
            this.btn_Send.Text = "보내기";
            this.btn_Send.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 402);
            this.Controls.Add(this.txt_Send);
            this.Controls.Add(this.txt_View);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.bnt_ClientStart);
            this.Controls.Add(this.btn_ServerClose);
            this.Controls.Add(this.btn_ServerStart);
            this.Controls.Add(this.txt_IPNum);
            this.Controls.Add(this.txt_PortNum);
            this.Name = "Form1";
            this.Text = "서버";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ServerStart;
        private System.Windows.Forms.Button btn_ServerClose;
        private System.Windows.Forms.Button bnt_ClientStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Send;
        private System.Windows.Forms.Button btn_Send;
        public System.Windows.Forms.TextBox txt_PortNum;
        public System.Windows.Forms.TextBox txt_IPNum;
        public System.Windows.Forms.TextBox txt_View;
    }
}

