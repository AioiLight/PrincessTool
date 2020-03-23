using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AioiLight.PrincessTool
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainWindow = new Main();
            Application.Run(MainWindow);
        }

        internal static string Origin { get; set; }
        internal static string Dest { get; set; }
        internal static Main MainWindow { get; set; }
    }
}
