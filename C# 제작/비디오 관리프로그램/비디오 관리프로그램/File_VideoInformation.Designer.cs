namespace 비디오_관리프로그램
{
    partial class File_VideoInformation
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Range = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Rant = new System.Windows.Forms.Button();
            this.button_Viedeo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "비디오 장르 :";
            // 
            // comboBox_Range
            // 
            this.comboBox_Range.FormattingEnabled = true;
            this.comboBox_Range.Items.AddRange(new object[] {
            "전체",
            "가족",
            "액션",
            "코미디",
            "범죄",
            "SF",
            "전쟁",
            "믹스",
            "기타"});
            this.comboBox_Range.Location = new System.Drawing.Point(104, 15);
            this.comboBox_Range.Name = "comboBox_Range";
            this.comboBox_Range.Size = new System.Drawing.Size(175, 20);
            this.comboBox_Range.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Rant);
            this.groupBox1.Controls.Add(this.button_Viedeo);
            this.groupBox1.Location = new System.Drawing.Point(14, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 57);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "엑셀로 출력";
            // 
            // button_Rant
            // 
            this.button_Rant.Location = new System.Drawing.Point(148, 20);
            this.button_Rant.Name = "button_Rant";
            this.button_Rant.Size = new System.Drawing.Size(117, 25);
            this.button_Rant.TabIndex = 0;
            this.button_Rant.Text = "대여 현황";
            this.button_Rant.UseVisualStyleBackColor = true;
            this.button_Rant.Click += new System.EventHandler(this.button_Rant_Click);
            // 
            // button_Viedeo
            // 
            this.button_Viedeo.Location = new System.Drawing.Point(6, 20);
            this.button_Viedeo.Name = "button_Viedeo";
            this.button_Viedeo.Size = new System.Drawing.Size(117, 25);
            this.button_Viedeo.TabIndex = 0;
            this.button_Viedeo.Text = "비디오 목록";
            this.button_Viedeo.UseVisualStyleBackColor = true;
            this.button_Viedeo.Click += new System.EventHandler(this.button_Viedeo_Click);
            // 
            // File_VideoInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(297, 110);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox_Range);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "File_VideoInformation";
            this.Text = "엑셀출력";
            this.Load += new System.EventHandler(this.File_VideoInformation_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Range;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Rant;
        private System.Windows.Forms.Button button_Viedeo;
    }
}