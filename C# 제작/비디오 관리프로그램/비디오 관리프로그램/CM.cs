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
    public partial class CM : Form
    {
        DBClass db;
        public CM()
        {
            InitializeComponent();
            
        }

        private void CM_Load(object sender, EventArgs e)
        {
            textBox_Address.MaxLength = 50;
            textBox_ClientCode.MaxLength = 7;
            textBox_ClientName.MaxLength = 5;
            textBox_Job.MaxLength = 5;
            textBox_Number.MaxLength = 20;
            textBox_PeoPleNo.MaxLength = 13;
            textBox_PhoneNum.MaxLength = 20;
            textBox_PostNum.MaxLength = 5;
            textBox_Sex.MaxLength = 1;

            dataGridView_Client.ColumnCount = 10;
            dataGridView_Client.Columns[0].Name = "고객코드";
            dataGridView_Client.Columns[1].Name = "고객명";
            dataGridView_Client.Columns[2].Name = "주민번호";
            dataGridView_Client.Columns[3].Name = "신분";
            dataGridView_Client.Columns[4].Name = "성별";
            dataGridView_Client.Columns[5].Name = "전화번호";
            dataGridView_Client.Columns[6].Name = "휴대폰";
            dataGridView_Client.Columns[7].Name = "우편번호";
            dataGridView_Client.Columns[8].Name = "주소";
            dataGridView_Client.Columns[9].Name = "대여횟수";
            Main_VMP vmp = (Main_VMP)MdiParent;
            db = vmp.db;
            db.DBClientInfo(this);

            textBox_ClientCount.Text = (dataGridView_Client.Rows.Count -1).ToString();
        }

        private void dataGridView_Client_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox_ClientCode.Text = dataGridView_Client.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox_ClientName.Text = dataGridView_Client.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox_PeoPleNo.Text = dataGridView_Client.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox_Job.Text = dataGridView_Client.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox_Sex.Text = dataGridView_Client.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox_Number.Text = dataGridView_Client.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBox_PhoneNum.Text = dataGridView_Client.Rows[e.RowIndex].Cells[6].Value.ToString();
                textBox_PostNum.Text = dataGridView_Client.Rows[e.RowIndex].Cells[7].Value.ToString();
                textBox_Address.Text = dataGridView_Client.Rows[e.RowIndex].Cells[8].Value.ToString();
                
                textBox_ClientCode.Text = textBox_ClientCode.Text.Trim();
                textBox_ClientName.Text = textBox_ClientName.Text.Trim();
                textBox_PeoPleNo.Text = textBox_PeoPleNo.Text.Trim();
                textBox_Job.Text = textBox_Job.Text.Trim();
                textBox_Sex.Text = textBox_Sex.Text.Trim();
                textBox_Number.Text = textBox_Number.Text.Trim();
                textBox_PhoneNum.Text = textBox_PhoneNum.Text.Trim();
                textBox_PostNum.Text = textBox_PostNum.Text.Trim();
                textBox_Address.Text = textBox_Address.Text.Trim();
            }
            catch
            {

            }


        }

        private void button_ADD_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dataGridView_Client.Rows.Count-1; i++)
            {
                if(textBox_ClientCode.Text == dataGridView_Client.Rows[i].Cells[0].Value.ToString() ||
                   textBox_PeoPleNo.Text == dataGridView_Client.Rows[i].Cells[2].Value.ToString() ||
                   textBox_PhoneNum.Text == dataGridView_Client.Rows[i].Cells[6].Value.ToString()
                   )
                {
                    MessageBox.Show("이미 등록된 회원 정보 입니다.");
                    return;
                }

            }

            //성별확인
            if (!(textBox_Sex.Text == "남" || textBox_Sex.Text == "여"))
            {
                MessageBox.Show("성별은 '남', '여'로 입력해주세요.");
                return;
            }

            //신분 확인
            if (!(textBox_Job.Text == "성인" || textBox_Job.Text == "학생" || textBox_Job.Text == "어린이"))
            {
                MessageBox.Show("신분은 '성인', '학생', '어린이'로 입력해주세요.");
                return;
            }


            //고객코드하고 성별 확인
            switch (textBox_Sex.Text)
            {
                case "남":
                    if ((textBox_ClientCode.Text[0].ToString() + textBox_ClientCode.Text[1].ToString()) == "PM")
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("코드를 확인 해주세요.\n 남 : PM, 여 : PG");
                        return;
                    }
                case "여":
                    if ((textBox_ClientCode.Text[0].ToString() + textBox_ClientCode.Text[1].ToString()) == "PG")
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("코드를 확인 해주세요.\n 남 : PM, 여 : PG");
                        return;
                    }

            }


            //주민번호하고 성별 확인
            //주민번호 1,2,3,4 확인
            switch (textBox_PeoPleNo.Text.ToString()[6])
            {
                case '1':
                    if (textBox_Sex.Text == "남")
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("성별을 확인 해주세요.");
                        return;
                    }
                case '2':
                    if (textBox_Sex.Text == "여")
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("성별을 확인 해주세요.");
                        return;
                    }
                case '3':
                    if (textBox_Sex.Text == "남")
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("성별을 확인 해주세요.");
                        return;
                    }
                case '4':
                    if (textBox_Sex.Text == "여")
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("성별을 확인 해주세요.");
                        return;
                    }
                default:
                    MessageBox.Show("주민번호가 잘못되었습니다.");
                    return;

            }

            db.DBClientAdd(this);

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            //성별확인
            if (!(textBox_Sex.Text == "남" || textBox_Sex.Text == "여"))
            {
                MessageBox.Show("성별은 '남', '여'로 입력해주세요.");
                return;
            }

            //신분 확인
            if (!(textBox_Job.Text == "성인" || textBox_Job.Text == "학생" || textBox_Job.Text == "어린이"))
            {
                MessageBox.Show("신분은 '성인', '학생', '어린이'로 입력해주세요.");
                return;
            }


            //고객코드하고 성별 확인
            switch (textBox_Sex.Text)
            {
                case "남":
                    if ((textBox_ClientCode.Text[0].ToString() + textBox_ClientCode.Text[1].ToString()) == "PM")
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("코드를 확인 해주세요.\n 남 : PM, 여 : PG");
                        return;
                    }
                case "여":
                    if ((textBox_ClientCode.Text[0].ToString() + textBox_ClientCode.Text[1].ToString()) == "PG")
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("코드를 확인 해주세요.\n 남 : PM, 여 : PG");
                        return;
                    }

            }


            //주민번호하고 성별 확인
            //주민번호 1,2,3,4 확인
            switch (textBox_PeoPleNo.Text.ToString()[6])
            {
                case '1':
                    if (textBox_Sex.Text == "남")
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("성별을 확인 해주세요.");
                        return;
                    }
                case '2':
                    if (textBox_Sex.Text == "여")
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("성별을 확인 해주세요.");
                        return;
                    }
                case '3':
                    if (textBox_Sex.Text == "남")
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("성별을 확인 해주세요.");
                        return;
                    }
                case '4':
                    if (textBox_Sex.Text == "여")
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("성별을 확인 해주세요.");
                        return;
                    }
                default:
                    MessageBox.Show("주민번호가 잘못되었습니다.");
                    return;

            }

            db.DBClientUpdate(this);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            db.DBClientDelete(this);

        }

        private void button_Cancle_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("지금까지 했던 모든 작업이 복구 됩니다.", "주의", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                db.DBRollBack();
                db.DBClientInfo(this);
            }
            else
            {
                return;
            }

        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CM_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.DBCommit();
        }
    }
}
