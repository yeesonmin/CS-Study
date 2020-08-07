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
    public partial class Information : Form
    {
        DBClass db;
        public Information()
        {
            InitializeComponent();
        }

        private void Information_Load(object sender, EventArgs e)
        {
            radioButton_VideoRentRank.Checked = true;
            comboBox_Range.SelectedIndex = 0;
            comboBox_Job.SelectedIndex = 0;
            Main_VMP vmp = (Main_VMP)MdiParent;
            db = vmp.db;
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string range, job;

            if(radioButton_VideoRentRank.Checked)
            {
                //비디오 대여 순위
                if(comboBox_Range.SelectedIndex == 0)
                {
                    range = "*";
                }else
                {
                    range = comboBox_Range.SelectedItem.ToString();
                }
                dataGridView1.ColumnCount = 10;
                dataGridView1.Columns[0].Name = "대여횟수";
                dataGridView1.Columns[1].Name = "비디오코드";
                dataGridView1.Columns[2].Name = "제목";
                dataGridView1.Columns[3].Name = "장르";
                dataGridView1.Columns[4].Name = "주연배우";
                dataGridView1.Columns[5].Name = "감독";
                dataGridView1.Columns[6].Name = "제작및배급";
                dataGridView1.Columns[7].Name = "출시일";
                dataGridView1.Columns[8].Name = "대여유무";
                dataGridView1.Columns[9].Name = "등록날짜";

                db.DBInfoVideoRentRank(this, range);

            }
            else if(radioButton_VideoRent.Checked)
            {
                //대여중인 비디오
                if (comboBox_Range.SelectedIndex == 0)
                {
                    range = "*";
                    dataGridView1.ColumnCount = 9;
                    dataGridView1.Columns[0].Name = "비디오코드";
                    dataGridView1.Columns[1].Name = "제목";
                    dataGridView1.Columns[2].Name = "장르";
                    dataGridView1.Columns[3].Name = "주연배우";
                    dataGridView1.Columns[4].Name = "감독";
                    dataGridView1.Columns[5].Name = "제작및배급";
                    dataGridView1.Columns[6].Name = "출시일";
                    dataGridView1.Columns[7].Name = "대여횟수";
                    dataGridView1.Columns[8].Name = "등록날짜";

                    db.DBInfoVideoRent(this, range);
                }
                else
                {
                    range = comboBox_Range.SelectedItem.ToString();
                }
                dataGridView1.ColumnCount = 9;
                dataGridView1.Columns[0].Name = "비디오코드";
                dataGridView1.Columns[1].Name = "제목";
                dataGridView1.Columns[2].Name = "장르";
                dataGridView1.Columns[3].Name = "주연배우";
                dataGridView1.Columns[4].Name = "감독";
                dataGridView1.Columns[5].Name = "제작및배급";
                dataGridView1.Columns[6].Name = "출시일";
                dataGridView1.Columns[7].Name = "대여횟수";
                dataGridView1.Columns[8].Name = "등록날짜";

                db.DBInfoVideoRent(this, range);
            }
            else
            {
                //고객 대여 순위
                if (comboBox_Job.SelectedIndex == 0)
                {
                    job = "*";
                }
                else
                {
                    job = comboBox_Job.SelectedItem.ToString();
                }
                dataGridView1.ColumnCount = 10;
                dataGridView1.Columns[0].Name = "대여횟수";
                dataGridView1.Columns[1].Name = "고객코드";
                dataGridView1.Columns[2].Name = "고객명";
                dataGridView1.Columns[3].Name = "주민번호";
                dataGridView1.Columns[4].Name = "신분";
                dataGridView1.Columns[5].Name = "성별";
                dataGridView1.Columns[6].Name = "전화번호";
                dataGridView1.Columns[7].Name = "휴대폰";
                dataGridView1.Columns[8].Name = "우편번호";
                dataGridView1.Columns[9].Name = "주소";

                db.DBInfoClientRank(this, job);
            }




        }
    }
}
