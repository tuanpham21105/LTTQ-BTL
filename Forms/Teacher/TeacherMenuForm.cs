using Guna.UI2.WinForms;
using prj_LTTQ_BTL.Data;
using prj_LTTQ_BTL.Forms.Teacher;
using prj_LTTQ_BTL.Utils;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace prj_LTTQ_BTL.Teacher
{
    public partial class TeacherMenuForm : Form
    {
        DataProcessor dtBase = new DataProcessor();
        public TeacherMenuForm()
        {
            InitializeComponent();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string thu = now.ToString("dddd", new CultureInfo("vi-VN"));
            string ngay = now.ToString("dd/MM/yyyy");
            string gio = now.ToString("HH:mm:ss");
            lblTime.Text = $"{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(thu)}, {ngay}  {gio}";
        }

        private void TeacherMenuForm_Load(object sender, EventArgs e)
        {
            LoadScheduleToday();
            LoadTeachingClasses();
            LoadQuickStats();
            LoadRecentActivities();
            this.Resize += (s, e2) => AdjustFlowLayouts();
            try
            {
                string teacherId = GlobalData.Id;
                if (string.IsNullOrEmpty(teacherId)) return;

                string query = $@"
            SELECT full_name
            FROM Teacher
            WHERE id = '{teacherId}'";

                DataTable dt = dtBase.GetDataTable(query);
                if (dt.Rows.Count > 0)
                {
                    string name = dt.Rows[0]["full_name"].ToString();
                    lblHello.Text = $"Xin Chào, {name} ";
                }
                else
                {
                    lblHello.Text = "Xin Chào, Giáo viên ";
                }
            }
            catch (Exception ex)
            {
                lblHello.Text = "Chào: ";
                MessageBox.Show("Lỗi tải tên giáo viên: " + ex.Message);
            }
        }

        private void AdjustFlowLayouts()
        {
            ResizeFlowLayout(flowLichDay);
            ResizeFlowLayout(flowLopDangDay);
        }

        private void ResizeFlowLayout(FlowLayoutPanel flow)
        {
            foreach (Control ctrl in flow.Controls)
            {
                if (ctrl is Guna2Panel card)
                {
                    card.Width = flow.ClientSize.Width - 20;
                    foreach (Control child in card.Controls)
                    {
                        if (child is Guna2ProgressBar bar)
                            bar.Width = card.ClientSize.Width - 40;
                    }
                }
            }
        }

        // =================== LỊCH DẠY HÔM NAY ===================
        private void LoadScheduleToday()
        {
            try
            {
                flowLichDay.FlowDirection = FlowDirection.TopDown;
                flowLichDay.WrapContents = false;
                flowLichDay.AutoScroll = true;
                flowLichDay.Padding = new Padding(5);
                flowLichDay.BackColor = Color.White;

                string teacherId = GlobalData.Id;
                if (string.IsNullOrEmpty(teacherId)) return;

                string query = $@"
                    SELECT 
                        FORMAT(CAST(S.start_time AS DATETIME), 'HH:mm') AS start_time,
                        FORMAT(DATEADD(MINUTE, 90, CAST(S.start_time AS DATETIME)), 'HH:mm') AS end_time,
                        C.name AS class_name,
                        S.room
                    FROM Schedule S
                    JOIN Class C ON S.class_id = C.id
                    WHERE CAST(S.session_date AS DATE) = CAST(GETDATE() AS DATE)
                      AND C.teacher_id = '{teacherId}'
                    ORDER BY S.start_time";

                DataTable dt = dtBase.GetDataTable(query);
                flowLichDay.Controls.Clear();

                if (dt.Rows.Count == 0)
                {
                    Label lblEmpty = new Label()
                    {
                        Text = "Hôm nay bạn không có lịch dạy.",
                        AutoSize = true,
                        Font = new Font("Segoe UI", 10, FontStyle.Italic),
                        ForeColor = Color.Gray,
                        Dock = DockStyle.Top,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Padding = new Padding(0, 15, 0, 0)
                    };
                    flowLichDay.Controls.Add(lblEmpty);
                    return;
                }

                foreach (DataRow row in dt.Rows)
                {
                    string start = row["start_time"].ToString();
                    string end = row["end_time"].ToString();
                    string lop = row["class_name"].ToString();
                    string phong = row["room"].ToString();

                    bool isActive = false;
                    if (DateTime.TryParse(start, out DateTime tStart) && DateTime.TryParse(end, out DateTime tEnd))
                    {
                        var now = DateTime.Now.TimeOfDay;
                        isActive = now >= tStart.TimeOfDay && now <= tEnd.TimeOfDay;
                    }

                    AddScheduleCard(start, end, lop, phong, isActive);
                }

                flowLichDay.PerformLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lịch dạy: " + ex.Message);
            }
        }

        private void AddScheduleCard(string start, string end, string lop, string phong, bool isActive)
        {
            var card = new Guna2Panel()
            {
                BorderRadius = 6,
                Height = 36,
                Width = flowLichDay.ClientSize.Width - 25,
                Margin = new Padding(3, 2, 3, 2),
                FillColor = isActive ? GlobalData.primaryColor : Color.White,
                BorderColor = isActive ? Color.FromArgb(0, 90, 170) : Color.FromArgb(230, 230, 230),
                BorderThickness = 1,
                ShadowDecoration = { Enabled = true, Shadow = new Padding(2) },
                Cursor = Cursors.Hand
            };

            var lbl = new Label()
            {
                Text = $"{start} - {end} | {lop} | {phong}" + (isActive ? "   ⏰" : ""),
                Font = new Font("Segoe UI", 9.5f),
                ForeColor = isActive ? Color.White : GlobalData.textPrimary,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(10, 0, 0, 0)
            };

            card.MouseEnter += (s, e) =>
            {
                if (!isActive)
                {
                    card.FillColor = Color.FromArgb(240, 245, 255);
                    lbl.ForeColor = GlobalData.primaryColor;
                }
            };
            card.MouseLeave += (s, e) =>
            {
                if (!isActive)
                {
                    card.FillColor = Color.White;
                    lbl.ForeColor = GlobalData.textPrimary;
                }
            };

            card.Controls.Add(lbl);
            flowLichDay.Controls.Add(card);
        }

        // =================== LỚP ĐANG DẠY ===================
        private void LoadTeachingClasses()
        {
            try
            {
                flowLopDangDay.FlowDirection = FlowDirection.TopDown;
                flowLopDangDay.WrapContents = false;
                flowLopDangDay.AutoScroll = true;
                flowLopDangDay.Padding = new Padding(5);
                flowLopDangDay.BackColor = Color.White;
                flowLopDangDay.Controls.Clear();

                string teacherId = GlobalData.Id;
                if (string.IsNullOrEmpty(teacherId)) return;

                string query = $@"
                    SELECT 
                        C.name AS class_name,
                        COUNT(DISTINCT CA.student_id) AS total_students,
                        CAST(
                            (CAST(COUNT(DISTINCT S.id) AS FLOAT) / Cr.number_of_lessons) * 100 AS DECIMAL(5, 2)
                        ) AS completion_rate
                    FROM Class C
                    JOIN Course Cr ON C.course_id = Cr.id
                    LEFT JOIN Schedule S ON S.class_id = C.id AND S.session_date < GETDATE()
                    LEFT JOIN ClassAssignment CA ON CA.class_id = C.id
                    WHERE C.teacher_id = '{teacherId}'
                    GROUP BY C.name, Cr.number_of_lessons
                    ORDER BY C.name;";

                DataTable dt = dtBase.GetDataTable(query);

                if (dt.Rows.Count == 0)
                {
                    Label lbl = new Label()
                    {
                        Text = "Hiện bạn chưa phụ trách lớp nào.",
                        AutoSize = true,
                        Font = new Font("Segoe UI", 10, FontStyle.Italic),
                        ForeColor = Color.Gray
                    };
                    flowLopDangDay.Controls.Add(lbl);
                    return;
                }

                foreach (DataRow row in dt.Rows)
                {
                    string lop = row["class_name"].ToString();
                    int soHV = Convert.ToInt32(row["total_students"]);
                    decimal hoanthanh = Convert.ToDecimal(row["completion_rate"]);
                    if (hoanthanh > 100) hoanthanh = 100;

                    AddTeachingClassCard(lop, soHV, hoanthanh);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lớp học đang dạy: " + ex.Message);
            }
        }

        private void AddTeachingClassCard(string lop, int hocvien, decimal hoanthanh)
        {
            var card = new Guna2Panel()
            {
                BorderRadius = 6,
                Height = 45,
                Width = flowLopDangDay.ClientSize.Width - 25,
                Margin = new Padding(5, 3, 5, 3),
                FillColor = Color.White,
                BorderColor = Color.FromArgb(220, 220, 220),
                BorderThickness = 1
            };

            var lblClass = new Label()
            {
                Text = lop,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = GlobalData.primaryColor,
                Location = new Point(10, 10),
                AutoSize = true
            };

            var lblInfo = new Label()
            {
                Text = $"Học viên: {hocvien} | Hoàn thành: {hoanthanh:0}%",
                Font = new Font("Segoe UI", 9),
                ForeColor = GlobalData.textSecondary,
                Location = new Point(130, 12),
                AutoSize = true
            };

            var bar = new Guna2ProgressBar()
            {
                Width = flowLopDangDay.ClientSize.Width - 50,
                Height = 6,
                Location = new Point(10, 30),
                Value = (int)Math.Min(hoanthanh, 100),
                FillColor = Color.FromArgb(230, 230, 230),
                ProgressColor = GlobalData.primaryColor,
                BorderRadius = 3
            };

            card.Controls.Add(lblClass);
            card.Controls.Add(lblInfo);
            card.Controls.Add(bar);
            flowLopDangDay.Controls.Add(card);
        }

        // =================== THỐNG KÊ NHANH ===================
        private void LoadQuickStats()
        {
            try
            {
                string teacherId = GlobalData.Id;
                if (string.IsNullOrEmpty(teacherId)) return;

                string query = $@"
        DECLARE @TotalClasses INT;
        DECLARE @TotalStudents INT;
        DECLARE @TotalLessons INT;
        DECLARE @LessonsTaught INT;
        DECLARE @AttendanceRate FLOAT;

        SELECT @TotalClasses = COUNT(*) FROM Class WHERE teacher_id = '{teacherId}';

        SELECT @TotalStudents = COUNT(DISTINCT CA.student_id)
        FROM ClassAssignment CA
        WHERE CA.class_id IN (SELECT id FROM Class WHERE teacher_id = '{teacherId}');

        SELECT @TotalLessons = COUNT(*) 
        FROM Schedule S
        JOIN Class C ON S.class_id = C.id
        WHERE C.teacher_id = '{teacherId}'
          AND MONTH(S.session_date) = MONTH(GETDATE())
          AND YEAR(S.session_date) = YEAR(GETDATE());

        SELECT @LessonsTaught = COUNT(DISTINCT S.id)
        FROM Schedule S
        JOIN Class C ON S.class_id = C.id
        WHERE C.teacher_id = '{teacherId}'
          AND S.id IN (SELECT DISTINCT schedule_id FROM Attendance)
          AND MONTH(S.session_date) = MONTH(GETDATE())
          AND YEAR(S.session_date) = YEAR(GETDATE());

        SELECT @AttendanceRate = 
            CASE WHEN COUNT(*) = 0 THEN 0
                 ELSE CAST(SUM(CASE WHEN A.status = 'present' THEN 1 ELSE 0 END) * 100.0 / COUNT(*) AS DECIMAL(5,2))
            END
        FROM Attendance A
        JOIN Schedule S ON A.schedule_id = S.id
        JOIN Class C ON S.class_id = C.id
        WHERE C.teacher_id = '{teacherId}'
          AND MONTH(S.session_date) = MONTH(GETDATE())
          AND YEAR(S.session_date) = YEAR(GETDATE());

        SELECT 
            ISNULL(@TotalClasses, 0) AS total_classes,
            ISNULL(@TotalStudents, 0) AS total_students,
            ISNULL(@TotalLessons, 0) AS total_lessons,
            ISNULL(@LessonsTaught, 0) AS lessons_taught,
            ISNULL(@AttendanceRate, 0) AS attendance_rate;";

                DataTable dt = dtBase.GetDataTable(query);
                if (dt.Rows.Count == 0) return;

                DataRow row = dt.Rows[0];
                lbTongSoLop.Text = row["total_classes"].ToString();
                lbTongSoHocVien.Text = row["total_students"].ToString();
                lbGioDayThangNay.Text = $"{row["lessons_taught"]}/{row["total_lessons"]}";
                lbTiLeThamGia.Text = $"{Convert.ToDouble(row["attendance_rate"]):0}%";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thống kê nhanh: " + ex.Message);
            }
        }

        // =================== HOẠT ĐỘNG GẦN ĐÂY ===================
        private void LoadRecentActivities()
        {
            try
            {
                string teacherId = GlobalData.Id;
                if (string.IsNullOrEmpty(teacherId)) return;

                string query = $@"
        SELECT TOP 10 * FROM (
            SELECT 
                FORMAT(S.session_date, 'HH:mm dd/MM') AS time,
                N'🏫 Thêm buổi học lớp ' + C.name AS message
            FROM Schedule S
            JOIN Class C ON S.class_id = C.id
            WHERE C.teacher_id = '{teacherId}' AND S.session_date >= DATEADD(DAY, -30, GETDATE())

            UNION ALL
            SELECT 
                FORMAT(ATime.session_date, 'HH:mm dd/MM') AS time,
                N'📋 Điểm danh lớp ' + C.name AS message
            FROM Attendance A
            JOIN Schedule ATime ON A.schedule_id = ATime.id
            JOIN Class C ON ATime.class_id = C.id
            WHERE C.teacher_id = '{teacherId}' AND ATime.session_date >= DATEADD(DAY, -30, GETDATE())

            UNION ALL
            SELECT 
                FORMAT(CA.assigned_date, 'HH:mm dd/MM') AS time,
                N'👨‍🎓 Học viên mới vào lớp ' + C.name AS message
            FROM ClassAssignment CA
            JOIN Class C ON CA.class_id = C.id
            WHERE C.teacher_id = '{teacherId}' AND CA.assigned_date >= DATEADD(DAY, -30, GETDATE())
        ) AS AllActs
        ORDER BY time DESC;";

                DataTable dt = dtBase.GetDataTable(query);
                flowHoatDong.Controls.Clear();

                if (dt.Rows.Count == 0)
                {
                    Label lblEmpty = new Label()
                    {
                        Text = "Chưa có hoạt động nào gần đây.",
                        Font = new Font("Segoe UI", 10, FontStyle.Italic),
                        ForeColor = Color.Gray,
                        AutoSize = true,
                        Padding = new Padding(10)
                    };
                    flowHoatDong.Controls.Add(lblEmpty);
                    return;
                }

                Color blue = GlobalData.primaryColor;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string time = dt.Rows[i]["time"].ToString();
                    string msg = dt.Rows[i]["message"].ToString();
                    bool isLast = (i == dt.Rows.Count - 1);
                    AddActivity(time, msg, blue, isLast);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải hoạt động gần đây: " + ex.Message);
            }
        }

        private void AddActivity(string time, string message, Color color, bool isLast)
        {
            Panel item = new Panel()
            {
                Width = flowHoatDong.Width - 25,
                Height = 45,
                Margin = new Padding(5, 2, 5, 2),
                BackColor = Color.White
            };

            Guna2CircleButton dot = new Guna2CircleButton()
            {
                Size = new Size(10, 10),
                FillColor = color,
                Location = new Point(15, 10),
                ShadowDecoration = { Enabled = false }
            };

            Panel line = new Panel()
            {
                Width = 2,
                Height = isLast ? 0 : 35,
                BackColor = color,
                Location = new Point(dot.Left + dot.Width / 2 - 1, dot.Top + dot.Height + 2)
            };

            Label lbl = new Label()
            {
                Text = $"{time} | {message}",
                Location = new Point(35, 5),
                Font = new Font("Segoe UI", 9.5f),
                ForeColor = GlobalData.textPrimary,
                AutoSize = true
            };

            item.Controls.Add(dot);
            item.Controls.Add(line);
            item.Controls.Add(lbl);
            flowHoatDong.Controls.Add(item);
        }


        private void btnLopHoc_Click_1(object sender, EventArgs e)
        {
            FormUtils.OpenChildForm(PnMain, new Teacher_ClassForm());
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in PnMain.Controls.OfType<Form>().ToList())
            {
                ctrl.Dispose(); 
            }
            PnMain.Tag = null; 
            LoadScheduleToday();
            LoadTeachingClasses();
            LoadQuickStats();
            LoadRecentActivities();
        }

        private void btnHoSo_Click(object sender, EventArgs e)
        {
            FormUtils.OpenChildForm(PnMain, new Teacher_ProfileForm());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}
