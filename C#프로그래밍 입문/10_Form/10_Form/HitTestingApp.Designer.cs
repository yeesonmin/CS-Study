namespace _10_Form
{
    partial class HitTestingApp
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
            this.SuspendLayout();
            // 
            // HitTestingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 518);
            this.Name = "HitTestingApp";
            this.Text = "HitTestingApp";
            this.Load += new System.EventHandler(this.HitTestingApp_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.HitTestingApp_Paint);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HitTestingApp_MouseUp);
            this.Resize += new System.EventHandler(this.HitTestingApp_Resize);
            this.ResumeLayout(false);

        }

        #endregion
    }
}