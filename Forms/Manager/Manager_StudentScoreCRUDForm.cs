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
    public partial class Manager_StudentScoreCRUDForm : Form
    {
        private DataProcessor dataProcessor = new DataProcessor();
        public Manager_StudentScoreCRUDForm()
        {
            InitializeComponent();
        }

        private void txtSearchStudent_TextChanged(object sender, EventArgs e)
        {
            List<string> keywords = txtSearchStudent.Text.Split(' ').ToList();

            DataTable searchStudents = new DataTable();
            DataTable sStudents = new DataTable();

            string classFilter;

            if (comboboxClasses.SelectedIndex != -1)
            {

            }

            foreach (string keyword in keywords)
            {
                sStudents = dataProcessor.GetDataTable($"select * from Student where name collate Latin1_General_CI_AI like '%{keyword}%'");
                sStudents.PrimaryKey = new DataColumn[] { sStudents.Columns["id"] };
                searchStudents.PrimaryKey = new DataColumn[] { searchStudents.Columns["id"] };
                searchStudents.Merge(sStudents, false);

                sStudents = dataProcessor.GetDataTable($"select * from Student where email collate Latin1_General_CI_AI like '%{keyword}%'");
                searchStudents.Merge(sStudents, false);

                sStudents = dataProcessor.GetDataTable($"select * from Student where address collate Latin1_General_CI_AI like '%{keyword}%'");
                searchStudents.Merge(sStudents, false);

                sStudents = dataProcessor.GetDataTable($"select * from Student where phone_number collate Latin1_General_CI_AI like '%{keyword}%'");
                searchStudents.Merge(sStudents, false);

                sStudents = dataProcessor.GetDataTable($"select * from Student where birth_date collate Latin1_General_CI_AI like '%{keyword}%'");
                searchStudents.Merge(sStudents, false);
            }

            FormUtils.FillGunaDgv(dgvStudent, searchStudents);
        }

        private void txtSearchScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboboxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Manager_StudentScoreCRUDForm_Load(object sender, EventArgs e)
        {
            FormUtils.FillGunaDgv(dgvStudent, dataProcessor.GetDataTable($"select * from Student"));

            comboboxClasses.DataSource = dataProcessor.GetDataTable($"select * from Class");
            comboboxClasses.DisplayMember = "name";
            comboboxClasses.ValueMember = "id";
        }
    }
}
