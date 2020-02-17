using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_DialogBox
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
            //Application.Run(new ModalAPp());
            // Application.Run(new OpenFileDialogApp());
            //Application.Run(new MultiSelectOpenFile());
            //Application.Run(new FontDialog());
            //Application.Run(new ColorDialog());
            Application.Run(new PrintDialogApp());
        }
    }
}
