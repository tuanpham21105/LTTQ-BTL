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
using System.Windows.Forms.DataVisualization.Charting;
using Guna.UI2.WinForms;
using prj_LTTQ_BTL.Data;
using prj_LTTQ_BTL.Utils;

namespace prj_LTTQ_BTL.Forms.Manager
{
    public partial class Manager_StudentScoreCRUDForm : Form
    {
        private DataProcessor dataProcessor = new DataProcessor();
        public Manager_StudentScoreCRUDForm()
        {
            InitializeComponent();
        }

        private void txtSearchStudent_TextChanged(object sender, EventArgs e)
        {
            List<string> keywords = txtSearchStudent.Text.Split(' ').ToList();

            DataTable searchStudents = new DataTable();
            DataTable sStudents = new DataTable();

            string classId = comboboxClasses.SelectedValue.ToString();

            if (classId.Length == 0 || !Guid.TryParse(classId, out Guid r))
            {
                return;
            }

            if (comboboxClasses.SelectedIndex == -1)
            {
                return;
            }

            foreach (string keyword in keywords)
            {
                sStudents = dataProcessor.GetDataTable($"select s.* from Student s inner join ClassAssignment c on s.id = c.student_id where s.full_name collate Latin1_General_CI_AI like '%{keyword}%' and c.class_id = '{classId}'");
                sStudents.PrimaryKey = new DataColumn[] { sStudents.Columns["id"] };
                searchStudents.PrimaryKey = new DataColumn[] { searchStudents.Columns["id"] };
                searchStudents.Merge(sStudents, false);

                sStudents = dataProcessor.GetDataTable($"select s.* from Student s inner join ClassAssignment c on s.id = c.student_id where email collate Latin1_General_CI_AI like '%{keyword}%' and c.class_id = '{classId}'");
                searchStudents.Merge(sStudents, false);

                sStudents = dataProcessor.GetDataTable($"select s.* from Student s inner join ClassAssignment c on s.id = c.student_id where address collate Latin1_General_CI_AI like '%{keyword}%' and c.class_id = '{classId}'");
                searchStudents.Merge(sStudents, false);

                sStudents = dataProcessor.GetDataTable($"select s.* from Student s inner join ClassAssignment c on s.id = c.student_id where phone_number collate Latin1_General_CI_AI like '%{keyword}%' and c.class_id = '{classId}'");
                searchStudents.Merge(sStudents, false);
            }

            FormUtils.FillGunaDgv(dgvStudent, searchStudents);

            SetStudentScoreBoard();
        }

        private void comboboxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchStudent_TextChanged(sender, e);

            SetStudentScoreBoard();
        }

        private void Manager_StudentScoreCRUDForm_Load(object sender, EventArgs e)
        {
            dgvStudent.AutoGenerateColumns = false;
            dgvExam.AutoGenerateColumns=false;

            DataTable scores = dataProcessor.GetDataTable($"select * from Score where score = -1");
            FormUtils.FillGunaDgv(dgvExam, scores);

            comboboxClasses.DataSource = dataProcessor.GetDataTable($"select * from Class");
            comboboxClasses.DisplayMember = "name";
            comboboxClasses.ValueMember = "id";

            txtSearchStudent_TextChanged(sender, e);

            dgvExam.DataSourceChanged += dgvExam_DataSourceChanged;

            SetStudentScoreBoard();

            FormUtils.ClearChartPoint(chartScore);

        }

        private void dgvExam_DataSourceChanged(object sender, EventArgs e)
        {
            SetScoreDetails();
        }

