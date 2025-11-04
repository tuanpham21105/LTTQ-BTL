using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prj_LTTQ_BTL.Data;
using prj_LTTQ_BTL.Utils;

namespace prj_LTTQ_BTL.Forms.Manager
{
    public partial class Manager_ClassCRUDForm : Form
    {
        private DataProcessor dataProcessor = new DataProcessor();

        public Manager_ClassCRUDForm()
        {
            InitializeComponent();
        }

        private void Manager_ClassCRUDForm_Load(object sender, EventArgs e)
        {
            DataTable classTable = dataProcessor.GetDataTable($"select * from Class");
            dgvClass.DataSource = classTable;

            comboboxMaGiaoVien.DisplayMember = "name";
            comboboxMaGiaoVien.ValueMember = "id";

            DataGridViewRow row = dgvClass.CurrentRow;

            if (row != null)
            {
                DataTable teacherTable = dataProcessor.GetDataTable("select * from Teacher");
                comboboxMaGiaoVien.DataSource = teacherTable;
            }
        }

        private void SetClassDetails()
        {
            DataGridViewRow row = dgvClass.CurrentRow;

            if (row == null)
            {
                EmptyClassDetails();
                return;
            }

            txtMaLopHoc.Text = row.Cells["id"].Value.ToString();
            txtTenLopHoc.Text = row.Cells["name"].Value.ToString();
            txtTongSoHocVien.Text = row.Cells["max_students"].Value.ToString();
            if (DateTime.TryParse(row.Cells["start_date"].Value.ToString(), out DateTime r))
                dateNgayBatDau.Value = r;
            else dateNgayBatDau.Value = DateTime.Now;
            comboboxMaGiaoVien.SelectedValue = row.Cells["teacher_id"].Value.ToString();

        }

        private void EmptyClassDetails()
        {
            txtMaLopHoc.Text = string.Empty;
            txtTenLopHoc.Text = string.Empty;
            txtTongSoHocVien.Text = string.Empty;
            dateNgayBatDau.Value = DateTime.Now;
            comboboxMaGiaoVien.DataSource = null;
            comboboxMaGiaoVien.SelectedText = string.Empty;
        }

        private void panelLichHocMoiBtn_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
