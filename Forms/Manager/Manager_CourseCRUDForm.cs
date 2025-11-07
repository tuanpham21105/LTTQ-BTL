using prj_LTTQ_BTL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_LTTQ_BTL.Forms.Manager
{
    public partial class Manager_CourseCRUDForm : Form
    {
        private readonly CourseService _courseService;
        private int _currentPage = 1;
        private const int PageSize = 10;
        private int _totalPages = 0;
        private Guid? _selectedCourseId = null;
        public Manager_CourseCRUDForm()
        {
            InitializeComponent();
            _courseService = new CourseService();
            InitializeButtonStates();
            LoadCourses();
        }
        private void InitializeButtonStates()
        {
            ClearInputFields();

            btnCreate.Enabled = true;
            btnSave.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;

            EnableInputFields(false);
        }
        private void ClearInputFields()
        {
            txtId.Clear();
            txtName.Clear();
            txtDescription.Clear();
            txtLessons.Clear();
            txtFee.Clear();
        }
        private void EnableInputFields(bool enable)
        {
            txtName.Enabled = enable;
            txtDescription.Enabled = enable;
            txtLessons.Enabled = enable;
            txtFee.Enabled = enable;
            txtId.ReadOnly = true;
        }
        private void LoadCourses()
        {
            DataTable courses = _courseService.GetCourses(_currentPage, PageSize);
            dgvCourses.DataSource = courses;

            if (dgvCourses.Columns.Contains("id"))
            {
                dgvCourses.Columns["id"].Visible = false;
            }
            if (dgvCourses.Columns.Contains("name"))
            {
                dgvCourses.Columns["name"].HeaderText = "Tên Khóa Học";
            }
            if (dgvCourses.Columns.Contains("description"))
            {
                dgvCourses.Columns["description"].HeaderText = "Mô Tả";
            }
            if (dgvCourses.Columns.Contains("number_of_lessons"))
            {
                dgvCourses.Columns["number_of_lessons"].HeaderText = "Số Bài Học";
            }
            if (dgvCourses.Columns.Contains("fee"))
            {
                dgvCourses.Columns["fee"].HeaderText = "Học Phí";
            }
            if (dgvCourses.Columns.Contains("status"))
            {
                dgvCourses.Columns["status"].HeaderText = "Trạng thái";
            }
            int totalRecords = GetTotalCourseCount();
            _totalPages = (int)Math.Ceiling((double)totalRecords / PageSize);

            lblPageInfo.Text = $"Trang {_currentPage} / {_totalPages}";

            btnPrev.Enabled = _currentPage > 1;
            btnNext.Enabled = _currentPage < _totalPages;
        }
        private int GetTotalCourseCount()
        {
            DataTable coureses = _courseService.GetCourses(-1, PageSize);
            return coureses.Rows.Count;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            EnableInputFields(true);

            btnCreate.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            _selectedCourseId = null;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedCourseId == null)
            {
                MessageBox.Show("Vui lòng chọn khóa học để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EnableInputFields(true);

            btnCreate.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedCourseId == null)
            {
                MessageBox.Show("Vui lòng chọn khóa học để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khóa học này? (Trạng thái sẽ chuyển thành 'Inactive')", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                _courseService.DeleteCourse(_selectedCourseId.Value);
                MessageBox.Show("Khóa học đã được chuyển sang trạng thái 'Inactive'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCourses();
                InitializeButtonStates();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                string description = txtDescription.Text.Trim();
                int numberOfLessons = int.Parse(txtLessons.Text.Trim());
                decimal fee = decimal.Parse(txtFee.Text.Trim());
                string status = checkBoxStatus.Checked ? "Enrolled" : "Cancelled";
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description) || numberOfLessons <= 0 || fee <= 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_selectedCourseId == null)
                {
                    Guid newId = Guid.NewGuid();
                    txtId.Text = newId.ToString();
                    _courseService.CreateCourse(newId, name, description, numberOfLessons, fee);
                    MessageBox.Show("Thêm khóa học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _courseService.UpdateCourse(_selectedCourseId.Value, name, description, numberOfLessons, fee, status);
                    MessageBox.Show("Cập nhật khóa học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadCourses();
                InitializeButtonStates();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu khóa học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            InitializeButtonStates();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                LoadCourses();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentPage < _totalPages)
            {
                _currentPage++;
                LoadCourses();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            DataTable searchResults = _courseService.SearchCourses(keyword);
            dgvCourses.DataSource = searchResults;
        }

        private void dgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCourses.Rows[e.RowIndex];
                _selectedCourseId = Guid.Parse(row.Cells["id"].Value.ToString());
                txtId.Text = row.Cells["id"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
                txtDescription.Text = row.Cells["description"].Value.ToString();
                txtLessons.Text = row.Cells["number_of_lessons"].Value.ToString();
                txtFee.Text = row.Cells["fee"].Value.ToString();
                checkBoxStatus.Checked = row.Cells["status"].Value.ToString() == "Enrolled";

                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnCreate.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = true;
            }
        }

        private void Manager_CourseCRUDForm_Load(object sender, EventArgs e)
        {

        }
    }
}
