using Guna.UI2.WinForms;
using System.Drawing;
using System.Windows.Forms;

namespace prj_LTTQ_BTL.Forms.Student
{
    partial class Student_ScheduleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            //
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
            int xOffset = 10;
            int columnWidth = 220;
            int headerHeight = 40;

            // 🔸 Panel cho từng ngày
            Guna2Panel dayColumn;
            dayColumn = new Guna2Panel();
            dayColumn.Width = columnWidth;
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

            int yOffset = 10;
            // 🔸 Card buổi học
            Guna2Panel cardPanel;
            cardPanel = new Guna2Panel();
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
            lblClass.Text = "Class Id";
            lblClass.Font = new Font("Segoe UI Semibold", 10);
            lblClass.ForeColor = textPrimary;
            lblClass.AutoSize = true;
            lblClass.Location = new Point(10, 10);
            lblClass.BackColor = Color.Transparent;
            cardPanel.Controls.Add(lblClass);

            // 🏫 Phòng học
            Label lblRoom;
            lblRoom = new Label();
            lblRoom.Text = "room";
            lblRoom.Font = new Font("Segoe UI", 9);
            lblRoom.ForeColor = textSecondary;
            lblRoom.AutoSize = true;
            lblRoom.Location = new Point(10, 40);
            lblRoom.BackColor = Color.Transparent;
            cardPanel.Controls.Add(lblRoom);

            // ⏰ Giờ bắt đầu
            Label lblTime;
            lblTime = new Label();
            lblTime.Text = "start_time";
            lblTime.Font = new Font("Segoe UI", 9);
            lblTime.ForeColor = textSecondary;
            lblTime.AutoSize = true;
            lblTime.Location = new Point(110, 40);
            lblTime.BackColor = Color.Transparent;
            cardPanel.Controls.Add(lblTime);

            yOffset += 100;

            xOffset += columnWidth + 20;

            // 🔹 Footer
            Label lblFooter;
            lblFooter = new Label();
            lblFooter.Text = "Kéo ngang để xem thêm ngày học →";
            lblFooter.Font = new Font("Segoe UI", 8, FontStyle.Italic);
            lblFooter.ForeColor = textSecondary;
            lblFooter.Dock = DockStyle.Bottom;
            lblFooter.Height = 25;
            lblFooter.TextAlign = ContentAlignment.MiddleRight;
            lblFooter.BackColor = Color.Transparent;
            panelMain.Controls.Add(lblFooter);
            // 
            // Student_ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Student_ScheduleForm";
            this.Text = "Student_ScheduleForm";
            this.Load += new System.EventHandler(this.Student_ScheduleForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}