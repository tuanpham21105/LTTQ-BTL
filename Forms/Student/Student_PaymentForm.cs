using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prj_LTTQ_BTL.Data;

namespace prj_LTTQ_BTL.Forms.Student
{
    public partial class Student_PaymentForm : Form
    {
        private DataProcessor dataProcessor = new DataProcessor();
        public Student_PaymentForm()
        {
            InitializeComponent();
        }

        private void Student_PaymentForm_Load(object sender, EventArgs e)
        {
            dgvHoaDon.AutoGenerateColumns = false;

            string id = GlobalData.Id;

            DataTable hoadon = dataProcessor.GetDataTable($"select p.* from Payment p where p.payer_id = '{id}'");    

            dgvHoaDon.DataSource = hoadon;

            DataTable phuongthuc = new DataTable();
            phuongthuc.Columns.Add("name", typeof(string));
            phuongthuc.Columns.Add("value", typeof(string));

            phuongthuc.Rows.Add("Không có", "None");
            phuongthuc.Rows.Add("Tiền mặt", "Cash");
            phuongthuc.Rows.Add("Chuyển khoản", "Bank transfer");
            phuongthuc.Rows.Add("Thẻ tín dụng", "Credit card");

            comboBoxPhuongThuc.DataSource = phuongthuc;
            comboBoxPhuongThuc.DisplayMember = "name";
            comboBoxPhuongThuc.ValueMember = "value";

            DataTable trangthai = new DataTable();
            trangthai.Columns.Add("name", typeof(string));
            trangthai.Columns.Add("value", typeof(string));

            trangthai.Rows.Add("Đã thanh toán", "Paid");
            trangthai.Rows.Add("Chưa thanh toán", "Pending");
            trangthai.Rows.Add("Đã hủy", "Cancelled");

            comboBoxTrangThai.DataSource = trangthai;
            comboBoxTrangThai.DisplayMember = "name";
            comboBoxTrangThai.ValueMember = "value";
        }

        private void SetPaymentDetails()
        {
            DataGridViewRow row = dgvHoaDon.CurrentRow;

            if (row == null)
            {
                txtMaHoaDon.Text = "";
                txtMaDangKy.Text = "";
                txtSoTien.Text = "";
                dateNgayDong.Value = DateTime.Now;
                comboBoxPhuongThuc.SelectedValue = "None";
                comboBoxTrangThai.SelectedItem = "";
                return;
            }

            txtMaHoaDon.Text = row.Cells[0].Value.ToString();
            txtMaDangKy.Text = row.Cells[1].Value.ToString();
            txtSoTien.Text = row.Cells[2].Value.ToString();
            if (DateTime.TryParse(row.Cells[3].Value.ToString(), out DateTime date))
            {
                lblNgayDong1.Visible = false;
                lblChuaDongTien.Visible = false;
                lblNgayDong2.Visible = true;
                dateNgayDong.Visible = true;
                dateNgayDong.Value = date;
            }
            else
            {
                lblNgayDong1.Visible = true;
                lblChuaDongTien.Visible = true;
                lblNgayDong2.Visible = false;
                dateNgayDong.Visible = false;
            }
            comboBoxPhuongThuc.SelectedValue = row.Cells[4].Value.ToString();
            comboBoxTrangThai.SelectedValue = row.Cells[5].Value.ToString();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetPaymentDetails();
        }

        private void dgvHoaDon_DataSourceChanged(object sender, EventArgs e)
        {
            SetPaymentDetails();
        }

        private void dgvHoaDon_CurrentCellChanged(object sender, EventArgs e)
        {
            SetPaymentDetails();
        }

        private void SetFilters(object sender, EventArgs e)
        {
            string id = GlobalData.Id;

            string query = $"select p.* from Payment p where payer_id = '{id}'";

            if (checkBoxPending.Checked || checkBoxPaid.Checked || checkBoxCancelled.Checked)
            {
                string condition = " and (";

                if (checkBoxPending.Checked)
                {
                    condition += "status = 'Pending'";
                }

                if (checkBoxPaid.Checked)
                {
                    if (condition != " and (")
                    {
                        condition += " or ";
                    }

                    condition += "status = 'Paid'";
                }

                if (checkBoxCancelled.Checked)
                {
                    if (condition != " and (")
                    {
                        condition += " or ";
                    }

                    condition += "status = 'Cancelled'";
                }

                condition += ")";

                query += condition;
            }

            DataTable hoadon = dataProcessor.GetDataTable(query);

            dgvHoaDon.DataSource = hoadon;
        }
    }
}
