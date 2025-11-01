using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Data;

namespace prj_LTTQ_BTL.Utils
{
    internal class FormUtils
    {
        public static void OpenChildForm(Guna2Panel parentPanel, Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            parentPanel.Controls.Add(childForm);
            parentPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public static void FillGunaDgv(Guna2DataGridView dgv, DataTable data)
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
            dgv.DataSource = data;
        }
    }
}
