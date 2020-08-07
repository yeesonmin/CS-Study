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
    public partial class VRM : Form
    {
        DBClass db;
   
        public VRM()
        {
            InitializeComponent();
        }

        private void VRM_Load(object sender, EventArgs e)
        {
            textBox_ClientAddress.MaxLength = 50;
            textBox_ClientCode.MaxLength = 7;
            textBox_ClientName.MaxLength = 5;
            textBox_ClientJob.MaxLength = 5;
            textBox_ClientNum.MaxLength = 20;
            textBox_ClientPeopleNum.MaxLength = 13;
            textBox_ClientPhone.MaxLength = 20;
            textBox_ClientPost.MaxLength = 5;

            textBox_VideoCode.MaxLength = 7;
            textBox_VideoName.MaxLength = 50;

            dateTimePicker_Rent.Value = System.DateTime.Today;

            dataGridView_Client.ColumnCount = 8;
            dataGridView_Client.Columns[0].Name = "고객코드";
            dataGridView_Client.Columns[1].Name = "고객명";
            dataGridView_Client.Columns[2].Name = "주민번호";
            dataGridView_Client.Columns[3].Name = "신분";
            dataGridView_Client.Columns[4].Name = "전화번호";
            dataGridView_Client.Columns[5].Name = "휴대폰";
            dataGridView_Client.Columns[6].Name = "우편번호";
            dataGridView_Client.Columns[7].Name = "주소";

          
            dataGridView_Rent.ColumnCount = 6;
            dataGridView_Rent.Columns[0].Name = "비디오코드";
            dataGridView_Rent.Columns[1].Name = "고객코드";
            dataGridView_Rent.Columns[2].Name = "대여료";
            dataGridView_Rent.Columns[3].Name = "연체료";
            dataGridView_Rent.Columns[4].Name = "대여일";
            dataGridView_Rent.Columns[5].Name = "반납예정일";

            Main_VMP vmp = (Main_VMP)MdiParent;
            db = vmp.db;
            db.DBVRMClientInfo(this);
            db.DBVRMRentInfo(this);
            textBox_Count.Text = (dataGridView_Rent.Rows.Count - 1).ToString();

        }

        private void dataGridView_Client_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox_ClientCode.Text = dataGridView_Client.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox_ClientName.Text = dataGridView_Client.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox_ClientPeopleNum.Text = dataGridView_Client.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox_ClientJob.Text = dataGridView_Client.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox_ClientNum.Text = dataGridView_Client.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox_ClientPhone.Text = dataGridView_Client.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBox_ClientPost.Text = dataGridView_Client.Rows[e.RowIndex].Cells[6].Value.ToString();
                textBox_ClientAddress.Text = dataGridView_Client.Rows[e.RowIndex].Cells[7].Value.ToString();
                

                textBox_ClientCode.Text = textBox_ClientCode.Text.Trim();
                textBox_ClientName.Text = textBox_ClientName.Text.Trim();
                textBox_ClientPeopleNum.Text = textBox_ClientPeopleNum.Text.Trim();
                textBox_ClientJob.Text = textBox_ClientJob.Text.Trim();
                textBox_ClientNum.Text = textBox_ClientNum.Text.Trim();
                textBox_ClientPhone.Text = textBox_ClientPhone.Text.Trim();
                textBox_ClientPost.Text = textBox_ClientPost.Text.Trim();
                textBox_ClientAddress.Text = textBox_ClientAddress.Text.Trim();
                db.DBVRMRentClientInfo(this);
            }
            catch
            {

            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            db.DBVRMSearch(this);
            tabControl1.SelectedIndex = 1;
        }

        private void textBox_VideoCode_TextChanged(object sender, EventArgs e)
        {
            db.DBVRMVideoSet(this);
 
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {

            if(textBox_ClientCode.Text.Length == 0 || textBox_VideoCode.Text.Length ==0)
            {
                MessageBox.Show("비디오코드 또는 고객코드가 없습니다.");
                return;
            }

            //대여여부 확인

            if (db.DBVRMRentCheck(this))
            {
                MessageBox.Show("이미 빌린 비디오 입니다. 확인해주세요");
                return;
            }

            //대여정보 등록(비디오, 고객, 대여)
            db.DBVRMRentClientInfoInsert(this);

            //대여할 때 대여료 추가


        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            db.DBCommit();
            db.DBVRMRentClientInfo(this);
        }

        private void button_RollBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("지금까지 했던 모든 작업이 복구 됩니다.", "주의", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                db.DBRollBack();
                db.DBVRMRentClientInfo(this);
                textBox_SumRent.Text = "0";
                textBox_SumReturn.Text = "0";
            }

        }

        private void dataGridView_Rent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox_VideoCode.Text = dataGridView_Rent.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox_ClientCode.Text = dataGridView_Rent.Rows[e.RowIndex].Cells[1].Value.ToString();

                db.DBVRMCellSearch(this);
                db.DBVRMRentClientInfo(this);
            }catch
            {

            }

            
        }

        private void button_Return_Click(object sender, EventArgs e)
        {
            //반납할 때 연체료 추가
            db.DBVRMReturn(this);
            db.DBVRMRentClientInfo(this);
        }

        private void VRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.DBCommit();
        }
    }
}