        private void SetStudentScoreBoard()
        {
            if (dgvStudent.CurrentRow == null)
            {
                panelWarning.Visible = false;
                panelWarning1.Visible = false;
                return;
            }

            string studentId = dgvStudent.CurrentRow.Cells["id"].Value.ToString();
            string classId = comboboxClasses.SelectedValue.ToString();

            if (string.IsNullOrEmpty(studentId) || string.IsNullOrEmpty(classId) || !Guid.TryParse(classId, out Guid guidValue))
            {
                panelWarning.Visible = false;
                panelWarning1.Visible = false;
                return;
            }

            if (dataProcessor.GetDataTable($"select * from ClassAssignment where student_id = '{studentId}' and class_id = '{classId}'").Rows.Count == 0)
            {
                panelWarning.Visible = true;
                panelWarning1.Visible = false;
                DataTable scores = dataProcessor.GetDataTable($"select * from Score where score = -1");
                FormUtils.FillGunaDgv(dgvExam, scores);
                FormUtils.ClearChartPoint(chartScore);
            }
            else
            {
                panelWarning.Visible = false;
                DataTable scores = dataProcessor.GetDataTable($"select * from Score where student_id = '{studentId}' and class_id = '{classId}' order by created_date");
                if (scores.Rows.Count == 0)
                {
                    panelWarning1.Visible = true;
                    FormUtils.ClearChartPoint(chartScore);
                }
                else
                {
                    panelWarning1.Visible = false;
                    SetScoreChart(scores);
                }
                FormUtils.FillGunaDgv(dgvExam, scores);
            }
        }

        public void SetScoreDetails()
        {
            if (panelWarning.Visible || panelWarning1.Visible)
            {
                txtTenBaiKT.Text = "";
                txtDiemSo.Text = "";
                dateNgayKT.Value = DateTime.Now;
                return;
            }

            DataGridViewRow row = dgvExam.CurrentRow;
            if (row == null) return;
            txtTenBaiKT.Text = row.Cells["exam_name"].Value.ToString();
            txtDiemSo.Text = row.Cells["exam_score"].Value.ToString();
            DateTime.TryParse(row.Cells["date"].Value.ToString(), out DateTime d);
            dateNgayKT.Value = d;
        }

        private void SetScoreChart(DataTable bangdiem)
        {
            if (bangdiem.Rows.Count == 0)
            {
                FormUtils.ClearChartPoint(chartScore);
                labelAverage.Text = "0";
                labelNumbers.Text = "0";
            }
            else
            {
                FormUtils.ClearChartPoint(chartScore);
                double avgScore = (double)bangdiem.AsEnumerable().Average(row => row.Field<decimal>("score"));
                labelAverage.Text = avgScore.ToString();
                labelNumbers.Text = bangdiem.Rows.Count.ToString();
                foreach (DataRow row in bangdiem.Rows)
                {
                    DateTime ngay = Convert.ToDateTime(row["created_date"]);
                    double diem = Convert.ToDouble(row["score"]);
                    chartScore.Series["Score"].Points.AddXY(ngay, diem);

                    var area = chartScore.ChartAreas[0];
                    area.AxisX.LabelStyle.Format = "dd/MM/yyyy";
                    area.AxisX.IntervalType = DateTimeIntervalType.Days;
                    area.AxisX.Interval = 1;
                    area.AxisX.LabelStyle.Angle = -45;
                    area.AxisX.MajorGrid.LineColor = Color.LightGray;
                }

                chartScore.Update();
                chartScore.Refresh();
            }
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetStudentScoreBoard();
        }

        private void dgvExam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetScoreDetails();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (panelWarning.Visible)
            {
                MessageBox.Show("Học viên không học lớp này");
                return;
            }

            DataGridViewRow student = dgvStudent.CurrentRow;

            if (student == null)
            {
                MessageBox.Show("Bạn chưa chọn học viên");
                return;
            }

            string classId = comboboxClasses.SelectedValue.ToString();

            if (classId == string.Empty)
            {
                MessageBox.Show("Bạn chưa chọn lớp học");
                return;
            }

            btnThem.Visible = false;
            btnXoa.Visible = false;
            btnLuu.Visible = true;
            btnHuy.Visible = true;

            txtTenBaiKT.Enabled = true;
            txtDiemSo.Enabled = true;
            dateNgayKT.Enabled = true;

