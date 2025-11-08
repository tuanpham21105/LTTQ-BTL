using prj_LTTQ_BTL.Data;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace prj_LTTQ_BTL.Forms.Teacher
{
    public partial class Teacher_ProfileForm : Form
    {
        DataProcessor dtBase = new DataProcessor();
        string teacherId = GlobalData.Id;

        public Teacher_ProfileForm()
        {
            InitializeComponent();
        }

        private void Teacher_ProfileForm_Load(object sender, EventArgs e)
        {
            LoadTeacherInfo();
            LoadAccountInfo();
        }

        private void LoadTeacherInfo()
        {
            string query = $@"
            SELECT T.full_name, T.specialization, T.qualification, 
            T.phone_number, T.email, T.address, 
            ISNULL(U.avatar, '') AS avatar
            FROM Teacher T
            JOIN [User] U ON T.id = U.id
            WHERE T.id = '{teacherId}'";

            DataTable dt = dtBase.GetDataTable(query);
            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                txtFullName.Text = r["full_name"].ToString();
                txtSpecialization.Text = r["specialization"].ToString();
                txtQualification.Text = r["qualification"].ToString();
                txtPhone.Text = r["phone_number"].ToString();
                txtEmail.Text = r["email"].ToString();
                txtAddress.Text = r["address"].ToString();

                string avatarPath = r["avatar"].ToString();
                if (!string.IsNullOrEmpty(avatarPath) && File.Exists(avatarPath))
                    guna2CirclePictureBox1.Image = Image.FromFile(avatarPath);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                string query = $@"
                UPDATE Teacher SET
                full_name = N'{txtFullName.Text}',
                specialization = N'{txtSpecialization.Text}',
                qualification = N'{txtQualification.Text}',
                phone_number = '{txtPhone.Text}',
                email = '{txtEmail.Text}',
                address = N'{txtAddress.Text}'
                WHERE id = '{teacherId}'";

            dtBase.UpdateData(query);
            MessageBox.Show(" Cập nhật thông tin thành công!", "Thông báo");
        }

        private void btnChangeAvatar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh đại diện";
                ofd.Filter = "Ảnh (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    guna2CirclePictureBox1.Image = Image.FromFile(ofd.FileName);

                    string query = $@"
                    UPDATE [User]
                    SET avatar = N'{ofd.FileName}'
                    WHERE id = '{teacherId}'";

                    dtBase.UpdateData(query);
                    MessageBox.Show("Ảnh đại diện đã được cập nhật!", "Thông báo");
                }
            }
        }

        private void LoadAccountInfo()
        {
            string query = $@"
            SELECT username, [password]
            FROM [User]
            WHERE id = '{teacherId}'";

            DataTable dt = dtBase.GetDataTable(query);
            if (dt.Rows.Count > 0)
            {
                txtUsername.Text = dt.Rows[0]["username"].ToString();
                txtPassword.Text = dt.Rows[0]["password"].ToString();
            }
        }

        

        private void btnUpDateUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(" Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo");
                return;
            }

            // 1️⃣ Kiểm tra xem username này đã tồn tại ở user khác chưa
            string checkQuery = $@"
        SELECT COUNT(*) AS Count
        FROM [User]
        WHERE username = N'{username}' AND id <> '{teacherId}'";

            DataTable dtCheck = dtBase.GetDataTable(checkQuery);
            int count = Convert.ToInt32(dtCheck.Rows[0]["Count"]);

            if (count > 0)
            {
                MessageBox.Show(" Tên đăng nhập này đã tồn tại, vui lòng chọn tên khác!",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
                string updateQuery = $@"
                UPDATE [User]
                SET username = N'{username}',
                [password] = N'{password}',
                update_at = GETDATE()
                WHERE id = '{teacherId}'";

            try
            {
                dtBase.UpdateData(updateQuery);
                MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật tài khoản:\n" + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
