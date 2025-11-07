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

namespace prj_LTTQ_BTL.Forms.Manager
{
    public partial class Manager_StudentClassAssigmentForm : Form
    {
        private DataProcessor dataProcessor = new DataProcessor();

        public Manager_StudentClassAssigmentForm()
        {
            InitializeComponent();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Manager_StudentClassAssigmentForm_Load(object sender, EventArgs e)
        {
            dgvClassStudent.AutoGenerateColumns = false;
            dgvEnrollmentStudent.AutoGenerateColumns = false;
            dgvAllStudent.AutoGenerateColumns = false;

            DataTable classes = dataProcessor.GetDataTable("select * from Class where status = 'Active'");

            comboboxClasses.DisplayMember = "name";
            comboboxClasses.ValueMember = "id";
            comboboxClasses.DataSource = classes;

            comboboxClasses_SelectedIndexChanged(sender, e);

            DataTable allStudent = dataProcessor.GetDataTable("select * from Student");
            
            dgvAllStudent.DataSource = allStudent;
        }

        private void comboboxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboboxClasses.SelectedValue == null || !Guid.TryParse(comboboxClasses.SelectedValue.ToString(), out Guid r))
            {
                return;
            }

            DataTable classes = dataProcessor.GetDataTable($"select * from Class where id = '{comboboxClasses.SelectedValue.ToString()}'");

            DataTable course = dataProcessor.GetDataTable($"select * from Course where id = '{classes.Rows[0]["course_id"]}'");

            txtTenKhoaHoc.Text = course.Rows[0]["name"].ToString();

            DataTable classStudent = dataProcessor.GetDataTable($"select s.* from Student s inner join ClassAssignment ca on s.id = ca.student_id where ca.class_id = '{comboboxClasses.SelectedValue.ToString()}'");

            dgvClassStudent.DataSource = classStudent;

            DataTable enrollmentStudent = dataProcessor.GetDataTable($"select s.* from Student s inner join Enrollment e on s.id = e.student_id where e.course_id = '{course.Rows[0]["id"].ToString()}'");

            dgvEnrollmentStudent.DataSource = enrollmentStudent;    
        }

        private void btnThemDangKy_Click(object sender, EventArgs e)
        {
            if (comboboxClasses.SelectedValue == null)
            {
                MessageBox.Show("Bạn chưa chọn lớp học");
                return;
            }

            DataGridViewRow row = dgvEnrollmentStudent.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Bạn chưa chọn học viên đăng ký");
                return;
            }

            dataProcessor.UpdateData($"insert into ClassAssignment(student_id, class_id) values ('{row.Cells[0].Value.ToString()}', '{comboboxClasses.SelectedValue.ToString()}')");

            comboboxClasses_SelectedIndexChanged(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (comboboxClasses.SelectedValue == null)
            {
                MessageBox.Show("Bạn chưa chọn lớp học");
                return;
            }

            DataGridViewRow row = dgvClassStudent.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Bạn chưa chọn học viên");
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa học viên khỏi lớp?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataProcessor.UpdateData($"delete from ClassAssignment where student_id = '{row.Cells[0].Value.ToString()}' and class_id = '{comboboxClasses.SelectedValue.ToString()}'");

                comboboxClasses_SelectedIndexChanged(sender, e);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (comboboxClasses.SelectedValue == null)
            {
                MessageBox.Show("Bạn chưa chọn lớp học");
                return;
            }

            DataGridViewRow row = dgvAllStudent.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Bạn chưa chọn học viên");
                return;
            }

            dataProcessor.UpdateData($"insert into ClassAssignment(student_id, class_id) values ('{row.Cells[0].Value.ToString()}', '{comboboxClasses.SelectedValue.ToString()}')");

            comboboxClasses_SelectedIndexChanged(sender, e);
        }
    }
}
