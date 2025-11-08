using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using prj_LTTQ_BTL.Data;
using prj_LTTQ_BTL.Utils;

namespace prj_LTTQ_BTL.Forms.Manager
{
    public partial class Manager_PaymentCRUDForm : Form
    {
        private DataProcessor dataProcessor = new DataProcessor();

        public Manager_PaymentCRUDForm()
        {
            InitializeComponent();
        }

        private void Manager_PaymentCRUDForm_Load(object sender, EventArgs e)
        {
            dgvHoaDon.AutoGenerateColumns = false;

            DataTable khoahoc = dataProcessor.GetDataTable($"select id from Course");

            comboBoxMaKhoaHoc.DataSource = khoahoc;
            comboBoxMaKhoaHoc.DisplayMember = "id";
            comboBoxMaKhoaHoc.ValueMember = "id";

            DataTable student = dataProcessor.GetDataTable($"select id from Student");

            comboBoxMaHocVien.DataSource = student;
            comboBoxMaHocVien.DisplayMember = "id";
            comboBoxMaHocVien.ValueMember = "id";

            DataTable phuongthuc = new DataTable();
            phuongthuc.Columns.Add("name", typeof(string));
            phuongthuc.Columns.Add("value", typeof(string));

            phuongthuc.Rows.Add("Không có", "None");
            phuongthuc.Rows.Add("Tiền mặt", "Cash");
            phuongthuc.Rows.Add("Chuyển khoản", "Bank transfer");
            phuongthuc.Rows.Add("Thẻ tín dụng", "Credit card");

            comboBoxMethod.DataSource = phuongthuc;
            comboBoxMethod.DisplayMember = "name";
            comboBoxMethod.ValueMember = "value";

            DataTable trangthai = new DataTable();
            trangthai.Columns.Add("name", typeof(string));
            trangthai.Columns.Add("value", typeof(string));

            trangthai.Rows.Add("Đã thanh toán", "Paid");
            trangthai.Rows.Add("Chưa thanh toán", "Pending");
            trangthai.Rows.Add("Đã hủy", "Cancelled");

            comboBoxStatus.DataSource = trangthai;
            comboBoxStatus.DisplayMember = "name";
            comboBoxStatus.ValueMember = "value";

            DataTable hoadon = dataProcessor.GetDataTable($"select * from Payment");

            dgvHoaDon.DataSource = hoadon;

            txtSearchPayment_TextChanged(sender, e);
        }

        private void SetEmptyAll()
        {
            txtMaHoaDon.Text = "";

            comboBoxMaKhoaHoc.SelectedIndex = -1;

            comboBoxMaHocVien.SelectedIndex = -1;

            txtSoTien.Text = string.Empty;

            lblNgayThanhToan.Visible = true;

            lblChuaDongTien.Visible = true;

            lblNgayThanhToan1.Visible = false;

            dateNgayThanhToan.Visible = false;

            comboBoxMethod.SelectedIndex = -1;

            comboBoxStatus.SelectedIndex = -1;
        }

        private void SetHoaDonDetails()
        {
            DataGridViewRow hoadonTable = dgvHoaDon.CurrentRow;

            if (hoadonTable == null)
            {
                SetEmptyAll();
                return;
            }

            string mahoadon = hoadonTable.Cells[0].Value.ToString();

            DataTable hoadon = dataProcessor.GetDataTable($"select * from Payment where id = '{mahoadon}'");

            if ( hoadon.Rows.Count == 0)
            {
                MessageBox.Show("Hóa đơn không tồn tại");
                SetEmptyAll();
                return;
            }

            txtMaHoaDon.Text = mahoadon;

            DataTable dangky = dataProcessor.GetDataTable($"select e.* from Enrollment e inner join Payment p on e.id = p.enrollment_id where p.id = '{mahoadon}'");

            comboBoxMaKhoaHoc.SelectedValue = dangky.Rows[0]["course_id"].ToString();

            DateTime ngaydangky = DateTime.Parse(dangky.Rows[0]["enrollment_date"].ToString());
            dateNgayDangKy.Value = ngaydangky;

            string mahocvien = hoadon.Rows[0]["payer_id"].ToString();
            comboBoxMaHocVien.SelectedValue = mahocvien;

            string sotien = hoadon.Rows[0]["amount"].ToString();
            txtSoTien.Text = sotien;

            if (hoadon.Rows[0]["status"].ToString() == "Pending")
            {
                lblNgayThanhToan.Visible = true;
                lblChuaDongTien.Visible = true;

                lblNgayThanhToan1.Visible = false;
                dateNgayThanhToan.Visible = false;
            }
            else
            {
                lblNgayThanhToan.Visible = false;
                lblChuaDongTien.Visible = false;

                lblNgayThanhToan1.Visible = true;
                dateNgayThanhToan.Visible = true;
            }

            DateTime ngaythanhtoan;
            if (!DateTime.TryParse(hoadon.Rows[0]["payment_date"].ToString(), out ngaythanhtoan))
            {
                ngaythanhtoan = DateTime.Now;
            }
            dateNgayThanhToan.Value = ngaythanhtoan;

            comboBoxMethod.SelectedValue = hoadon.Rows[0]["method"].ToString();

            comboBoxStatus.SelectedValue = hoadon.Rows[0]["status"].ToString();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetHoaDonDetails();
        }

