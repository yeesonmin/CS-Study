using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Form
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
            //Application.Run(new MainmenuApp());
            //Application.Run(new MouseWheelApp());
            //Application.Run(new MousePositionApp());
            // Application.Run(new MouseEvent());
            //Application.Run(new HitTestingApp());
            //Application.Run(new FocusApp());
            //Application.Run(new FocusEventApp());
            Application.Run(new KeyEventAPp());
        }
    }
}
