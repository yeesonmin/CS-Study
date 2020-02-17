namespace WindowsFormsApp1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로만들ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다른이름저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.인쇄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.미리보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.모두닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이전ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자르기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.복사ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.붙여넣기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.서식ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.폰트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.배경색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.계단식ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.타일식ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.아이콘식ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tss_State = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlb_New = new System.Windows.Forms.ToolStripButton();
            this.tlb_Open = new System.Windows.Forms.ToolStripButton();
            this.tlb_Save = new System.Windows.Forms.ToolStripButton();
            this.tlb_SaveAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlb_Print = new System.Windows.Forms.ToolStripButton();
            this.tlb_Preview = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlb_Copy = new System.Windows.Forms.ToolStripButton();
            this.tlb_Paste = new System.Windows.Forms.ToolStripButton();
            this.tlb_Cut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tlb_Undo = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메모장정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.서식ToolStripMenuItem,
            this.보기ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들ToolStripMenuItem,
            this.열기ToolStripMenuItem,
            this.저장SToolStripMenuItem,
            this.다른이름저장ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.인쇄ToolStripMenuItem,
            this.미리보기ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.닫기ToolStripMenuItem,
            this.모두닫기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 새로만들ToolStripMenuItem
            // 
            this.새로만들ToolStripMenuItem.Name = "새로만들ToolStripMenuItem";
            this.새로만들ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.새로만들ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.새로만들ToolStripMenuItem.Text = "새로만들기(&N)";
            this.새로만들ToolStripMenuItem.Click += new System.EventHandler(this.새로만들ToolStripMenuItem_Click);
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.열기ToolStripMenuItem.Text = "열기(&O)";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // 저장SToolStripMenuItem
            // 
            this.저장SToolStripMenuItem.Name = "저장SToolStripMenuItem";
            this.저장SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.저장SToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.저장SToolStripMenuItem.Text = "저장(&S)";
            this.저장SToolStripMenuItem.Click += new System.EventHandler(this.저장SToolStripMenuItem_Click);
            // 
            // 다른이름저장ToolStripMenuItem
            // 
            this.다른이름저장ToolStripMenuItem.Name = "다른이름저장ToolStripMenuItem";
            this.다른이름저장ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.다른이름저장ToolStripMenuItem.Text = "다른이름저장(&A)";
            this.다른이름저장ToolStripMenuItem.Click += new System.EventHandler(this.다른이름저장ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(191, 6);
            // 
            // 인쇄ToolStripMenuItem
            // 
            this.인쇄ToolStripMenuItem.Name = "인쇄ToolStripMenuItem";
            this.인쇄ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.인쇄ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.인쇄ToolStripMenuItem.Text = "인쇄(&P)";
            this.인쇄ToolStripMenuItem.Click += new System.EventHandler(this.인쇄ToolStripMenuItem_Click);
            // 
            // 미리보기ToolStripMenuItem
            // 
            this.미리보기ToolStripMenuItem.Name = "미리보기ToolStripMenuItem";
            this.미리보기ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.미리보기ToolStripMenuItem.Text = "미리보기";
            this.미리보기ToolStripMenuItem.Click += new System.EventHandler(this.미리보기ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(191, 6);
            // 
            // 닫기ToolStripMenuItem
            // 
            this.닫기ToolStripMenuItem.Name = "닫기ToolStripMenuItem";
            this.닫기ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.닫기ToolStripMenuItem.Text = "닫기(&C)";
            this.닫기ToolStripMenuItem.Click += new System.EventHandler(this.닫기ToolStripMenuItem_Click);
            // 
            // 모두닫기ToolStripMenuItem
            // 
            this.모두닫기ToolStripMenuItem.Name = "모두닫기ToolStripMenuItem";
            this.모두닫기ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.모두닫기ToolStripMenuItem.Text = "모두 닫기(&X)";
            this.모두닫기ToolStripMenuItem.Click += new System.EventHandler(this.모두닫기ToolStripMenuItem_Click);
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.이전ToolStripMenuItem,
            this.자르기ToolStripMenuItem,
            this.복사ToolStripMenuItem,
            this.붙여넣기ToolStripMenuItem});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.편집ToolStripMenuItem.Text = "편집";
            // 
            // 이전ToolStripMenuItem
            // 
            this.이전ToolStripMenuItem.Name = "이전ToolStripMenuItem";
            this.이전ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.이전ToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.이전ToolStripMenuItem.Text = "이전(&U)";
            this.이전ToolStripMenuItem.Click += new System.EventHandler(this.이전ToolStripMenuItem_Click);
            // 
            // 자르기ToolStripMenuItem
            // 
            this.자르기ToolStripMenuItem.Name = "자르기ToolStripMenuItem";
            this.자르기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.자르기ToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.자르기ToolStripMenuItem.Text = "자르기(&T)";
            this.자르기ToolStripMenuItem.Click += new System.EventHandler(this.자르기ToolStripMenuItem_Click);
            // 
            // 복사ToolStripMenuItem
            // 
            this.복사ToolStripMenuItem.Name = "복사ToolStripMenuItem";
            this.복사ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.복사ToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.복사ToolStripMenuItem.Text = "복사(&C)";
            this.복사ToolStripMenuItem.Click += new System.EventHandler(this.복사ToolStripMenuItem_Click);
            // 
            // 붙여넣기ToolStripMenuItem
            // 
            this.붙여넣기ToolStripMenuItem.Name = "붙여넣기ToolStripMenuItem";
            this.붙여넣기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.붙여넣기ToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.붙여넣기ToolStripMenuItem.Text = "붙여넣기(&P)";
            this.붙여넣기ToolStripMenuItem.Click += new System.EventHandler(this.붙여넣기ToolStripMenuItem_Click);
            // 
            // 서식ToolStripMenuItem
            // 
            this.서식ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.폰트ToolStripMenuItem,
            this.배경색ToolStripMenuItem});
            this.서식ToolStripMenuItem.Name = "서식ToolStripMenuItem";
            this.서식ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.서식ToolStripMenuItem.Text = "서식";
            // 
            // 폰트ToolStripMenuItem
            // 
            this.폰트ToolStripMenuItem.Name = "폰트ToolStripMenuItem";
            this.폰트ToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.폰트ToolStripMenuItem.Text = "폰트(&F)";
            this.폰트ToolStripMenuItem.Click += new System.EventHandler(this.폰트ToolStripMenuItem_Click);
            // 
            // 배경색ToolStripMenuItem
            // 
            this.배경색ToolStripMenuItem.Name = "배경색ToolStripMenuItem";
            this.배경색ToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.배경색ToolStripMenuItem.Text = "배경색(&B)";
            this.배경색ToolStripMenuItem.Click += new System.EventHandler(this.배경색ToolStripMenuItem_Click);
            // 
            // 보기ToolStripMenuItem
            // 
            this.보기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.계단식ToolStripMenuItem,
            this.타일식ToolStripMenuItem,
            this.아이콘식ToolStripMenuItem});
            this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            this.보기ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.보기ToolStripMenuItem.Text = "보기";
            // 
            // 계단식ToolStripMenuItem
            // 
            this.계단식ToolStripMenuItem.Name = "계단식ToolStripMenuItem";
            this.계단식ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.계단식ToolStripMenuItem.Text = "계단식정렬";
            this.계단식ToolStripMenuItem.Click += new System.EventHandler(this.계단식ToolStripMenuItem_Click);
            // 
            // 타일식ToolStripMenuItem
            // 
            this.타일식ToolStripMenuItem.Name = "타일식ToolStripMenuItem";
            this.타일식ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.타일식ToolStripMenuItem.Text = "타일수평정렬";
            this.타일식ToolStripMenuItem.Click += new System.EventHandler(this.타일식ToolStripMenuItem_Click);
            // 
            // 아이콘식ToolStripMenuItem
            // 
            this.아이콘식ToolStripMenuItem.Name = "아이콘식ToolStripMenuItem";
            this.아이콘식ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.아이콘식ToolStripMenuItem.Text = "타일식수직정렬";
            this.아이콘식ToolStripMenuItem.Click += new System.EventHandler(this.아이콘식ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_State,
            this.tss_Time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 373);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(783, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tss_State
            // 
            this.tss_State.Name = "tss_State";
            this.tss_State.Size = new System.Drawing.Size(121, 17);
            this.tss_State.Text = "toolStripStatusLabel1";
            this.tss_State.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tss_Time
            // 
            this.tss_Time.Name = "tss_Time";
            this.tss_Time.Size = new System.Drawing.Size(647, 17);
            this.tss_Time.Spring = true;
            this.tss_Time.Text = "toolStripStatusLabel2";
            this.tss_Time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStrip1
            // 
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlb_New,
            this.tlb_Open,
            this.tlb_Save,
            this.tlb_SaveAs,
            this.toolStripSeparator1,
            this.tlb_Print,
            this.tlb_Preview,
            this.toolStripSeparator2,
            this.tlb_Copy,
            this.tlb_Paste,
            this.tlb_Cut,
            this.toolStripSeparator3,
            this.tlb_Undo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(783, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "New";
            // 
            // tlb_New
            // 
            this.tlb_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlb_New.Image = ((System.Drawing.Image)(resources.GetObject("tlb_New.Image")));
            this.tlb_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlb_New.Name = "tlb_New";
            this.tlb_New.Size = new System.Drawing.Size(23, 22);
            this.tlb_New.Text = "New";
            this.tlb_New.Click += new System.EventHandler(this.tlb_New_Click);
            // 
            // tlb_Open
            // 
            this.tlb_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlb_Open.Image = ((System.Drawing.Image)(resources.GetObject("tlb_Open.Image")));
            this.tlb_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlb_Open.Name = "tlb_Open";
            this.tlb_Open.Size = new System.Drawing.Size(23, 22);
            this.tlb_Open.Text = "Open";
            this.tlb_Open.Click += new System.EventHandler(this.tlb_Open_Click);
            // 
            // tlb_Save
            // 
            this.tlb_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlb_Save.Image = ((System.Drawing.Image)(resources.GetObject("tlb_Save.Image")));
            this.tlb_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlb_Save.Name = "tlb_Save";
            this.tlb_Save.Size = new System.Drawing.Size(23, 22);
            this.tlb_Save.Text = "Save";
            this.tlb_Save.Click += new System.EventHandler(this.tlb_Save_Click);
            // 
            // tlb_SaveAs
            // 
            this.tlb_SaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlb_SaveAs.Image = ((System.Drawing.Image)(resources.GetObject("tlb_SaveAs.Image")));
            this.tlb_SaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlb_SaveAs.Name = "tlb_SaveAs";
            this.tlb_SaveAs.Size = new System.Drawing.Size(23, 22);
            this.tlb_SaveAs.Text = "Save As";
            this.tlb_SaveAs.Click += new System.EventHandler(this.tlb_SaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tlb_Print
            // 
            this.tlb_Print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlb_Print.Image = ((System.Drawing.Image)(resources.GetObject("tlb_Print.Image")));
            this.tlb_Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlb_Print.Name = "tlb_Print";
            this.tlb_Print.Size = new System.Drawing.Size(23, 22);
            this.tlb_Print.Text = "Print";
            this.tlb_Print.Click += new System.EventHandler(this.tlb_Print_Click);
            // 
            // tlb_Preview
            // 
            this.tlb_Preview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlb_Preview.Image = ((System.Drawing.Image)(resources.GetObject("tlb_Preview.Image")));
            this.tlb_Preview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlb_Preview.Name = "tlb_Preview";
            this.tlb_Preview.Size = new System.Drawing.Size(23, 22);
            this.tlb_Preview.Text = "Preview";
            this.tlb_Preview.Click += new System.EventHandler(this.tlb_Preview_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tlb_Copy
            // 
            this.tlb_Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlb_Copy.Image = ((System.Drawing.Image)(resources.GetObject("tlb_Copy.Image")));
            this.tlb_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlb_Copy.Name = "tlb_Copy";
            this.tlb_Copy.Size = new System.Drawing.Size(23, 22);
            this.tlb_Copy.Text = "Copy";
            this.tlb_Copy.Click += new System.EventHandler(this.tlb_Copy_Click);
            // 
            // tlb_Paste
            // 
            this.tlb_Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlb_Paste.Image = ((System.Drawing.Image)(resources.GetObject("tlb_Paste.Image")));
            this.tlb_Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlb_Paste.Name = "tlb_Paste";
            this.tlb_Paste.Size = new System.Drawing.Size(23, 22);
            this.tlb_Paste.Text = "Paste";
            this.tlb_Paste.Click += new System.EventHandler(this.tlb_Paste_Click);
            // 
            // tlb_Cut
            // 
            this.tlb_Cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlb_Cut.Image = ((System.Drawing.Image)(resources.GetObject("tlb_Cut.Image")));
            this.tlb_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlb_Cut.Name = "tlb_Cut";
            this.tlb_Cut.Size = new System.Drawing.Size(23, 22);
            this.tlb_Cut.Text = "Cut";
            this.tlb_Cut.Click += new System.EventHandler(this.tlb_Cut_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tlb_Undo
            // 
            this.tlb_Undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlb_Undo.Image = ((System.Drawing.Image)(resources.GetObject("tlb_Undo.Image")));
            this.tlb_Undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlb_Undo.Name = "tlb_Undo";
            this.tlb_Undo.Size = new System.Drawing.Size(23, 22);
            this.tlb_Undo.Text = "Undo";
            this.tlb_Undo.Click += new System.EventHandler(this.tlb_Undo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메모장정보ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.도움말ToolStripMenuItem.Text = "정보";
            // 
            // 메모장정보ToolStripMenuItem
            // 
            this.메모장정보ToolStripMenuItem.Name = "메모장정보ToolStripMenuItem";
            this.메모장정보ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.메모장정보ToolStripMenuItem.Text = "메모장정보";
            this.메모장정보ToolStripMenuItem.Click += new System.EventHandler(this.메모장정보ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 395);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "메모장";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다른이름저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 인쇄ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 미리보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 닫기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모두닫기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이전ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자르기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 복사ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 붙여넣기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 서식ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 폰트ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 배경색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 계단식ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 타일식ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 아이콘식ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tss_Time;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlb_New;
        private System.Windows.Forms.ToolStripButton tlb_Open;
        private System.Windows.Forms.ToolStripButton tlb_Save;
        private System.Windows.Forms.ToolStripButton tlb_SaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tlb_Print;
        private System.Windows.Forms.ToolStripButton tlb_Preview;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tlb_Copy;
        private System.Windows.Forms.ToolStripButton tlb_Paste;
        private System.Windows.Forms.ToolStripButton tlb_Cut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tlb_Undo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.ToolStripStatusLabel tss_State;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메모장정보ToolStripMenuItem;
    }
}

