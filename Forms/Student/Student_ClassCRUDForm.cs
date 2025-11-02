using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using prj_LTTQ_BTL.Data;
using prj_LTTQ_BTL.Utils;

namespace prj_LTTQ_BTL.Forms.Student
{
    public partial class Student_ClassCRUDForm : Form
    {
        private DataProcessor dataProcessor = new DataProcessor();

        public Student_ClassCRUDForm()
        {
            InitializeComponent();
            InitializeEvent();
        }

        private void InitializeEvent()
        {
            FormUtils.FillGunaDgv(dgvClassList, dataProcessor.GetDataTable($"select * from Class inner join ClassAssignment on Class.id = ClassAssignment.class_id where ClassAssignment.student_id = '{GlobalData.Id}'"));
        }

        private void Student_ClassCRUDForm_Load(object sender, EventArgs e)
        {
            dgvClassList.AutoGenerateColumns = false;

            dgvClassList.Columns.Clear();

            dgvClassList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Class Id",
                DataPropertyName = "id",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                Name = "colClassId"
            });

            dgvClassList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Class Name",
                DataPropertyName = "name",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                Name = "colClassName"
            });

            dgvClassList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Ccourse Id",
                DataPropertyName = "course_id",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                Name = "colCourseId"
            });

            dgvClassList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Max Students",
                DataPropertyName = "max_students",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                Name = "colMaxStudents"
            });

            dgvClassList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Start Date",
                DataPropertyName = "start_date",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                Name = "colStartDate"
            });

            dgvClassList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Teacher Id",
                DataPropertyName = "teacher_id",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                Name = "colTeacherId"
            });
        }

        private void txtSearch_text_changed(object sender, EventArgs e)
        {
            List<string> keywords = txtSearch.Text.Split(' ').ToList();

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

            FormUtils.FillGunaDgv(dgvClassList, searchClasses);
        }

        private void dgvClassList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvClassList.CurrentRow;
            txtName.Text = row.Cells["colClassName"].Value.ToString();
            txtMaxStudents.Text = row.Cells["colMaxStudents"].Value.ToString();
            txtStartDate.Text = row.Cells["colStartDate"].Value.ToString();
            txtTeacherId.Text = row.Cells["colTeacherId"].Value.ToString();

            DataTable course = dataProcessor.GetDataTable($"select * from Course where id = '{row.Cells["colCourseId"].Value.ToString()}'");
            txtCourseName.Text = course.Rows[0]["name"].ToString();
            txtCourseDesc.Text = course.Rows[0]["description"].ToString();
            txtLessons.Text = course.Rows[0]["number_of_lessons"].ToString();
            txtFee.Text = course.Rows[0]["fee"].ToString();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {

        }
    }
}
