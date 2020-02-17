using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public int count = 0;
        public static int opencount = 0;
        string readString;
        public delegate void dThead();
        bool ThreadGo = true;
        
       
        public MainForm()
        {
            InitializeComponent();
            tss_State.Text = "메모장";
            Thread t = new Thread(new ThreadStart(SysTime));
            t.Start();
           

        }
        //시간
        protected void SysTime()
        {
           if(InvokeRequired)
            {
                dThead d = new dThead(SysTime);
                while(ThreadGo)
                {
                    tss_Time.Text = DateTime.Now.ToString();
                    Invoke(d);
                    Thread.Sleep(1000);
                }
                
            }
                
        }

        //파일새로만들기
        protected void NewFile()
        {
            tss_State.Text = "파일새로만들기";
            TextForm newfile = new TextForm();
            newfile.TopLevel = false;
            newfile.MdiParent = this;
            newfile.BringToFront();
            count++;
            newfile.Text = "제목 없음(" + count + ")";
            opencount++;
            newfile.save = true;
            newfile.Show();
        }

        private void 새로만들ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void tlb_New_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        //파일열기
        protected void OpenFIle()
        {
           
            tss_State.Text = "파일열기";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = true;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach(string adr in openFileDialog1.FileNames)
                {
                    readString = File.ReadAllText(adr, Encoding.Default);
                    ReadFile(readString, Path.GetFileNameWithoutExtension(adr), adr);
                    readString = "";
                    opencount++;
                }
                
            }else
            {
                tss_State.Text = "파일열기취소";
            }
        }
        protected void ReadFile(string s, string name, string sp)
        {
            TextForm newfile = new TextForm();
            newfile.TopLevel = false;
            newfile.MdiParent = this;
            newfile.BringToFront();
            newfile.Text = name;
            newfile.textBox1.Text = s;
            newfile.save = true;
            newfile.savePoin = sp;
            newfile.Show();

        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFIle();

        }

        private void tlb_Open_Click(object sender, EventArgs e)
        {
            OpenFIle();
        }
        //파일 끌어 넣기
        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy | DragDropEffects.Scroll;
            }


        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string str in file)
                {
                    readString = File.ReadAllText(str, Encoding.Default);
                    ReadFile(readString, Path.GetFileNameWithoutExtension(str), str);
                    readString = "";
                    opencount++;
                }
            }


        }
        //저장
        public void SaveFile(TextForm tf)
        {
            
            if(opencount!=0)
            {
                tss_State.Text = "저장";
                saveFileDialog1.Title = "저장";
                saveFileDialog1.InitialDirectory = @"C:\";
                saveFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;

                if (tf.save == false)
                {
                    if (tf.Text.Contains("제목 없음") == true)
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.Default);
                            sw.Write(tf.textBox1.Text);
                            sw.Close();
                            tf.save = true;
                            tf.savePoin = saveFileDialog1.FileName;
                            tf.Text = Path.GetFileNameWithoutExtension(saveFileDialog1.FileName);
                        }else
                        {
                            tss_State.Text = "저장취소";
                        }
                    }
                    else
                    {
                        StreamWriter sw = new StreamWriter(tf.savePoin, false, Encoding.Default);
                        sw.Write(tf.textBox1.Text);
                        sw.Close();
                        tf.save = true;
                    }
                }
            }
            else
            {
                tss_State.Text = "열린 파일이 없습니다.";
            }
            
           
            
        }

        private void tlb_Save_Click(object sender, EventArgs e)
        {
            TextForm tf = new TextForm();
            tf = (TextForm)this.ActiveMdiChild;
            SaveFile(tf);
        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextForm tf = new TextForm();
            tf = (TextForm)this.ActiveMdiChild;
            SaveFile(tf);
        }

       
        //다른이름저장
        protected void SaveAsFile()
        {
            if(opencount!=0)
            {
                tss_State.Text = "다른이름저장";
                TextForm tf = new TextForm();
                tf = (TextForm)this.ActiveMdiChild;

                saveFileDialog1.Title = "저장";
                saveFileDialog1.InitialDirectory = @"C:\";
                saveFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    TextBox tb = new TextBox();
                    tb = (TextBox)this.ActiveMdiChild.ActiveControl;
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.Default);
                    sw.Write(tb.Text);
                    sw.Close();
                    tf.save = true;
                    tf.Text = Path.GetFileNameWithoutExtension(saveFileDialog1.FileName);
                }
                else
                {
                    tss_State.Text = "다른이름저장취소";
                }
            }
            else
            {
                tss_State.Text = "열린 파일이 없습니다.";

            }
            
           


        }
        private void tlb_SaveAs_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }

        private void 다른이름저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }

        //닫기
       
        public void FileClose(TextForm tf)
        {
            if (opencount != 0)
            {
                
                if (tf.save == false)
                {

                    switch (MessageBox.Show("변경된 내용을 " + tf.Text + "에 저장하겠습니까?", "메모장", MessageBoxButtons.YesNoCancel))
                    {
                        case DialogResult.Yes:
                            {
                                SaveFile(tf);
                                opencount--;
                                tf.exit = true;
                                tss_State.Text = "닫기";
                                break;
                            }
                        case DialogResult.No:
                            {
                                
                                opencount--;
                                tf.exit = true;
                                tss_State.Text = "닫기";
                                break;
                            }
                        case DialogResult.Cancel:
                            {
                                
                                tf.exit = false;
                                tss_State.Text = "닫기취소";
                                break;
                            }

                    }
                   
                }
                else
                {
                    opencount--;
                    tf.exit = true;
                    tss_State.Text = "닫기";
                }
            }
            else
            {
                tss_State.Text = "열린 파일이 없습니다.";

            }

            
        }
        private void 닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (opencount != 0)
            {
                TextForm tf = new TextForm();
                tf = (TextForm)this.ActiveMdiChild;
                tf.Close();
            }
            else
            {
                tss_State.Text = "열린 파일이 없습니다.";
            }
        }




        //모두닫기
        protected void AllExitFile()
        {
            
            tss_State.Text = "모두닫기";
            if(MessageBox.Show("모두 닫겠습니까?","모두닫기",MessageBoxButtons.OKCancel) ==DialogResult.OK)
            {
                foreach (TextForm tf in this.MdiChildren)
                {
                    
                    tf.Close();
                }
            }
            else
            {
                tss_State.Text = "모두닫기취소";
            }
            
        }
        private void 모두닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (opencount != 0)
            {
                AllExitFile();
            }
            else
            {
                tss_State.Text = "열린 파일이 없습니다.";
            }
               
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (opencount != 0)
            {
                AllExitFile();
            }
            ThreadGo = false;
        }

        //프린트
        protected void FilePrint()
        {
            if (opencount != 0)
            {
                tss_State.Text = "프린트";
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    
                    TextForm tf = new TextForm();
                    tf = (TextForm)this.ActiveMdiChild;
                    this.printDialog1.Document = this.printDocument1;
                    printDialog1.Document.Print();
                    
                }
            }
            else
            {
                tss_State.Text = "열린 파일이 없습니다.";

            }

            
        }
        private void 인쇄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilePrint();
        }

        private void tlb_Print_Click(object sender, EventArgs e)
        {
            FilePrint();
        }

        //미리보기
        protected void FilePrintPreview()
        {
            if (opencount != 0)
            {
                tss_State.Text = "미리보기";
                TextForm tf = new TextForm();
                tf = (TextForm)this.ActiveMdiChild;
                this.printPreviewDialog1.Document = this.printDocument1;
                this.printPreviewDialog1.ShowDialog();
                
            }
            else
            {
                tss_State.Text = "열린 파일이 없습니다.";

            }
           
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            TextForm tf = new TextForm();
            tf = (TextForm)this.ActiveMdiChild;
            Font f = new Font("바탕", 10);
            e.Graphics.DrawString(tf.textBox1.Text, f, Brushes.Black, e.MarginBounds.Left + 10, e.MarginBounds.Top + 10);
        }
        private void tlb_Preview_Click(object sender, EventArgs e)
        {
            FilePrintPreview();
        }

        

        private void 미리보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilePrintPreview();
        }
        //이전
        protected void ControlUndo()
        {
            if (opencount != 0)
            {
                TextForm tf = new TextForm();
                tf = (TextForm)this.ActiveMdiChild;
                tf.textBox1.Undo();
                tss_State.Text = "이전";
            }
            else
            {
                tss_State.Text = "열린 파일이 없습니다.";

            }
            
        }

        private void tlb_Undo_Click(object sender, EventArgs e)
        {
            ControlUndo();
        }

        private void 이전ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlUndo();
        }

       

        //자르기
        protected void ControlCut()
        {
            if (opencount != 0)
            {
                TextForm tf = new TextForm();
                tf = (TextForm)this.ActiveMdiChild;
                tf.textBox1.Cut();
                tss_State.Text = "자르기";
            }
            else
            {
                tss_State.Text = "열린 파일이 없습니다.";

            }
           
        }

        private void 자르기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlCut();
        }

        private void tlb_Cut_Click(object sender, EventArgs e)
        {
            ControlCut();
        }

        

        //복사
        protected void ControlCopy()
        {
            if (opencount != 0)
            {
                TextForm tf = new TextForm();
                tf = (TextForm)this.ActiveMdiChild;
                tf.textBox1.Copy();
                tss_State.Text = "복사";

            }
            else
            {
                tss_State.Text = "열린 파일이 없습니다.";

            }
            
        }

        private void 복사ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlCopy();
        }

        private void tlb_Copy_Click(object sender, EventArgs e)
        {
            ControlCopy();
        }

        

        //붙여넣기
        protected void ControlPaste()
        {
            if (opencount != 0)
            {
                TextForm tf = new TextForm();
                tf = (TextForm)this.ActiveMdiChild;
                tf.textBox1.Paste();
                tss_State.Text = "붙여넣기";
            }
            else
            {
                tss_State.Text = "열린 파일이 없습니다.";

            }
            
        }

        private void 붙여넣기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlPaste();
        }

        

        private void tlb_Paste_Click(object sender, EventArgs e)
        {
            ControlPaste();
           
        }

        

        //폰트
        private void 폰트ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (opencount != 0)
            {
                fontDialog1.ShowColor = true;
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    TextForm tf = new TextForm();
                    tf = (TextForm)this.ActiveMdiChild;
                    tf.textBox1.Font = fontDialog1.Font;
                    tf.textBox1.ForeColor = fontDialog1.Color;
                    tss_State.Text = "폰트변경";
                }else
                {
                    tss_State.Text = "폰트변경취소";
                }
            }
            else
            {
                tss_State.Text = "열린 파일이 없습니다.";

            }
            
            
        }

        

        //배경색
        private void 배경색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (opencount != 0)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    TextForm tf = new TextForm();
                    tf = (TextForm)this.ActiveMdiChild;
                    tf.textBox1.BackColor = colorDialog1.Color;
                    tss_State.Text = "배경색을 교체";
                }
                else
                {
                    tss_State.Text = "배경색을 교체취소";
                }
            }
            else
            {
                tss_State.Text = "열린 파일이 없습니다.";

            }
            
        }

       

       

        //계단식정렬
        private void 계단식ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (opencount != 0)
            {
                this.LayoutMdi(MdiLayout.Cascade);
                tss_State.Text = "계단식 정렬";
            }
            else
            {
                tss_State.Text = "열린 파일이 없습니다.";

            }
            
        }
        //타일식수평정렬
        private void 타일식ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (opencount != 0)
            {
                this.LayoutMdi(MdiLayout.TileHorizontal);
                tss_State.Text = "타일식수평정렬";
            }
            else
            {
                tss_State.Text = "열린 파일이 없습니다.";

            }
            
        }

        

        //타일식수직정렬
        private void 아이콘식ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (opencount != 0)
            {
                this.LayoutMdi(MdiLayout.TileVertical);
                tss_State.Text = "타일식수직정렬";
            }
            else
            {
                tss_State.Text = "열린 파일이 없습니다.";

            }
          
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            tss_State.Text = "메인 창 크기 조절 중";
        }

        private void 메모장정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemoInfo mi = new MemoInfo();
            mi.Owner = this;
            tss_State.Text = "정보열기";
            mi.Show();
        }
    }

}
