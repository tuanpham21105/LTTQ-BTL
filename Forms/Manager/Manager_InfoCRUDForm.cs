using prj_LTTQ_BTL.Data;
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
using System.Xml.Linq;

namespace prj_LTTQ_BTL.Forms.Manager
{
    public partial class Manager_InfoCRUDForm : Form
    {
        private readonly UserService _userService;
        private string _selectedImagePath;
        private Guid _currentUserId;
        public Manager_InfoCRUDForm()
        {
            InitializeComponent();
            _currentUserId = Guid.Parse(GlobalData.Id);
            _userService = new UserService();
        }
        private void ToggleInfor(bool mode)
        {
            txtUsername.Enabled = mode;
            txtPassword.ReadOnly = !mode;
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ToggleInfor(true);
            btnSave.Visible = true;
            btnEdit.Visible = false;
        }

        private void Manager_InfoCRUDForm_Load(object sender, EventArgs e)
        {
            try
            {
                DataRow userRow = _userService.GetUserById(_currentUserId);

                if (userRow != null)
                {
                    txtId.Text = userRow["Id"].ToString();
                    txtUsername.Text = userRow["username"].ToString();
                    txtPassword.Text = userRow["password"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin người dùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                ToggleInfor(false);
                btnSave.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin người dùng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _userService.UpdateUser(_currentUserId, username, password, "admin", "active");

                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ToggleInfor(false);
                btnSave.Visible = false;
                btnEdit.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu thông tin người dùng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditPicture_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Chọn ảnh";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _selectedImagePath = openFileDialog.FileName;
                    picUser.Image = Image.FromFile(_selectedImagePath);
                }
            }
            ToggleInfor(true);
            btnSave.Visible = true;
            btnEdit.Visible = false;
        }
    }
}
