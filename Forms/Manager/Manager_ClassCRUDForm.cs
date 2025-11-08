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
    public partial class Manager_ClassCRUDForm : Form
    {
        private DataProcessor dataProcessor = new DataProcessor();

        public Manager_ClassCRUDForm()
        {
            InitializeComponent();
        }

        private void Manager_ClassCRUDForm_Load(object sender, EventArgs e)
        {
            dgvClass.AutoGenerateColumns = false;
            dgvCourse.AutoGenerateColumns = false;
            dgvSchedule.AutoGenerateColumns = false;

            ResetDgvClass();
           
            DataTable teacherTable = dataProcessor.GetDataTable("select * from Teacher");
            comboboxMaGiaoVien.DataSource = teacherTable;
            comboboxMaGiaoVien.DisplayMember = "full_name";
            comboboxMaGiaoVien.ValueMember = "id";

            XemLopUI();
        }

        private void ResetDgvClass()
        {
            DataTable classTable = dataProcessor.GetDataTable($"select * from Class");
            FormUtils.FillGunaDgv(dgvClass, classTable);

            txtSearchClass_TextChanged(null, null);
        }

        private void ResetDgvCourse()
        {
            DataTable courseTable = dataProcessor.GetDataTable($"select * from Course where status = 'Active'");
            FormUtils.FillGunaDgv(dgvCourse, courseTable);
        }

        private void ResetDgvSchedule()
        {
            SetClassDetails();
        }

        private void SetClassDetails()
        {
            DataGridViewRow row = dgvClass.CurrentRow;

            if (row == null)
            {
                EmptyClassDetails();
                return;
            }

            txtMaLopHoc.Text = row.Cells["id"].Value.ToString();
            txtTenLopHoc.Text = row.Cells["name"].Value.ToString();
            txtTongSoHocVien.Text = row.Cells["max_students"].Value.ToString();
            if (DateTime.TryParse(row.Cells["start_date"].Value.ToString(), out DateTime r))
                dateNgayBatDau.Value = r;
            else dateNgayBatDau.Value = DateTime.Now;
            comboboxMaGiaoVien.SelectedValue = row.Cells["teacher_id"].Value.ToString();

            DataTable courses = dataProcessor.GetDataTable($"select * from Course where id = '{row.Cells["course_id"].Value.ToString()}'");
            FormUtils.FillGunaDgv(dgvCourse, courses);

            DataTable schedules = dataProcessor.GetDataTable($"select * from Schedule where class_id = '{row.Cells["id"].Value.ToString()}' order by session_date");
            FormUtils.FillGunaDgv(dgvSchedule, schedules);
        }

        private void EmptyClassDetails()
        {
            txtMaLopHoc.Text = string.Empty;
            txtTenLopHoc.Text = string.Empty;
            txtTongSoHocVien.Text = string.Empty;
            dateNgayBatDau.Value = DateTime.Now;
            comboboxMaGiaoVien.SelectedValue = string.Empty;
        }

        private void txtSearchClass_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchClass.Text == string.Empty)
            {
                FormUtils.FillGunaDgv(dgvClass, dataProcessor.GetDataTable("select * from Class"));
                return;
            }

            List<string> keywords = txtSearchClass.Text.Split(' ').ToList();

            DataTable searchClasses = new DataTable();
            DataTable sClasses = new DataTable();

            foreach (string keyword in keywords)
            {
                sClasses = dataProcessor.GetDataTable(
                    $"select Cl.* " +
                    $"from Class Cl " +
                    $"inner join ClassAssignment ClAs " +
                    $"on ClAs.class_id = Cl.id " +
                    $"inner join Student St " +
                    $"on St.id = '{GlobalData.Id}' and St.id = ClAs.student_id " +
                    $"where Cl.name collate Latin1_General_CI_AI like '%{keyword}%'"
                );

                sClasses.PrimaryKey = new DataColumn[] { sClasses.Columns["id"] };
                searchClasses.PrimaryKey = new DataColumn[] { searchClasses.Columns["id"] };
                searchClasses.Merge(sClasses, false);

                if (int.TryParse(keyword, out int maxStudents))
                {
                    sClasses = dataProcessor.GetDataTable(
                        $"select Cl.* " +
                        $"from Class Cl " +
                        $"inner join ClassAssignment ClAs " +
                        $"on ClAs.class_id = Cl.id " +
                        $"inner join Student St " +
                        $"on St.id = '{GlobalData.Id}' and St.id = ClAs.student_id " +
                        $"where Cl.max_students = {keyword}"
                    );
                    searchClasses.Merge(sClasses, false);
                }

                if (int.TryParse(keyword, out int year))
                {
                    sClasses = dataProcessor.GetDataTable(
                        $"select Cl.* " +
                        $"from Class Cl " +
                        $"inner join ClassAssignment ClAs " +
                        $"on ClAs.class_id = Cl.id " +
                        $"inner join Student St " +
                        $"on St.id = '{GlobalData.Id}' and St.id = ClAs.student_id " +
                        $"where year( Cl.start_date) = {keyword}");
                    searchClasses.Merge(sClasses, false);
                }

                if (int.TryParse(keyword, out int month))
                {
                    sClasses = dataProcessor.GetDataTable(
                        $"select Cl.* " +
                        $"from Class Cl " +
                        $"inner join ClassAssignment ClAs " +
                        $"on ClAs.class_id = Cl.id " +
                        $"inner join Student St " +
                        $"on St.id = '{GlobalData.Id}' and St.id = ClAs.student_id " +
                        $"where month(Cl.start_date) = {keyword}");
                    searchClasses.Merge(sClasses, false);
                }

                if (int.TryParse(keyword, out int day))
                {
                    sClasses = dataProcessor.GetDataTable(
                        $"select Cl.* " +
                        $"from Class Cl " +
                        $"inner join ClassAssignment ClAs " +
                        $"on ClAs.class_id = Cl.id " +
                        $"inner join Student St " +
                        $"on St.id = '{GlobalData.Id}' and St.id = ClAs.student_id " +
                        $"where day(Cl.start_date) = {keyword}");
                    searchClasses.Merge(sClasses, false);
                }
            }

            FormUtils.FillGunaDgv(dgvClass, searchClasses);
        }

        private void txtSearchCourse_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchCourse.Text == string.Empty)
            {
                FormUtils.FillGunaDgv(dgvCourse, dataProcessor.GetDataTable("select * from Course where status = 'Active'"));
                return;
            }

            List<string> keywords = txtSearchCourse.Text.Split(' ').ToList();

            DataTable searchCourses = new DataTable();
            DataTable sCourses = new DataTable();

            foreach (string keyword in keywords)
            {
                sCourses = dataProcessor.GetDataTable($"select * from Course where name collate Latin1_General_CI_AI like '%{keyword}%' and status = 'Active'");
                sCourses.PrimaryKey = new DataColumn[] { sCourses.Columns["id"] };
                searchCourses.PrimaryKey = new DataColumn[] { searchCourses.Columns["id"] };
                searchCourses.Merge(sCourses, false);

                sCourses = dataProcessor.GetDataTable($"select * from Course where description collate Latin1_General_CI_AI like '%{keyword}%' and status = 'Active'");
                searchCourses.Merge(sCourses, false);

                if (int.TryParse(keyword, out int lesson))
                {
                    sCourses = dataProcessor.GetDataTable($"select * from Course where number_of_lessons = {keyword} and status = 'Active'");
                    searchCourses.Merge(sCourses, false);
                }

                if (double.TryParse(keyword, out double fee))
                {
                    sCourses = dataProcessor.GetDataTable($"select * from Course where fee = {keyword} and status = 'Active'");
                    searchCourses.Merge(sCourses, false);
                }
            }

            FormUtils.FillGunaDgv(dgvCourse, searchCourses);
        }

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetClassDetails();
        }

        private void dgvSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetScheduleDetails();
        }

        private void SetCourseDetails()
        {
            DataGridViewRow row = dgvCourse.CurrentRow;

            if (row == null)
            {
                EmptyCourseDetails();
                return;
            }

            txtMaKhoaHoc.Text = row.Cells[0].Value.ToString();
            txtTenKhoaHoc.Text = row.Cells[1].Value.ToString();
            txtSoBuoiHoc.Text = row.Cells[2].Value.ToString();
        }

        private void EmptyCourseDetails()
        {
            txtMaKhoaHoc.Text = string.Empty;
            txtTenKhoaHoc.Text = string.Empty;
            txtSoBuoiHoc.Text = string.Empty;
        }

        private void SetScheduleDetails()
        {
            DataGridViewRow row = dgvSchedule.CurrentRow;

            if (row == null)
            {
                EmptyScheduleDetails();
                return;
            }

            txtMaBuoiHoc.Text = row.Cells[0].Value.ToString();
            txtPhongHoc.Text = row.Cells[4].Value.ToString();
            if (DateTime.TryParse(row.Cells[3].Value.ToString(), out DateTime r))
                dateGioBatDau.Value = r;
            if (DateTime.TryParse(row.Cells[2].Value.ToString(), out DateTime r1))
                dateNgayHoc.Value = r1;
        }

        private void EmptyScheduleDetails()
        {
            txtMaBuoiHoc.Text = string.Empty;
            txtPhongHoc.Text = string.Empty;
            dateGioBatDau.Value = DateTime.Now;
            dateNgayHoc.Value = DateTime.Now;
        }

        private void dgvClass_CurrentCellChanged(object sender, EventArgs e)
        {
            SetClassDetails();
        }

        private void dgvCourse_CurrentCellChanged(object sender, EventArgs e)
        {
            SetCourseDetails();
        }

        private void dgvSchedule_CurrentCellChanged(object sender, EventArgs e)
        {
            SetScheduleDetails();
        }

        private void dgvClass_DataSourceChanged(object sender, EventArgs e)
        {
            SetClassDetails();
        }

        private void dgvCourse_DataSourceChanged(object sender, EventArgs e)
        {
            SetCourseDetails();
        }

        private void dgvSchedule_DataSourceChanged(object sender, EventArgs e)
        {
            SetScheduleDetails();
        }

        private void btnThemLopMoi_Click(object sender, EventArgs e)
        {
            ThemMoiLopUI();
        }

        private void XemLopUI()
        {
            panelMain.VerticalScroll.Value = 0;

            panelCheDo.Visible = false;

            txtSearchClass.Text = "";
            txtSearchClass.Visible = true;

            panelDgvClass.Visible = true;

            txtMaLopHoc.Text = "";

            txtTenLopHoc.Enabled = false;
            txtTenLopHoc.Text = "";

            txtTongSoHocVien.Enabled = false;
            txtTongSoHocVien.Text = "";

            dateNgayBatDau.Enabled = false;
            dateNgayBatDau.Value = DateTime.Now;

            comboboxMaGiaoVien.Enabled = false;
            comboboxMaGiaoVien.SelectedValue = "";

            txtSearchCourse.Visible = false;
            txtSearchCourse.Text = "";

            panelDgvKhoaHoc.Visible = false;

            panelLichHocCuaLop.Visible = true;

            panelDgvLichHoc.Visible = true;

            txtPhongHoc.Enabled = false;

            dateGioBatDau.Enabled = false;

            dateNgayHoc.Enabled = false;

            panelLichHocMoi.Visible = false;

            txtPhongHoc.Text = "";

            dateGioBatDau.Value = DateTime.Now;

            panelLichHocMoiBtn.Visible = false;

            btnThemLopMoi.Visible = true;

            btnTaoLichHoc.Visible = true;

            btnChinhSuaLop.Visible = true;

            btnXoaLopHoc.Visible = true;

            btnLuuLopHoc.Visible = false;

            btnHuyLopHoc.Visible = false;

            btnChinhSuaBuoiHoc.Visible = true;

            btnLuuBuoiHoc.Visible = false;

            btnHuyBuoiHoc.Visible = false;

            panelLopHocBtn.Visible = true;
        }

        private void ThemMoiLopUI()
        {
            panelMain.VerticalScroll.Value = 0;

            panelCheDo.Visible = true;

            lblCheDo.Text = "Chế độ thêm lớp học";

            txtSearchClass.Text = "";
            txtSearchClass.Visible = false;

            panelDgvClass.Visible = false;

            txtMaLopHoc.Text = "";

            txtTenLopHoc.Enabled = true;
            txtTenLopHoc.Text = "";

            txtTongSoHocVien.Enabled = true;
            txtTongSoHocVien.Text = "";

            dateNgayBatDau.Enabled = true;
            dateNgayBatDau.Value = DateTime.Now;

            comboboxMaGiaoVien.Enabled = true;
            comboboxMaGiaoVien.SelectedValue = "";

            txtSearchCourse.Visible = true;
            txtSearchCourse.Text = "";

            panelDgvKhoaHoc.Visible = true;

            ResetDgvCourse();

            panelLichHocCuaLop.Visible = false;

            panelLichHocMoi.Visible = true;

            txtPhongHoc.Text = "";

            dateGioBatDau.Value = DateTime.Now;
            
            panelLichHocMoiBtn.Visible = false;

            checkBoxThu2.Checked = false;

            checkBoxThu3.Checked = false;

            checkBoxThu4.Checked = false;

            checkBoxThu5.Checked = false;

            checkBoxThu6.Checked = false;

            checkBoxThu7.Checked = false;

            checkBoxChuNhat.Checked = false;

            panelLichHocMoiBtn.Visible = false;

            btnThemLopMoi.Visible = false;

            btnTaoLichHoc.Visible = false;

            btnChinhSuaLop.Visible = false;

            btnXoaLopHoc.Visible = false;

            btnLuuLopHoc.Visible = true;

            btnHuyLopHoc.Visible = true;
        }

        private void btnLuuLopHoc_Click(object sender, EventArgs e)
        {
            string malophoc = txtMaLopHoc.Text;

            string tenlophoc = txtTenLopHoc.Text;

            if (tenlophoc == string.Empty)
            {
                MessageBox.Show("Tên lớp không được để trống");
                return;
            }

            string tongsohocvien = txtTongSoHocVien.Text;

            if (tongsohocvien == string.Empty)
            {
                MessageBox.Show("Tổng số học viên không được để trống");
                return;
            }

            if (int.TryParse(tongsohocvien, out int r))
            {
                if (r < 0)
                {
                    MessageBox.Show("Tổng số học viên phải là số dương lớn hơn 0");
                    return;
                } 
            }

            string ngaybatdau = dateNgayBatDau.Value.Year.ToString() + "-" + dateNgayBatDau.Value.Month.ToString() + "-" + dateNgayBatDau.Value.Day.ToString();

            if (dateNgayBatDau.Value < DateTime.Now)
            {
                MessageBox.Show("Ngày bắt đầu lớp phải lớn hơn hiện tại");
                return;
            }

            if (comboboxMaGiaoVien.SelectedValue == null)
            {
                MessageBox.Show("Không có giáo viên");
                return;
            }

            string magiaovien = comboboxMaGiaoVien.SelectedValue.ToString();


            if (magiaovien == string.Empty)
            {
                MessageBox.Show("Mã giáo viên không được để trống");
                return;
            }

            string makhoahoc = txtMaKhoaHoc.Text;

            if (makhoahoc == string.Empty)
            {
                MessageBox.Show("Bạn chưa chọn khóa học cho lớp");
                return;
            }

            if (malophoc == string.Empty)
            {
                malophoc = Guid.NewGuid().ToString();

                txtMaLopHoc.Text = malophoc;

                dataProcessor.UpdateData($"insert into Class(id, course_id, name, max_students, start_date, teacher_id, status) values ('{malophoc}', '{makhoahoc}', N'{tenlophoc}', {tongsohocvien}, '{ngaybatdau}', '{magiaovien}', 'Active')");
            }
            else
            {
                if (dataProcessor.GetDataTable($"select * from Course where id = '{makhoahoc}'").Rows[0]["status"].ToString() == "Inactive")
                {
                    MessageBox.Show("Khóa học của lớp đã bị hủy, không thể chỉnh sửa lớp học");
                    return;
                }
                dataProcessor.UpdateData($"update Class set" +
                    $" course_id = '{makhoahoc}'," +
                    $" name = N'{tenlophoc}'," +
                    $" max_students = {tongsohocvien}," +
                    $" start_date = '{ngaybatdau}'," +
                    $" teacher_id = '{magiaovien}'," +
                    $" status = 'Active'" +
                    $" where id = '{malophoc}'");
            }

            if (panelLichHocMoi.Visible)
            {
                if (!CreateLichHoc()) return;
            }

            ResetDgvClass();

            SetClassDetails();

            XemLopUI();

            txtSearchClass_TextChanged(sender, e);
        }

        private void btnHuyLopHoc_Click(object sender, EventArgs e)
        {
            ResetDgvClass();

            XemLopUI();

            txtSearchClass_TextChanged(sender, e);
        }

        private void btnChinhSuaLop_Click(object sender, EventArgs e)
        {
            string malophoc = txtMaLopHoc.Text;

            if (malophoc.Length == 0) 
            {
                MessageBox.Show("Bạn chưa chọn lớp học");
                return;
            }

            ChinhSuaLopUI();
        }

        private void ChinhSuaLopUI()
        {
            panelMain.VerticalScroll.Value = 0;

            panelCheDo.Visible = true;

            lblCheDo.Text = "Chế độ chỉnh sửa lớp học";

            txtSearchClass.Visible = false;

            panelDgvClass.Visible = false;

            txtTenLopHoc.Enabled = true;

            txtTongSoHocVien.Enabled = true;

            dateNgayBatDau.Enabled = true;

            comboboxMaGiaoVien.Enabled = true;

            txtSearchCourse.Visible = true;

            panelDgvKhoaHoc.Visible = true;

            panelLichHocCuaLop.Visible = true;

            panelLichHocMoi.Visible = false;

            panelLichHocMoiBtn.Visible = false;

            btnThemLopMoi.Visible = false;

            btnTaoLichHoc.Visible = false;

            btnChinhSuaLop.Visible = false;

            btnXoaLopHoc.Visible = false;

            btnLuuLopHoc.Visible = true;

            btnHuyLopHoc.Visible = true;
        }

        private void dgvCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetCourseDetails();
        }

        private void btnXoaLopHoc_Click(object sender, EventArgs e)
        {
            string malophoc = txtMaLopHoc.Text;

            if (malophoc.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn lớp học");
                return;
            }

            DataTable classAssignments = dataProcessor.GetDataTable($"select * from ClassAssignment where class_id = '{malophoc}'");

            if ( classAssignments.Rows.Count > 0 )
            {
                MessageBox.Show("Không thể xóa lớp có học viên");
                return;
            } 

            if (MessageBox.Show("Bạn có muốn xóa lớp học này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //dataProcessor.UpdateData($"delete from Schedule where class_id = '{malophoc}'");

                dataProcessor.UpdateData($"update Class set status = 'Inactive' where id = '{malophoc}'");
            }

            ResetDgvClass();
        }

        private void btnTaoLichHoc_Click(object sender, EventArgs e)
        {
            string malophoc = txtMaLopHoc.Text;

            if (malophoc.Length == 0 )
            {
                MessageBox.Show("Bạn chưa chọn lớp học");
                return;
            }

            LichHocMoiUI();
        }

        private void LichHocMoiUI()
        {
            panelMain.VerticalScroll.Value = 0;

            panelCheDo.Visible = true;

            lblCheDo.Text = "Chế độ thêm buổi học";

            txtSearchClass.Visible = false;

            panelDgvClass.Visible = false;

            txtTenLopHoc.Enabled = false;

            txtTongSoHocVien.Enabled = false;

            dateNgayBatDau.Enabled = false;

            comboboxMaGiaoVien.Enabled = false;

            txtSearchCourse.Visible = false;

            panelDgvKhoaHoc.Visible = false;

            panelLichHocCuaLop.Visible = false;

            panelLichHocMoi.Visible = true;

            txtPhongHoc.Text = "";

            dateGioBatDau.Value = DateTime.Now;

            checkBoxThu2.Checked = false;

            checkBoxThu3.Checked = false;

            checkBoxThu4.Checked = false;

            checkBoxThu5.Checked = false;

            checkBoxThu6.Checked = false;

            checkBoxThu7.Checked = false;

            checkBoxChuNhat.Checked = false;

            panelLichHocMoiBtn.Visible = false;

            btnThemLopMoi.Visible = false;

            btnTaoLichHoc.Visible = false;

            btnChinhSuaLop.Visible = false;

            btnXoaLopHoc.Visible = false;

            btnLuuLopHoc.Visible = true;

            btnHuyLopHoc.Visible = true;
        }

        private bool CreateLichHoc()
        {
            string malophoc = txtMaLopHoc.Text;

            string phonghoc = txtPhongHocMoi.Text;

            if (phonghoc.Length == 0)
            {
                MessageBox.Show("Phòng học không được để trống");
                return false;
            }

            string giobatdau = dateGioBatDauMoi.Value.Hour.ToString() + ":" + dateGioBatDauMoi.Value.Minute.ToString() + ":00";

            bool thu2 = checkBoxThu2.Checked;
            bool thu3 = checkBoxThu3.Checked;
            bool thu4 = checkBoxThu4.Checked;
            bool thu5 = checkBoxThu5.Checked;
            bool thu6 = checkBoxThu6.Checked;
            bool thu7 = checkBoxThu7.Checked;
            bool chunhat = checkBoxChuNhat.Checked;

            if (!thu2 && !thu3 && !thu4 && !thu5 && !thu6 && !thu7 && !chunhat)
            {
                MessageBox.Show("Bạn phải chọn ít nhất một thứ trong tuần");
                return false;
            }

            int sobuoihoc = int.Parse(txtSoBuoiHoc.Text);

            DateTime ngaybatdau = dateNgayBatDau.Value;

            Queue<DateTime> dates = new Queue<DateTime>();

            int datedayofweek = DayOfWeekToInt(ngaybatdau.DayOfWeek);

            if (thu2)
            {
                dates.Enqueue(ngaybatdau.AddDays(2 - datedayofweek));
            }

            if (thu3)
            {
                dates.Enqueue(ngaybatdau.AddDays(3 - datedayofweek));
            }

            if (thu4)
            {
                dates.Enqueue(ngaybatdau.AddDays(4 - datedayofweek));
            }

            if (thu5)
            {
                dates.Enqueue(ngaybatdau.AddDays(5 - datedayofweek));
            }

            if (thu6)
            {
                dates.Enqueue(ngaybatdau.AddDays(6 - datedayofweek));
            }

            if (thu7)
            {
                dates.Enqueue(ngaybatdau.AddDays(7 - datedayofweek));
            }

            if (chunhat)
            {
                dates.Enqueue(ngaybatdau.AddDays(1 - datedayofweek));
            }

            dataProcessor.UpdateData($"delete from Schedule where class_id = '{malophoc}'");

            while (sobuoihoc > 0)
            {
                DateTime currentDate = dates.Dequeue();

                dates.Enqueue(currentDate.AddDays(7));

                if (currentDate < ngaybatdau)
                {
                    continue;
                }

                dataProcessor.UpdateData($"insert into Schedule(class_id, session_date, start_time, room) values ('{malophoc}', '{currentDate.Year.ToString() + "-" + currentDate.Month.ToString() + "-" + currentDate.Day.ToString()}', '{giobatdau}', '{phonghoc}')");

                sobuoihoc--;
            }

            return true;
        }

        private int DayOfWeekToInt(DayOfWeek dayofweek)
        {
            switch (dayofweek)
            {
                case DayOfWeek.Sunday:
                    return 1;
                case DayOfWeek.Monday:
                    return 2;
                case DayOfWeek.Tuesday:
                    return 3;
                case DayOfWeek.Wednesday:
                    return 4;
                case DayOfWeek.Thursday:
                    return 5;
                case DayOfWeek.Friday:
                    return 6;
                case DayOfWeek.Saturday:
                    return 7;
                default:
                    return 0;
            }
        }

        private void btnChinhSuaBuoiHoc_Click(object sender, EventArgs e)
        {
            string mabuoihoc = txtMaBuoiHoc.Text;

            if (mabuoihoc.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn buổi học");
                return;
            }

            ChinhSuaLichHocUI();
        }

        private void ChinhSuaLichHocUI()
        {
            panelMain.VerticalScroll.Value = 0;

            panelCheDo.Visible = true;

            lblCheDo.Text = "Chế độ chỉnh sửa buổi học";

            txtSearchClass.Visible = false;

            panelDgvClass.Visible = false;

            txtTenLopHoc.Enabled = false;

            txtTongSoHocVien.Enabled = false;

            dateNgayBatDau.Enabled = false;

            comboboxMaGiaoVien.Enabled = false;

            txtSearchCourse.Visible = false;

            panelDgvKhoaHoc.Visible = false;

            panelLichHocCuaLop.Visible = true;

            panelDgvLichHoc.Visible = false;

            txtPhongHoc.Enabled = true;

            dateGioBatDau.Enabled = true;

            dateNgayHoc.Enabled = true;

            panelLichHocMoi.Visible = false;

            txtPhongHoc.Text = "";

            dateGioBatDau.Value = DateTime.Now;

            checkBoxThu2.Checked = false;

            checkBoxThu3.Checked = false;

            checkBoxThu4.Checked = false;

            checkBoxThu5.Checked = false;

            checkBoxThu6.Checked = false;

            checkBoxThu7.Checked = false;

            checkBoxChuNhat.Checked = false;

            panelLichHocMoiBtn.Visible = false;

            panelLopHocBtn.Visible = false;

            btnThemLopMoi.Visible = false;

            btnTaoLichHoc.Visible = false;

            btnChinhSuaLop.Visible = false;

            btnXoaLopHoc.Visible = false;

            btnLuuLopHoc.Visible = true;

            btnHuyLopHoc.Visible = true;

            btnChinhSuaBuoiHoc.Visible = false;

            btnLuuBuoiHoc.Visible = true;

            btnHuyBuoiHoc.Visible = true;
        }

        private void btnLuuBuoiHoc_Click(object sender, EventArgs e)
        {
            string phonghoc = txtPhongHoc.Text;

            if (phonghoc.Length == 0 )
            {
                MessageBox.Show("Phòng học không được để trống");
                return;
            }

            string giobatdau = dateGioBatDau.Value.Hour.ToString() + ":" + dateGioBatDau.Value.Minute.ToString() + ":00";

            string ngayhoc = dateNgayHoc.Value.Year.ToString() + "-" + dateNgayHoc.Value.Month.ToString() + "-" + dateNgayHoc.Value.Day.ToString();

            string mabuoihoc = txtMaBuoiHoc.Text;

            dataProcessor.UpdateData($"update Schedule set room = N'{phonghoc}', session_date = '{ngayhoc}', start_time = '{giobatdau}' where id = '{mabuoihoc}'");

            ResetDgvSchedule();

            XemLopUI();}

        private void btnHuyBuoiHoc_Click(object sender, EventArgs e)
        {
            ResetDgvSchedule();

            XemLopUI();
        }
    }
}
