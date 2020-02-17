namespace WindowsFormsApp1
{
    partial class SetTime
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.cmb_H = new System.Windows.Forms.ComboBox();
            this.cmb_M = new System.Windows.Forms.ComboBox();
            this.cmb_S = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("굴림", 20F);
            this.lbl1.Location = new System.Drawing.Point(111, 85);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(25, 29);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = ":";
            // 
            // cmb_H
            // 
            this.cmb_H.Font = new System.Drawing.Font("굴림", 20F);
            this.cmb_H.FormattingEnabled = true;
            this.cmb_H.Location = new System.Drawing.Point(40, 82);
            this.cmb_H.Name = "cmb_H";
            this.cmb_H.Size = new System.Drawing.Size(58, 35);
            this.cmb_H.TabIndex = 3;
            // 
            // cmb_M
            // 
            this.cmb_M.Font = new System.Drawing.Font("굴림", 20F);
            this.cmb_M.FormattingEnabled = true;
            this.cmb_M.Location = new System.Drawing.Point(149, 82);
            this.cmb_M.Name = "cmb_M";
            this.cmb_M.Size = new System.Drawing.Size(58, 35);
            this.cmb_M.TabIndex = 4;
            // 
            // cmb_S
            // 
            this.cmb_S.Font = new System.Drawing.Font("굴림", 20F);
            this.cmb_S.FormattingEnabled = true;
            this.cmb_S.Location = new System.Drawing.Point(258, 82);
            this.cmb_S.Name = "cmb_S";
            this.cmb_S.Size = new System.Drawing.Size(58, 35);
            this.cmb_S.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.Location = new System.Drawing.Point(220, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "설정";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SetTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 221);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_S);
            this.Controls.Add(this.cmb_M);
            this.Controls.Add(this.cmb_H);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Name = "SetTime";
            this.Text = "시간설정";
            this.Load += new System.EventHandler(this.SetTime_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ComboBox cmb_H;
        private System.Windows.Forms.ComboBox cmb_M;
        private System.Windows.Forms.ComboBox cmb_S;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}