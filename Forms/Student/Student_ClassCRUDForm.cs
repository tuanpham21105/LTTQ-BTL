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
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvClassList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Class Name",
                DataPropertyName = "name",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvClassList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Max Students",
                DataPropertyName = "max_students",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvClassList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Start Date",
                DataPropertyName = "start_date",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvClassList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Teacher Id",
                DataPropertyName = "teacher_id",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        private void txtSearch_text_changed(object sender, EventArgs e)
        {
            List<string> keywords = txtSearch.Text.Split(' ').ToList();

            DataTable searchClasses = new DataTable();
            DataTable sClasses = new DataTable();

            foreach (string keyword in keywords)
            {
                sClasses = dataProcessor.GetDataTable($"select * from Class where name collate Latin1_General_CI_AI like '%{keyword}%'");
                sClasses.PrimaryKey = new DataColumn[] { sClasses.Columns["id"] };
                searchClasses.PrimaryKey = new DataColumn[] { searchClasses.Columns["id"] };
                searchClasses.Merge(sClasses, false);

                if (int.TryParse(keyword, out int maxStudents))
                {
                    sClasses = dataProcessor.GetDataTable($"select * from Class where max_students = {keyword}");
                    searchClasses.Merge(sClasses, false);
                }

                if (int.TryParse(keyword, out int year))
                {
                    sClasses = dataProcessor.GetDataTable($"select * from Class where year(start_date) = {keyword}");
                    searchClasses.Merge(sClasses, false);
                }

                if (int.TryParse(keyword, out int month))
                {
                    sClasses = dataProcessor.GetDataTable($"select * from Class where month(start_date) = {keyword}");
                    searchClasses.Merge(sClasses, false);
                }

                if (int.TryParse(keyword, out int day))
                {
                    sClasses = dataProcessor.GetDataTable($"select * from Class where day(start_date) = {keyword}");
                    searchClasses.Merge(sClasses, false);
                }
            }

            FormUtils.FillGunaDgv(dgvClassList, searchClasses);
        }
    }
}
