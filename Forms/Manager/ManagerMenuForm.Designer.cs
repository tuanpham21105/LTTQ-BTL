using System.Drawing;
using System.IO;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace prj_LTTQ_BTL.Forms.Manager
{
    partial class ManagerMenuForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMenuForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panelSideBar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAccount = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button16 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button11 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
            this.btnClass = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCourse = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTeacher = new Guna.UI2.WinForms.Guna2Button();
            this.panelStudent = new Guna.UI2.WinForms.Guna2Panel();
            this.btnStudentScore = new Guna.UI2.WinForms.Guna2Button();
            this.btnStudentAttendance = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnStudentList = new Guna.UI2.WinForms.Guna2Button();
            this.btnStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.panelBrand = new Guna.UI2.WinForms.Guna2Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.picBrand = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMaximize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.panelSideBar.SuspendLayout();
            this.panelStudent.SuspendLayout();
            this.panelBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBrand)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 12;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panelSideBar
            // 
            this.panelSideBar.AutoScroll = true;
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.panelSideBar.Controls.Add(this.btnAccount);
            this.panelSideBar.Controls.Add(this.guna2Button16);
            this.panelSideBar.Controls.Add(this.guna2Button11);
            this.panelSideBar.Controls.Add(this.guna2Button9);
            this.panelSideBar.Controls.Add(this.btnClass);
            this.panelSideBar.Controls.Add(this.guna2Panel3);
            this.panelSideBar.Controls.Add(this.btnCourse);
            this.panelSideBar.Controls.Add(this.guna2Panel2);
            this.panelSideBar.Controls.Add(this.btnTeacher);
            this.panelSideBar.Controls.Add(this.panelStudent);
            this.panelSideBar.Controls.Add(this.btnStudent);
            this.panelSideBar.Controls.Add(this.btnDashboard);
            this.panelSideBar.Controls.Add(this.panelBrand);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Padding = new System.Windows.Forms.Padding(20, 25, 20, 25);
            this.panelSideBar.ShadowDecoration.Depth = 10;
            this.panelSideBar.ShadowDecoration.Enabled = true;
            this.panelSideBar.Size = new System.Drawing.Size(425, 920);
            this.panelSideBar.TabIndex = 2;
            // 
            // btnAccount
            // 
            this.btnAccount.BorderRadius = 8;
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FillColor = System.Drawing.Color.Transparent;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnAccount.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAccount.Location = new System.Drawing.Point(20, 904);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(0, 18, 0, 18);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnAccount.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnAccount.Size = new System.Drawing.Size(359, 62);
            this.btnAccount.TabIndex = 31;
            this.btnAccount.Text = "Học viên";
            this.btnAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guna2Button16
            // 
            this.guna2Button16.BorderRadius = 8;
            this.guna2Button16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button16.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button16.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button16.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button16.ForeColor = System.Drawing.Color.White;
            this.guna2Button16.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.guna2Button16.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button16.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button16.Image")));
            this.guna2Button16.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button16.Location = new System.Drawing.Point(20, 842);
            this.guna2Button16.Margin = new System.Windows.Forms.Padding(0, 18, 0, 18);
            this.guna2Button16.Name = "guna2Button16";
            this.guna2Button16.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.guna2Button16.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.guna2Button16.Size = new System.Drawing.Size(359, 62);
            this.guna2Button16.TabIndex = 30;
            this.guna2Button16.Text = "Quản lý tài khoản";
            this.guna2Button16.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guna2Button11
            // 
            this.guna2Button11.BorderRadius = 8;
            this.guna2Button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button11.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button11.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button11.ForeColor = System.Drawing.Color.White;
            this.guna2Button11.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.guna2Button11.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button11.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button11.Image")));
            this.guna2Button11.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button11.Location = new System.Drawing.Point(20, 780);
            this.guna2Button11.Margin = new System.Windows.Forms.Padding(0, 18, 0, 18);
            this.guna2Button11.Name = "guna2Button11";
            this.guna2Button11.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.guna2Button11.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.guna2Button11.Size = new System.Drawing.Size(359, 62);
            this.guna2Button11.TabIndex = 28;
            this.guna2Button11.Text = "Tài chính";
            this.guna2Button11.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guna2Button9
            // 
            this.guna2Button9.BorderRadius = 8;
            this.guna2Button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button9.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button9.ForeColor = System.Drawing.Color.White;
            this.guna2Button9.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.guna2Button9.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button9.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button9.Image")));
            this.guna2Button9.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button9.Location = new System.Drawing.Point(20, 718);
            this.guna2Button9.Margin = new System.Windows.Forms.Padding(0, 18, 0, 18);
            this.guna2Button9.Name = "guna2Button9";
            this.guna2Button9.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.guna2Button9.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.guna2Button9.Size = new System.Drawing.Size(359, 62);
            this.guna2Button9.TabIndex = 26;
            this.guna2Button9.Text = "Lịch học";
            this.guna2Button9.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnClass
            // 
            this.btnClass.BorderRadius = 8;
            this.btnClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClass.FillColor = System.Drawing.Color.Transparent;
            this.btnClass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClass.ForeColor = System.Drawing.Color.White;
            this.btnClass.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnClass.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnClass.Image = ((System.Drawing.Image)(resources.GetObject("btnClass.Image")));
            this.btnClass.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClass.Location = new System.Drawing.Point(20, 656);
            this.btnClass.Margin = new System.Windows.Forms.Padding(0, 18, 0, 18);
            this.btnClass.Name = "btnClass";
            this.btnClass.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnClass.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnClass.Size = new System.Drawing.Size(359, 62);
            this.btnClass.TabIndex = 24;
            this.btnClass.Text = "Lớp học";
            this.btnClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.AutoSize = true;
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(20, 656);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.guna2Panel3.Size = new System.Drawing.Size(359, 0);
            this.guna2Panel3.TabIndex = 22;
            // 
            // btnCourse
            // 
            this.btnCourse.BorderRadius = 8;
            this.btnCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCourse.FillColor = System.Drawing.Color.Transparent;
            this.btnCourse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCourse.ForeColor = System.Drawing.Color.White;
            this.btnCourse.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnCourse.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnCourse.Image")));
            this.btnCourse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCourse.Location = new System.Drawing.Point(20, 594);
            this.btnCourse.Margin = new System.Windows.Forms.Padding(0, 18, 0, 18);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnCourse.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnCourse.Size = new System.Drawing.Size(359, 62);
            this.btnCourse.TabIndex = 21;
            this.btnCourse.Text = "Khóa học";
            this.btnCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.AutoSize = true;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(20, 594);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.guna2Panel2.Size = new System.Drawing.Size(359, 0);
            this.guna2Panel2.TabIndex = 20;
            // 
            // btnTeacher
            // 
            this.btnTeacher.BorderRadius = 8;
            this.btnTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeacher.FillColor = System.Drawing.Color.Transparent;
            this.btnTeacher.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTeacher.ForeColor = System.Drawing.Color.White;
            this.btnTeacher.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnTeacher.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnTeacher.Image = ((System.Drawing.Image)(resources.GetObject("btnTeacher.Image")));
            this.btnTeacher.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTeacher.Location = new System.Drawing.Point(20, 532);
            this.btnTeacher.Margin = new System.Windows.Forms.Padding(0, 18, 0, 18);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnTeacher.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnTeacher.Size = new System.Drawing.Size(359, 62);
            this.btnTeacher.TabIndex = 19;
            this.btnTeacher.Text = "Giáo viên";
            this.btnTeacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panelStudent
            // 
            this.panelStudent.AutoSize = true;
            this.panelStudent.Controls.Add(this.btnStudentScore);
            this.panelStudent.Controls.Add(this.btnStudentAttendance);
            this.panelStudent.Controls.Add(this.guna2Button3);
            this.panelStudent.Controls.Add(this.guna2Button2);
            this.panelStudent.Controls.Add(this.btnStudentList);
            this.panelStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStudent.Location = new System.Drawing.Point(20, 274);
            this.panelStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panelStudent.Size = new System.Drawing.Size(359, 258);
            this.panelStudent.TabIndex = 18;
            this.panelStudent.Visible = false;
            // 
            // btnStudentScore
            // 
            this.btnStudentScore.BorderRadius = 8;
            this.btnStudentScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentScore.FillColor = System.Drawing.Color.Transparent;
            this.btnStudentScore.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStudentScore.ForeColor = System.Drawing.Color.White;
            this.btnStudentScore.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnStudentScore.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnStudentScore.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStudentScore.Location = new System.Drawing.Point(30, 196);
            this.btnStudentScore.Margin = new System.Windows.Forms.Padding(0, 18, 0, 18);
            this.btnStudentScore.Name = "btnStudentScore";
            this.btnStudentScore.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnStudentScore.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnStudentScore.Size = new System.Drawing.Size(329, 62);
            this.btnStudentScore.TabIndex = 22;
            this.btnStudentScore.Text = "Điểm số học viên";
            this.btnStudentScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStudentScore.Click += new System.EventHandler(this.btnStudentScore_Click);
            // 
            // btnStudentAttendance
            // 
            this.btnStudentAttendance.BorderRadius = 8;
            this.btnStudentAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentAttendance.FillColor = System.Drawing.Color.Transparent;
            this.btnStudentAttendance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStudentAttendance.ForeColor = System.Drawing.Color.White;
            this.btnStudentAttendance.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnStudentAttendance.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnStudentAttendance.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStudentAttendance.Location = new System.Drawing.Point(30, 147);
            this.btnStudentAttendance.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.btnStudentAttendance.Name = "btnStudentAttendance";
            this.btnStudentAttendance.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnStudentAttendance.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnStudentAttendance.Size = new System.Drawing.Size(329, 49);
            this.btnStudentAttendance.TabIndex = 21;
            this.btnStudentAttendance.Text = "Ghi danh trong buổi";
            this.btnStudentAttendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 8;
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.guna2Button3.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.Location = new System.Drawing.Point(30, 98);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.guna2Button3.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.guna2Button3.Size = new System.Drawing.Size(329, 49);
            this.guna2Button3.TabIndex = 20;
            this.guna2Button3.Text = "Ghi danh trong lớp";
            this.guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 8;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.guna2Button2.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.Location = new System.Drawing.Point(30, 49);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.guna2Button2.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.guna2Button2.Size = new System.Drawing.Size(329, 49);
            this.guna2Button2.TabIndex = 19;
            this.guna2Button2.Text = "Ghi danh trong buổi học";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnStudentList
            // 
            this.btnStudentList.BorderRadius = 8;
            this.btnStudentList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentList.FillColor = System.Drawing.Color.Transparent;
            this.btnStudentList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStudentList.ForeColor = System.Drawing.Color.White;
            this.btnStudentList.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnStudentList.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnStudentList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStudentList.Location = new System.Drawing.Point(30, 0);
            this.btnStudentList.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.btnStudentList.Name = "btnStudentList";
            this.btnStudentList.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnStudentList.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnStudentList.Size = new System.Drawing.Size(329, 49);
            this.btnStudentList.TabIndex = 18;
            this.btnStudentList.Text = "Danh sách học viên";
            this.btnStudentList.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnStudent
            // 
            this.btnStudent.BorderRadius = 8;
            this.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudent.FillColor = System.Drawing.Color.Transparent;
            this.btnStudent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStudent.ForeColor = System.Drawing.Color.White;
            this.btnStudent.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnStudent.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnStudent.Image")));
            this.btnStudent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStudent.Location = new System.Drawing.Point(20, 212);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnStudent.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnStudent.Size = new System.Drawing.Size(359, 62);
            this.btnStudent.TabIndex = 17;
            this.btnStudent.Text = "Học viên";
            this.btnStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BorderRadius = 8;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FillColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnDashboard.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.Location = new System.Drawing.Point(20, 150);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnDashboard.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnDashboard.Size = new System.Drawing.Size(359, 62);
            this.btnDashboard.TabIndex = 16;
            this.btnDashboard.Text = "Thống kê";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panelBrand
            // 
            this.panelBrand.BackColor = System.Drawing.Color.Transparent;
            this.panelBrand.Controls.Add(this.lblBrand);
            this.panelBrand.Controls.Add(this.picBrand);
            this.panelBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBrand.Location = new System.Drawing.Point(20, 25);
            this.panelBrand.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelBrand.Name = "panelBrand";
            this.panelBrand.Padding = new System.Windows.Forms.Padding(12, 25, 12, 25);
            this.panelBrand.Size = new System.Drawing.Size(359, 125);
            this.panelBrand.TabIndex = 0;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(75, 25);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(173, 54);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "OwlEng";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picBrand
            // 
            this.picBrand.BackColor = System.Drawing.Color.Transparent;
            this.picBrand.Cursor = System.Windows.Forms.Cursors.Default;
            this.picBrand.Dock = System.Windows.Forms.DockStyle.Left;
            this.picBrand.FillColor = System.Drawing.Color.Transparent;
            this.picBrand.Image = ((System.Drawing.Image)(resources.GetObject("picBrand.Image")));
            this.picBrand.ImageRotate = 0F;
            this.picBrand.Location = new System.Drawing.Point(12, 25);
            this.picBrand.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.picBrand.Name = "picBrand";
            this.picBrand.Size = new System.Drawing.Size(63, 75);
            this.picBrand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBrand.TabIndex = 1;
            this.picBrand.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.AutoSize = true;
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panelHeader.BorderThickness = 1;
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Controls.Add(this.btnMaximize);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(425, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1113, 38);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMinimize.BorderThickness = 1;
            this.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimize.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.Location = new System.Drawing.Point(942, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(57, 38);
            this.btnMinimize.TabIndex = 0;
            // 
            // btnMaximize
            // 
            this.btnMaximize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMaximize.BorderThickness = 1;
            this.btnMaximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FillColor = System.Drawing.Color.Transparent;
            this.btnMaximize.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnMaximize.IconColor = System.Drawing.Color.Black;
            this.btnMaximize.Location = new System.Drawing.Point(999, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(57, 38);
            this.btnMaximize.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnClose.HoverState.IconColor = System.Drawing.Color.White;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(1056, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 38);
            this.btnClose.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(251, 38);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "🧑‍💼Manager Menu";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelMain
            // 
            this.panelMain.AutoSize = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(425, 38);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(12, 15, 12, 15);
            this.panelMain.Size = new System.Drawing.Size(1113, 882);
            this.panelMain.TabIndex = 0;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // ManagerMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1538, 920);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Name = "ManagerMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Menu";
            this.Load += new System.EventHandler(this.ManagerMenuForm_Load);
            this.panelSideBar.ResumeLayout(false);
            this.panelSideBar.PerformLayout();
            this.panelStudent.ResumeLayout(false);
            this.panelBrand.ResumeLayout(false);
            this.panelBrand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBrand)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private Guna.UI2.WinForms.Guna2Panel panelSideBar;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox btnMaximize;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2Panel panelBrand;
        private Guna.UI2.WinForms.Guna2PictureBox picBrand;
        private System.Windows.Forms.Label lblBrand;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnStudent;
        private Guna.UI2.WinForms.Guna2Panel panelStudent;
        private Guna.UI2.WinForms.Guna2Button btnStudentList;
        private Guna.UI2.WinForms.Guna2Button btnStudentAttendance;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button btnCourse;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnTeacher;
        private Guna.UI2.WinForms.Guna2Button btnClass;
        private Guna.UI2.WinForms.Guna2Button guna2Button11;
        private Guna.UI2.WinForms.Guna2Button guna2Button9;
        private Guna.UI2.WinForms.Guna2Button btnStudentScore;
        private Guna.UI2.WinForms.Guna2Button guna2Button16;
        private Guna.UI2.WinForms.Guna2Button btnAccount;
    }
}