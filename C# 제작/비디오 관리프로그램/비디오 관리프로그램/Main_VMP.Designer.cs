namespace 비디오_관리프로그램
{
    partial class Main_VMP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_VMP));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.엑셀출력ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.비디오대여반납ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.대여반납ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.비디오관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.비디오관리ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.고객관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.고객관리ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.정보조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보조회ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.환경설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Rent = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_VideoM = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_ClientM = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Information = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Excel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Setting = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.비디오대여반납ToolStripMenuItem,
            this.비디오관리ToolStripMenuItem,
            this.고객관리ToolStripMenuItem,
            this.정보조회ToolStripMenuItem,
            this.환경설정ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1161, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.엑셀출력ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 엑셀출력ToolStripMenuItem
            // 
            this.엑셀출력ToolStripMenuItem.Name = "엑셀출력ToolStripMenuItem";
            this.엑셀출력ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.엑셀출력ToolStripMenuItem.Text = "엑셀 출력";
            this.엑셀출력ToolStripMenuItem.Click += new System.EventHandler(this.엑셀출력ToolStripMenuItem_Click);
            // 
            // 비디오대여반납ToolStripMenuItem
            // 
            this.비디오대여반납ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.대여반납ToolStripMenuItem});
            this.비디오대여반납ToolStripMenuItem.Name = "비디오대여반납ToolStripMenuItem";
            this.비디오대여반납ToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.비디오대여반납ToolStripMenuItem.Text = "비디오 대여/반납";
            // 
            // 대여반납ToolStripMenuItem
            // 
            this.대여반납ToolStripMenuItem.Name = "대여반납ToolStripMenuItem";
            this.대여반납ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.대여반납ToolStripMenuItem.Text = "대여/반납";
            this.대여반납ToolStripMenuItem.Click += new System.EventHandler(this.대여반납ToolStripMenuItem_Click);
            // 
            // 비디오관리ToolStripMenuItem
            // 
            this.비디오관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.비디오관리ToolStripMenuItem1});
            this.비디오관리ToolStripMenuItem.Name = "비디오관리ToolStripMenuItem";
            this.비디오관리ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.비디오관리ToolStripMenuItem.Text = "비디오 관리";
            // 
            // 비디오관리ToolStripMenuItem1
            // 
            this.비디오관리ToolStripMenuItem1.Name = "비디오관리ToolStripMenuItem1";
            this.비디오관리ToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.비디오관리ToolStripMenuItem1.Text = "비디오 관리";
            this.비디오관리ToolStripMenuItem1.Click += new System.EventHandler(this.비디오관리ToolStripMenuItem1_Click);
            // 
            // 고객관리ToolStripMenuItem
            // 
            this.고객관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.고객관리ToolStripMenuItem1});
            this.고객관리ToolStripMenuItem.Name = "고객관리ToolStripMenuItem";
            this.고객관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.고객관리ToolStripMenuItem.Text = "고객관리";
            // 
            // 고객관리ToolStripMenuItem1
            // 
            this.고객관리ToolStripMenuItem1.Name = "고객관리ToolStripMenuItem1";
            this.고객관리ToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.고객관리ToolStripMenuItem1.Text = "고객관리";
            this.고객관리ToolStripMenuItem1.Click += new System.EventHandler(this.고객관리ToolStripMenuItem1_Click);
            // 
            // 정보조회ToolStripMenuItem
            // 
            this.정보조회ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.정보조회ToolStripMenuItem1});
            this.정보조회ToolStripMenuItem.Name = "정보조회ToolStripMenuItem";
            this.정보조회ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.정보조회ToolStripMenuItem.Text = "정보조회";
            // 
            // 정보조회ToolStripMenuItem1
            // 
            this.정보조회ToolStripMenuItem1.Name = "정보조회ToolStripMenuItem1";
            this.정보조회ToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.정보조회ToolStripMenuItem1.Text = "정보조회";
            this.정보조회ToolStripMenuItem1.Click += new System.EventHandler(this.정보조회ToolStripMenuItem1_Click);
            // 
            // 환경설정ToolStripMenuItem
            // 
            this.환경설정ToolStripMenuItem.Name = "환경설정ToolStripMenuItem";
            this.환경설정ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.환경설정ToolStripMenuItem.Text = "환경설정";
            this.환경설정ToolStripMenuItem.Click += new System.EventHandler(this.환경설정ToolStripMenuItem_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움말ToolStripMenuItem.Text = "제작자";
            this.도움말ToolStripMenuItem.Click += new System.EventHandler(this.도움말ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Rent,
            this.toolStripSeparator1,
            this.toolStripButton_VideoM,
            this.toolStripButton_ClientM,
            this.toolStripButton_Information,
            this.toolStripButton_Excel,
            this.toolStripSeparator2,
            this.toolStripButton_Setting});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1161, 85);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Rent
            // 
            this.toolStripButton_Rent.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Rent.Image")));
            this.toolStripButton_Rent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Rent.Name = "toolStripButton_Rent";
            this.toolStripButton_Rent.Size = new System.Drawing.Size(64, 82);
            this.toolStripButton_Rent.Text = "대여/반납";
            this.toolStripButton_Rent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_Rent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Rent.Click += new System.EventHandler(this.toolStripButton_Rent_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 85);
            // 
            // toolStripButton_VideoM
            // 
            this.toolStripButton_VideoM.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_VideoM.Image")));
            this.toolStripButton_VideoM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_VideoM.Name = "toolStripButton_VideoM";
            this.toolStripButton_VideoM.Size = new System.Drawing.Size(75, 82);
            this.toolStripButton_VideoM.Text = "비디오 관리";
            this.toolStripButton_VideoM.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_VideoM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_VideoM.Click += new System.EventHandler(this.toolStripButton_VideoM_Click);
            // 
            // toolStripButton_ClientM
            // 
            this.toolStripButton_ClientM.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_ClientM.Image")));
            this.toolStripButton_ClientM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_ClientM.Name = "toolStripButton_ClientM";
            this.toolStripButton_ClientM.Size = new System.Drawing.Size(59, 82);
            this.toolStripButton_ClientM.Text = "고객관리";
            this.toolStripButton_ClientM.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_ClientM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_ClientM.Click += new System.EventHandler(this.toolStripButton_ClientM_Click);
            // 
            // toolStripButton_Information
            // 
            this.toolStripButton_Information.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Information.Image")));
            this.toolStripButton_Information.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Information.Name = "toolStripButton_Information";
            this.toolStripButton_Information.Size = new System.Drawing.Size(59, 82);
            this.toolStripButton_Information.Text = "정보조회";
            this.toolStripButton_Information.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_Information.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Information.Click += new System.EventHandler(this.toolStripButton_Information_Click);
            // 
            // toolStripButton_Excel
            // 
            this.toolStripButton_Excel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Excel.Image")));
            this.toolStripButton_Excel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Excel.Name = "toolStripButton_Excel";
            this.toolStripButton_Excel.Size = new System.Drawing.Size(63, 82);
            this.toolStripButton_Excel.Text = "엑셜 출력";
            this.toolStripButton_Excel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_Excel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Excel.Click += new System.EventHandler(this.toolStripButton_Excel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 85);
            // 
            // toolStripButton_Setting
            // 
            this.toolStripButton_Setting.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Setting.Image")));
            this.toolStripButton_Setting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Setting.Name = "toolStripButton_Setting";
            this.toolStripButton_Setting.Size = new System.Drawing.Size(59, 82);
            this.toolStripButton_Setting.Text = "환경설정";
            this.toolStripButton_Setting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_Setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Setting.Click += new System.EventHandler(this.toolStripButton_Setting_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 795);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1161, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Time
            // 
            this.toolStripStatusLabel_Time.Name = "toolStripStatusLabel_Time";
            this.toolStripStatusLabel_Time.Size = new System.Drawing.Size(1146, 17);
            this.toolStripStatusLabel_Time.Spring = true;
            this.toolStripStatusLabel_Time.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel_Time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Main_VMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 817);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_VMP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "비디오 관리프로그램";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_VMP_FormClosing);
            this.Load += new System.EventHandler(this.Main_VMP_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 비디오대여반납ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 비디오관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 고객관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 환경설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Rent;
        private System.Windows.Forms.ToolStripButton toolStripButton_VideoM;
        private System.Windows.Forms.ToolStripButton toolStripButton_ClientM;
        private System.Windows.Forms.ToolStripButton toolStripButton_Information;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_Setting;
        private System.Windows.Forms.ToolStripButton toolStripButton_Excel;
        private System.Windows.Forms.ToolStripMenuItem 엑셀출력ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 대여반납ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 비디오관리ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 고객관리ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 정보조회ToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Time;
    }
}

