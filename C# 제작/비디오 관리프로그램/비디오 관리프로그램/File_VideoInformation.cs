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
    
    public partial class File_VideoInformation : Form
    {
        DBClass db;
        public File_VideoInformation()
        {
            InitializeComponent();
        }

        private void File_VideoInformation_Load(object sender, EventArgs e)
        {
            comboBox_Range.SelectedIndex = 0;
            Main_VMP vmp = (Main_VMP)MdiParent;
            db = vmp.db;
        }

        private void button_Viedeo_Click(object sender, EventArgs e)
        {
            string s;
            if(comboBox_Range.SelectedIndex == 0)
            {
                s = "*";
            }
            else
            {
                s = comboBox_Range.SelectedItem.ToString();
            }

            db.DBExcelVideo(s);
        }

        private void button_Rant_Click(object sender, EventArgs e)
        {
            string s;
            if (comboBox_Range.SelectedIndex == 0)
            {
                s = "*";
            }
            else
            {
                s = comboBox_Range.SelectedItem.ToString();
            }

            db.DBExcelRent(s);
        }
    }
}
