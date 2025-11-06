using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AntdUI;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using prj_LTTQ_BTL.Data;
using static System.Net.Mime.MediaTypeNames;
using Label = AntdUI.Label;

namespace prj_LTTQ_BTL.Forms.Student
{
    partial class StudentMenuForm
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

        private readonly Color primaryColor = GlobalData.primaryColor;
        private readonly Color secondaryColor = GlobalData.secondaryColor;
        private readonly Color backgroundColor = GlobalData.backgroundColor;
        private readonly Color cardColor = GlobalData.cardColor;
        private readonly Color textPrimary = GlobalData.textPrimary;
        private readonly Color textSecondary = GlobalData.textSecondary;
        private readonly Color dangerColor = GlobalData.dangerColor;
        private readonly Color borderColor = GlobalData.borderColor;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMenuForm));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.borderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblXinChao = new AntdUI.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMaximize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnTest = new Guna.UI2.WinForms.Guna2Button();
            this.btnHP = new Guna.UI2.WinForms.Guna2Button();
            this.btnDiemSo = new Guna.UI2.WinForms.Guna2Button();
            this.btnLichHoc = new Guna.UI2.WinForms.Guna2Button();
            this.btnLH = new Guna.UI2.WinForms.Guna2Button();
            this.btnKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnTTHV = new Guna.UI2.WinForms.Guna2Button();
            this.brandPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblBrand = new AntdUI.Label();
            this.picBrand = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelHeader.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSidebar.SuspendLayout();
            this.brandPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBrand)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // borderlessForm
            // 
            this.borderlessForm.BorderRadius = 12;
            this.borderlessForm.ContainerControl = this;
            this.borderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.borderlessForm.TransparentWhileDrag = true;
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.AutoSize = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(210, 25);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(8);
            this.panelMain.Size = new System.Drawing.Size(814, 599);
            this.panelMain.TabIndex = 0;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // panelHeader
            // 
            this.panelHeader.AutoSize = true;
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panelHeader.BorderThickness = 1;
            this.panelHeader.Controls.Add(this.guna2Panel1);
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Controls.Add(this.btnMaximize);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(210, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(814, 25);
            this.panelHeader.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.lblXinChao);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(712, 25);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblXinChao
            // 
            this.lblXinChao.AutoSizeMode = AntdUI.TAutoSize.Width;
            this.lblXinChao.BackColor = System.Drawing.Color.Transparent;
            this.lblXinChao.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblXinChao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXinChao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lblXinChao.Location = new System.Drawing.Point(30, 0);
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblXinChao.Size = new System.Drawing.Size(65, 25);
            this.lblXinChao.TabIndex = 23;
            this.lblXinChao.Text = "Xin chào";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
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
            this.btnMinimize.Location = new System.Drawing.Point(712, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(34, 25);
            this.btnMinimize.TabIndex = 1;
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
            this.btnMaximize.Location = new System.Drawing.Point(746, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(34, 25);
            this.btnMaximize.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClose.BorderThickness = 1;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnClose.HoverState.IconColor = System.Drawing.Color.White;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(780, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 25);
            this.btnClose.TabIndex = 3;
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnTest);
            this.panelSidebar.Controls.Add(this.btnHP);
            this.panelSidebar.Controls.Add(this.btnDiemSo);
            this.panelSidebar.Controls.Add(this.btnLichHoc);
            this.panelSidebar.Controls.Add(this.btnLH);
            this.panelSidebar.Controls.Add(this.btnKH);
            this.panelSidebar.Controls.Add(this.btnTTHV);
            this.panelSidebar.Controls.Add(this.brandPanel);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(2);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.panelSidebar.ShadowDecoration.Depth = 10;
            this.panelSidebar.ShadowDecoration.Enabled = true;
            this.panelSidebar.Size = new System.Drawing.Size(210, 624);
            this.panelSidebar.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderRadius = 8;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnLogout.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.Location = new System.Drawing.Point(11, 571);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnLogout.Size = new System.Drawing.Size(188, 41);
            this.btnLogout.TabIndex = 24;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.Transparent;
            this.btnTest.BorderRadius = 8;
            this.btnTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTest.FillColor = System.Drawing.Color.Transparent;
            this.btnTest.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnTest.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnTest.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTest.Location = new System.Drawing.Point(11, 323);
            this.btnTest.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.btnTest.Name = "btnTest";
            this.btnTest.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnTest.Size = new System.Drawing.Size(188, 41);
            this.btnTest.TabIndex = 23;
            this.btnTest.Text = "Test";
            this.btnTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTest.Visible = false;
            // 
            // btnHP
            // 
            this.btnHP.BackColor = System.Drawing.Color.Transparent;
            this.btnHP.BorderRadius = 8;
            this.btnHP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHP.FillColor = System.Drawing.Color.Transparent;
            this.btnHP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHP.ForeColor = System.Drawing.Color.White;
            this.btnHP.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnHP.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnHP.Image = ((System.Drawing.Image)(resources.GetObject("btnHP.Image")));
            this.btnHP.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHP.Location = new System.Drawing.Point(11, 282);
            this.btnHP.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.btnHP.Name = "btnHP";
            this.btnHP.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnHP.Size = new System.Drawing.Size(188, 41);
            this.btnHP.TabIndex = 22;
            this.btnHP.Text = "Học phí";
            this.btnHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnDiemSo
            // 
            this.btnDiemSo.BackColor = System.Drawing.Color.Transparent;
            this.btnDiemSo.BorderRadius = 8;
            this.btnDiemSo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiemSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiemSo.FillColor = System.Drawing.Color.Transparent;
            this.btnDiemSo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDiemSo.ForeColor = System.Drawing.Color.White;
            this.btnDiemSo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnDiemSo.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDiemSo.Image = ((System.Drawing.Image)(resources.GetObject("btnDiemSo.Image")));
            this.btnDiemSo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDiemSo.Location = new System.Drawing.Point(11, 241);
            this.btnDiemSo.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.btnDiemSo.Name = "btnDiemSo";
            this.btnDiemSo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnDiemSo.Size = new System.Drawing.Size(188, 41);
            this.btnDiemSo.TabIndex = 21;
            this.btnDiemSo.Text = "Điểm số";
            this.btnDiemSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnLichHoc
            // 
            this.btnLichHoc.BackColor = System.Drawing.Color.Transparent;
            this.btnLichHoc.BorderRadius = 8;
            this.btnLichHoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLichHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLichHoc.FillColor = System.Drawing.Color.Transparent;
            this.btnLichHoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLichHoc.ForeColor = System.Drawing.Color.White;
            this.btnLichHoc.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnLichHoc.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLichHoc.Image = ((System.Drawing.Image)(resources.GetObject("btnLichHoc.Image")));
            this.btnLichHoc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLichHoc.Location = new System.Drawing.Point(11, 200);
            this.btnLichHoc.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.btnLichHoc.Name = "btnLichHoc";
            this.btnLichHoc.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnLichHoc.Size = new System.Drawing.Size(188, 41);
            this.btnLichHoc.TabIndex = 20;
            this.btnLichHoc.Text = "Lịch học";
            this.btnLichHoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnLH
            // 
            this.btnLH.BackColor = System.Drawing.Color.Transparent;
            this.btnLH.BorderRadius = 8;
            this.btnLH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLH.FillColor = System.Drawing.Color.Transparent;
            this.btnLH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLH.ForeColor = System.Drawing.Color.White;
            this.btnLH.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnLH.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLH.Image = ((System.Drawing.Image)(resources.GetObject("btnLH.Image")));
            this.btnLH.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLH.Location = new System.Drawing.Point(11, 159);
            this.btnLH.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.btnLH.Name = "btnLH";
            this.btnLH.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnLH.Size = new System.Drawing.Size(188, 41);
            this.btnLH.TabIndex = 18;
            this.btnLH.Text = "Lớp học của học viên";
            this.btnLH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnKH
            // 
            this.btnKH.BackColor = System.Drawing.Color.Transparent;
            this.btnKH.BorderRadius = 8;
            this.btnKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKH.FillColor = System.Drawing.Color.Transparent;
            this.btnKH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKH.ForeColor = System.Drawing.Color.White;
            this.btnKH.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnKH.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnKH.Image = ((System.Drawing.Image)(resources.GetObject("btnKH.Image")));
            this.btnKH.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKH.Location = new System.Drawing.Point(11, 118);
            this.btnKH.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.btnKH.Name = "btnKH";
            this.btnKH.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnKH.Size = new System.Drawing.Size(188, 41);
            this.btnKH.TabIndex = 16;
            this.btnKH.Text = "Khóa học";
            this.btnKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnTTHV
            // 
            this.btnTTHV.BackColor = System.Drawing.Color.Transparent;
            this.btnTTHV.BorderRadius = 8;
            this.btnTTHV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTTHV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTTHV.FillColor = System.Drawing.Color.Transparent;
            this.btnTTHV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTTHV.ForeColor = System.Drawing.Color.White;
            this.btnTTHV.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnTTHV.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnTTHV.Image = ((System.Drawing.Image)(resources.GetObject("btnTTHV.Image")));
            this.btnTTHV.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTTHV.Location = new System.Drawing.Point(11, 77);
            this.btnTTHV.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.btnTTHV.Name = "btnTTHV";
            this.btnTTHV.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnTTHV.Size = new System.Drawing.Size(188, 41);
            this.btnTTHV.TabIndex = 8;
            this.btnTTHV.Text = "Thông tin học viên";
            this.btnTTHV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // brandPanel
            // 
            this.brandPanel.BackColor = System.Drawing.Color.Transparent;
            this.brandPanel.Controls.Add(this.lblBrand);
            this.brandPanel.Controls.Add(this.picBrand);
            this.brandPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.brandPanel.Location = new System.Drawing.Point(11, 12);
            this.brandPanel.Margin = new System.Windows.Forms.Padding(2);
            this.brandPanel.Name = "brandPanel";
            this.brandPanel.Padding = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.brandPanel.Size = new System.Drawing.Size(188, 65);
            this.brandPanel.TabIndex = 7;
            // 
            // lblBrand
            // 
            this.lblBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(46, 12);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(2);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(134, 41);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "OwlEng";
            // 
            // picBrand
            // 
            this.picBrand.BackColor = System.Drawing.Color.Transparent;
            this.picBrand.Cursor = System.Windows.Forms.Cursors.Default;
            this.picBrand.Dock = System.Windows.Forms.DockStyle.Left;
            this.picBrand.FillColor = System.Drawing.Color.Transparent;
            this.picBrand.Image = ((System.Drawing.Image)(resources.GetObject("picBrand.Image")));
            this.picBrand.ImageRotate = 0F;
            this.picBrand.Location = new System.Drawing.Point(8, 12);
            this.picBrand.Margin = new System.Windows.Forms.Padding(2);
            this.picBrand.Name = "picBrand";
            this.picBrand.Size = new System.Drawing.Size(38, 41);
            this.picBrand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBrand.TabIndex = 1;
            this.picBrand.TabStop = false;
            // 
            // StudentMenuForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1024, 624);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Menu";
            this.Load += new System.EventHandler(this.StudentMenuForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSidebar.ResumeLayout(false);
            this.brandPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBrand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna2BorderlessForm borderlessForm;
        private Guna2Panel panelSidebar, panelHeader, panelMain;
        private Guna2ControlBox btnMinimize, btnMaximize, btnClose;
        private PictureBox logoBox;
        private Guna2Button btnLH;
        private Guna2Button btnKH;
        private Guna2Button btnTTHV;
        private Guna2Panel brandPanel;
        private Label lblBrand;
        private Guna2PictureBox picBrand;
        private Guna2Button btnDiemSo;
        private Guna2Button btnLichHoc;
        private Guna2Button btnHP;
        private Guna2Button btnTest;
        private Guna2Button btnLogout;
        private Guna2Panel guna2Panel1;
        private Label lblXinChao;
        private PictureBox pictureBox1;
    }
}