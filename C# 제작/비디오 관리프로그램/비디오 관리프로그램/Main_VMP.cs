using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace 비디오_관리프로그램
{
    public partial class Main_VMP : Form
    {
        public DBClass db = new DBClass();
        Thread th;
        public Main_VMP()
        {
            InitializeComponent();
        }

        void timer()
        {
            while(true)
            {
                toolStripStatusLabel_Time.Text = DateTime.Now.ToString();
            }
        }

       void OpenRent()
        {
            VRM vrm = new VRM();
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == vrm.GetType())
                {
                    form.Activate();
                    form.BringToFront();
                    return;
                }
            }

            vrm.MdiParent = this;
            vrm.Show();
        }

        void OpenVideoM()
        {
            VIM vim = new VIM();
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == vim.GetType())
                {
                    form.Activate();
                    form.BringToFront();
                    return;
                }
            }

            vim.MdiParent = this;
            vim.Show();
        }

        void OpenClientM()
        {
            CM cm = new CM();
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == cm.GetType())
                {
                    form.Activate();
                    form.BringToFront();
                    return;
                }
            }

            cm.MdiParent = this;
            cm.Show();
        }

        void OpenInfo()
        {
            Information information = new Information();
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == information.GetType())
                {
                    form.Activate();
                    form.BringToFront();
                    return;
                }
            }

            information.MdiParent = this;
            information.Show();
        }

        void OpenSetting()
        {
            Set_VideoRentSet setVieoRent = new Set_VideoRentSet();
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == setVieoRent.GetType())
                {
                    form.Activate();
                    form.BringToFront();
                    return;
                }
            }

            setVieoRent.MdiParent = this;
            setVieoRent.Show();
        }

        void OpenExcel()
        {
            File_VideoInformation fileVieoInfo = new File_VideoInformation();
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == fileVieoInfo.GetType())
                {
                    form.Activate();
                    form.BringToFront();
                    return;
                }
            }

            fileVieoInfo.MdiParent = this;
            fileVieoInfo.Show();
        }
        private void toolStripButton_Rent_Click(object sender, EventArgs e)
        {
            OpenRent();
        }

        private void toolStripButton_VideoM_Click(object sender, EventArgs e)
        {
            OpenVideoM();
        }

        private void toolStripButton_ClientM_Click(object sender, EventArgs e)
        {
            OpenClientM();
        }

        private void toolStripButton_Information_Click(object sender, EventArgs e)
        {
            OpenInfo();
        }

        private void toolStripButton_Setting_Click(object sender, EventArgs e)
        {
            OpenSetting();
        }

        private void toolStripButton_Excel_Click(object sender, EventArgs e)
        {
            OpenExcel();
        }

        private void 엑셀출력ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenExcel();
        }

        private void 대여반납ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenRent();
        }

        private void 비디오관리ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenVideoM();
        }

        private void 고객관리ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenClientM();
        }

        private void 정보조회ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenInfo();
        }

        private void 환경설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSetting();
        }

        private void Main_VMP_Load(object sender, EventArgs e)
        {
            db.SQLConnect();
            th = new Thread(new ThreadStart(timer));
            th.Start();
        }

        private void Main_VMP_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.SQLClose();
            th.Abort();
        }

        
    }
}
