using Guna.UI2.WinForms;
using prj_LTTQ_BTL.Data;
using prj_LTTQ_BTL.Utils;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace prj_LTTQ_BTL.Forms.Teacher
{
    public partial class Teacher_ClassForm : Form
    {
        private readonly DataProcessor dtBase = new DataProcessor();

        public Teacher_ClassForm()
        {
            InitializeComponent();
        }

        private void Teacher_ClassForm_Load(object sender, EventArgs e)
        {
            LoadClassCards();
        }

        // ====================== LOAD DANH SÁCH LỚP ======================
        private void LoadClassCards()
        {
            flowLayoutPanel1.Controls.Clear();

            string query = @"
                SELECT 
                    C.id AS ClassId,
                    C.name AS ClassName,
                    CR.name AS CourseName,
                    ISNULL(T.full_name, N'Chưa phân công') AS TeacherName,
                    CONVERT(VARCHAR(10), C.start_date, 103) AS StartDate,
                    COUNT(CA.student_id) AS StudentCount,
                    CASE 
                        WHEN C.start_date > GETDATE() THEN N'Chưa bắt đầu'
                        WHEN C.start_date <= GETDATE() THEN N'Đang học'
                        ELSE N'Đã kết thúc'
                    END AS TrangThai
                FROM Class C
                INNER JOIN Course CR ON C.course_id = CR.id
                LEFT JOIN Teacher T ON C.teacher_id = T.id
                LEFT JOIN ClassAssignment CA ON CA.class_id = C.id
                GROUP BY C.id, C.name, CR.name, C.start_date, T.full_name
                ORDER BY C.start_date DESC;";

            DataTable dt = dtBase.GetDataTable(query);

            if (dt.Rows.Count == 0)
            {
                Label lblNoData = new Label
                {
                    Text = "Không có lớp học nào để hiển thị.",
                    Font = new Font("Segoe UI", 12, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    AutoSize = true,
                    Margin = new Padding(20)
                };
                flowLayoutPanel1.Controls.Add(lblNoData);
                return;
            }

            foreach (DataRow row in dt.Rows)
            {
                string classId = row["ClassId"].ToString();
                string tenLop = row["ClassName"].ToString();
                string monHoc = row["CourseName"].ToString();
                string gv = row["TeacherName"].ToString();
                string ngayBD = row["StartDate"].ToString();
                int soHV = Convert.ToInt32(row["StudentCount"]);
                string trangThai = row["TrangThai"].ToString().Trim();

                Color statusColor;
                switch (trangThai)
                {
                    case "Đang học":
                        statusColor = Color.LimeGreen;
                        break;
                    case "Chưa bắt đầu":
                        statusColor = Color.Orange;
                        break;
                    case "Đã kết thúc":
                        statusColor = Color.Red;
                        break;
                    default:
                        statusColor = Color.Gray;
                        break;
                }


                // 🟦 Card lớp học
                var card = new Guna2Panel
                {
                    Size = new Size(300, 160),
                    BorderRadius = 12,
                    FillColor = Color.White,
                    ShadowDecoration = { Enabled = true },
                    Margin = new Padding(20),
                    Cursor = Cursors.Hand
                };

                // 📘 Tên lớp
                var lblName = new Label
                {
                    Text = tenLop,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    Location = new Point(15, 10),
                    AutoSize = true
                };

                // 🧾 Môn học
                var lblSubject = new Label
                {
                    Text = monHoc,
                    Font = new Font("Segoe UI", 10, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    Location = new Point(15, 35),
                    AutoSize = true
                };

                // 👨‍🏫 Giáo viên
                var lblTeacher = new Label
                {
                    Text = $"👨‍🏫 GV: {gv}",
                    Font = new Font("Segoe UI", 9),
                    Location = new Point(15, 60),
                    AutoSize = true
                };

                // 🗓 Ngày bắt đầu
                var lblDate = new Label
                {
                    Text = $"📅 Bắt đầu: {ngayBD}",
                    Font = new Font("Segoe UI", 9),
                    Location = new Point(15, 80),
                    AutoSize = true
                };

                // 👥 Số học viên
                var lblCount = new Label
                {
                    Text = $"👥 Số HV: {soHV}",
                    Font = new Font("Segoe UI", 9),
                    Location = new Point(15, 100),
                    AutoSize = true
                };

                // 🔵 Chấm trạng thái
                var dot = new Guna2CircleButton
                {
                    Size = new Size(12, 12),
                    FillColor = statusColor,
                    Location = new Point(15, 125),
                    BackColor = Color.Transparent,
                    UseTransparentBackground = true,
                    Enabled = false,
                    DisabledState = { FillColor = statusColor, BorderColor = statusColor },
                    ShadowDecoration = { Enabled = false }
                };

                var lblStatus = new Label
                {
                    Text = trangThai,
                    Font = new Font("Segoe UI", 9),
                    Location = new Point(30, 122),
                    AutoSize = true
                };

                // 🧩 Gắn control vào card
                card.Controls.Add(lblName);
                card.Controls.Add(lblSubject);
                card.Controls.Add(lblTeacher);
                card.Controls.Add(lblDate);
                card.Controls.Add(lblCount);
                card.Controls.Add(dot);
                card.Controls.Add(lblStatus);

                // 🔗 Khi click card → mở chi tiết lớp
                card.Click += (s, e) =>
                {
                    var detailForm = new Teacher_ClassDetailForm(classId, tenLop);
                    FormUtils.OpenChildForm(guna2Panelmain, detailForm);
                };

                flowLayoutPanel1.Controls.Add(card);
                flowLayoutPanel1.AutoScroll = true;       
                flowLayoutPanel1.WrapContents = true;     

            }
        }
    }
}
