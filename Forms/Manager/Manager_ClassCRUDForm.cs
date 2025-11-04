using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
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
            dgvClass.AutoGenerateColumns = false;
            FormUtils.FillGunaDgv(dgvClass, classTable);


            DataTable teacherTable = dataProcessor.GetDataTable("select * from Teacher");
            comboboxMaGiaoVien.DataSource = teacherTable;
            comboboxMaGiaoVien.DisplayMember = "full_name";
            comboboxMaGiaoVien.ValueMember = "id";
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
            comboboxMaGiaoVien.SelectedValue = string.Empty;
        }

        private void dgvClass_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SetClassDetails();
        }

        private void txtSearchClass_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchClass.Text == string.Empty)
            {
                FormUtils.FillGunaDgv(dgvClass, dataProcessor.GetDataTable("select * from Class"));
                return;
            }

            List<string> keywords = txtSearchClass.Text.Split(' ').ToList();

            DataTable searchClasses = new DataTable();
            DataTable sClasses = new DataTable();

            foreach (string keyword in keywords)
            {
                sClasses = dataProcessor.GetDataTable(
                    $"select Cl.* " +
                    $"from Class Cl " +
                    $"inner join ClassAssignment ClAs " +
                    $"on ClAs.class_id = Cl.id " +
                    $"inner join Student St " +
                    $"on St.id = '{GlobalData.Id}' and St.id = ClAs.student_id " +
                    $"where Cl.name collate Latin1_General_CI_AI like '%{keyword}%'"
                );

                sClasses.PrimaryKey = new DataColumn[] { sClasses.Columns["id"] };
                searchClasses.PrimaryKey = new DataColumn[] { searchClasses.Columns["id"] };
                searchClasses.Merge(sClasses, false);

                if (int.TryParse(keyword, out int maxStudents))
                {
                    sClasses = dataProcessor.GetDataTable(
                        $"select Cl.* " +
                        $"from Class Cl " +
                        $"inner join ClassAssignment ClAs " +
                        $"on ClAs.class_id = Cl.id " +
                        $"inner join Student St " +
                        $"on St.id = '{GlobalData.Id}' and St.id = ClAs.student_id " +
                        $"where Cl.max_students = {keyword}"
                    );
                    searchClasses.Merge(sClasses, false);
                }

                if (int.TryParse(keyword, out int year))
                {
                    sClasses = dataProcessor.GetDataTable(
                        $"select Cl.* " +
                        $"from Class Cl " +
                        $"inner join ClassAssignment ClAs " +
                        $"on ClAs.class_id = Cl.id " +
                        $"inner join Student St " +
                        $"on St.id = '{GlobalData.Id}' and St.id = ClAs.student_id " +
                        $"where year( Cl.start_date) = {keyword}");
                    searchClasses.Merge(sClasses, false);
                }

                if (int.TryParse(keyword, out int month))
                {
                    sClasses = dataProcessor.GetDataTable(
                        $"select Cl.* " +
                        $"from Class Cl " +
                        $"inner join ClassAssignment ClAs " +
                        $"on ClAs.class_id = Cl.id " +
                        $"inner join Student St " +
                        $"on St.id = '{GlobalData.Id}' and St.id = ClAs.student_id " +
                        $"where month(Cl.start_date) = {keyword}");
                    searchClasses.Merge(sClasses, false);
                }

                if (int.TryParse(keyword, out int day))
                {
                    sClasses = dataProcessor.GetDataTable(
                        $"select Cl.* " +
                        $"from Class Cl " +
                        $"inner join ClassAssignment ClAs " +
                        $"on ClAs.class_id = Cl.id " +
                        $"inner join Student St " +
                        $"on St.id = '{GlobalData.Id}' and St.id = ClAs.student_id " +
                        $"where day(Cl.start_date) = {keyword}");
                    searchClasses.Merge(sClasses, false);
                }
            }

            FormUtils.FillGunaDgv(dgvClass, searchClasses);
        }

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetClassDetails();
        }
    }
}