            comboboxClasses.Enabled = false;
            dgvStudent.Enabled = false;
            dgvExam.Enabled = false;  

            txtTenBaiKT.Text = "";
            txtDiemSo.Text = "";
            dateNgayKT.Value = DateTime.Now;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenBaiKT.Text))
            {
                MessageBox.Show("Tên bài kiểm tra không được để trống");
                return;
            } 

            if (string.IsNullOrEmpty(txtDiemSo.Text))
            {
                MessageBox.Show("Điểm bài kiểm tra không được để trống");
                return;
            }

            if (!float.TryParse(txtDiemSo.Text, out float diemso))
            {
                MessageBox.Show("Điểm bài kiểm tra phải là số thực");
                return;
            }

            if (diemso < 0 || diemso > 10)
            {
                MessageBox.Show("Điểm bài kiểm tra phải trong khoảng 0 đến 10");
                return;
            }

            btnThem.Visible = true;
            btnXoa.Visible = true;
            btnLuu.Visible = false;
            btnHuy.Visible = false;

            txtTenBaiKT.Enabled = false;
            txtDiemSo.Enabled = false;
            dateNgayKT.Enabled = false;

            comboboxClasses.Enabled = true;
            dgvStudent.Enabled = true;
            dgvExam.Enabled = true;

            string studentId = dgvStudent.CurrentRow.Cells["id"].Value.ToString();
            string classId = comboboxClasses.SelectedValue.ToString();

            dataProcessor.UpdateData($"insert into Score values('{studentId}', '{classId}', {txtDiemSo.Text}, '{dateNgayKT.Value.Year.ToString() + "-" + dateNgayKT.Value.Month.ToString() + "-" + dateNgayKT.Value.Day.ToString() + " " + dateNgayKT.Value.Hour.ToString() + ":" + dateNgayKT.Value.Minute.ToString() + ":00"}', N'{txtTenBaiKT.Text}')");

            SetStudentScoreBoard();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenBaiKT.Text) || string.IsNullOrEmpty(txtDiemSo.Text))
            {
                MessageBox.Show("Điểm kiểm tra không hợp lệ");
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa điểm của học viên?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No) return;

            string studentId = dgvStudent.CurrentRow.Cells["id"].Value.ToString();
            string classId = comboboxClasses.SelectedValue.ToString();

            dataProcessor.UpdateData($"delete from Score where " +
                $"student_id = '{studentId}' and " +
                $"class_id = '{classId}' and " +
                $"score = {txtDiemSo.Text} and " +
                $"created_date = '{dateNgayKT.Value.Year.ToString() + "-" + dateNgayKT.Value.Month.ToString() + "-" + dateNgayKT.Value.Day.ToString() + " " + dateNgayKT.Value.Hour.ToString() + ":" + dateNgayKT.Value.Minute.ToString() + ":00"}' and " +
                $"name = N'{txtTenBaiKT.Text}'");

            SetStudentScoreBoard();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Visible = true;
            btnXoa.Visible = true;
            btnLuu.Visible = false;
            btnHuy.Visible = false;

            txtTenBaiKT.Enabled = false;
            txtDiemSo.Enabled = false;
            dateNgayKT.Enabled = false;

            comboboxClasses.Enabled = true;
            dgvStudent.Enabled = true;
            dgvExam.Enabled = true;

            txtTenBaiKT.Text = "";
            txtDiemSo.Text = "";
            dateNgayKT.Value = DateTime.Now;
        }

        private void btnRefreshGraph_Click(object sender, EventArgs e)
        {
            string studentId = dgvStudent.CurrentRow.Cells["id"].Value.ToString();
            string classId = comboboxClasses.SelectedValue.ToString();
            DataTable bangdiem = dataProcessor.GetDataTable($"select * from Score where student_id = '{studentId}' and class_id = '{classId}' order by created_date");

            SetScoreChart(bangdiem);
        }
    }
}
