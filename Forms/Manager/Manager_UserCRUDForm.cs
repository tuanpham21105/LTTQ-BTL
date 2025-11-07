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
    public partial class Manager_UserCRUDForm : Form
    {
        private readonly UserService _userService;
        private readonly TeacherService _teacherService;
        private readonly StudentService _studentService;
        private Guid? _selectedUserId = null;
        private int _currentPage = 1;
        private const int PageSize = 10;
        private int _totalPages = 0;
        public Manager_UserCRUDForm()
        {
            InitializeComponent();
            InitializeGenderComboBox();
            InitializeRoleComboBox();
            _userService = new UserService();
            _studentService = new StudentService();
            _teacherService = new TeacherService();
        }
        private void LoadUsers()
        {
            DataTable users = _userService.GetAllUsersJoin(1, 10);
            dgvUsers.DataSource = users;

            if (dgvUsers.Columns.Contains("id"))
            {
                dgvUsers.Columns["id"].Visible = false;
            }
            //if (dgvUsers.Columns.Contains("address"))
            //{
            //    dgvUsers.Columns["address"].Visible = false;
            //}
            //if (dgvUsers.Columns.Contains("gender"))
            //{
            //    dgvUsers.Columns["gender"].Visible = false;
            //}
            if (dgvUsers.Columns.Contains("password"))
            {
                dgvUsers.Columns["password"].Visible = false;
            }
            if (dgvUsers.Columns.Contains("specialization"))
            {
                dgvUsers.Columns["specialization"].Visible = false;
            }
            if (dgvUsers.Columns.Contains("qualification"))
            {
                dgvUsers.Columns["qualification"].Visible = false;
            }
            if (dgvUsers.Columns.Contains("start_date"))
            {
                dgvUsers.Columns["start_date"].Visible = false;
            }
            if (dgvUsers.Columns.Contains("status"))
            {
                dgvUsers.Columns["status"].HeaderText = "Trạng thái";
            }
            int totalRecords = users.Rows.Count;
            _totalPages = (int)Math.Ceiling((double)totalRecords / PageSize);

            lblPageInfo.Text = $"Trang {_currentPage} / {_totalPages}";
            btnPrev.Enabled = _currentPage > 1;
            btnNext.Enabled = _currentPage < _totalPages;
            //if (dgvUsers.Columns.Contains("username"))
            //{
            //    dgvUsers.Columns["username"].HeaderText = "Tên đăng nhập";
            //}
            //if (dgvUsers.Columns.Contains("role"))
            //{
            //    dgvUsers.Columns["role"].HeaderText = "Vai trò";
            //}
            //if (dgvUsers.Columns.Contains("created_at"))
            //{
            //    dgvUsers.Columns["created_at"].HeaderText = "Ngày tạo";
            //}
            //if (dgvUsers.Columns.Contains("update_at"))
            //{
            //    dgvUsers.Columns["update_at"].HeaderText = "Ngày cập nhật";
            //}
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
        private void guna2Panel11_Paint(object sender, PaintEventArgs e)
        {

        }
        private void SetStudentFieldsVisibility(bool visible)
        {
            panelAddress.Visible = visible;
            panelBirthDate.Visible = visible;
            panelEmail.Visible = visible;
            panelGender.Visible = visible;
            panelPhoneNumber.Visible = visible;
            panelFullname.Visible = visible;
        }
        private void SetTeacherFieldsVisibility(bool visible)
        {
            panelAddress.Visible = visible;
            panelSpecialization.Visible = visible;
            panelQualification.Visible = visible;
            panelEmail.Visible = visible;
            panelPhoneNumber.Visible = visible;
            panelStartDate.Visible = visible;
            panelFullname.Visible = visible;
        }
        private void InitializeRoleComboBox()
        {
            cmbRole.Items.Clear();
            cmbRole.Items.Add("admin");
            cmbRole.Items.Add("student");
            cmbRole.Items.Add("teacher");

        }
        private void InitializeGenderComboBox()
        {
            cmbGender.Items.Clear();
            cmbGender.Items.Add("Nam");
            cmbGender.Items.Add("Nữ");
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void Manager_UserCRUDForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
            InitializeButtonStates();
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = cmbRole.Text.Trim();
            SetStudentFieldsVisibility(false);
            SetTeacherFieldsVisibility(false);

            if (selectedRole == "student")
            {
                SetStudentFieldsVisibility(true);
            }
            else if (selectedRole == "teacher")
            {
                SetTeacherFieldsVisibility(true);
            }
            if (selectedRole == "student")
            {
                SetStudentFieldsVisibility(true);

                if (_selectedUserId != null)
                {
                    DataRow studentRow = _studentService.GetStudentById(_selectedUserId.Value);
                    if (studentRow != null)
                    {
                        txtFullname.Text = studentRow["full_name"].ToString();
                        txtPhoneNumber.Text = studentRow["phone_number"].ToString();
                        cmbGender.Text = studentRow["gender"].ToString();
                        txtEmail.Text = studentRow["email"].ToString();
                        dtpBirthDate.Value = DateTime.Parse(studentRow["birth_date"].ToString());
                        txtAddress.Text = studentRow["address"].ToString();
                    }
                }
            }
            else if (selectedRole == "teacher")
            {
                SetTeacherFieldsVisibility(true);

                if (_selectedUserId != null)
                {
                    DataRow teacherRow = _teacherService.GetTeacherById(_selectedUserId.Value);
                    if (teacherRow != null)
                    {
                        txtFullname.Text = teacherRow["full_name"].ToString();
                        txtSpecialization.Text = teacherRow["specialization"].ToString();
                        txtQualification.Text = teacherRow["qualification"].ToString();
                        txtPhoneNumber.Text = teacherRow["phone_number"].ToString();
                        txtEmail.Text = teacherRow["email"].ToString();
                        txtAddress.Text = teacherRow["address"].ToString();
                        dtpStartDate.Value = DateTime.Parse(teacherRow["start_date"].ToString());
                    }
                }
            }
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

            _selectedUserId = null;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedUserId == null)
            {
                MessageBox.Show("Vui lòng chọn người dùng để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EnableInputFields(true);

            btnCreate.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedUserId == null)
            {
                MessageBox.Show("Vui lòng chọn người dùng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    //DataRow studentRow = _studentService.GetStudentById(_selectedUserId.Value);
                    //if (studentRow != null)
                    //{
                    //    _studentService.DeleteStudent(_selectedUserId.Value);
                    //}

                    //DataRow teacherRow = _teacherService.GetTeacherById(_selectedUserId.Value);
                    //if (teacherRow != null)
                    //{
                    //    _teacherService.DeleteTeacher(_selectedUserId.Value);
                    //}

                    _userService.DeleteUser(_selectedUserId.Value);

                    MessageBox.Show("Xóa người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                    InitializeButtonStates();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa người dùng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadUsers();
                return;
            }

            DataTable filteredUsers = _userService.SearchUsers(keyword);
            dgvUsers.DataSource = filteredUsers;

            lblPageInfo.Text = $"Kết quả tìm kiếm: {filteredUsers.Rows.Count}";
            btnPrev.Enabled = false;
            btnNext.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string role = cmbRole.Text.Trim();
                string fullName = txtFullname.Text.Trim();
                string password = txtPassword.Text.Trim();
                string gender = cmbGender.Text.Trim();
                string phoneNumber = txtPhoneNumber.Text.Trim();
                string email = txtEmail.Text.Trim();
                string address = txtAddress.Text.Trim();
                DateTime birthDate = dtpBirthDate.Value;
                DateTime startDate = dtpStartDate.Value;
                string specialization = txtSpecialization.Text.Trim();
                string qualification = txtQualification.Text.Trim();
                string status = checkBoxStatus.Checked ? "Active" : "Inactive";

                string username = _selectedUserId == null ? GenerateUsername(fullName) : txtusername.Text.Trim();
                if (role.Equals("admin"))
                {
                    username = txtusername.Text.Trim();
                }
                if (string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Guid newId = _selectedUserId ?? Guid.NewGuid();

                if (_selectedUserId == null)
                {
                    string defaultPassword = string.IsNullOrEmpty(password) ? "default123" : password;
                    _userService.CreateUser(newId, username, defaultPassword, role);
                }
                else
                {
                    _userService.UpdateUser(newId, username, password, role, status);
                }

                if (role.Equals("student", StringComparison.OrdinalIgnoreCase))
                {
                    if (string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin học viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DataRow existingStudent = _studentService.GetStudentById(newId);
                    if (existingStudent == null)
                    {
                        _studentService.CreateStudent(newId, fullName, birthDate, gender, phoneNumber, email, address);
                    }
                    else
                    {
                        _studentService.UpdateStudent(newId, fullName, birthDate, gender, phoneNumber, email, address, status);
                    }
                }
                else if (role.Equals("teacher", StringComparison.OrdinalIgnoreCase))
                {
                    if (string.IsNullOrEmpty(specialization) || string.IsNullOrEmpty(qualification) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin giáo viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DataRow existingTeacher = _teacherService.GetTeacherById(newId);
                    if (existingTeacher == null)
                    {
                        _teacherService.CreateTeacher(newId, fullName, specialization, qualification, phoneNumber, email, address, startDate);
                    }
                    else
                    {
                        _teacherService.UpdateTeacher(newId, fullName, specialization, qualification, phoneNumber, email, address, startDate, status);
                    }
                }

                MessageBox.Show("Lưu thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
                InitializeButtonStates();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu người dùng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                LoadUsers();
            }
        }
        private void ClearInputFields()
        {
            txtId.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            txtQualification.Clear();
            txtSearch.Clear();
            txtSpecialization.Clear();
            dtpBirthDate.Value = DateTime.Now;
            txtusername.Clear();
            txtPassword.Clear();

            cmbRole.SelectedIndex = 0;
        }

        private void EnableInputFields(bool enable)
        {
            if(cmbRole.SelectedIndex == 0)
            {
                txtusername.Enabled = enable;

            }
            txtPassword.Enabled = enable;
            cmbGender.Enabled = enable;
            cmbRole.Enabled = enable;
            dtpBirthDate.Enabled = enable;
            dtpStartDate.Enabled = enable;
            txtPhoneNumber.Enabled = enable;
            txtEmail.Enabled = enable;
            txtAddress.Enabled = enable;
            txtSpecialization.Enabled = enable;
            txtQualification.Enabled = enable;
            txtFullname.Enabled = enable;
            txtId.ReadOnly = true;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentPage < _totalPages)
            {
                _currentPage++;
                LoadUsers();
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearInputFields();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                _selectedUserId = Guid.Parse(row.Cells["id"].Value.ToString());
                txtusername.Text = row.Cells["username"].Value.ToString();
                txtPassword.Text = row.Cells["password"].Value.ToString();
                //cmbRole.Text = row.Cells["role_name"].Value.ToString();
                string role = row.Cells["role_name"].Value.ToString();
                string status = row.Cells["status"].Value.ToString();
                checkBoxStatus.Checked = status == "Active";
                if (role.Equals("admin", StringComparison.OrdinalIgnoreCase))
                {
                    cmbRole.SelectedIndex = 0;
                }
                else if (role.Equals("student", StringComparison.OrdinalIgnoreCase))
                {
                    cmbRole.SelectedIndex = 1;
                    txtFullname.Text = row.Cells["full_name"].Value.ToString();
                    txtPhoneNumber.Text = row.Cells["phone_number"].Value.ToString();
                    cmbGender.Text = row.Cells["gender"].Value.ToString();
                    txtEmail.Text = row.Cells["email"].Value.ToString();
                    dtpBirthDate.Value = DateTime.Parse(row.Cells["birth_date"].Value.ToString());
                    txtAddress.Text = row.Cells["address"].Value.ToString();
                }
                else
                {
                    cmbRole.SelectedIndex = 2;
                    txtSpecialization.Text = row.Cells["specialization"].Value.ToString();
                    txtQualification.Text = row.Cells["qualification"].Value.ToString();
                    txtPhoneNumber.Text = row.Cells["phone_number"].Value.ToString();
                    txtEmail.Text = row.Cells["email"].Value.ToString();
                    txtAddress.Text = row.Cells["address"].Value.ToString();
                    dtpStartDate.Value = DateTime.Parse(row.Cells["start_date"].Value.ToString());
                }
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
