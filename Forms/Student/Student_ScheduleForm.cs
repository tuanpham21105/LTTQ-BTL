using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;
using AntdUI;
using System.Windows.Forms;
using Label = AntdUI.Label;
using System.Globalization;
using prj_LTTQ_BTL.Data;
using System.Web.UI.WebControls;

namespace prj_LTTQ_BTL.Forms.Student
{
    public partial class Student_ScheduleForm : Form
    {
        private DataProcessor dataProcessor = new DataProcessor();
        private DataTable allSchedule;
        public Student_ScheduleForm()
        {
            InitializeComponent();
        }

        private void Student_ScheduleForm_Load(object sender, EventArgs e)
        {
            allSchedule = dataProcessor.GetDataTable(
                $"select sc.* " +
                $"from Schedule sc " +
                $"inner join ClassAssignment ca " +
                $"on sc.class_id = ca.class_id " +
                $"inner join Student st " +
                $"on st.id = ca.student_id" +
                $" where st.id = '{GlobalData.Id}'"
            );

            SetWeekSchedule(DateTime.Now);
        }

        private void SetWeekSchedule(DateTime date)
        {
            List<DateTime> weekDates = GetWeekDates(date);

            lblStartDate.Text = weekDates[0].Day.ToString() + "/" + weekDates[0].Month.ToString() + "/" + weekDates[0].Year.ToString();
            lblEndDate.Text = weekDates[6].Day.ToString() + "/" + weekDates[6].Month.ToString() + "/" + weekDates[6].Year.ToString();

            SetCardDate(lblDate1, weekDates[0]);
            SetCardDate(lblDate2, weekDates[1]);
            SetCardDate(lblDate3, weekDates[2]);
            SetCardDate(lblDate4, weekDates[3]);
            SetCardDate(lblDate5, weekDates[4]);
            SetCardDate(lblDate6, weekDates[5]);
            SetCardDate(lblDate7, weekDates[6]);

            SetSchedulesPanel(weekDates[0], panelSchedules1);
            SetSchedulesPanel(weekDates[1], panelSchedules2);
            SetSchedulesPanel(weekDates[2], panelSchedules3);
            SetSchedulesPanel(weekDates[3], panelSchedules4);
            SetSchedulesPanel(weekDates[4], panelSchedules5);
            SetSchedulesPanel(weekDates[5], panelSchedules6);
            SetSchedulesPanel(weekDates[6], panelSchedules7);

        }

        private void SetCardDate(AntdUI.Label label, DateTime date)
        {
            label.Text = date.DayOfWeek.ToString() + ", " + date.Day.ToString() + "/" + date.Month.ToString() +"/" + date.Year.ToString();
        }

