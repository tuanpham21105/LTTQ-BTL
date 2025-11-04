using System;
using System.Windows.Forms;
using DotNetEnv;
using prj_LTTQ_BTL.Forms;
using prj_LTTQ_BTL.Forms.Manager;
using prj_LTTQ_BTL.Forms.Student;

namespace prj_LTTQ_BTL
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Env.Load();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StudentMenuForm());
        }
    }
}