        private void dgvHoaDon_CurrentCellChanged(object sender, EventArgs e)
        {
            SetHoaDonDetails();
        }

        private void dgvHoaDon_DataSourceChanged(object sender, EventArgs e)
        {
            SetHoaDonDetails();
        }

        private void txtSearchPayment_TextChanged(object sender, EventArgs e)
        {
            List<string> keywords = txtSearchPayment.Text.Split(' ').ToList();

            DataTable searchPayment = new DataTable();
            DataTable sPayment = new DataTable();

            string baseQuery = $"select p.*, c.name as course_name, e.enrollment_date as enrollment_date, s.phone_number as payer_phone_number, s.full_name as payer_full_name " +
                    $"from Payment p " +
                    $"inner join Enrollment e " +
                    $"on e.id = p.enrollment_id " +
                    $"inner join Course c " +
                    $"on e.course_id = c.id " +
                    $"inner join Student s " +
                    $"on s.id = p.payer_id ";

            foreach (string keyword in keywords)
            {
                sPayment = dataProcessor.GetDataTable(
                    baseQuery +
                    $"where c.name collate Latin1_General_CI_AI like '%{keyword}%'" + SetFilters("p.")
                );

                sPayment.PrimaryKey = new DataColumn[] { sPayment.Columns["id"] };
                searchPayment.PrimaryKey = new DataColumn[] { searchPayment.Columns["id"] };
                searchPayment.Merge(sPayment, false);

                sPayment = dataProcessor.GetDataTable(
                    baseQuery +
                    $"where s.phone_number collate Latin1_General_CI_AI like '%{keyword}%'" + SetFilters("p.")
                );
                searchPayment.Merge(sPayment, false);

                sPayment = dataProcessor.GetDataTable(
                    baseQuery +
                    $"where s.full_name collate Latin1_General_CI_AI like '%{keyword}%'" + SetFilters("p.")
                );
                searchPayment.Merge(sPayment, false);

                if (float.TryParse(keyword, out float amount))
                {
                    sPayment = dataProcessor.GetDataTable(
                    baseQuery +
                        $"where p.amount = {keyword}" + SetFilters("p.")
                    );
                    searchPayment.Merge(sPayment, false);
                }
            }

            FormUtils.FillGunaDgv(dgvHoaDon, searchPayment);
        }

        private void comboBoxMaKhoaHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            SetCourseDetails();
        }

        private void SetCourseDetails()
        {
            if (comboBoxMaKhoaHoc.SelectedValue == null)
            {
                txtTenKhoaHoc.Text = "";
                return;
            }

            string makhoahoc = comboBoxMaKhoaHoc.SelectedValue.ToString();

            if (makhoahoc == string.Empty || !Guid.TryParse(makhoahoc, out Guid r))
            {
                txtTenKhoaHoc.Text = "";
                return;
            }

            DataTable khoahoc = dataProcessor.GetDataTable($"select * from Course where id = '{makhoahoc}'");

            txtTenKhoaHoc.Text = khoahoc.Rows[0]["name"].ToString();
        }

        private void comboBoxMaHocVien_SelectedValueChanged(object sender, EventArgs e)
        {
            SetStudentDetails();
        }

