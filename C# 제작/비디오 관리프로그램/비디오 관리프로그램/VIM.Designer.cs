namespace 비디오_관리프로그램
{
    partial class VIM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIM));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_VideoRelease = new System.Windows.Forms.DateTimePicker();
            this.textBox_VideoDirector = new System.Windows.Forms.TextBox();
            this.textBox_VideoCategory = new System.Windows.Forms.TextBox();
            this.textBox_VideoMade = new System.Windows.Forms.TextBox();
            this.textBox_VideoActor = new System.Windows.Forms.TextBox();
            this.textBox_VideoName = new System.Windows.Forms.TextBox();
            this.textBox_VideoCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_VideoAdd = new System.Windows.Forms.Button();
            this.button_VideoSave = new System.Windows.Forms.Button();
            this.button_VideoDelete = new System.Windows.Forms.Button();
            this.button_VideoClose = new System.Windows.Forms.Button();
            this.button_VideoCancle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_VideoCount = new System.Windows.Forms.TextBox();
            this.button_VideoPrint = new System.Windows.Forms.Button();
            this.dataGridView_Video = new System.Windows.Forms.DataGridView();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Video)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_VideoRelease);
            this.groupBox1.Controls.Add(this.textBox_VideoDirector);
            this.groupBox1.Controls.Add(this.textBox_VideoCategory);
            this.groupBox1.Controls.Add(this.textBox_VideoMade);
            this.groupBox1.Controls.Add(this.textBox_VideoActor);
            this.groupBox1.Controls.Add(this.textBox_VideoName);
            this.groupBox1.Controls.Add(this.textBox_VideoCode);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "비디오 정보";
            // 
            // dateTimePicker_VideoRelease
            // 
            this.dateTimePicker_VideoRelease.CustomFormat = "yyyy-mm-dd";
            this.dateTimePicker_VideoRelease.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_VideoRelease.Location = new System.Drawing.Point(390, 135);
            this.dateTimePicker_VideoRelease.Name = "dateTimePicker_VideoRelease";
            this.dateTimePicker_VideoRelease.Size = new System.Drawing.Size(204, 21);
            this.dateTimePicker_VideoRelease.TabIndex = 6;
            // 
            // textBox_VideoDirector
            // 
            this.textBox_VideoDirector.Location = new System.Drawing.Point(390, 98);
            this.textBox_VideoDirector.Name = "textBox_VideoDirector";
            this.textBox_VideoDirector.Size = new System.Drawing.Size(204, 21);
            this.textBox_VideoDirector.TabIndex = 4;
            // 
            // textBox_VideoCategory
            // 
            this.textBox_VideoCategory.Location = new System.Drawing.Point(390, 61);
            this.textBox_VideoCategory.Name = "textBox_VideoCategory";
            this.textBox_VideoCategory.Size = new System.Drawing.Size(204, 21);
            this.textBox_VideoCategory.TabIndex = 2;
            // 
            // textBox_VideoMade
            // 
            this.textBox_VideoMade.Location = new System.Drawing.Point(93, 135);
            this.textBox_VideoMade.Name = "textBox_VideoMade";
            this.textBox_VideoMade.Size = new System.Drawing.Size(204, 21);
            this.textBox_VideoMade.TabIndex = 5;
            // 
            // textBox_VideoActor
            // 
            this.textBox_VideoActor.Location = new System.Drawing.Point(93, 98);
            this.textBox_VideoActor.Name = "textBox_VideoActor";
            this.textBox_VideoActor.Size = new System.Drawing.Size(204, 21);
            this.textBox_VideoActor.TabIndex = 3;
            // 
            // textBox_VideoName
            // 
            this.textBox_VideoName.Location = new System.Drawing.Point(93, 61);
            this.textBox_VideoName.Name = "textBox_VideoName";
            this.textBox_VideoName.Size = new System.Drawing.Size(204, 21);
            this.textBox_VideoName.TabIndex = 1;
            // 
            // textBox_VideoCode
            // 
            this.textBox_VideoCode.Location = new System.Drawing.Point(93, 25);
            this.textBox_VideoCode.Name = "textBox_VideoCode";
            this.textBox_VideoCode.Size = new System.Drawing.Size(204, 21);
            this.textBox_VideoCode.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "출시일 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "감독 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "장르 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "제작 및 배급 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "주연 배우 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "제목 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "비디오 코드 :";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.63636F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.63636F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.63636F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.63636F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tableLayoutPanel1.Controls.Add(this.button_VideoAdd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_VideoSave, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_VideoDelete, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_VideoClose, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_VideoCancle, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 190);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(620, 35);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button_VideoAdd
            // 
            this.button_VideoAdd.Location = new System.Drawing.Point(3, 3);
            this.button_VideoAdd.Name = "button_VideoAdd";
            this.button_VideoAdd.Size = new System.Drawing.Size(75, 23);
            this.button_VideoAdd.TabIndex = 2;
            this.button_VideoAdd.Text = "추가";
            this.button_VideoAdd.UseVisualStyleBackColor = true;
            this.button_VideoAdd.Click += new System.EventHandler(this.button_VideoAdd_Click);
            // 
            // button_VideoSave
            // 
            this.button_VideoSave.Location = new System.Drawing.Point(87, 3);
            this.button_VideoSave.Name = "button_VideoSave";
            this.button_VideoSave.Size = new System.Drawing.Size(75, 23);
            this.button_VideoSave.TabIndex = 3;
            this.button_VideoSave.Text = "수정";
            this.button_VideoSave.UseVisualStyleBackColor = true;
            this.button_VideoSave.Click += new System.EventHandler(this.button_VideoSave_Click);
            // 
            // button_VideoDelete
            // 
            this.button_VideoDelete.Location = new System.Drawing.Point(171, 3);
            this.button_VideoDelete.Name = "button_VideoDelete";
            this.button_VideoDelete.Size = new System.Drawing.Size(75, 23);
            this.button_VideoDelete.TabIndex = 2;
            this.button_VideoDelete.Text = "삭제";
            this.button_VideoDelete.UseVisualStyleBackColor = true;
            this.button_VideoDelete.Click += new System.EventHandler(this.button_VideoDelete_Click);
            // 
            // button_VideoClose
            // 
            this.button_VideoClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_VideoClose.Location = new System.Drawing.Point(542, 3);
            this.button_VideoClose.Name = "button_VideoClose";
            this.button_VideoClose.Size = new System.Drawing.Size(75, 23);
            this.button_VideoClose.TabIndex = 2;
            this.button_VideoClose.Text = "나가기";
            this.button_VideoClose.UseVisualStyleBackColor = true;
            this.button_VideoClose.Click += new System.EventHandler(this.button_VideoClose_Click);
            // 
            // button_VideoCancle
            // 
            this.button_VideoCancle.Location = new System.Drawing.Point(255, 3);
            this.button_VideoCancle.Name = "button_VideoCancle";
            this.button_VideoCancle.Size = new System.Drawing.Size(75, 23);
            this.button_VideoCancle.TabIndex = 2;
            this.button_VideoCancle.Text = "취소";
            this.button_VideoCancle.UseVisualStyleBackColor = true;
            this.button_VideoCancle.Click += new System.EventHandler(this.button_VideoCancle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 12F);
            this.label8.Location = new System.Drawing.Point(13, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "전체 비디오 수 :";
            // 
            // textBox_VideoCount
            // 
            this.textBox_VideoCount.Font = new System.Drawing.Font("굴림", 12F);
            this.textBox_VideoCount.Location = new System.Drawing.Point(143, 241);
            this.textBox_VideoCount.Name = "textBox_VideoCount";
            this.textBox_VideoCount.ReadOnly = true;
            this.textBox_VideoCount.Size = new System.Drawing.Size(166, 26);
            this.textBox_VideoCount.TabIndex = 3;
            // 
            // button_VideoPrint
            // 
            this.button_VideoPrint.Location = new System.Drawing.Point(315, 241);
            this.button_VideoPrint.Name = "button_VideoPrint";
            this.button_VideoPrint.Size = new System.Drawing.Size(92, 26);
            this.button_VideoPrint.TabIndex = 4;
            this.button_VideoPrint.Text = "목록 출력";
            this.button_VideoPrint.UseVisualStyleBackColor = true;
            this.button_VideoPrint.Click += new System.EventHandler(this.button_VideoPrint_Click);
            // 
            // dataGridView_Video
            // 
            this.dataGridView_Video.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Video.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Video.Location = new System.Drawing.Point(12, 273);
            this.dataGridView_Video.Name = "dataGridView_Video";
            this.dataGridView_Video.ReadOnly = true;
            this.dataGridView_Video.RowTemplate.Height = 23;
            this.dataGridView_Video.Size = new System.Drawing.Size(617, 285);
            this.dataGridView_Video.TabIndex = 5;
            this.dataGridView_Video.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Video_CellClick);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // VIM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 570);
            this.Controls.Add(this.dataGridView_Video);
            this.Controls.Add(this.button_VideoPrint);
            this.Controls.Add(this.textBox_VideoCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "VIM";
            this.Text = "비디오 관리";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VIM_FormClosing);
            this.Load += new System.EventHandler(this.VIM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Video)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_VideoAdd;
        private System.Windows.Forms.Button button_VideoSave;
        private System.Windows.Forms.Button button_VideoDelete;
        private System.Windows.Forms.Button button_VideoClose;
        private System.Windows.Forms.Button button_VideoCancle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_VideoCount;
        private System.Windows.Forms.Button button_VideoPrint;
        public System.Windows.Forms.DataGridView dataGridView_Video;
        public System.Windows.Forms.DateTimePicker dateTimePicker_VideoRelease;
        public System.Windows.Forms.TextBox textBox_VideoDirector;
        public System.Windows.Forms.TextBox textBox_VideoCategory;
        public System.Windows.Forms.TextBox textBox_VideoMade;
        public System.Windows.Forms.TextBox textBox_VideoActor;
        public System.Windows.Forms.TextBox textBox_VideoName;
        public System.Windows.Forms.TextBox textBox_VideoCode;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}