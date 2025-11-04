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
    public partial class Manager_TeacherCRUDForm : Form
    {
        private readonly TeacherService _teacherService;
        private readonly UserService _userService;
        private int _currentPage = 1;
        private const int PageSize = 10;
        private int _totalPages = 0;
        private Guid? _selectedTeacherId = null;
        public Manager_TeacherCRUDForm()
        {
            InitializeComponent();
            _teacherService = new TeacherService();
            _userService = new UserService();
            InitializeButtonStates();
        }
        private string GenerateUsername(string fullName)
        {
            var words = fullName.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string baseUsername = string.Join("", words.Select(w => w[0])).ToLower();
            string username = baseUsername;
            int counter = 1;
            while (_userService.GetUserByUsername(username) != null)
            {
                username = $"{baseUsername}{counter}";
                counter++;
            }

            return username;
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
            txtFullName.Clear();
            txtSpecialization.Clear();
            txtQualification.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            dtpStartDate.Value = DateTime.Now;
        }
        private void EnableInputFields(bool enable)
        {
            txtFullName.Enabled = enable;
            dtpStartDate.Enabled = enable;
            txtPhoneNumber.Enabled = enable;
            txtEmail.Enabled = enable;
            txtAddress.Enabled = enable;
            txtId.ReadOnly = true;
            txtQualification.Enabled = enable;
            txtSpecialization.Enabled = enable;
        }
        private int GetTotalTeacherCount()
        {
            DataTable students = _teacherService.GetAllTeachers(-1, PageSize);
            return students.Rows.Count;
        }
        private void LoadTeachers()
        {
            DataTable students = _teacherService.GetAllTeachers(_currentPage, PageSize);
            dgvTeachers.DataSource = students;
            int totalRecords = GetTotalTeacherCount();
            if (dgvTeachers.Columns.Contains("id"))
            {
                dgvTeachers.Columns["id"].Visible = false;
            }
            if (dgvTeachers.Columns.Contains("full_name"))
            {
                dgvTeachers.Columns["full_name"].HeaderText = "Họ và Tên";
            }
            if (dgvTeachers.Columns.Contains("specialization"))
            {
                dgvTeachers.Columns["specialization"].HeaderText = "Chuyên môn";
            }
            if (dgvTeachers.Columns.Contains("qualification"))
            {
                dgvTeachers.Columns["qualification"].HeaderText = "Trình độ";
            }
            if (dgvTeachers.Columns.Contains("phone_number"))
            {
                dgvTeachers.Columns["phone_number"].HeaderText = "Số Điện Thoại";
            }
            if (dgvTeachers.Columns.Contains("email"))
            {
                dgvTeachers.Columns["email"].HeaderText = "Email";
            }
            if (dgvTeachers.Columns.Contains("address"))
            {
                dgvTeachers.Columns["address"].HeaderText = "Địa Chỉ";
            }
            if (dgvTeachers.Columns.Contains("start_date"))
            {
                dgvTeachers.Columns["start_date"].HeaderText = "Ngày Bắt Đầu";
            }

            _totalPages = (int)Math.Ceiling((double)totalRecords / PageSize);

            lblPageInfo.Text = $"Trang {_currentPage} / {_totalPages}";

            btnPrev.Enabled = _currentPage > 1;
            btnNext.Enabled = _currentPage < _totalPages;
        }
        private void guna2Panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Manager_TeacherCRUDForm_Load(object sender, EventArgs e)
        {
            LoadTeachers();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                LoadTeachers();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _currentPage++;
            LoadTeachers();
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

            _selectedTeacherId = null;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedTeacherId == null)
            {
                MessageBox.Show("Vui lòng chọn giáo viên để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (_selectedTeacherId == null)
            {
                MessageBox.Show("Vui lòng chọn giáo viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa giáo viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                _teacherService.DeleteTeacher(_selectedTeacherId.Value);
                MessageBox.Show("Xóa giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTeachers();
                InitializeButtonStates();
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = txtFullName.Text.Trim();
                string specialization = txtSpecialization.Text.Trim();
                string qualification = txtQualification.Text.Trim();
                string phoneNumber = txtPhoneNumber.Text.Trim();
                string email = txtEmail.Text.Trim();
                string address = txtAddress.Text.Trim();
                DateTime startDate = dtpStartDate.Value;
                if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(specialization) || string.IsNullOrEmpty(qualification) ||
                    string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_selectedTeacherId == null)
                {
                    Guid newId = Guid.NewGuid();
                    txtId.Text = newId.ToString();
                    string username = GenerateUsername(fullName);
                    string defaultPassword = "teacher123";
                    _userService.CreateUser(newId, username, defaultPassword, "teacher");
                    _teacherService.CreateTeacher(newId, fullName, specialization, qualification, phoneNumber, email, address, startDate);
                    MessageBox.Show("Thêm giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _teacherService.UpdateTeacher(_selectedTeacherId.Value, fullName, specialization, qualification, phoneNumber, email, address, startDate);
                    MessageBox.Show("Cập nhật giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadTeachers();
                InitializeButtonStates();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu giáo viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            InitializeButtonStates();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadTeachers();
                return;
            }

            DataTable filteredTeachers = _teacherService.SearchTeachers(keyword);
            dgvTeachers.DataSource = filteredTeachers;

            lblPageInfo.Text = $"Kết quả tìm kiếm: {filteredTeachers.Rows.Count}";
            btnPrev.Enabled = false;
            btnNext.Enabled = false;
        }

        private void dgvTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTeachers.Rows[e.RowIndex];
                _selectedTeacherId = Guid.Parse(row.Cells["id"].Value.ToString());
                txtFullName.Text = row.Cells["full_name"].Value.ToString();
                txtSpecialization.Text = row.Cells["specialization"].Value.ToString();
                txtQualification.Text = row.Cells["qualification"].Value.ToString();
                txtPhoneNumber.Text = row.Cells["phone_number"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtAddress.Text = row.Cells["address"].Value.ToString();
                dtpStartDate.Value = DateTime.Parse(row.Cells["start_date"].Value.ToString());
                txtId.Text = row.Cells["id"].Value.ToString();
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnCreate.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = true;
            }
        }
    }
}
