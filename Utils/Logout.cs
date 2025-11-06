using prj_LTTQ_BTL.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_LTTQ_BTL.Utils
{
    internal class Logout
    {
        public static void PerformLogout(Form currentForm)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                currentForm.Hide();
                FormLogin loginForm = new FormLogin();
                loginForm.ShowDialog();
                currentForm.Close();
            }
        }
    }
}
