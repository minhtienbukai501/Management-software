using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Kho_Thuoc_Tay
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
            Application.Run(new FormMenu());
        }
    }


    class mySave
    {
        static bool Kt = true;

        public static bool KT { get => Kt; set => Kt = value; }
    }
}
