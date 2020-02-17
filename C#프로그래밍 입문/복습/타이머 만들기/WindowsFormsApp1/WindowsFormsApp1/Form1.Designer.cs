namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_H = new System.Windows.Forms.Label();
            this.lbl_M = new System.Windows.Forms.Label();
            this.lbl_S = new System.Windows.Forms.Label();
            this.lbl_o1 = new System.Windows.Forms.Label();
            this.lbl_o2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cmb_S = new System.Windows.Forms.ComboBox();
            this.cmb_M = new System.Windows.Forms.ComboBox();
            this.cmb_H = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "시작";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_H
            // 
            this.lbl_H.Font = new System.Drawing.Font("굴림", 50F);
            this.lbl_H.Location = new System.Drawing.Point(43, 93);
            this.lbl_H.Name = "lbl_H";
            this.lbl_H.Size = new System.Drawing.Size(106, 65);
            this.lbl_H.TabIndex = 1;
            this.lbl_H.Text = "00";
            // 
            // lbl_M
            // 
            this.lbl_M.Font = new System.Drawing.Font("굴림", 50F);
            this.lbl_M.Location = new System.Drawing.Point(241, 93);
            this.lbl_M.Name = "lbl_M";
            this.lbl_M.Size = new System.Drawing.Size(106, 65);
            this.lbl_M.TabIndex = 2;
            this.lbl_M.Text = "00";
            // 
            // lbl_S
            // 
            this.lbl_S.Font = new System.Drawing.Font("굴림", 50F);
            this.lbl_S.Location = new System.Drawing.Point(439, 93);
            this.lbl_S.Name = "lbl_S";
            this.lbl_S.Size = new System.Drawing.Size(106, 65);
            this.lbl_S.TabIndex = 2;
            this.lbl_S.Text = "00";
            // 
            // lbl_o1
            // 
            this.lbl_o1.Font = new System.Drawing.Font("굴림", 50F);
            this.lbl_o1.Location = new System.Drawing.Point(176, 93);
            this.lbl_o1.Name = "lbl_o1";
            this.lbl_o1.Size = new System.Drawing.Size(38, 65);
            this.lbl_o1.TabIndex = 3;
            this.lbl_o1.Text = ":";
            // 
            // lbl_o2
            // 
            this.lbl_o2.Font = new System.Drawing.Font("굴림", 50F);
            this.lbl_o2.Location = new System.Drawing.Point(374, 93);
            this.lbl_o2.Name = "lbl_o2";
            this.lbl_o2.Size = new System.Drawing.Size(38, 65);
            this.lbl_o2.TabIndex = 3;
            this.lbl_o2.Text = ":";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(134, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 35);
            this.button3.TabIndex = 15;
            this.button3.Text = "설정";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmb_S
            // 
            this.cmb_S.Font = new System.Drawing.Font("굴림", 20F);
            this.cmb_S.FormattingEnabled = true;
            this.cmb_S.Location = new System.Drawing.Point(362, 237);
            this.cmb_S.Name = "cmb_S";
            this.cmb_S.Size = new System.Drawing.Size(58, 35);
            this.cmb_S.TabIndex = 13;
            // 
            // cmb_M
            // 
            this.cmb_M.Font = new System.Drawing.Font("굴림", 20F);
            this.cmb_M.FormattingEnabled = true;
            this.cmb_M.Location = new System.Drawing.Point(253, 237);
            this.cmb_M.Name = "cmb_M";
            this.cmb_M.Size = new System.Drawing.Size(58, 35);
            this.cmb_M.TabIndex = 12;
            // 
            // cmb_H
            // 
            this.cmb_H.Font = new System.Drawing.Font("굴림", 20F);
            this.cmb_H.FormattingEnabled = true;
            this.cmb_H.Location = new System.Drawing.Point(144, 237);
            this.cmb_H.Name = "cmb_H";
            this.cmb_H.Size = new System.Drawing.Size(58, 35);
            this.cmb_H.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 20F);
            this.label3.Location = new System.Drawing.Point(324, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = ":";
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("굴림", 20F);
            this.lbl1.Location = new System.Drawing.Point(215, 240);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(25, 29);
            this.lbl1.TabIndex = 10;
            this.lbl1.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 430);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmb_S);
            this.Controls.Add(this.cmb_M);
            this.Controls.Add(this.cmb_H);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl_o2);
            this.Controls.Add(this.lbl_o1);
            this.Controls.Add(this.lbl_S);
            this.Controls.Add(this.lbl_M);
            this.Controls.Add(this.lbl_H);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "타이머";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label lbl_H;
        public System.Windows.Forms.Label lbl_M;
        public System.Windows.Forms.Label lbl_S;
        public System.Windows.Forms.Label lbl_o1;
        public System.Windows.Forms.Label lbl_o2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmb_S;
        private System.Windows.Forms.ComboBox cmb_M;
        private System.Windows.Forms.ComboBox cmb_H;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl1;
    }
}

