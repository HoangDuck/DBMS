using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiGiuXeVer2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Forms.Login.frmLogin());
            //Application.Run(new Forms.Registers.frmRegister());
            Application.Run(new Forms.Staff.mainFormStaff());
            //Application.Run(new Forms.Manager.mainFormManager());

        }
    }
}