        private void SetStudentDetails()
        {
            if (comboBoxMaHocVien.SelectedValue == null)
            {
                txtTenHocVien.Text = "";
                txtSoDienThoai.Text = "";
                return;
            }

            string mahocvien = comboBoxMaHocVien.SelectedValue.ToString();

            if (mahocvien == string.Empty || !Guid.TryParse(mahocvien, out Guid r))
            {
                txtTenKhoaHoc.Text = "";
                txtTenHocVien.Text = "";
                txtSoDienThoai.Text = "";
                return;
            }

            DataTable hocvien = dataProcessor.GetDataTable($"select * from Student where id = '{mahocvien}'");

            txtTenHocVien.Text = hocvien.Rows[0]["full_name"].ToString();
            txtSoDienThoai.Text = hocvien.Rows[0]["phone_number"].ToString();
        }

        private string SetFilters(string first)
        {
            string query = "";

            if (checkBoxPending.Checked || checkBoxPaid.Checked || checkBoxCancelled.Checked)
            {
                string condition = " and (";

                if (checkBoxPending.Checked)
                {
                    condition += $"{first}status = 'Pending'";
                }

                if (checkBoxPaid.Checked)
                {
                    if (condition != " and (")
                    {
                        condition += " or ";
                    }

                    condition += $"{first}status = 'Paid'";
                }

                if (checkBoxCancelled.Checked)
                {
                    if (condition != " and (")
                    {
                        condition += " or ";
                    }

                    condition += $"{first}status = 'Cancelled'";
                }

                condition += ")";

                query += condition;
            }

            return query;
        }

        private void checkBoxPaid_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchPayment_TextChanged(sender, e);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string mahoadon = txtMaHoaDon.Text;

