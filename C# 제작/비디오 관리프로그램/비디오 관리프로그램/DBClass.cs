using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace 비디오_관리프로그램
{
    public class DBClass : Form
    {
        SqlConnection conn = null;
        SqlCommand sqlCommand;
        bool chBegin = false;
        public void SQLConnect()
        {

            string DBConnectString = "Server=localhost; Database=VideoRent; Uid=sa; Pwd=tjsals6565;";

            try
            {
                if (conn != null)
                {
                    conn.Close();
                }
                conn = new SqlConnection(DBConnectString);
                conn.Open();
                Console.WriteLine("연결성공");
            }
            catch
            {
                Console.WriteLine("연결 실패");

            }

        }

        public void SQLClose()
        {
            conn.Close();
        }

        public void DBBeginTran()
        {
            if (!chBegin)
            {
                string query = "BEGIN TRAN;";
                sqlCommand = new SqlCommand(query, conn);
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    chBegin = true;
                }
                catch
                {
                    Console.WriteLine("오류");
                    Console.WriteLine(query);
                }

            }

        }

        public void DBCommit()
        {
            if (chBegin)
            {
                string query = "COMMIT;";
                sqlCommand = new SqlCommand(query, conn);
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    chBegin = false;
                }
                catch
                {
                    Console.WriteLine("오류");
                    Console.WriteLine(query);
                }

            }
        }

        public void DBRollBack()
        {
            if (chBegin)
            {
                string query = "RollBack;";
                sqlCommand = new SqlCommand(query, conn);
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    chBegin = false;
                }
                catch
                {
                    Console.WriteLine("오류");
                    Console.WriteLine(query);
                }

            }
        }

        public void DBClientInfo(CM cm)
        {

            string query = "SELECT * FROM 고객정보";
            sqlCommand = new SqlCommand(query, conn);
            int i = 0;

            using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
            {
                cm.dataGridView_Client.Rows.Clear();
                while (sqlDataReader.Read())
                {
                    cm.dataGridView_Client.Rows.Add();
                    cm.dataGridView_Client["고객코드", i].Value = sqlDataReader[0];
                    cm.dataGridView_Client["고객명", i].Value = sqlDataReader[1];
                    cm.dataGridView_Client["주민번호", i].Value = sqlDataReader[2];
                    cm.dataGridView_Client["신분", i].Value = sqlDataReader[3];
                    cm.dataGridView_Client["성별", i].Value = sqlDataReader[4];
                    cm.dataGridView_Client["전화번호", i].Value = sqlDataReader[5];
                    cm.dataGridView_Client["휴대폰", i].Value = sqlDataReader[6];
                    cm.dataGridView_Client["우편번호", i].Value = sqlDataReader[7];
                    cm.dataGridView_Client["주소", i].Value = sqlDataReader[8];
                    cm.dataGridView_Client["대여횟수", i].Value = sqlDataReader[9];
                    i++;
                }

                sqlDataReader.Close();
            }
        }

        public void DBClientAdd(CM cm)
        {
            DBBeginTran();
            string query = "INSERT INTO 고객정보(고객코드, 고객명, 주민번호, 신분, 성별, 전화번호, 휴대폰, 우편번호, 주소, 대여횟수) " +
                "VALUES ('" + cm.textBox_ClientCode.Text + "', '" + cm.textBox_ClientName.Text + "', '" +
                cm.textBox_PeoPleNo.Text + "', '" + cm.textBox_Job.Text + "', '" + cm.textBox_Sex.Text + "', '" +
                cm.textBox_Number.Text + "', '" + cm.textBox_PhoneNum.Text + "', " + int.Parse(cm.textBox_PostNum.Text) + ", '" +
                cm.textBox_Address.Text + "', 0);";

            sqlCommand = new SqlCommand(query, conn);
            try
            {
                sqlCommand.ExecuteNonQuery();
                DBClientInfo(cm);
            }
            catch
            {
                Console.WriteLine("오류");
                Console.WriteLine(query);
            }

        }

        public void DBClientUpdate(CM cm)
        {
            string 고객명 = cm.textBox_ClientName.Text;
            string 신분 = cm.textBox_Job.Text;
            string 전화번호 = cm.textBox_Number.Text;
            string 휴대폰 = cm.textBox_PhoneNum.Text;
            int 우편번호 = int.Parse(cm.textBox_PostNum.Text);
            string 주소 = cm.textBox_Address.Text;
            string 고객코드 = cm.textBox_ClientCode.Text;

            DBBeginTran();
            string query = "update 고객정보 set 고객명 = '" + 고객명 + "', 신분 = '" + 신분 + "', 전화번호 = '" + 전화번호 +
                "', 휴대폰 = '" + 휴대폰 + "', 우편번호 = " + 우편번호 + ", 주소 = '" + 주소 + "' where 고객코드 = '" +
                고객코드 + "';";

            sqlCommand = new SqlCommand(query, conn);
            try
            {
                sqlCommand.ExecuteNonQuery();
                DBClientInfo(cm);
            }
            catch
            {
                Console.WriteLine("오류");
                Console.WriteLine(query);
            }
        }

        public void DBClientDelete(CM cm)
        {
            string 고객코드 = cm.textBox_ClientCode.Text;
            DBBeginTran();
            string query = "delete from 고객정보 where 고객코드 = '" + 고객코드 + "';";
            sqlCommand = new SqlCommand(query, conn);
            try
            {
                sqlCommand.ExecuteNonQuery();
                DBClientInfo(cm);
            }
            catch
            {
                Console.WriteLine("오류");
                Console.WriteLine(query);
            }

        }


        public void DBVideoInfo(VIM vim)
        {

            string query = "SELECT * FROM 비디오정보";
            sqlCommand = new SqlCommand(query, conn);
            int i = 0;

            using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
            {
                vim.dataGridView_Video.Rows.Clear();
                while (sqlDataReader.Read())
                {
                    vim.dataGridView_Video.Rows.Add();
                    vim.dataGridView_Video["비디오코드", i].Value = sqlDataReader[0];
                    vim.dataGridView_Video["제목", i].Value = sqlDataReader[1];
                    vim.dataGridView_Video["장르", i].Value = sqlDataReader[2];
                    vim.dataGridView_Video["주연배우", i].Value = sqlDataReader[3];
                    vim.dataGridView_Video["감독", i].Value = sqlDataReader[4];
                    vim.dataGridView_Video["제작및배급", i].Value = sqlDataReader[5];
                    vim.dataGridView_Video["출시일", i].Value = sqlDataReader[6];
                    vim.dataGridView_Video["대여횟수", i].Value = sqlDataReader[7];
                    vim.dataGridView_Video["대여유무", i].Value = sqlDataReader[8];
                    vim.dataGridView_Video["등록날짜", i].Value = sqlDataReader[9];
                    i++;
                }

                sqlDataReader.Close();
            }
        }

        public void DBVideoAdd(VIM vim)
        {
            string 비디오코드 = vim.textBox_VideoCode.Text;
            string 제목 = vim.textBox_VideoName.Text;
            string 장르 = vim.textBox_VideoCategory.Text;
            string 주연배우 = vim.textBox_VideoActor.Text;
            string 감독 = vim.textBox_VideoDirector.Text;
            string 제작및배급 = vim.textBox_VideoMade.Text;
            string 출시일 = vim.dateTimePicker_VideoRelease.Text;
            string 등록날짜 = System.DateTime.Today.ToString("yyyy-MM-dd");

            DBBeginTran();
            string query = "INSERT INTO 비디오정보(비디오코드, 제목, 장르, 주연배우, 감독, 제작및배급, 출시일, 대여횟수, 대여유무, 등록날짜)" +
                "VALUES('" + 비디오코드 + "', '" + 제목 + "', '" + 장르 + "', '" + 주연배우 + "', '" +
                감독 + "', '" + 제작및배급 + "', '" + 출시일 + "', 0, 0, '" + 등록날짜 + "'); ";
            sqlCommand = new SqlCommand(query, conn);

            try
            {
                sqlCommand.ExecuteNonQuery();
                DBVideoInfo(vim);
            }
            catch
            {
                Console.WriteLine("오류");
                Console.WriteLine(query);
            }

        }

        public void DBVideoUpdate(VIM vim)
        {
            string 비디오코드 = vim.textBox_VideoCode.Text;
            string 제목 = vim.textBox_VideoName.Text;
            string 장르 = vim.textBox_VideoCategory.Text;
            string 주연배우 = vim.textBox_VideoActor.Text;
            string 감독 = vim.textBox_VideoDirector.Text;
            string 제작및배급 = vim.textBox_VideoMade.Text;
            string 출시일 = vim.dateTimePicker_VideoRelease.Text;

            DBBeginTran();
            string query =
                "UPDATE 비디오정보 SET 비디오코드 = '" + 비디오코드 + "', 제목 = '" + 제목 +
                "', 장르 = '" + 장르 + "', 주연배우 = '" + 주연배우 + "', 감독 = '" + 감독 +
                "', 제작및배급 = '" + 제작및배급 + "', 출시일 = '" + 출시일 + "' WHERE 비디오코드 = '" + 비디오코드 + "';";

            sqlCommand = new SqlCommand(query, conn);
            try
            {
                sqlCommand.ExecuteNonQuery();
                DBVideoInfo(vim);
            }
            catch
            {
                Console.WriteLine("오류");
                Console.WriteLine(query);
            }
        }

        public void DBVideoDelete(VIM vim)
        {
            string 비디오코드 = vim.textBox_VideoCode.Text;
            DBBeginTran();
            string query = "delete from 비디오정보 where 비디오코드 = '" + 비디오코드 + "';";
            sqlCommand = new SqlCommand(query, conn);
            try
            {
                sqlCommand.ExecuteNonQuery();
                DBVideoInfo(vim);
            }
            catch
            {
                Console.WriteLine("오류");
                Console.WriteLine(query);
            }
        }



        public void DBVRMClientInfo(VRM vrm)
        {

            string query = "SELECT 고객코드, 고객명, 주민번호, 신분, 전화번호, 휴대폰, 우편번호, 주소  FROM 고객정보";
            sqlCommand = new SqlCommand(query, conn);
            int i = 0;

            using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
            {
                vrm.dataGridView_Client.Rows.Clear();
                while (sqlDataReader.Read())
                {
                    vrm.dataGridView_Client.Rows.Add();
                    vrm.dataGridView_Client["고객코드", i].Value = sqlDataReader[0];
                    vrm.dataGridView_Client["고객명", i].Value = sqlDataReader[1];
                    vrm.dataGridView_Client["주민번호", i].Value = sqlDataReader[2];
                    vrm.dataGridView_Client["신분", i].Value = sqlDataReader[3];
                    vrm.dataGridView_Client["전화번호", i].Value = sqlDataReader[4];
                    vrm.dataGridView_Client["휴대폰", i].Value = sqlDataReader[5];
                    vrm.dataGridView_Client["우편번호", i].Value = sqlDataReader[6];
                    vrm.dataGridView_Client["주소", i].Value = sqlDataReader[7];
                    i++;
                }

                sqlDataReader.Close();
            }
        }

        public void DBVRMSearch(VRM vrm)
        {
            string query, s;


            if (vrm.textBox_VRMClientName.Text.Length > 0)
            {
                s = vrm.textBox_VRMClientName.Text;

                query = "SELECT 고객코드, 고객명, 주민번호, 신분, 전화번호, 휴대폰, 우편번호, 주소  FROM 고객정보 " +
                    "WHERE 고객명 like '" + s + "%';";

                sqlCommand = new SqlCommand(query, conn);
                int i = 0;

                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    vrm.dataGridView_Client.Rows.Clear();
                    while (sqlDataReader.Read())
                    {
                        vrm.dataGridView_Client.Rows.Add();
                        vrm.dataGridView_Client["고객코드", i].Value = sqlDataReader[0];
                        vrm.dataGridView_Client["고객명", i].Value = sqlDataReader[1];
                        vrm.dataGridView_Client["주민번호", i].Value = sqlDataReader[2];
                        vrm.dataGridView_Client["신분", i].Value = sqlDataReader[3];
                        vrm.dataGridView_Client["전화번호", i].Value = sqlDataReader[4];
                        vrm.dataGridView_Client["휴대폰", i].Value = sqlDataReader[5];
                        vrm.dataGridView_Client["우편번호", i].Value = sqlDataReader[6];
                        vrm.dataGridView_Client["주소", i].Value = sqlDataReader[7];
                        i++;
                    }

                    sqlDataReader.Close();
                }

            }
            else if (vrm.textBox_VRMClientCode.Text.Length > 0)
            {
                s = vrm.textBox_VRMClientCode.Text;

                query = "SELECT 고객코드, 고객명, 주민번호, 신분, 전화번호, 휴대폰, 우편번호, 주소  FROM 고객정보 " +
                    "WHERE 고객코드 like '" + s + "%';";

                sqlCommand = new SqlCommand(query, conn);
                int i = 0;

                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    vrm.dataGridView_Client.Rows.Clear();
                    while (sqlDataReader.Read())
                    {
                        vrm.dataGridView_Client.Rows.Add();
                        vrm.dataGridView_Client["고객코드", i].Value = sqlDataReader[0];
                        vrm.dataGridView_Client["고객명", i].Value = sqlDataReader[1];
                        vrm.dataGridView_Client["주민번호", i].Value = sqlDataReader[2];
                        vrm.dataGridView_Client["신분", i].Value = sqlDataReader[3];
                        vrm.dataGridView_Client["전화번호", i].Value = sqlDataReader[4];
                        vrm.dataGridView_Client["휴대폰", i].Value = sqlDataReader[5];
                        vrm.dataGridView_Client["우편번호", i].Value = sqlDataReader[6];
                        vrm.dataGridView_Client["주소", i].Value = sqlDataReader[7];
                        i++;
                    }

                    sqlDataReader.Close();
                }

            }
            else if (vrm.textBox_VRMClientNum.Text.Length > 0)
            {
                s = vrm.textBox_VRMClientNum.Text;

                query = "SELECT 고객코드, 고객명, 주민번호, 신분, 전화번호, 휴대폰, 우편번호, 주소  FROM 고객정보 " +
                    "WHERE 전화번호 like '" + s + "%';";

                sqlCommand = new SqlCommand(query, conn);
                int i = 0;

                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    vrm.dataGridView_Client.Rows.Clear();
                    while (sqlDataReader.Read())
                    {
                        vrm.dataGridView_Client.Rows.Add();
                        vrm.dataGridView_Client["고객코드", i].Value = sqlDataReader[0];
                        vrm.dataGridView_Client["고객명", i].Value = sqlDataReader[1];
                        vrm.dataGridView_Client["주민번호", i].Value = sqlDataReader[2];
                        vrm.dataGridView_Client["신분", i].Value = sqlDataReader[3];
                        vrm.dataGridView_Client["전화번호", i].Value = sqlDataReader[4];
                        vrm.dataGridView_Client["휴대폰", i].Value = sqlDataReader[5];
                        vrm.dataGridView_Client["우편번호", i].Value = sqlDataReader[6];
                        vrm.dataGridView_Client["주소", i].Value = sqlDataReader[7];
                        i++;
                    }

                    sqlDataReader.Close();
                }

            }
            else if (vrm.textBox_VRMClientPhone.Text.Length > 0)
            {
                s = vrm.textBox_VRMClientPhone.Text;

                query = "SELECT 고객코드, 고객명, 주민번호, 신분, 전화번호, 휴대폰, 우편번호, 주소  FROM 고객정보 " +
                    "WHERE 휴대폰 = '" + s + "';";

                sqlCommand = new SqlCommand(query, conn);
                int i = 0;

                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    vrm.dataGridView_Client.Rows.Clear();
                    while (sqlDataReader.Read())
                    {
                        vrm.dataGridView_Client.Rows.Add();
                        vrm.dataGridView_Client["고객코드", i].Value = sqlDataReader[0];
                        vrm.dataGridView_Client["고객명", i].Value = sqlDataReader[1];
                        vrm.dataGridView_Client["주민번호", i].Value = sqlDataReader[2];
                        vrm.dataGridView_Client["신분", i].Value = sqlDataReader[3];
                        vrm.dataGridView_Client["전화번호", i].Value = sqlDataReader[4];
                        vrm.dataGridView_Client["휴대폰", i].Value = sqlDataReader[5];
                        vrm.dataGridView_Client["우편번호", i].Value = sqlDataReader[6];
                        vrm.dataGridView_Client["주소", i].Value = sqlDataReader[7];
                        i++;
                    }

                    sqlDataReader.Close();
                }
            }
        }

        public void DBVRMVideoSet(VRM vrm)
        {
            string query;
            string code;
            DateTime date = DateTime.Now;

            int 전환기간, 신프로대여기간, 신프로대여료, 신프로연체료, 구프로대여기간, 구프로대여료, 구프로연체료;

            code = vrm.textBox_VideoCode.Text;
            query = "SELECT 비디오코드, 제목, 등록날짜 FROM 비디오정보 WHERE 비디오코드 = '" + code + "'";
            sqlCommand = new SqlCommand(query, conn);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            try
            {

                sqlDataReader.Read();
                if (code == sqlDataReader[0].ToString())
                {
                    vrm.textBox_VideoName.Text = sqlDataReader[1].ToString();
                    date = Convert.ToDateTime(sqlDataReader[2].ToString());
                    sqlDataReader.Close();

                    query = "SELECT * FROM 설정정보";
                    sqlCommand = new SqlCommand(query, conn);
                    using (sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        sqlDataReader.Read();
                        전환기간 = int.Parse(sqlDataReader[0].ToString());
                        신프로대여기간 = int.Parse(sqlDataReader[1].ToString());
                        신프로대여료 = int.Parse(sqlDataReader[2].ToString());
                        신프로연체료 = int.Parse(sqlDataReader[3].ToString());
                        구프로대여기간 = int.Parse(sqlDataReader[4].ToString());
                        구프로대여료 = int.Parse(sqlDataReader[5].ToString());
                        구프로연체료 = int.Parse(sqlDataReader[6].ToString());
                        sqlDataReader.Close();
                    }

                    TimeSpan time = System.DateTime.Today - date;
                    if (time.Days > 60)
                    {
                        vrm.textBox_RentRate.Text = 구프로대여료.ToString();
                        vrm.textBox_Arrears.Text = 구프로연체료.ToString();
                        vrm.dateTimePicker_Return.Value = System.DateTime.Today.AddDays(구프로대여기간);
                    }
                    else
                    {
                        vrm.textBox_RentRate.Text = 신프로대여료.ToString();
                        vrm.textBox_Arrears.Text = 신프로연체료.ToString();
                        vrm.dateTimePicker_Return.Value = System.DateTime.Today.AddDays(신프로대여기간);
                    }
                }
            }
            catch
            {

            }
            finally
            {
                sqlDataReader.Close();
            }




        }

        public void DBVRMRentInfo(VRM vrm)
        {
            string query = "SELECT * FROM 대여정보";

            sqlCommand = new SqlCommand(query, conn);
            int i = 0;

            using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
            {
                vrm.dataGridView_Rent.Rows.Clear();
                while (sqlDataReader.Read())
                {
                    vrm.dataGridView_Rent.Rows.Add();
                    vrm.dataGridView_Rent["비디오코드", i].Value = sqlDataReader[0];
                    vrm.dataGridView_Rent["고객코드", i].Value = sqlDataReader[1];
                    vrm.dataGridView_Rent["대여료", i].Value = sqlDataReader[2];
                    vrm.dataGridView_Rent["연체료", i].Value = sqlDataReader[3];
                    vrm.dataGridView_Rent["대여일", i].Value = sqlDataReader[4];
                    vrm.dataGridView_Rent["반납예정일", i].Value = sqlDataReader[5];
                    i++;
                }

                sqlDataReader.Close();
            }
        }

        public void DBVRMRentClientInfo(VRM vrm)
        {
            string 고객코드 = vrm.textBox_ClientCode.Text;
            string query = "SELECT * FROM 대여정보 WHERE 고객코드 = '" + 고객코드 + "'";

            sqlCommand = new SqlCommand(query, conn);
            int i = 0;

            using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
            {
                vrm.dataGridView_Rent.Rows.Clear();
                while (sqlDataReader.Read())
                {
                    vrm.dataGridView_Rent.Rows.Add();
                    vrm.dataGridView_Rent["비디오코드", i].Value = sqlDataReader[0];
                    vrm.dataGridView_Rent["고객코드", i].Value = sqlDataReader[1];
                    vrm.dataGridView_Rent["대여료", i].Value = sqlDataReader[2];
                    vrm.dataGridView_Rent["연체료", i].Value = sqlDataReader[3];
                    vrm.dataGridView_Rent["대여일", i].Value = sqlDataReader[4];
                    vrm.dataGridView_Rent["반납예정일", i].Value = sqlDataReader[5];
                    i++;
                }
                vrm.textBox_Count.Text = (vrm.dataGridView_Rent.Rows.Count - 1).ToString();
                sqlDataReader.Close();
            }
        }

        public void DBVRMRentClientInfoInsert(VRM vrm)
        {
            string 비디오코드, 고객코드, 대여료, 연체료, 대여일, 반납예정일;
            비디오코드 = vrm.textBox_VideoCode.Text;
            고객코드 = vrm.textBox_ClientCode.Text;
            대여료 = vrm.textBox_RentRate.Text;
            연체료 = vrm.textBox_Arrears.Text;
            대여일 = vrm.dateTimePicker_Rent.Text;
            반납예정일 = vrm.dateTimePicker_Return.Text;

            int sum = int.Parse(vrm.textBox_SumRent.Text);

            DBBeginTran();
            string query =
                "INSERT INTO 대여정보(비디오코드, 고객코드, 대여료, 연체료, 대여일, 반납예정일) VALUES (" +
                "'" + 비디오코드 + "', '" + 고객코드 + "', " + 대여료 + ", " + 연체료 + ", '" + 대여일 + "', '" + 반납예정일 +
                "')";

            sqlCommand = new SqlCommand(query, conn);

            try
            {
                sqlCommand.ExecuteNonQuery();
                sum += int.Parse(대여료);
                vrm.textBox_SumRent.Text = sum.ToString();
            }
            catch
            {
                Console.WriteLine("오류");
                Console.WriteLine(query);
            }

            query =
                "UPDATE 비디오정보 SET 대여유무 = 1, 대여횟수 = 대여횟수 + 1 WHERE 비디오코드 = '" + 비디오코드 + "'";
            sqlCommand = new SqlCommand(query, conn);

            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("오류");
                Console.WriteLine(query);
            }

            query =
                "UPDATE 고객정보 SET 대여횟수 = 대여횟수 + 1 WHERE 고객코드 = '" + 고객코드 + "'";
            sqlCommand = new SqlCommand(query, conn);

            try
            {
                sqlCommand.ExecuteNonQuery();
                DBVRMRentClientInfo(vrm);
            }
            catch
            {
                Console.WriteLine("오류");
                Console.WriteLine(query);
            }



        }

        public bool DBVRMRentCheck(VRM vrm)
        {
            string 비디오코드 = vrm.textBox_VideoCode.Text;
            string query = "SELECT 대여유무 FROM 비디오정보 WHERE 비디오코드 = '" + 비디오코드 + "'";
            bool 대여유무;

            sqlCommand = new SqlCommand(query, conn);
            using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
            {
                sqlDataReader.Read();
                대여유무 = (bool)sqlDataReader[0];
                sqlDataReader.Close();
            }

            return 대여유무;

        }


        public void DBVRMCellSearch(VRM vrm)
        {
            string query, 비디오코드, 고객코드;

            비디오코드 = vrm.textBox_VideoCode.Text;
            고객코드 = vrm.textBox_ClientCode.Text;


            query = "SELECT 고객코드, 고객명, 주민번호, 신분, 전화번호, 휴대폰, 우편번호, 주소  FROM 고객정보 " +
                   "WHERE 고객코드 = '" + 고객코드 + "';";

            sqlCommand = new SqlCommand(query, conn);

            using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
            {
                sqlDataReader.Read();

                vrm.textBox_ClientName.Text = sqlDataReader[1].ToString();
                vrm.textBox_ClientPeopleNum.Text = sqlDataReader[2].ToString();
                vrm.textBox_ClientJob.Text = sqlDataReader[3].ToString();
                vrm.textBox_ClientNum.Text = sqlDataReader[4].ToString();
                vrm.textBox_ClientPhone.Text = sqlDataReader[5].ToString();
                vrm.textBox_ClientPost.Text = sqlDataReader[6].ToString();
                vrm.textBox_ClientAddress.Text = sqlDataReader[7].ToString();


                sqlDataReader.Close();
            }


        }

        public void DBVRMReturn(VRM vrm)
        {
            string query, 비디오코드;
            int sum = int.Parse(vrm.textBox_SumReturn.Text);
            int i = 0;
            DateTime dateTime = System.DateTime.Today;
            DateTime 반납예정일 = System.DateTime.Today; ;
            TimeSpan time;
            비디오코드 = vrm.textBox_VideoCode.Text;

            //반납일 비교후 연체료 계산
            for (i = 0; i < vrm.dataGridView_Rent.Rows.Count - 1; i++)
            {
                if (비디오코드 == vrm.dataGridView_Rent.Rows[i].Cells[0].Value.ToString())
                {
                    반납예정일 = Convert.ToDateTime(vrm.dataGridView_Rent.Rows[i].Cells[5].Value.ToString());
                    break;
                }
            }

            time = dateTime - 반납예정일;
            if (time.Days > 0)
            {
                sum += int.Parse(vrm.dataGridView_Rent.Rows[i].Cells[3].Value.ToString());
                vrm.textBox_SumReturn.Text = sum.ToString();
            }
            else
            {
                vrm.textBox_SumReturn.Text = sum.ToString();
            }

            //비디오 대여유무 수정, 대여정보 수정
            query = "UPDATE 비디오정보 SET 대여유무 = 0 WHERE 비디오코드 = '" + 비디오코드 + "'";
            sqlCommand = new SqlCommand(query, conn);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("오류");
                Console.WriteLine(query);
            }

            query = "delete from 대여정보 where 비디오코드 = '" + 비디오코드 + "';";
            sqlCommand = new SqlCommand(query, conn);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("오류");
                Console.WriteLine(query);
            }
        }

        public void DBInfoVideoRentRank(Information info, string s)
        {
            string query;
            int i = 0;

            if (s == "*")
            {
                query = "SELECT 대여횟수, 비디오코드, 제목, 장르, 주연배우, 감독, 제작및배급, 출시일, 대여유무, 등록날짜 " +
                    "FROM 비디오정보 ORDER BY 대여횟수 DESC";
            }
            else
            {
                query = "SELECT 대여횟수, 비디오코드, 제목, 장르, 주연배우, 감독, 제작및배급, 출시일, 대여유무, 등록날짜 " +
                        "FROM 비디오정보 " + "WHERE 장르 = '" + s + "' " + "ORDER BY 대여횟수 DESC";
            }

            sqlCommand = new SqlCommand(query, conn);
            using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
            {
                info.dataGridView1.Rows.Clear();
                while (sqlDataReader.Read())
                {
                    info.dataGridView1.Rows.Add();
                    info.dataGridView1["대여횟수", i].Value = sqlDataReader[0];
                    info.dataGridView1["비디오코드", i].Value = sqlDataReader[1];
                    info.dataGridView1["제목", i].Value = sqlDataReader[2];
                    info.dataGridView1["장르", i].Value = sqlDataReader[3];
                    info.dataGridView1["주연배우", i].Value = sqlDataReader[4];
                    info.dataGridView1["감독", i].Value = sqlDataReader[5];
                    info.dataGridView1["제작및배급", i].Value = sqlDataReader[6];
                    info.dataGridView1["출시일", i].Value = sqlDataReader[7];
                    info.dataGridView1["대여유무", i].Value = sqlDataReader[8];
                    info.dataGridView1["등록날짜", i].Value = sqlDataReader[9];
                    i++;
                }

                sqlDataReader.Close();
            }
        }

        public void DBInfoVideoRent(Information info, string s)
        {
            string query;
            int i = 0;

            if (s == "*")
            {
                query = "SELECT 비디오코드, 제목, 장르, 주연배우, 감독, 제작및배급, 출시일, 대여횟수, 등록날짜 " +
                        "FROM 비디오정보 ";
            }
            else
            {
                query = "SELECT 비디오코드, 제목, 장르, 주연배우, 감독, 제작및배급, 출시일, 대여횟수, 등록날짜 " +
                        "FROM 비디오정보 " + "WHERE 장르 = '" + s + "' ";
            }

            sqlCommand = new SqlCommand(query, conn);

            using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
            {
                info.dataGridView1.Rows.Clear();
                while (sqlDataReader.Read())
                {
                    info.dataGridView1.Rows.Add();
                    info.dataGridView1["비디오코드", i].Value = sqlDataReader[0];
                    info.dataGridView1["제목", i].Value = sqlDataReader[1];
                    info.dataGridView1["장르", i].Value = sqlDataReader[2];
                    info.dataGridView1["주연배우", i].Value = sqlDataReader[3];
                    info.dataGridView1["감독", i].Value = sqlDataReader[4];
                    info.dataGridView1["제작및배급", i].Value = sqlDataReader[5];
                    info.dataGridView1["출시일", i].Value = sqlDataReader[6];
                    info.dataGridView1["대여횟수", i].Value = sqlDataReader[7];
                    info.dataGridView1["등록날짜", i].Value = sqlDataReader[8];
                    i++;
                }

                sqlDataReader.Close();
            }
        }
        public void DBInfoClientRank(Information info, string s)
        {
            string query;
            int i = 0;

            if (s == "*")
            {
                query = "SELECT 대여횟수, 고객코드, 고객명, 주민번호, 신분, 성별, 전화번호, 휴대폰, 우편번호, 주소 " +
                    "FROM 고객정보 ORDER BY 대여횟수 DESC";

            }
            else
            {
                query = "SELECT 대여횟수, 고객코드, 고객명, 주민번호, 신분, 성별, 전화번호, 휴대폰, 우편번호, 주소 " +
                   "FROM 고객정보 WHERE 신분 = '" + s + "' ORDER BY 대여횟수 DESC";
            }

            sqlCommand = new SqlCommand(query, conn);

            using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
            {
                info.dataGridView1.Rows.Clear();
                while (sqlDataReader.Read())
                {
                    info.dataGridView1.Rows.Add();
                    info.dataGridView1["대여횟수", i].Value = sqlDataReader[0];
                    info.dataGridView1["고객코드", i].Value = sqlDataReader[1];
                    info.dataGridView1["고객명", i].Value = sqlDataReader[2];
                    info.dataGridView1["주민번호", i].Value = sqlDataReader[3];
                    info.dataGridView1["신분", i].Value = sqlDataReader[4];
                    info.dataGridView1["성별", i].Value = sqlDataReader[5];
                    info.dataGridView1["전화번호", i].Value = sqlDataReader[6];
                    info.dataGridView1["휴대폰", i].Value = sqlDataReader[7];
                    info.dataGridView1["우편번호", i].Value = sqlDataReader[8];
                    info.dataGridView1["주소", i].Value = sqlDataReader[9];
                    i++;
                }

                sqlDataReader.Close();
            }

        }

        public void DBExcelVideo(string s)
        {
            Excel.Application oXL;
            Excel._Workbook oWB;
            Excel._Worksheet oSheet;
            Excel.Range oRng;
            string query;
            int i = 2;

            if (s == "*")
            {
                query = "SELECT 비디오코드, 제목, 장르, 주연배우, 감독, 제작및배급, 출시일, 대여횟수, 대여유무, 등록날짜 " +
                    "FROM 비디오정보";
            }
            else
            {
                query = "SELECT 비디오코드, 제목, 장르, 주연배우, 감독, 제작및배급, 출시일, 대여횟수, 대여유무, 등록날짜 " +
                        "FROM 비디오정보 " + "WHERE 장르 = '" + s + "' ";
            }

            try
            {
                //Start Excel and get Application object.
                oXL = new Excel.Application();
                oXL.Visible = true;

                //Get a new workbook.
                oWB = oXL.Workbooks.Add();
                oSheet = oWB.ActiveSheet;

                //Add table headers going cell by cell.
                oSheet.Cells[1, 1] = "비디오코드";
                oSheet.Cells[1, 2] = "제목";
                oSheet.Cells[1, 3] = "장르";
                oSheet.Cells[1, 4] = "주연배우";
                oSheet.Cells[1, 5] = "감독";
                oSheet.Cells[1, 6] = "제작및배급";
                oSheet.Cells[1, 7] = "출시일";
                oSheet.Cells[1, 8] = "대여횟수";
                oSheet.Cells[1, 9] = "대여유무";
                oSheet.Cells[1, 10] = "등록날짜";

                //Format A1:D1 as bold, vertical alignment = center.
                oSheet.get_Range("A1", "J1").Font.Bold = true;
                oSheet.get_Range("A1", "J1").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

                // Create an array to multiple values at once.
                sqlCommand = new SqlCommand(query, conn);
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        oSheet.Cells[i, 1] = sqlDataReader[0];
                        oSheet.Cells[i, 2] = sqlDataReader[1];
                        oSheet.Cells[i, 3] = sqlDataReader[2];
                        oSheet.Cells[i, 4] = sqlDataReader[3];
                        oSheet.Cells[i, 5] = sqlDataReader[4];
                        oSheet.Cells[i, 6] = sqlDataReader[5];
                        oSheet.Cells[i, 7] = sqlDataReader[6];
                        oSheet.Cells[i, 8] = sqlDataReader[7];
                        oSheet.Cells[i, 9] = sqlDataReader[8];
                        oSheet.Cells[i, 10] = sqlDataReader[9];
                        i++;
                    }

                    sqlDataReader.Close();
                }

                //AutoFit columns A:D.
                oRng = oSheet.get_Range("A1", "J1");
                oRng.EntireColumn.AutoFit();

                //Make sure Excel is visible and give the user control
                //of Microsoft Excel's lifetime.
                oXL.Visible = true;
                oXL.UserControl = true;

            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "Error");
            }
        }


        public void DBExcelRent(string s)
        {
            Excel.Application oXL;
            Excel._Workbook oWB;
            Excel._Worksheet oSheet;
            Excel.Range oRng;
            string query;
            int i = 2;

            if (s == "*")
            {
                query = "SELECT 대여유무, 비디오코드, 제목, 장르, 주연배우, 감독, 제작및배급, 출시일, 대여횟수, 등록날짜 " +
                    "FROM 비디오정보 ORDER BY 대여유무 DESC";
            }
            else
            {
                query = "SELECT 대여유무, 비디오코드, 제목, 장르, 주연배우, 감독, 제작및배급, 출시일, 대여횟수, 등록날짜 " +
                        "FROM 비디오정보 " + "WHERE 장르 = '" + s + "' ORDER BY 대여유무 DESC";
            }

            try
            {
                //Start Excel and get Application object.
                oXL = new Excel.Application();
                oXL.Visible = true;

                //Get a new workbook.
                oWB = oXL.Workbooks.Add();
                oSheet = oWB.ActiveSheet;

                //Add table headers going cell by cell.
                oSheet.Cells[1, 1] = "대여유무";
                oSheet.Cells[1, 2] = "비디오코드";
                oSheet.Cells[1, 3] = "제목";
                oSheet.Cells[1, 4] = "장르";
                oSheet.Cells[1, 5] = "주연배우";
                oSheet.Cells[1, 6] = "감독";
                oSheet.Cells[1, 7] = "제작및배급";
                oSheet.Cells[1, 8] = "출시일";
                oSheet.Cells[1, 9] = "대여횟수";
                oSheet.Cells[1, 10] = "등록날짜";

                //Format A1:D1 as bold, vertical alignment = center.
                oSheet.get_Range("A1", "J1").Font.Bold = true;
                oSheet.get_Range("A1", "J1").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

                // Create an array to multiple values at once.
                sqlCommand = new SqlCommand(query, conn);
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        oSheet.Cells[i, 1] = sqlDataReader[0];
                        oSheet.Cells[i, 2] = sqlDataReader[1];
                        oSheet.Cells[i, 3] = sqlDataReader[2];
                        oSheet.Cells[i, 4] = sqlDataReader[3];
                        oSheet.Cells[i, 5] = sqlDataReader[4];
                        oSheet.Cells[i, 6] = sqlDataReader[5];
                        oSheet.Cells[i, 7] = sqlDataReader[6];
                        oSheet.Cells[i, 8] = sqlDataReader[7];
                        oSheet.Cells[i, 9] = sqlDataReader[8];
                        oSheet.Cells[i, 10] = sqlDataReader[9];
                        i++;
                    }

                    sqlDataReader.Close();
                }

                //AutoFit columns A:D.
                oRng = oSheet.get_Range("A1", "J1");
                oRng.EntireColumn.AutoFit();

                //Make sure Excel is visible and give the user control
                //of Microsoft Excel's lifetime.
                oXL.Visible = true;
                oXL.UserControl = true;

            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "Error");
            }
        }

        public void DBSettingInfo(Set_VideoRentSet set)
        {
            string query = "select * from 설정정보";

            sqlCommand = new SqlCommand(query, conn);
            using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
            {
                sqlDataReader.Read();
                set.textBox_NewChange.Text = sqlDataReader[0].ToString();
                set.textBox_NewRenttiem.Text = sqlDataReader[1].ToString();
                set.textBox_NewRent.Text = sqlDataReader[2].ToString();
                set.textBox_NewArro.Text = sqlDataReader[3].ToString();
                set.textBox_Renttime.Text = sqlDataReader[4].ToString();
                set.textBox_Rent.Text = sqlDataReader[5].ToString();
                set.textBox_Arro.Text = sqlDataReader[6].ToString();
                sqlDataReader.Close();
            }

        }

        public void DBSettingModify(Set_VideoRentSet set)
        {
            int 전환기간, 신프로대여기간, 신프로대여료, 신프로연체료, 구프로대여기간, 구프로대여료, 구프로연체료;
            전환기간 = int.Parse(set.textBox_NewChange.Text);
            신프로대여기간 = int.Parse(set.textBox_NewRenttiem.Text);
            신프로대여료 = int.Parse(set.textBox_NewRent.Text);
            신프로연체료 = int.Parse(set.textBox_NewArro.Text);
            구프로대여기간 = int.Parse(set.textBox_Renttime.Text);
            구프로대여료 = int.Parse(set.textBox_Rent.Text);
            구프로연체료 = int.Parse(set.textBox_Arro.Text);

            string query = "Update 설정정보 Set 전환기간 = " + 전환기간 + ", 신프로대여기간 = " + 신프로대여기간 +
                ", 신프로대여료 = " + 신프로대여료 + ", 신프로연체료 = " + 신프로연체료 + ", 구프로대여기간 = " + 구프로대여기간 +
                ", 구프로대여료 = " + 구프로대여료 + ", 구프로연체료 = " + 구프로연체료;

            sqlCommand = new SqlCommand(query, conn);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("오류");
                Console.WriteLine(query);
            }

        }


    }

}

