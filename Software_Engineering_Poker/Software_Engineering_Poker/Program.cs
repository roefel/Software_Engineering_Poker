using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Software_Engineering_Poker
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static GameController controller;
        [STAThread]
        static void Main()
        {
            controller = new GameController();
            controller.Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
