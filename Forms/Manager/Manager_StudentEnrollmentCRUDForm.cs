using prj_LTTQ_BTL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_LTTQ_BTL.Forms.Manager
{
    public partial class Manager_StudentEnrollmentCRUDForm : Form
    {
        private readonly EnrollmentService _enrollmentService;
        private Guid? _selectedEnrollmentId = null;
        private int _currentPage = 1;
        private const int PageSize = 10;

        public Manager_StudentEnrollmentCRUDForm()
        {
            InitializeComponent();
            _enrollmentService = new EnrollmentService();
        }

        private void Manager_StudentEnrollmentCRUDForm_Load(object sender, EventArgs e)
        {
            LoadEnrollments();
        }
        private void LoadEnrollments()
        {
            DataTable enrollments = _enrollmentService.GetEnrollments(_currentPage, PageSize);
            dgvEnrollments.DataSource = enrollments;

            if (dgvEnrollments.Columns.Contains("id"))
            {
                dgvEnrollments.Columns["id"].Visible = false;
            }
            if (dgvEnrollments.Columns.Contains("student_name"))
            {
                dgvEnrollments.Columns["student_name"].HeaderText = "Học viên";
            }
            if (dgvEnrollments.Columns.Contains("course_name"))
            {
                dgvEnrollments.Columns["course_name"].HeaderText = "Khóa học";
            }
            if (dgvEnrollments.Columns.Contains("enrollment_date"))
            {
                dgvEnrollments.Columns["enrollment_date"].HeaderText = "Ngày đăng ký";
            }
            if (dgvEnrollments.Columns.Contains("status"))
            {
                dgvEnrollments.Columns["status"].HeaderText = "Trạng thái";
            }
            int totalRecords = _enrollmentService.GetEnrollments(-1, PageSize).Rows.Count; 
            int totalPages = (int)Math.Ceiling((double)totalRecords / PageSize);

            lblPageInfo.Text = $"Trang {_currentPage} / {totalPages}";

            btnPrev.Enabled = _currentPage > 1;
            btnNext.Enabled = _currentPage < totalPages;
        }
        private void ClearInputFields()
        {
            txtFullName.Text = "";
            txtCourse.Text = "";
            dtpEnrollmentDate.Value = DateTime.Now;
            _selectedEnrollmentId = null;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvEnrollments.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một hàng để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvEnrollments.CurrentRow;
            _selectedEnrollmentId = Guid.Parse(row.Cells["id"].Value.ToString());
            txtFullName.Text = row.Cells["student_name"].Value.ToString();
            txtCourse.Text = row.Cells["course_name"].Value.ToString();
            dtpEnrollmentDate.Value = DateTime.Parse(row.Cells["enrollment_date"].Value.ToString());
            checkBoxStatus.Checked = row.Cells["status"].Value.ToString() == "Active";
            txtCourseId.Text = row.Cells["course_id"].Value.ToString();
            txtStudentId.Text = row.Cells["student_id"].Value.ToString();
            txtFullName.Enabled = true;
            txtCourse.Enabled = true;
            dtpEnrollmentDate.Enabled = true;
            checkBoxStatus.Enabled = true;

            btnSave.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedEnrollmentId == null)
            {
                MessageBox.Show("Vui lòng chọn một đăng ký để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _enrollmentService.DeleteEnrollment(_selectedEnrollmentId.Value);
                MessageBox.Show("Xóa đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEnrollments();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa đăng ký: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_selectedEnrollmentId == null)
            {
                MessageBox.Show("Vui lòng chọn một hàng để lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string studentName = txtFullName.Text.Trim();
                string courseName = txtCourse.Text.Trim();
                DateTime enrollmentDate = dtpEnrollmentDate.Value;
                string status = checkBoxStatus.Checked ? "Enrolled" : "Cancelled";

                if (status != "Enrolled" && status != "Cancelled")
                {
                    MessageBox.Show("Trạng thái không hợp lệ. Vui lòng chọn trạng thái hợp lệ ('Enrolled' hoặc 'Cancelled').", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _enrollmentService.UpdateEnrollment(_selectedEnrollmentId.Value, Guid.Parse(txtStudentId.Text), Guid.Parse(txtCourseId.Text), enrollmentDate, status);

                MessageBox.Show($"Lưu thông tin thành công! Trạng thái hiện tại: {status}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEnrollments();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu thông tin: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                LoadEnrollments();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _currentPage++;
            LoadEnrollments();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            DataTable searchResults = _enrollmentService.SearchEnrollments(keyword);
            dgvEnrollments.DataSource = searchResults;
        }

        private void dgvEnrollments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvEnrollments.Rows[e.RowIndex];
            if (row.Cells["id"].Value != null)
            {
                _selectedEnrollmentId = Guid.Parse(row.Cells["id"].Value.ToString());
                txtStudentId.Text = row.Cells["student_id"].Value?.ToString();
                txtCourseId.Text = row.Cells["course_id"].Value?.ToString();
                txtFullName.Text = row.Cells["student_name"].Value?.ToString();
                txtCourse.Text = row.Cells["course_name"].Value?.ToString();
                dtpEnrollmentDate.Value = DateTime.Parse(row.Cells["enrollment_date"].Value?.ToString() ?? DateTime.Now.ToString());
                checkBoxStatus.Checked = row.Cells["status"].Value?.ToString() == "Enrolled";
                txtEnrollmentId.Text = row.Cells["id"].Value.ToString();
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = false;
                btnCancel.Enabled = true;
            }
            else
            {
                MessageBox.Show("Không thể lấy thông tin đăng ký. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