        private void SetScheduleCard(string lophoc, string giobatdau, string phonghoc, string trangthai, string note, Guna2Panel parentPanel)
        {
            Label lblLopHoc = new Label();
            Label lblGioBatDau = new Label();
            Label lblPhong = new Label();
            Label lblTrangThai = new Label();
            Label lblNote = new Label();
            Guna2Panel cardPanel = new Guna2Panel();
            // 
            // cardPanel
            // 
            cardPanel.AutoSize = true;
            cardPanel.BackColor = System.Drawing.Color.Transparent;
            cardPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            cardPanel.BorderRadius = 10;
            cardPanel.BorderThickness = 2;
            cardPanel.Dock = System.Windows.Forms.DockStyle.Top;
            cardPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            cardPanel.Location = new System.Drawing.Point(0, 0);
            cardPanel.Padding = new System.Windows.Forms.Padding(10);
            cardPanel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 4, 4);
            cardPanel.Size = new System.Drawing.Size(200, 127);
            cardPanel.TabIndex = 4;
            // 
            // lblLopHoc
            // 
            lblLopHoc.Dock = System.Windows.Forms.DockStyle.Top;
            lblLopHoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblLopHoc.Location = new System.Drawing.Point(10, 10);
            lblLopHoc.Size = new System.Drawing.Size(180, 53);
            lblLopHoc.TabIndex = 0;
            lblLopHoc.Text = lophoc;
            lblLopHoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGioBatDau
            // 
            lblGioBatDau.AutoSizeMode = AntdUI.TAutoSize.Height;
            lblGioBatDau.Dock = System.Windows.Forms.DockStyle.Top;
            lblGioBatDau.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblGioBatDau.Location = new System.Drawing.Point(10, 63);
            lblGioBatDau.Size = new System.Drawing.Size(180, 18);
            lblGioBatDau.TabIndex = 1;
            lblGioBatDau.Text = giobatdau;
            lblGioBatDau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhong
            // 
            lblPhong.AutoSizeMode = AntdUI.TAutoSize.Height;
            lblPhong.Dock = System.Windows.Forms.DockStyle.Top;
            lblPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPhong.Location = new System.Drawing.Point(10, 81);
            lblPhong.Size = new System.Drawing.Size(180, 18);
            lblPhong.TabIndex = 2;
            lblPhong.Text = phonghoc;
            lblPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNote
            // 
            lblNote.AutoSizeMode = AntdUI.TAutoSize.Height;
            lblNote.Dock = System.Windows.Forms.DockStyle.Top;
            lblNote.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNote.Location = new System.Drawing.Point(10, 99);
            lblNote.Size = new System.Drawing.Size(180, 18);
            lblNote.TabIndex = 3;
            lblNote.Text = note;
            lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSizeMode = AntdUI.TAutoSize.Height;
            lblTrangThai.Dock = System.Windows.Forms.DockStyle.Top;
            lblTrangThai.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTrangThai.Location = new System.Drawing.Point(10, 99);
            lblTrangThai.Size = new System.Drawing.Size(180, 18);
            lblTrangThai.TabIndex = 3;
            lblTrangThai.Text = trangthai;
            lblTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            switch (trangthai)
            {
                case "present":
                    lblTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(255)))), ((int)(((byte)(193)))));
                    break;
                case "absent":
                    lblTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
                    break;
                case "late":
                    lblTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(168)))));
                    break;
                case "excused":
                    lblTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
                    break;
                case "Chưa học":
                    lblTrangThai.BackColor = Color.Transparent;
                    break;
            }

            parentPanel.Controls.Add(cardPanel);
            cardPanel.Controls.Add(lblNote);
            cardPanel.Controls.Add(lblTrangThai);
            cardPanel.Controls.Add(lblPhong);
            cardPanel.Controls.Add(lblGioBatDau);
            cardPanel.Controls.Add(lblLopHoc);
        }

        private void SetSchedulesPanel(DateTime date, Guna2Panel schedulesPanel)
        {
            DataTable day = FilterByDate(allSchedule, date);

            schedulesPanel.Controls.Clear();

            if (day.Rows.Count > 0)
            {
                foreach (DataRow row in day.Rows)
                {
                    string lophoc = dataProcessor.GetDataTable($"select name from Class where id = '{row["class_id"].ToString()}'").Rows[0]["name"].ToString();
                    DataTable diemdanh = dataProcessor.GetDataTable($"select status, note from Attendance at where at.schedule_id = '{row["id"].ToString()}'");
                    string trangthai;
                    string note;
                    if (diemdanh.Rows.Count > 0)
                    {
                        trangthai = diemdanh.Rows[0]["status"].ToString();
                        note = diemdanh.Rows[0]["note"].ToString();
                    }
                    else
                    {
                        trangthai = "Chưa học";
                        note = "Không có";
                    }
                    SetScheduleCard(lophoc, row["start_time"].ToString(), row["room"].ToString(), trangthai, note, schedulesPanel);
                }
            }
        }

        private static List<DateTime> GetWeekDates(DateTime inputDate)
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            int diff = (7 + (inputDate.DayOfWeek - DayOfWeek.Monday)) % 7;

            DateTime weekStart = inputDate.AddDays(-diff).Date;

            List<DateTime> weekDates = new List<DateTime>();
            for (int i = 0; i < 7; i++)
            {
                weekDates.Add(weekStart.AddDays(i));
            }

            return weekDates;
        }

        public static DataTable FilterByDate(DataTable table, DateTime targetDate)
        {
            // Giữ nguyên ngày, bỏ phần giờ phút giây
            DateTime targetDay = targetDate.Date;

            // Tạo bản sao cấu trúc DataTable ban đầu
            DataTable filtered = table.Clone();

            // Lọc từng row theo ngày
            var rows = table.AsEnumerable()
                            .Where(r =>
                            {
                                if (DateTime.TryParse(r["session_date"].ToString(), out DateTime d))
                                    return d.Date == targetDay;
                                return false;
                            });

            // Copy lại các row trùng
            foreach (var row in rows)
                filtered.ImportRow(row);

            return filtered;
        }

        private void dateSchedule_ValueChanged(object sender, EventArgs e)
        {
            SetWeekSchedule(dateSchedule.Value);
        }
    }
}
