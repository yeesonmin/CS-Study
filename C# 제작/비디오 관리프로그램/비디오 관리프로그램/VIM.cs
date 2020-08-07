using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 비디오_관리프로그램
{
    public partial class VIM : Form
    {
        DBClass db;
        public VIM()
        {
            InitializeComponent();
        }

        private void VIM_Load(object sender, EventArgs e)
        {
            textBox_VideoCode.MaxLength = 7;
            textBox_VideoName.MaxLength = 50;
            textBox_VideoCategory.MaxLength = 20;
            textBox_VideoDirector.MaxLength = 20;
            textBox_VideoActor.MaxLength = 20;
            textBox_VideoMade.MaxLength = 20;

            dataGridView_Video.ColumnCount = 10;
            dataGridView_Video.Columns[0].Name = "비디오코드";
            dataGridView_Video.Columns[1].Name = "제목";
            dataGridView_Video.Columns[2].Name = "장르";
            dataGridView_Video.Columns[3].Name = "주연배우";
            dataGridView_Video.Columns[4].Name = "감독";
            dataGridView_Video.Columns[5].Name = "제작및배급";
            dataGridView_Video.Columns[6].Name = "출시일";
            dataGridView_Video.Columns[7].Name = "대여횟수";
            dataGridView_Video.Columns[8].Name = "대여유무";
            dataGridView_Video.Columns[9].Name = "등록날짜";
            Main_VMP vmp = (Main_VMP)MdiParent;
            db = vmp.db;

            db.DBVideoInfo(this);
            textBox_VideoCount.Text = (dataGridView_Video.Rows.Count - 1).ToString();
        }

        private void button_VideoAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView_Video.Rows.Count - 1; i++)
            {
                if (textBox_VideoCode.Text == dataGridView_Video.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show("이미 등록된 비디오 정보 입니다.");
                    return;
                }
            }

            switch (textBox_VideoCode.Text[0])
            {
                case 'F':
                    if(textBox_VideoCategory.Text == "가족")
                    {
                        break;
                    }else
                    {
                        MessageBox.Show("코드와 장르를 확인하세요.");
                        return;
                    }
                case 'A':
                    if (textBox_VideoCategory.Text == "액션")
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("코드와 장르를 확인하세요.");
                        return;
                    }
                case 'C':
                    if (textBox_VideoCategory.Text == "코미디")
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("코드와 장르를 확인하세요.");
                        return;
                    }
                case 'S':
                    if (textBox_VideoCategory.Text == "SF")
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("코드와 장르를 확인하세요.");
                        return;
                    }
                case 'W':
                    if (textBox_VideoCategory.Text == "전쟁")
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("코드와 장르를 확인하세요.");
                        return;
                    }
                case 'R':
                    if (textBox_VideoCategory.Text == "범죄")
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("코드와 장르를 확인하세요.");
                        return;
                    }
                case 'E':
                    if (textBox_VideoCategory.Text == "기타")
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("코드와 장르를 확인하세요.");
                        return;
                    }
                case 'M':
                    if (textBox_VideoCategory.Text == "믹스")
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("코드와 장르를 확인하세요.");
                        return;
                    }
                default:
                    MessageBox.Show("코드 형식을 확인 하세요.\nF : 가족, A : 액션, C: 코미디, S : SF, W : 전쟁, R: 범죄, E : 기타, M : 믹스");
                    return;

            }

            db.DBVideoAdd(this);
        }

        private void dataGridView_Video_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox_VideoCode.Text = dataGridView_Video.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox_VideoName.Text = dataGridView_Video.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox_VideoCategory.Text = dataGridView_Video.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox_VideoActor.Text = dataGridView_Video.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox_VideoDirector.Text = dataGridView_Video.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox_VideoMade.Text = dataGridView_Video.Rows[e.RowIndex].Cells[5].Value.ToString();
                dateTimePicker_VideoRelease.Text = dataGridView_Video.Rows[e.RowIndex].Cells[6].Value.ToString();


                textBox_VideoCode.Text = textBox_VideoCode.Text.Trim();
                textBox_VideoName.Text = textBox_VideoName.Text.Trim();
                textBox_VideoCategory.Text = textBox_VideoCategory.Text.Trim();
                textBox_VideoActor.Text = textBox_VideoActor.Text.Trim();
                textBox_VideoDirector.Text = textBox_VideoDirector.Text.Trim();
                textBox_VideoMade.Text = textBox_VideoMade.Text.Trim();
                dateTimePicker_VideoRelease.Text = dateTimePicker_VideoRelease.Text.Trim();
               
            }
            catch
            {

            }
        }

        private void button_VideoSave_Click(object sender, EventArgs e)
        {
            switch (textBox_VideoCode.Text[0])
            {
                case 'F':
                    if (textBox_VideoCategory.Text == "가족")
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("코드와 장르를 확인하세요.");
                        return;
                    }
                case 'A':
                    if (textBox_VideoCategory.Text == "액션")
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("코드와 장르를 확인하세요.");
                        return;
                    }
                case 'C':
                    if (textBox_VideoCategory.Text == "코미디")
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("코드와 장르를 확인하세요.");
                        return;
                    }
                case 'S':
                    if (textBox_VideoCategory.Text == "SF")
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("코드와 장르를 확인하세요.");
                        return;
                    }
                case 'W':
                    if (textBox_VideoCategory.Text == "전쟁")
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("코드와 장르를 확인하세요.");
                        return;
                    }
                case 'R':
                    if (textBox_VideoCategory.Text == "범죄")
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("코드와 장르를 확인하세요.");
                        return;
                    }
                case 'E':
                    if (textBox_VideoCategory.Text == "기타")
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("코드와 장르를 확인하세요.");
                        return;
                    }
                case 'M':
                    if (textBox_VideoCategory.Text == "믹스")
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("코드와 장르를 확인하세요.");
                        return;
                    }
                default:
                    MessageBox.Show("코드 형식을 확인 하세요.\nF : 가족, A : 액션, C: 코미디, S : SF, W : 전쟁, R: 범죄, E : 기타, M : 믹스");
                    return;

            }

            db.DBVideoUpdate(this);

        }

        private void button_VideoDelete_Click(object sender, EventArgs e)
        {
            db.DBVideoDelete(this);
        }

        private void button_VideoCancle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("지금까지 했던 모든 작업이 복구 됩니다.", "주의", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                db.DBRollBack();
                db.DBVideoInfo(this);
            }
            else
            {
                return;
            }
            
        }

        private void button_VideoClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VIM_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.DBCommit();
        }

        private void button_VideoPrint_Click(object sender, EventArgs e)
        {
            this.printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", 826, 1169);
            this.printDocument1.DefaultPageSettings.Landscape = true;

            this.printPreviewDialog1.Document = this.printDocument1;
            
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int cnt = 0;
            int pageNo = 1;
            int dialogWidth = 1169;//페이지 전체넓이 printPreviewDialog.Width

            StringFormat sf = new StringFormat();//컬럼 안에있는 값들 가운데로 정렬하기위해서.
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            int width, width1;//width 는 시작점 위치, width1은 datagrid 1개의 컬럼 가로길이
            int startWidth = 40;//시작 x좌표
            int startHeight = 100;//시작 y좌표
            int avgHeight = dataGridView_Video.Rows[0].Height+10;//gridview 컬럼 하나의 높이
            int i, j;//반복문용 변수
            int temp = 0;//row개수 세어줄것. cnt의 역할



            e.Graphics.DrawString("비디오 정보", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, dialogWidth / 2 - 60, 40);

            for (i = 0; i < dataGridView_Video.ColumnCount; i++)//columnCount는 일정
            {
                if (i == 0)
                {
                    width = 0;
                    width1 = this.dataGridView_Video.Columns[i].Width + 15;
                }
                else if (i == 6)
                {
                    width = this.dataGridView_Video.Columns[i - 1].Width + 15;
                    width1 = this.dataGridView_Video.Columns[i].Width + 80;
                }
                else
                {
                    width = this.dataGridView_Video.Columns[i - 1].Width + 15;
                    width1 = this.dataGridView_Video.Columns[i].Width + 15;
                }

                RectangleF drawRect = new RectangleF((float)(startWidth), (float)startHeight, (float)width1, avgHeight);

                e.Graphics.DrawRectangle(Pens.Black, (float)(startWidth), (float)startHeight, (float)width1, avgHeight);

                // e.Graphics.FillRectangle(Brushes.LightGray, (float)(startWidth + width), (float)startHeight, (float)width, avgHeight);
                e.Graphics.DrawString(dataGridView_Video.Columns[i].HeaderText, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, drawRect, sf);

                startWidth += width1;


            }
            startHeight += avgHeight;

            for (i = cnt; i < dataGridView_Video.RowCount - 1; i++)
            {
                startWidth = 40;//다시 초기화
                for (j = 0; j < dataGridView_Video.ColumnCount; j++)
                {
                    if (j == 0)
                    {
                        width = 0;
                        width1 = this.dataGridView_Video.Columns[j].Width + 15;
                    }
                    else if (j == 6 )
                    {
                        width = this.dataGridView_Video.Columns[j - 1].Width + 15;
                        width1 = this.dataGridView_Video.Columns[j].Width + 80;
                    }
                    else
                    {
                        width = this.dataGridView_Video.Columns[j - 1].Width + 15;
                        width1 = this.dataGridView_Video.Columns[j].Width + 15;
                    }

                    RectangleF drawRect = new RectangleF((float)(startWidth), (float)startHeight, (float)width1, avgHeight);

                    e.Graphics.DrawRectangle(Pens.Black, (float)(startWidth), (float)startHeight, (float)width1, avgHeight);

                    // e.Graphics.FillRectangle(Brushes.LightGray, (float)(startWidth + width), (float)startHeight, (float)width, avgHeight);
                    e.Graphics.DrawString(dataGridView_Video.Rows[i].Cells[j].FormattedValue.ToString(), new Font("Arial", 10), Brushes.Black, drawRect, sf);
                    startWidth += width1;


                }
                startHeight += avgHeight;
                temp++;
                cnt++;

                if (temp % 40 == 0)
                {
                    // MessageBox.Show("40으로 나눠졋다");
                    e.HasMorePages = true;
                    pageNo++;
                    return;

                }



            }
        }
    }
}
