using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prj_LTTQ_BTL.Data;
using System.Data;
using prj_LTTQ_BTL.Utils;

namespace prj_LTTQ_BTL.Forms.Manager
{
    public partial class Manager_StudentAttendanceCRUDForm : Form
    {
        private DataProcessor dataProcessor = new DataProcessor();

        public Manager_StudentAttendanceCRUDForm()
        {
            InitializeComponent();

        }

        private void Manager_StudentAttendanceCRUDForm_Load(object sender, EventArgs e)
        {
            dgvStudent.AutoGenerateColumns = false;

            DataTable classes = dataProcessor.GetDataTable($"select * from Class");
            comboboxClasses.DataSource = classes;
            comboboxClasses.DisplayMember = "name";
            comboboxClasses.ValueMember = "id";

            SetScheduleComboBox();

            SetDgvStudent();
        }

        private void SetScheduleComboBox()
        {
            string classId = comboboxClasses.SelectedValue.ToString();

            if (string.IsNullOrEmpty(classId) || !Guid.TryParse(classId, out Guid r))
            {
                return;
            }

            DataTable schedules = dataProcessor.GetDataTable($"select * from Schedule where class_id = '{classId}'");
            comboboxSchedules.DataSource = schedules;
            comboboxSchedules.ValueMember = "id";
            comboboxSchedules.DisplayMember = "session_date";
        }

        private void SetDgvStudent()
        {
            string classId = comboboxClasses.SelectedValue.ToString();

            if (string.IsNullOrEmpty(classId) || !Guid.TryParse(classId, out Guid r))
            {
                return;
            }

            dgvStudent.DataSource = dataProcessor.GetDataTable($"select Student.*, Attendance.status from Student inner join ClassAssignment on ClassAssignment.student_id = Student.id left join Attendance on Attendance.schedule_id = '{comboboxSchedules.SelectedValue.ToString()}' and Attendance.student_id = Student.id where ClassAssignment.class_id = '{classId}'");

            SetStudentDetails();
            
        }

        private void SetStudentDetails()
        {
            if (dgvStudent.CurrentRow == null)
            {
                txtMaHocVien.Text = "";
                txtName.Text = "";
                txtSdt.Text = "";
                SetScheduleDetails();
                return;
            }

            DataGridViewRow row = dgvStudent.CurrentRow;

            txtMaHocVien.Text = row.Cells["id"].Value.ToString();
            txtName.Text = row.Cells["full_name"].Value.ToString();
            txtSdt.Text = row.Cells["phone_number"].Value.ToString();

            SetScheduleDetails();
        }

        private void comboboxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScheduleComboBox();

            SetDgvStudent();
        }

