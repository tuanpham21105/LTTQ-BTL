using AntdUI;
using prj_LTTQ_BTL.Data;
using prj_LTTQ_BTL.Services;
using prj_LTTQ_BTL.Utils;
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
        private DataProcessor dataProcessor = new DataProcessor();
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

                DataTable infor1 = dataProcessor.GetDataTable($"select * from [User] where id = '{GlobalData.Id}'");
                if (infor1.Rows[0]["avatar"].ToString() != string.Empty)
                    FormUtils.LoadImage(picUser, infor1.Rows[0]["avatar"].ToString());
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

        }
        private void avatarBtn_Click(object sender, EventArgs e)
        {
            string path = FormUtils.UploadImage();

            dataProcessor.UpdateData($"update [User] set avatar = '{path}' where id = '{GlobalData.Id}'");

            FormUtils.LoadImage(picUser, path);
        }
    }
}
