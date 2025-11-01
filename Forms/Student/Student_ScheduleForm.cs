using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace prj_LTTQ_BTL.Forms.Student
{
    public partial class Student_ScheduleForm : Form
    {
        public Student_ScheduleForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            Color primaryColor = Color.FromArgb(0, 120, 215);
            Color secondaryColor = Color.FromArgb(43, 136, 216);
            Color backgroundColor = Color.FromArgb(243, 243, 243);
            Color cardColor = Color.FromArgb(255, 255, 255);
            Color textPrimary = Color.FromArgb(0, 0, 0);
            Color textSecondary = Color.FromArgb(85, 85, 85);
            Color dangerColor = Color.FromArgb(232, 17, 35);
            Color borderColor = Color.FromArgb(204, 204, 204);

            // 🔹 Panel chính
            Guna2Panel panelMain;
            panelMain = new Guna2Panel();
            panelMain.Dock = DockStyle.Fill;
            panelMain.BackColor = backgroundColor;
            panelMain.Padding = new Padding(20);
            this.Controls.Add(panelMain);

            // 🔹 Tiêu đề form
            Label lblHeader;
            lblHeader = new Label();
            lblHeader.Text = "📅 Thời khóa biểu học viên";
            lblHeader.Font = new Font("Segoe UI Semibold", 16, FontStyle.Bold);
            lblHeader.ForeColor = primaryColor;
            lblHeader.Dock = DockStyle.Top;
            lblHeader.Height = 50;
            lblHeader.TextAlign = ContentAlignment.MiddleLeft;
            lblHeader.BackColor = Color.Transparent;
            panelMain.Controls.Add(lblHeader);

            // 🔹 Panel chứa toàn bộ cột ngày (cuộn ngang)
            Guna2Panel panelScrollContainer;
            panelScrollContainer = new Guna2Panel();
            panelScrollContainer.Dock = DockStyle.Fill;
            panelScrollContainer.AutoScroll = true;
            panelScrollContainer.AutoScrollMinSize = new Size(800, 0);
            panelScrollContainer.BackColor = backgroundColor;
            panelScrollContainer.Padding = new Padding(10);
            panelScrollContainer.HorizontalScroll.Enabled = true;
            panelScrollContainer.HorizontalScroll.Visible = true;
            panelMain.Controls.Add(panelScrollContainer);

            // 🔹 Giả lập dữ liệu từ DB
            DataTable schedules = new DataTable();
            schedules.Columns.Add("class_id");
            schedules.Columns.Add("room");
            schedules.Columns.Add("session_date");
            schedules.Columns.Add("start_time");

            schedules.Rows.Add("ENG101", "A301", "2025-11-01", "08:00");
            schedules.Rows.Add("ENG102", "B202", "2025-11-01", "13:30");
            schedules.Rows.Add("ENG103", "C105", "2025-11-02", "09:45");
            schedules.Rows.Add("ENG104", "A201", "2025-11-03", "15:00");
            schedules.Rows.Add("ENG105", "D110", "2025-11-03", "10:30");
            schedules.Rows.Add("ENG106", "E101", "2025-11-04", "08:00");

            // 🔹 Lấy danh sách ngày học duy nhất
            var distinctDates = schedules.AsEnumerable()
            .Select(r => Convert.ToDateTime(r["session_date"]))
            .Distinct()
            .OrderBy(d => d)
            .ToList();

            // 🔹 Tạo layout ngang theo ngày
            int xOffset = 10;
            int columnWidth = 220;
            int headerHeight = 40;

            // 🔸 Panel cho từng ngày
            Guna2Panel dayColumn;
            dayColumn = new Guna2Panel();
            dayColumn.Width = columnWidth;
            dayColumn.Height = panelScrollContainer.Height - 40;
            dayColumn.BorderColor = borderColor;
            dayColumn.BorderThickness = 1;
            dayColumn.BorderRadius = 6;
            dayColumn.FillColor = cardColor;
            dayColumn.Location = new Point(xOffset, 10);
            dayColumn.Anchor = AnchorStyles.Top;
            dayColumn.Padding = new Padding(10);
            dayColumn.ShadowDecoration.Enabled = true;
            dayColumn.ShadowDecoration.Shadow = new Padding(2, 2, 4, 4);
            panelScrollContainer.Controls.Add(dayColumn);

            // 🔹 Label ngày học (Header)
            Label lblDayHeader;
            lblDayHeader = new Label();
            lblDayHeader.Text = "01/11/2025";
            lblDayHeader.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblDayHeader.ForeColor = primaryColor;
            lblDayHeader.BackColor = Color.Transparent;
            lblDayHeader.Dock = DockStyle.Top;
            lblDayHeader.Height = headerHeight;
            lblDayHeader.TextAlign = ContentAlignment.MiddleCenter;
            dayColumn.Controls.Add(lblDayHeader);

            // 🔹 Panel chứa các thẻ buổi học trong ngày
            Guna2Panel dayScheduleContainer;
            dayScheduleContainer = new Guna2Panel();
            dayScheduleContainer.Dock = DockStyle.Fill;
            dayScheduleContainer.AutoScroll = true;
            dayScheduleContainer.BackColor = Color.Transparent;
            dayScheduleContainer.Padding = new Padding(0, 5, 0, 5);
            dayColumn.Controls.Add(dayScheduleContainer);

            // 🔹 Lấy buổi học trong ngày
            var sessions = schedules.AsEnumerable()
                .Where(r => Convert.ToDateTime(r["session_date"]) == DateTime.Now)
                .OrderBy(r => r["start_time"])
                .ToList();

            int yOffset = 10;
            foreach (var session in sessions)
            {
                // 🔸 Card buổi học
                Guna2Panel cardPanel;
                cardPanel = new Guna2Panel();
                cardPanel.Width = dayColumn.Width - 30;
                cardPanel.Height = 90;
                cardPanel.BorderColor = borderColor;
                cardPanel.BorderThickness = 1;
                cardPanel.BorderRadius = 8;
                cardPanel.FillColor = cardColor;
                cardPanel.Location = new Point(5, yOffset);
                cardPanel.ShadowDecoration.Enabled = true;
                cardPanel.ShadowDecoration.Shadow = new Padding(2, 2, 4, 4);
                dayScheduleContainer.Controls.Add(cardPanel);

                // 📘 Mã lớp
                Label lblClass;
                lblClass = new Label();
                lblClass.Text = $"📘 {session["class_id"]}";
                lblClass.Font = new Font("Segoe UI Semibold", 10);
                lblClass.ForeColor = textPrimary;
                lblClass.AutoSize = true;
                lblClass.Location = new Point(10, 10);
                lblClass.BackColor = Color.Transparent;
                cardPanel.Controls.Add(lblClass);

                // 🏫 Phòng học
                Label lblRoom;
                lblRoom = new Label();
                lblRoom.Text = $"🏫 {session["room"]}";
                lblRoom.Font = new Font("Segoe UI", 9);
                lblRoom.ForeColor = textSecondary;
                lblRoom.AutoSize = true;
                lblRoom.Location = new Point(10, 40);
                lblRoom.BackColor = Color.Transparent;
                cardPanel.Controls.Add(lblRoom);

                // ⏰ Giờ bắt đầu
                Label lblTime;
                lblTime = new Label();
                lblTime.Text = $"⏰ {session["start_time"]}";
                lblTime.Font = new Font("Segoe UI", 9);
                lblTime.ForeColor = textSecondary;
                lblTime.AutoSize = true;
                lblTime.Location = new Point(110, 40);
                lblTime.BackColor = Color.Transparent;
                cardPanel.Controls.Add(lblTime);

                yOffset += 100;
            }

            xOffset += columnWidth + 20;

            // 🔹 Footer
            Label lblFooter;
            lblFooter = new Label();
            lblFooter.Text = "💡 Kéo ngang để xem thêm ngày học →";
            lblFooter.Font = new Font("Segoe UI", 8, FontStyle.Italic);
            lblFooter.ForeColor = textSecondary;
            lblFooter.Dock = DockStyle.Bottom;
            lblFooter.Height = 25;
            lblFooter.TextAlign = ContentAlignment.MiddleRight;
            lblFooter.BackColor = Color.Transparent;
            panelMain.Controls.Add(lblFooter);
        }

        private void Student_ScheduleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
