using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using prj_LTTQ_BTL.Data;

namespace prj_LTTQ_BTL.Forms.Student
{
    public partial class Student_CourseCRUDForm : Form
    {
        private DataProcessor dataProcessor = new DataProcessor();

        private void FillGunaDgv(Guna2DataGridView dgv, DataTable data)
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
            dgv.DataSource = data;
        }

        public Student_CourseCRUDForm()
        {
            InitializeComponent();
            InitializeEvent();
        }

        private void InitializeEvent()
        {
            FillGunaDgv(dgvCourses, dataProcessor.GetDataTable("select * from Course"));
            dgvCourses.CellClick += dgvCourses_cell_click;
            txtSearch.TextChanged += txtSearch_text_changed;
        }

        private void FormStudent_CourseCRUD_Load(object sender, EventArgs e)
        {
            dgvCourses.AutoGenerateColumns = false;

            dgvCourses.Columns.Clear();

            dgvCourses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "id",
                HeaderText = "Course Id",
                DataPropertyName = "id",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvCourses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "name",
                HeaderText = "Course Name",
                DataPropertyName = "name",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvCourses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "number_of_lessons",
                HeaderText = "Lessons",
                DataPropertyName = "number_of_lessons",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvCourses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "fee",
                HeaderText = "Fee",
                DataPropertyName = "fee",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvCourses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "description",
                HeaderText = "Description",
                DataPropertyName = "description",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvClasses.AutoGenerateColumns = false;

            dgvClasses.Columns.Clear();

            dgvClasses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Class Id",
                DataPropertyName = "id",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvClasses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Class Name",
                DataPropertyName = "name",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvClasses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Max Students",
                DataPropertyName = "max_students",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvClasses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Start Date",
                DataPropertyName = "start_date",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvClasses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Teacher Id",
                DataPropertyName = "teacher_id",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        private void dgvCourses_cell_click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvCourses.CurrentRow;

            txtId.Text = row.Cells["id"].Value.ToString();
            txtName.Text = row.Cells["name"].Value.ToString();
            txtLessons.Text = row.Cells["number_of_lessons"].Value.ToString();
            txtDesc.Text = row.Cells["description"].Value.ToString();
            txtFee.Text = row.Cells["fee"].Value.ToString();

            FillGunaDgv(dgvClasses, dataProcessor.GetDataTable($"select * from Class where course_id = '{txtId.Text}'"));
        }

        private void txtSearch_text_changed(object sender, EventArgs e)
        {
            List<string> keywords = txtSearch.Text.Split(' ').ToList();

            DataTable searchCourses = new DataTable();
            DataTable sCourses = new DataTable();

            foreach (string keyword in keywords)
            {
                sCourses = dataProcessor.GetDataTable($"select * from Course where name collate Latin1_General_CI_AI like '%{keyword}%'");
                sCourses.PrimaryKey = new DataColumn[] { sCourses.Columns["id"] };
                searchCourses.PrimaryKey = new DataColumn[] { searchCourses.Columns["id"] };
                searchCourses.Merge(sCourses, false);

                sCourses = dataProcessor.GetDataTable($"select * from Course where description collate Latin1_General_CI_AI like '%{keyword}%'");
                searchCourses.Merge(sCourses, false);

                if (int.TryParse(keyword, out int lesson))
                {
                    sCourses = dataProcessor.GetDataTable($"select * from Course where number_of_lessons = {keyword}");
                    searchCourses.Merge(sCourses, false);
                }

                if (double.TryParse(keyword, out double fee))
                {
                    sCourses = dataProcessor.GetDataTable($"select * from Course where fee = {keyword}");
                    searchCourses.Merge(sCourses, false);
                }
            }

            FillGunaDgv(dgvCourses, searchCourses);
        }
    }
}
