using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            userControl11.setButtonsText(0, "1빠");
            userControl11.setButtonsText(1, "2빠");
            userControl11.setButtonsText(2, "3빠");

        }
    }
}
