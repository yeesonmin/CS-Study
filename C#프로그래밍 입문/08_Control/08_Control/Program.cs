using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_Control
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ButtonApp());
            //Application.Run(new CheckBoxApp());
            //Application.Run(new RadioButtonApp());
            //Application.Run(new LabelSample());
            //Application.Run(new LinkLable());
            //Application.Run(new ListBoxApp());
            //Application.Run(new ComboBoxApp());
            Application.Run(new CheckListboxApp());
        }
    }
}
