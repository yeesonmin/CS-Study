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
    public partial class Set_VideoRentSet : Form
    {
        DBClass db;
        public Set_VideoRentSet()
        {
            InitializeComponent();
        }

        private void Set_VideoRentSet_Load(object sender, EventArgs e)
        {
            Main_VMP vmp = (Main_VMP)MdiParent;
            db = vmp.db;
            db.DBSettingInfo(this);
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Modify_Click(object sender, EventArgs e)
        {
            db.DBSettingModify(this);
        }
    }
}
