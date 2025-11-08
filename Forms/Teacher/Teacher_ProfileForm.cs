using prj_LTTQ_BTL.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_LTTQ_BTL.Forms.Teacher
{
    public partial class Teacher_ProfileForm : Form
    {
        DataProcessor dtBase = new DataProcessor();
        string teacherId= GlobalData.Id;
        public Teacher_ProfileForm()
        {
            InitializeComponent();
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void Teacher_ProfileForm_Load(object sender, EventArgs e)
        {
            string query = $@"
        SELECT full_name, specialization, qualification, phone_number, 
               email, address, start_date
        FROM Teacher
        WHERE id = '{teacherId}'";

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

                   
                }
            }
        }
    }
}
