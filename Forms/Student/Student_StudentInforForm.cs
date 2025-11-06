using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using prj_LTTQ_BTL.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace prj_LTTQ_BTL.Forms.Student
{
    public partial class Student_StudentInforForm : Form
    {
        private DataProcessor dataProcessor = new DataProcessor();

        Color primaryColor = Color.FromArgb(0, 120, 215);
        Color secondaryColor = Color.FromArgb(43, 136, 216);
        Color backgroundColor = Color.FromArgb(243, 243, 243);
        Color cardColor = Color.White;
        Color textPrimary = Color.Black;
        Color textSecondary = Color.FromArgb(85, 85, 85);
        Color dangerColor = Color.FromArgb(232, 17, 35);
        Color borderColor = Color.FromArgb(204, 204, 204);

        private string usernameTemp;

        public Student_StudentInforForm()
        {
            InitializeComponent();
        }

        private void Student_StudentInforForm_Load(object sender, EventArgs e)
        {
            DataTable infor1 = dataProcessor.GetDataTable($"select * from [User] where id = '{GlobalData.Id}'");
            DataTable infor2 = dataProcessor.GetDataTable($"select * from Student where id = '{GlobalData.Id}'");

            if (infor1.Rows.Count > 0 && infor2.Rows.Count > 0)
            {
                txtId.Text = infor1.Rows[0]["id"].ToString();
                txtUsername.Text = infor1.Rows[0]["username"].ToString();
                txtPassword.Text = infor1.Rows[0]["password"].ToString();

                txtName.Text = infor2.Rows[0]["full_name"].ToString();
                DateTime parseDate = Convert.ToDateTime(infor2.Rows[0]["birth_date"]);
                dateBirthDate.Value = parseDate;
                comboboxGender.SelectedItem = infor2.Rows[0]["gender"].ToString();
                txtSdt.Text = infor2.Rows[0]["phone_number"].ToString();
                txtEmail.Text = infor2.Rows[0]["email"].ToString();
                txtAddress.Text = infor2.Rows[0]["address"].ToString();
            }
        }

        private void ToggleInfor(bool mode)
        {
            txtUsername.Enabled = mode;
            txtPassword.ReadOnly = !mode;
            txtName.Enabled = mode;
            txtSdt.Enabled = mode;
            txtEmail.Enabled = mode;
            dateBirthDate.Enabled = mode;
            comboboxGender.Enabled = mode;
            txtAddress.Enabled = mode;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ToggleInfor(true);
            btnSave.Visible = true;
            btnEdit.Visible = false;

            usernameTemp = txtUsername.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username không được để trống");
                return;
            }

            if (dataProcessor.GetDataTable($"select * from [User] where username = '{txtUsername.Text}'").Rows.Count > 0 && txtUsername.Text != usernameTemp)
            {
                MessageBox.Show("Username đã được sử dụng");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text)) 
            {
                MessageBox.Show("Họ và tên không được để trống");
                return; 
            }

            if (string.IsNullOrWhiteSpace(txtSdt.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống");
                return;
            }

            string stdPattern = @"^(0\d{8,10}|(\+84)\d{9})$";
            if (!Regex.IsMatch(txtSdt.Text.Trim(), stdPattern))
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email không được để trống");
                return;
            }

            string emailPattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
            if(!Regex.IsMatch(txtEmail.Text.Trim(), emailPattern, RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Email không hợp lệ");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Địa chỉ không được để trống");
                return;
            }

            ToggleInfor(false);
            btnEdit.Visible = true;
            btnSave.Visible = false;

            dataProcessor.UpdateData($"update [User] set " +
                $"username = N'{txtUsername.Text}'," +
                $"password = '{txtPassword.Text}'," +
                $"update_at = '{DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString()}'" +
                $"where id = '{txtId.Text}'"
            );

            dataProcessor.UpdateData($"update Student set " +
                $"full_name = N'{txtName.Text}'," +
                $"birth_date = '{dateBirthDate.Value.Year.ToString() + "-" + dateBirthDate.Value.Month.ToString() + "-" + dateBirthDate.Value.Day.ToString()}'," +
                $"gender = N'{comboboxGender.SelectedItem.ToString()}'," +
                $"phone_number = '{txtSdt.Text}'," +
                $"email = '{txtEmail.Text}'," +
                $"address = N'{txtAddress.Text}'" +
                $"where id = '{txtId.Text}'"
            );
        }
    }
}
