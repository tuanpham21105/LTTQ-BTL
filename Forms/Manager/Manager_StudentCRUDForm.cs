using prj_LTTQ_BTL.Data.Repository;
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
    public partial class Manager_StudentCRUDForm : Form
    {
        private readonly StudentService _studentService;
        private int _currentPage = 1;
        private const int PageSize = 10;
        private int _totalPages = 0;
        private Guid? _selectedStudentId = null;
        private readonly UserService _userService;
        public Manager_StudentCRUDForm()
        {
            InitializeComponent();
            _studentService = new StudentService();
            _userService = new UserService();
            InitializeGenderComboBox();
            InitializeButtonStates();
        }
        private void InitializeGenderComboBox()
        {
            cmbGender.Items.Clear();
            cmbGender.Items.Add("Nam"); 
            cmbGender.Items.Add("Nữ"); 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
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
            dtpBirthDate.Value = DateTime.Now;
            cmbGender.SelectedIndex = -1;
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
        }
        private void EnableInputFields(bool enable)
        {
            txtFullName.Enabled = enable;
            dtpBirthDate.Enabled = enable;
            cmbGender.Enabled = enable;
            txtPhoneNumber.Enabled = enable;
            txtEmail.Enabled = enable;
            txtAddress.Enabled = enable;

            txtId.ReadOnly = true;
        }
        private void LoadStudents()
        {
            DataTable students = _studentService.GetAllStudents(_currentPage, PageSize);
            dgvStudents.DataSource = students;
            int totalRecords = GetTotalStudentCount();
            if (dgvStudents.Columns.Contains("id"))
            {
                dgvStudents.Columns["id"].Visible = false;
            }
            if (dgvStudents.Columns.Contains("full_name"))
            {
                dgvStudents.Columns["full_name"].HeaderText = "Họ và Tên";
            }
            if (dgvStudents.Columns.Contains("birth_date"))
            {
                dgvStudents.Columns["birth_date"].HeaderText = "Ngày Sinh";
            }
            if (dgvStudents.Columns.Contains("gender"))
            {
                dgvStudents.Columns["gender"].HeaderText = "Giới Tính";
            }
            if (dgvStudents.Columns.Contains("phone_number"))
            {
                dgvStudents.Columns["phone_number"].HeaderText = "Số Điện Thoại";
            }
            if (dgvStudents.Columns.Contains("email"))
            {
                dgvStudents.Columns["email"].HeaderText = "Email";
            }
            if (dgvStudents.Columns.Contains("address"))
            {
                dgvStudents.Columns["address"].HeaderText = "Địa Chỉ";
            }

            _totalPages = (int)Math.Ceiling((double)totalRecords / PageSize);

            lblPageInfo.Text = $"Trang {_currentPage} / {_totalPages}";

            btnPrev.Enabled = _currentPage > 1;
            btnNext.Enabled = _currentPage < _totalPages;
        }
        private int GetTotalStudentCount()
        {
            DataTable students = _studentService.GetAllStudents(-1, PageSize);
            return students.Rows.Count;
        }
        private void Manager_StudentCRUDFormTrue_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _currentPage++;
            LoadStudents();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                LoadStudents();
            }
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

            _selectedStudentId = null; 
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedStudentId == null)
            {
                MessageBox.Show("Vui lòng chọn học viên để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (_selectedStudentId == null)
            {
                MessageBox.Show("Vui lòng chọn học viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa học viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    _studentService.DeleteStudent(_selectedStudentId.Value);
                    MessageBox.Show("Xóa học viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa học viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = txtFullName.Text.Trim();
                DateTime birthDate = dtpBirthDate.Value;
                string gender = cmbGender.Text.Trim();
                string phoneNumber = txtPhoneNumber.Text.Trim();
                string email = txtEmail.Text.Trim();
                string address = txtAddress.Text.Trim();

               
                if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_selectedStudentId == null)
                {
                    Guid newId = Guid.NewGuid();
                    txtId.Text = newId.ToString();
                    string username = GenerateUsername(fullName);
                    string defaultPassword = "owleng";
                    _userService.CreateUser(newId, username, defaultPassword, "student");
                    _studentService.CreateStudent(newId, fullName, birthDate, gender, phoneNumber, email, address);
                    MessageBox.Show("Thêm học viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _studentService.UpdateStudent(_selectedStudentId.Value, fullName, birthDate, gender, phoneNumber, email, address);
                    MessageBox.Show("Cập nhật học viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadStudents();
                InitializeButtonStates();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật học viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            InitializeButtonStates();
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
                _selectedStudentId = Guid.Parse(row.Cells["id"].Value.ToString());
                txtFullName.Text = row.Cells["full_name"].Value.ToString();
                dtpBirthDate.Value = DateTime.Parse(row.Cells["birth_date"].Value.ToString());
                cmbGender.Text = row.Cells["gender"].Value.ToString();
                txtPhoneNumber.Text = row.Cells["phone_number"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtAddress.Text = row.Cells["address"].Value.ToString();
                txtId.Text = row.Cells["id"].Value.ToString();

                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnCreate.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadStudents();
                return;
            }

            DataTable filteredStudents = _studentService.SearchStudents(keyword);
            dgvStudents.DataSource = filteredStudents;

            lblPageInfo.Text = $"Kết quả tìm kiếm:{filteredStudents.Rows.Count}";
            btnPrev.Enabled = false;
            btnNext.Enabled = false;
        }

        private void dgvStudents_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
