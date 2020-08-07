namespace 비디오_관리프로그램
{
    partial class Information
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.comboBox_Job = new System.Windows.Forms.ComboBox();
            this.comboBox_Range = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_ClientRentRank = new System.Windows.Forms.RadioButton();
            this.radioButton_VideoRent = new System.Windows.Forms.RadioButton();
            this.radioButton_VideoRentRank = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Close);
            this.groupBox1.Controls.Add(this.button_Search);
            this.groupBox1.Controls.Add(this.comboBox_Job);
            this.groupBox1.Controls.Add(this.comboBox_Range);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton_ClientRentRank);
            this.groupBox1.Controls.Add(this.radioButton_VideoRent);
            this.groupBox1.Controls.Add(this.radioButton_VideoRentRank);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "조회 정보";
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(594, 33);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(81, 61);
            this.button_Close.TabIndex = 3;
            this.button_Close.Text = "나가기";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(498, 33);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(81, 61);
            this.button_Search.TabIndex = 3;
            this.button_Search.Text = "검색";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // comboBox_Job
            // 
            this.comboBox_Job.FormattingEnabled = true;
            this.comboBox_Job.Items.AddRange(new object[] {
            "전체",
            "성인",
            "학생",
            "어린이"});
            this.comboBox_Job.Location = new System.Drawing.Point(360, 74);
            this.comboBox_Job.Name = "comboBox_Job";
            this.comboBox_Job.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Job.TabIndex = 2;
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
            this.comboBox_Range.Location = new System.Drawing.Point(360, 35);
            this.comboBox_Range.Name = "comboBox_Range";
            this.comboBox_Range.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Range.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "고객 신분 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "장르 :";
            // 
            // radioButton_ClientRentRank
            // 
            this.radioButton_ClientRentRank.AutoSize = true;
            this.radioButton_ClientRentRank.Location = new System.Drawing.Point(6, 76);
            this.radioButton_ClientRentRank.Name = "radioButton_ClientRentRank";
            this.radioButton_ClientRentRank.Size = new System.Drawing.Size(103, 16);
            this.radioButton_ClientRentRank.TabIndex = 0;
            this.radioButton_ClientRentRank.TabStop = true;
            this.radioButton_ClientRentRank.Text = "고객 대여 순위";
            this.radioButton_ClientRentRank.UseVisualStyleBackColor = true;
            // 
            // radioButton_VideoRent
            // 
            this.radioButton_VideoRent.AutoSize = true;
            this.radioButton_VideoRent.Location = new System.Drawing.Point(145, 37);
            this.radioButton_VideoRent.Name = "radioButton_VideoRent";
            this.radioButton_VideoRent.Size = new System.Drawing.Size(111, 16);
            this.radioButton_VideoRent.TabIndex = 0;
            this.radioButton_VideoRent.TabStop = true;
            this.radioButton_VideoRent.Text = "대여중인 비디오";
            this.radioButton_VideoRent.UseVisualStyleBackColor = true;
            // 
            // radioButton_VideoRentRank
            // 
            this.radioButton_VideoRentRank.AutoSize = true;
            this.radioButton_VideoRentRank.Location = new System.Drawing.Point(6, 37);
            this.radioButton_VideoRentRank.Name = "radioButton_VideoRentRank";
            this.radioButton_VideoRentRank.Size = new System.Drawing.Size(115, 16);
            this.radioButton_VideoRentRank.TabIndex = 0;
            this.radioButton_VideoRentRank.TabStop = true;
            this.radioButton_VideoRentRank.Text = "비디오 대여 순위";
            this.radioButton_VideoRentRank.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(681, 301);
            this.dataGridView1.TabIndex = 1;
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Information";
            this.Text = "정보조회";
            this.Load += new System.EventHandler(this.Information_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.ComboBox comboBox_Job;
        private System.Windows.Forms.ComboBox comboBox_Range;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_ClientRentRank;
        private System.Windows.Forms.RadioButton radioButton_VideoRent;
        private System.Windows.Forms.RadioButton radioButton_VideoRentRank;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}