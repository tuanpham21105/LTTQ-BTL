using prj_LTTQ_BTL.Forms;
using prj_LTTQ_BTL.Forms.Student;
using prj_LTTQ_BTL.Teacher;
using prj_LTTQ_BTL.Forms.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetEnv;

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
            Application.Run(new FormLogin());
        }
    }
}
