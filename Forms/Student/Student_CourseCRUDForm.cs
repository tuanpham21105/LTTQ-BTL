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
using prj_LTTQ_BTL.Utils;

namespace prj_LTTQ_BTL.Forms.Student
{
    public partial class Student_CourseCRUDForm : Form
    {
        private DataProcessor dataProcessor = new DataProcessor();

        public Student_CourseCRUDForm()
        {
            InitializeComponent();
            InitializeEvent();
        }

        private void InitializeEvent()
        {
            FormUtils.FillGunaDgv(dgvCourse, dataProcessor.GetDataTable("select * from Course"));
            dgvCourse.CellClick += dgvCourses_cell_click;
            txtSearchKhoaHoc.TextChanged += txtSearch_text_changed;

            string id = GlobalData.Id;

            FormUtils.FillGunaDgv(dgvEnrollment, dataProcessor.GetDataTable($"select e.*, c.name from Enrollment e inner join Course c on e.course_id = c.id where e.student_id = '{id}'"));
        }

        private void FormStudent_CourseCRUD_Load(object sender, EventArgs e)
        {
            dgvCourse.AutoGenerateColumns = false;

            dgvEnrollment.AutoGenerateColumns = false;
        }

        private void dgvCourses_cell_click(object sender, EventArgs e)
        {
            SetCourseDetails();
        }

        private void SetCourseDetails()
        {
            DataGridViewRow row = dgvCourse.CurrentRow;

            if (row == null)
            {
                txtTenKhoaHoc.Text = "";
                txtSoBuoiHoc.Text = "";
                txtMoTa.Text = "";
                txtHocPhi.Text = "";
                return;
            }

            //txtId.Text = row.Cells["id"].Value.ToString();
            txtTenKhoaHoc.Text = row.Cells["course_name"].Value.ToString();
            txtSoBuoiHoc.Text = row.Cells["number_of_lessons"].Value.ToString();
            txtMoTa.Text = row.Cells["course_description"].Value.ToString();
            txtHocPhi.Text = row.Cells["course_fee"].Value.ToString();
        }

        private void txtSearch_text_changed(object sender, EventArgs e)
        {
            List<string> keywords = txtSearchKhoaHoc.Text.Split(' ').ToList();

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

            FormUtils.FillGunaDgv(dgvCourse, searchCourses);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvCourse.CurrentRow;

            string madangky = Guid.NewGuid().ToString();

            dataProcessor.UpdateData($"insert into Enrollment (id, student_id, course_id, enrollment_date) values ('{madangky}', '{GlobalData.Id}', '{row.Cells["course_id"].Value.ToString()}', '{DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString()}')");

            if (madangky.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn một khóa học");
                return;
            } 

            float hocphi = float.Parse(txtHocPhi.Text);

            dataProcessor.UpdateData($"insert into Payment(enrollment_id, amount, payment_date, method, status, fee_collector_id, payer_id) values ('{madangky}', {hocphi}, NULL, 'None', 'Pending', NULL, '{GlobalData.Id}')");

            txtSearchDangKy_TextChanged(sender, e);
        }

        private void dgvCourse_DataSourceChanged(object sender, EventArgs e)
        {
            SetCourseDetails();
        }

        private void dgvCourse_CurrentCellChanged(object sender, EventArgs e)
        {
            SetCourseDetails();
        }

        private void txtSearchDangKy_TextChanged(object sender, EventArgs e)
        {
            List<string> keywords = txtSearchDangKy.Text.Split(' ').ToList();

            DataTable searchEnrollments = new DataTable();

            foreach (string keyword in keywords)
            {
                searchEnrollments = dataProcessor.GetDataTable($"select e.*, c.name from Enrollment e inner join Course c on e.course_id = c.id where c.name collate Latin1_General_CI_AI like '%{keyword}%' and e.student_id = '{GlobalData.Id}'");
            }

            FormUtils.FillGunaDgv(dgvEnrollment, searchEnrollments);
        }

        private void dgvEnrollment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetEnrollmentDetails();
        }

        private void dgvEnrollment_CurrentCellChanged(object sender, EventArgs e)
        {
            SetEnrollmentDetails();
        }

        private void dgvEnrollment_DataSourceChanged(object sender, EventArgs e)
        {
            SetEnrollmentDetails();
        }

        private void SetEnrollmentDetails()
        {
            DataGridViewRow row = dgvEnrollment.CurrentRow;

            if (row ==  null)
            {
                txtMaDangKy.Text = "";
                return;
            }

            txtMaDangKy.Text = row.Cells[0].Value.ToString();
        }

        private void btnXoaDangKy_Click(object sender, EventArgs e)
        {
            string madangky = txtMaDangKy.Text;

            if (madangky.Length == 0)
            {
                return;
            }

            dataProcessor.UpdateData($"update Payment set status = 'Cancelled', enrollment_id = null where enrollment_id = '{madangky}'");

            dataProcessor.UpdateData($"delete from Enrollment where id = '{madangky}'");

            txtSearchDangKy_TextChanged(sender, e);
        }

        private void ResetDgvEnrollment()
        {
            string id = GlobalData.Id;

            FormUtils.FillGunaDgv(dgvEnrollment, dataProcessor.GetDataTable($"select e.*, c.name from Enrollment e inner join Course c on e.course_id = c.id where e.student_id = '{id}'"));
        }
    }
}