        private void comboboxSchedules_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScheduleDetails();
        }

        private void SetScheduleDetails()
        {
            string scheduleId = comboboxSchedules.SelectedValue.ToString();

            if (string.IsNullOrEmpty(scheduleId) || !Guid.TryParse(scheduleId, out Guid r1))
            {
                txtMaBuoiHoc.Text = "";
                comboboxStatus.SelectedIndex = -1;
                txtNote.Text = "";
                return;
            }

            if (dgvStudent.CurrentRow == null)
            {
                txtMaBuoiHoc.Text = "";
                comboboxStatus.SelectedIndex = -1;
                txtNote.Text = "";
                return;
            }

            string studentId = dgvStudent.CurrentRow.Cells["id"].Value.ToString();

            DataTable schedule = dataProcessor.GetDataTable($"select * from Attendance where student_id = '{studentId}' and schedule_id = '{scheduleId}'");

            if (schedule.Rows.Count > 0)
            {
                txtMaBuoiHoc.Text = schedule.Rows[0]["schedule_id"].ToString();
                comboboxStatus.SelectedItem = schedule.Rows[0]["status"].ToString();
                txtNote.Text = schedule.Rows[0]["note"].ToString();
            }
            else
            {
                txtMaBuoiHoc.Text = scheduleId;
                comboboxStatus.SelectedIndex = -1;
                txtNote.Text = "";
            }
        }

        private void txtSearchStudent_TextChanged(object sender, EventArgs e)
        {
            string classId = comboboxClasses.SelectedValue.ToString();

            if (string.IsNullOrEmpty(classId) || !Guid.TryParse(classId, out Guid r))
            {
                return;
            }

            List<string> keywords = txtSearchStudent.Text.Split(' ').ToList();

            DataTable searchStudents = new DataTable();
            DataTable sStudents = new DataTable();

            //string classFilter;

            if (comboboxClasses.SelectedIndex == -1)
            {
                return;
            }

            foreach (string keyword in keywords)
            {
                sStudents = dataProcessor.GetDataTable($"select Student.*, Attendance.status from Student inner join ClassAssignment on ClassAssignment.student_id = Student.id and ClassAssignment.class_id = '{classId}' left join Attendance on Attendance.schedule_id = '{comboboxSchedules.SelectedValue.ToString()}' and Attendance.student_id = Student.id where full_name collate Latin1_General_CI_AI like '%{keyword}%'");
                sStudents.PrimaryKey = new DataColumn[] { sStudents.Columns["id"] };
                searchStudents.PrimaryKey = new DataColumn[] { searchStudents.Columns["id"] };
                searchStudents.Merge(sStudents, false);

                sStudents = dataProcessor.GetDataTable($"select Student.*, Attendance.status from Student inner join ClassAssignment on ClassAssignment.student_id = Student.id and ClassAssignment.class_id = '{classId}' left join Attendance on Attendance.schedule_id = '{comboboxSchedules.SelectedValue.ToString()}' and Attendance.student_id = Student.id where email collate Latin1_General_CI_AI like '%{keyword}%'");
                searchStudents.Merge(sStudents, false);

                sStudents = dataProcessor.GetDataTable($"select Student.*, Attendance.status from Student inner join ClassAssignment on ClassAssignment.student_id = Student.id and ClassAssignment.class_id = '{classId}' left join Attendance on Attendance.schedule_id = '{comboboxSchedules.SelectedValue.ToString()}' and Attendance.student_id = Student.id where address collate Latin1_General_CI_AI like '%{keyword}%'");
                searchStudents.Merge(sStudents, false);

                sStudents = dataProcessor.GetDataTable($"select Student.*, Attendance.status from Student inner join ClassAssignment on ClassAssignment.student_id = Student.id and ClassAssignment.class_id = '{classId}' left join Attendance on Attendance.schedule_id = '{comboboxSchedules.SelectedValue.ToString()}' and Attendance.student_id = Student.id where phone_number collate Latin1_General_CI_AI like '%{keyword}%'");
                searchStudents.Merge(sStudents, false);
            }

            FormUtils.FillGunaDgv(dgvStudent, searchStudents);

            SetStudentDetails();
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetStudentDetails();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaBuoiHoc.Text))
            {
                return;
            }

            string scheduleId = comboboxSchedules.SelectedValue.ToString();

            if (string.IsNullOrEmpty(scheduleId) || !Guid.TryParse(scheduleId, out Guid r1))
            {
                return;
            }

            if (dgvStudent.CurrentRow == null)
            {
                return;
            }

            string studentId = dgvStudent.CurrentRow.Cells["id"].Value.ToString();

            if (dataProcessor.GetDataTable($"select * from Attendance where student_id = '{studentId}' and schedule_id = '{scheduleId}'").Rows.Count > 0)
            {
                MessageBox.Show("Đã tồn tại điểm danh buổi học của học viên");
                return;
            }

            btnLuu.Visible = true;
            btnHuy.Visible = true;
            btnThem.Visible = false;
            btnChinhSua.Visible = false;
            btnXoa.Visible = false;

            comboboxStatus.Enabled = true;
            txtNote.Enabled = true;

            comboboxStatus.SelectedIndex = 0;
            txtNote.Text = "";

            ToggleFilters(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaBuoiHoc.Text))
            {
                return;
            }

            string scheduleId = comboboxSchedules.SelectedValue.ToString();

            if (string.IsNullOrEmpty(scheduleId) || !Guid.TryParse(scheduleId, out Guid r1))
            {
                return;
            }

            if (dgvStudent.CurrentRow == null)
            {
                return;
            }

            string studentId = dgvStudent.CurrentRow.Cells["id"].Value.ToString();

            if (dataProcessor.GetDataTable($"select * from Attendance where student_id = '{studentId}' and schedule_id = '{scheduleId}'").Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy điểm danh buổi học của học viên");
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa trạng thái điểm danh của học viên?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataProcessor.UpdateData($"delete from Attendance where student_id = '{studentId}' and schedule_id = '{scheduleId}'");
            }

            SetScheduleDetails();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaBuoiHoc.Text))
            {
                return;
            }

            string scheduleId = comboboxSchedules.SelectedValue.ToString();

            if (string.IsNullOrEmpty(scheduleId) || !Guid.TryParse(scheduleId, out Guid r1))
            {
                return;
            }

            if (dgvStudent.CurrentRow == null)
            {
                return;
            }

            string studentId = dgvStudent.CurrentRow.Cells["id"].Value.ToString();

            if (dataProcessor.GetDataTable($"select * from Attendance where student_id = '{studentId}' and schedule_id = '{scheduleId}'").Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy điểm danh buổi học của học viên");
                return;
            }

            btnLuu.Visible = true;
            btnHuy.Visible = true;
            btnThem.Visible = false;
            btnChinhSua.Visible = false;
            btnXoa.Visible = false;

            comboboxStatus.Enabled = true;
            txtNote.Enabled = true;

            ToggleFilters(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaBuoiHoc.Text))
            {
                return;
            }

            string scheduleId = comboboxSchedules.SelectedValue.ToString();

            if (string.IsNullOrEmpty(scheduleId) || !Guid.TryParse(scheduleId, out Guid r1))
            {
                return;
            }

            if (dgvStudent.CurrentRow == null)
            {
                return;
            }

            string studentId = dgvStudent.CurrentRow.Cells["id"].Value.ToString();

            btnThem.Visible = true;
            btnChinhSua.Visible = true;
            btnXoa.Visible = true;
            btnLuu.Visible = false;
            btnHuy.Visible = false;

            comboboxStatus.Enabled = false;
            txtNote.Enabled = false;

            ToggleFilters(true);

            if (dataProcessor.GetDataTable($"select * from Attendance where schedule_id = '{scheduleId}' and student_id = '{studentId}'").Rows.Count == 0)
            {
                dataProcessor.UpdateData($"insert into Attendance(schedule_id, student_id, status, note) values (" +
                    $" '{scheduleId}'," +
                    $" '{studentId}'," +
                    $" '{comboboxStatus.SelectedItem.ToString()}'," +
                    $" N'{txtNote.Text}'" +
                    $")"
                );
            }
            else
            {
                dataProcessor.UpdateData($"update Attendance set status = '{comboboxStatus.SelectedItem.ToString()}', note = N'{txtNote.Text}' where schedule_id = '{scheduleId}' and student_id = '{studentId}'");
            }

            SetScheduleDetails();

            txtSearchStudent_TextChanged(null, null);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Visible = true;
            btnChinhSua.Visible = true;
            btnXoa.Visible = true;
            btnLuu.Visible = false;
            btnHuy.Visible = false;

            comboboxStatus.Enabled = false;
            txtNote.Enabled = false;

            ToggleFilters(true);

            SetScheduleDetails();
        }

        private void ToggleFilters(bool mode)
        {
            comboboxClasses.Enabled = mode;
            comboboxSchedules.Enabled = mode;
            txtSearchStudent.Enabled = mode;
            dgvStudent.Enabled = mode;

        }
    }
}
