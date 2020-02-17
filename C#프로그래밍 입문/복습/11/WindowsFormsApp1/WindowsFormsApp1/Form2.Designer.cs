namespace WindowsFormsApp1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("워드");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("파워포인트");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("엑셀");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("비지오");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("아웃룩");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("오피스", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("메모장");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("그림판");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("계산기");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("보조프로그램", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.listView1 = new System.Windows.Forms.ListView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(248, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(211, 237);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "노드2";
            treeNode1.Text = "워드";
            treeNode2.ImageIndex = 2;
            treeNode2.Name = "노드3";
            treeNode2.Text = "파워포인트";
            treeNode3.ImageIndex = 3;
            treeNode3.Name = "노드4";
            treeNode3.Text = "엑셀";
            treeNode4.ImageIndex = 4;
            treeNode4.Name = "노드5";
            treeNode4.Text = "비지오";
            treeNode5.ImageIndex = 1;
            treeNode5.Name = "노드6";
            treeNode5.Text = "아웃룩";
            treeNode6.Name = "노드0";
            treeNode6.Text = "오피스";
            treeNode7.ImageIndex = 1;
            treeNode7.Name = "노드7";
            treeNode7.Text = "메모장";
            treeNode8.ImageIndex = 2;
            treeNode8.Name = "노드8";
            treeNode8.Text = "그림판";
            treeNode9.ImageIndex = 3;
            treeNode9.Name = "노드9";
            treeNode9.Text = "계산기";
            treeNode10.Name = "노드1";
            treeNode10.Text = "보조프로그램";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode10});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(211, 237);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "frame-1.png");
            this.imageList1.Images.SetKeyName(1, "frame-2.png");
            this.imageList1.Images.SetKeyName(2, "frame-3.png");
            this.imageList1.Images.SetKeyName(3, "frame-4.png");
            this.imageList1.Images.SetKeyName(4, "frame-5.png");
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 261);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}