            if (mahoadon == string.Empty)
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn");
                return;
            }

            if (comboBoxStatus.SelectedValue.ToString() == "Paid")
            {
                MessageBox.Show("Hóa đơn đã thanh toán");
                return;
            }

            if (comboBoxStatus.SelectedValue.ToString() == "Cancelled")
            {
                MessageBox.Show("Hóa đơn đã bị hủy");
                return;
            }

            dateNgayThanhToan.Value = DateTime.Now;

            comboBoxStatus.SelectedValue = "Paid";

            ThanhToanUI();
        }

        private void ThanhToanUI()
        {
            btnThanhToan.Visible = false;
            btnChinhSua.Visible = false;
            btnHuyHoaDon.Visible = false;

            btnLuu.Visible = true;
            btnHuy.Visible = true;

            txtSearchPayment.Enabled = false;

            dgvHoaDon.Enabled = false;

            checkBoxPaid.Enabled = false;
            checkBoxPending.Enabled = false;
            checkBoxCancelled.Enabled = false;  

            txtMaHoaDon.Enabled = false;

            comboBoxMaKhoaHoc.Enabled = false;

            txtTenKhoaHoc.Enabled=false;

            dateNgayDangKy.Enabled = false;

            comboBoxMaHocVien.Enabled = false;

            txtTenHocVien.Enabled = false;

            txtSoDienThoai.Enabled = false;

            txtSoTien.Enabled = false;

            lblNgayThanhToan.Visible = false;
            lblChuaDongTien.Visible = false;

            lblNgayThanhToan1.Visible = true;
            dateNgayThanhToan.Visible = true;

            dateNgayThanhToan.Enabled = false;

            comboBoxMethod.Enabled = true;

            comboBoxStatus.Enabled = false;
        }

        private void XemUI()
        {
            btnThanhToan.Visible = true;
            btnChinhSua.Visible = true;
            btnHuyHoaDon.Visible = true;

            btnLuu.Visible = false;
            btnHuy.Visible = false;

            txtSearchPayment.Enabled = true;

            dgvHoaDon.Enabled = true;

            checkBoxPaid.Enabled = true;
            checkBoxPending.Enabled = true;
            checkBoxCancelled.Enabled = true;

            txtMaHoaDon.Enabled = false;

            comboBoxMaKhoaHoc.Enabled = false;

            txtTenKhoaHoc.Enabled = false;

            dateNgayDangKy.Enabled = false;

            comboBoxMaHocVien.Enabled = false;

            txtTenHocVien.Enabled = false;

            txtSoDienThoai.Enabled = false;

            txtSoTien.Enabled = false;

            lblNgayThanhToan.Visible = false;
            lblChuaDongTien.Visible = false;

            lblNgayThanhToan1.Visible = true;
            dateNgayThanhToan.Visible = true;

            dateNgayThanhToan.Enabled = false;

            comboBoxMethod.Enabled = false;

            comboBoxStatus.Enabled = false;

            txtSearchPayment_TextChanged(null, null);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string mahoadon = txtMaHoaDon.Text;

            string amount = txtSoTien.Text;

            if (amount.Length == 0 )
            {
                MessageBox.Show("Số tiến không được để trống");
                return;
            }

            if (float.TryParse(amount, out float r))
            {
                if (r < 0)
                {
                    MessageBox.Show("Số tiến phải là số thực dương");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Số tiến phải là số thực dương");
                return;
            }

            DateTime ngaythanhtoan = dateNgayThanhToan.Value;

            string ngaythanhtoanStr = ngaythanhtoan.Year.ToString() + "-" + ngaythanhtoan.Month.ToString() + "-" + ngaythanhtoan.Day.ToString();

            if (comboBoxMethod.SelectedValue == null)
            {
                MessageBox.Show("Bạn chưa chọn phương thức thanh toán");
                return;
            }

            string phuongthuc = comboBoxMethod.SelectedValue.ToString();

            if (phuongthuc.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn phương thức thanh toán");
                return;
            }

            if (comboBoxStatus.SelectedValue == null)
            {
                MessageBox.Show("Bạn chưa chọn trạng thái thanh toán");
                return;
            }

            if (phuongthuc == "None")
            {
                MessageBox.Show("Bạn chưa chọn trạng thái thanh toán");
                return;
            }

            string trangthai = comboBoxStatus.SelectedValue.ToString();

            if (trangthai.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn trạng thái thanh toán");
                return;
            }

            if (comboBoxMaHocVien.SelectedValue == null)
            {
                MessageBox.Show("Bạn chưa chọn học viên");
                return;
            }

            string mahocvien = comboBoxMaHocVien.SelectedValue.ToString();

            if (mahocvien.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn học viên");
                return;
            }

            string manhanvien = GlobalData.Id;

            dataProcessor.UpdateData($"update Payment set amount = {amount}, payment_date = '{ngaythanhtoanStr}', method = '{phuongthuc}', status = '{trangthai}', fee_collector_id = '{manhanvien}', payer_id = '{mahocvien}' where id = '{mahoadon}'");

            XemUI();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            XemUI();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            string mahoadon = txtMaHoaDon.Text;

            if (mahoadon == string.Empty)
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn");
                return;
            }

            if (comboBoxStatus.SelectedValue.ToString() == "Cancelled")
            {
                MessageBox.Show("Hóa đơn đã bị hủy");
                return;
            }

            ChinhSuaUI();
        }

        private void ChinhSuaUI()
        {
            btnThanhToan.Visible = false;
            btnChinhSua.Visible = false;
            btnHuyHoaDon.Visible = false;

            btnLuu.Visible = true;
            btnHuy.Visible = true;

            txtSearchPayment.Enabled = false;

            dgvHoaDon.Enabled = false;

            checkBoxPaid.Enabled = false;
            checkBoxPending.Enabled = false;
            checkBoxCancelled.Enabled = false;

            txtMaHoaDon.Enabled = false;

            comboBoxMaKhoaHoc.Enabled = false;

            txtTenKhoaHoc.Enabled = false;

            dateNgayDangKy.Enabled = false;

            comboBoxMaHocVien.Enabled = false;

            txtTenHocVien.Enabled = false;

            txtSoDienThoai.Enabled = false;

            txtSoTien.Enabled = true;

            lblNgayThanhToan.Visible = false;
            lblChuaDongTien.Visible = false;

            lblNgayThanhToan1.Visible = true;
            dateNgayThanhToan.Visible = true;

            dateNgayThanhToan.Enabled = true;

            comboBoxMethod.Enabled = true;

            comboBoxStatus.Enabled = false;
        }

        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            string mahoadon = txtMaHoaDon.Text;

            if (mahoadon == string.Empty)
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn");
                return;
            }

            if (MessageBox.Show("Bạn có muốn hủy hóa đơn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataProcessor.UpdateData($"update Payment set status = 'Cancelled' where id = '{mahoadon}'");
            }

            txtSearchPayment_TextChanged(sender, e);
        }
    }
}
