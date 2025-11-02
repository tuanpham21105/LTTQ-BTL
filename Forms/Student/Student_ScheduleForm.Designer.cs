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
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHeader = new AntdUI.Label();
            this.panelInfor = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new AntdUI.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dateSchedule = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label11 = new AntdUI.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.panelScrollContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel17 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelSchedules7 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDate7 = new AntdUI.Label();
            this.guna2Panel14 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelSchedules6 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDate6 = new AntdUI.Label();
            this.guna2Panel11 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelSchedules5 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDate5 = new AntdUI.Label();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelSchedules4 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDate4 = new AntdUI.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelSchedules3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDate3 = new AntdUI.Label();
            this.dayColumn1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelSchedules2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDate2 = new AntdUI.Label();
            this.dayColumn = new Guna.UI2.WinForms.Guna2Panel();
            this.panelSchedules1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDate1 = new AntdUI.Label();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblEndDate = new AntdUI.Label();
            this.label31 = new AntdUI.Label();
            this.lblStartDate = new AntdUI.Label();
            this.label21 = new AntdUI.Label();
            this.panelMain.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelInfor.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panelScrollContainer.SuspendLayout();
            this.guna2Panel17.SuspendLayout();
            this.guna2Panel14.SuspendLayout();
            this.guna2Panel11.SuspendLayout();
            this.guna2Panel8.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.dayColumn1.SuspendLayout();
            this.dayColumn.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.guna2Panel1);
            this.panelMain.Controls.Add(this.panelInfor);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(867, 723);
            this.panelMain.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panelHeader.BorderRadius = 12;
            this.panelHeader.BorderThickness = 1;
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.FillColor = System.Drawing.Color.White;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.panelHeader.Size = new System.Drawing.Size(867, 44);
            this.panelHeader.TabIndex = 6;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSizeMode = AntdUI.TAutoSize.Width;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lblHeader.Location = new System.Drawing.Point(20, 5);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(83, 34);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Lịch học";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelInfor
            // 
            this.panelInfor.AutoSize = true;
            this.panelInfor.Controls.Add(this.guna2Panel2);
            this.panelInfor.Controls.Add(this.guna2Panel3);
            this.panelInfor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfor.Location = new System.Drawing.Point(0, 44);
            this.panelInfor.Name = "panelInfor";
            this.panelInfor.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelInfor.Size = new System.Drawing.Size(867, 102);
            this.panelInfor.TabIndex = 7;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.AutoSize = true;
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.guna2Panel2.BorderRadius = 8;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.tableLayoutPanel1);
            this.guna2Panel2.CustomizableEdges.TopLeft = false;
            this.guna2Panel2.CustomizableEdges.TopRight = false;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 52);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.guna2Panel2.Size = new System.Drawing.Size(867, 50);
            this.guna2Panel2.TabIndex = 16;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.guna2Panel3.BorderRadius = 12;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.label1);
            this.guna2Panel3.CustomizableEdges.BottomLeft = false;
            this.guna2Panel3.CustomizableEdges.BottomRight = false;
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 10);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Padding = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.guna2Panel3.Size = new System.Drawing.Size(867, 42);
            this.guna2Panel3.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSizeMode = AntdUI.TAutoSize.Width;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label1.Location = new System.Drawing.Point(20, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bộ lọc";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.dateSchedule, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(857, 40);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // dateSchedule
            // 
            this.dateSchedule.BackColor = System.Drawing.Color.Transparent;
            this.dateSchedule.BorderRadius = 6;
            this.dateSchedule.Checked = true;
            this.dateSchedule.CustomFormat = "dd/MM/yyyy";
            this.dateSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateSchedule.FillColor = System.Drawing.Color.White;
            this.dateSchedule.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateSchedule.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateSchedule.Location = new System.Drawing.Point(260, 3);
            this.dateSchedule.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateSchedule.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateSchedule.Name = "dateSchedule";
            this.dateSchedule.Size = new System.Drawing.Size(594, 34);
            this.dateSchedule.TabIndex = 6;
            this.dateSchedule.Value = new System.DateTime(2025, 11, 2, 9, 47, 21, 613);
            this.dateSchedule.ValueChanged += new System.EventHandler(this.dateSchedule_ValueChanged);
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(251, 34);
            this.label11.TabIndex = 7;
            this.label11.Text = "Ngày học";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoSize = true;
            this.guna2Panel1.Controls.Add(this.lblFooter);
            this.guna2Panel1.Controls.Add(this.panelScrollContainer);
            this.guna2Panel1.Controls.Add(this.guna2Panel6);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 146);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.guna2Panel1.Size = new System.Drawing.Size(867, 577);
            this.guna2Panel1.TabIndex = 8;
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.Transparent;
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblFooter.Location = new System.Drawing.Point(0, 552);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(867, 25);
            this.lblFooter.TabIndex = 23;
            this.lblFooter.Text = "Kéo ngang để xem thêm ngày học →";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelScrollContainer
            // 
            this.panelScrollContainer.AutoScroll = true;
            this.panelScrollContainer.AutoScrollMinSize = new System.Drawing.Size(800, 0);
            this.panelScrollContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelScrollContainer.Controls.Add(this.guna2Panel17);
            this.panelScrollContainer.Controls.Add(this.guna2Panel14);
            this.panelScrollContainer.Controls.Add(this.guna2Panel11);
            this.panelScrollContainer.Controls.Add(this.guna2Panel8);
            this.panelScrollContainer.Controls.Add(this.guna2Panel5);
            this.panelScrollContainer.Controls.Add(this.dayColumn1);
            this.panelScrollContainer.Controls.Add(this.dayColumn);
            this.panelScrollContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScrollContainer.Location = new System.Drawing.Point(0, 52);
            this.panelScrollContainer.Name = "panelScrollContainer";
            this.panelScrollContainer.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelScrollContainer.Size = new System.Drawing.Size(867, 525);
            this.panelScrollContainer.TabIndex = 22;
            // 
            // guna2Panel17
            // 
            this.guna2Panel17.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.guna2Panel17.BorderRadius = 12;
            this.guna2Panel17.BorderThickness = 1;
            this.guna2Panel17.Controls.Add(this.panelSchedules7);
            this.guna2Panel17.Controls.Add(this.lblDate7);
            this.guna2Panel17.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel17.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.guna2Panel17.Location = new System.Drawing.Point(1320, 10);
            this.guna2Panel17.Name = "guna2Panel17";
            this.guna2Panel17.Padding = new System.Windows.Forms.Padding(10);
            this.guna2Panel17.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 4, 4);
            this.guna2Panel17.Size = new System.Drawing.Size(220, 488);
            this.guna2Panel17.TabIndex = 6;
            // 
            // panelSchedules7
            // 
            this.panelSchedules7.AutoScroll = true;
            this.panelSchedules7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSchedules7.Location = new System.Drawing.Point(10, 37);
            this.panelSchedules7.Name = "panelSchedules7";
            this.panelSchedules7.Size = new System.Drawing.Size(200, 441);
            this.panelSchedules7.TabIndex = 5;
            // 
            // lblDate7
            // 
            this.lblDate7.AutoSizeMode = AntdUI.TAutoSize.Height;
            this.lblDate7.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDate7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDate7.Location = new System.Drawing.Point(10, 10);
            this.lblDate7.Name = "lblDate7";
            this.lblDate7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblDate7.Size = new System.Drawing.Size(200, 27);
            this.lblDate7.TabIndex = 1;
            this.lblDate7.Text = "07/11/2025";
            this.lblDate7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel14
            // 
            this.guna2Panel14.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.guna2Panel14.BorderRadius = 12;
            this.guna2Panel14.BorderThickness = 1;
            this.guna2Panel14.Controls.Add(this.panelSchedules6);
            this.guna2Panel14.Controls.Add(this.lblDate6);
            this.guna2Panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.guna2Panel14.Location = new System.Drawing.Point(1100, 10);
            this.guna2Panel14.Name = "guna2Panel14";
            this.guna2Panel14.Padding = new System.Windows.Forms.Padding(10);
            this.guna2Panel14.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 4, 4);
            this.guna2Panel14.Size = new System.Drawing.Size(220, 488);
            this.guna2Panel14.TabIndex = 5;
            // 
            // panelSchedules6
            // 
            this.panelSchedules6.AutoScroll = true;
            this.panelSchedules6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSchedules6.Location = new System.Drawing.Point(10, 37);
            this.panelSchedules6.Name = "panelSchedules6";
            this.panelSchedules6.Size = new System.Drawing.Size(200, 441);
            this.panelSchedules6.TabIndex = 5;
            // 
            // lblDate6
            // 
            this.lblDate6.AutoSizeMode = AntdUI.TAutoSize.Height;
            this.lblDate6.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDate6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDate6.Location = new System.Drawing.Point(10, 10);
            this.lblDate6.Name = "lblDate6";
            this.lblDate6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblDate6.Size = new System.Drawing.Size(200, 27);
            this.lblDate6.TabIndex = 1;
            this.lblDate6.Text = "06/11/2025";
            this.lblDate6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel11
            // 
            this.guna2Panel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.guna2Panel11.BorderRadius = 12;
            this.guna2Panel11.BorderThickness = 1;
            this.guna2Panel11.Controls.Add(this.panelSchedules5);
            this.guna2Panel11.Controls.Add(this.lblDate5);
            this.guna2Panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.guna2Panel11.Location = new System.Drawing.Point(880, 10);
            this.guna2Panel11.Name = "guna2Panel11";
            this.guna2Panel11.Padding = new System.Windows.Forms.Padding(10);
            this.guna2Panel11.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 4, 4);
            this.guna2Panel11.Size = new System.Drawing.Size(220, 488);
            this.guna2Panel11.TabIndex = 4;
            // 
            // panelSchedules5
            // 
            this.panelSchedules5.AutoScroll = true;
            this.panelSchedules5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSchedules5.Location = new System.Drawing.Point(10, 37);
            this.panelSchedules5.Name = "panelSchedules5";
            this.panelSchedules5.Size = new System.Drawing.Size(200, 441);
            this.panelSchedules5.TabIndex = 5;
            // 
            // lblDate5
            // 
            this.lblDate5.AutoSizeMode = AntdUI.TAutoSize.Height;
            this.lblDate5.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDate5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDate5.Location = new System.Drawing.Point(10, 10);
            this.lblDate5.Name = "lblDate5";
            this.lblDate5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblDate5.Size = new System.Drawing.Size(200, 27);
            this.lblDate5.TabIndex = 1;
            this.lblDate5.Text = "05/11/2025";
            this.lblDate5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.guna2Panel8.BorderRadius = 12;
            this.guna2Panel8.BorderThickness = 1;
            this.guna2Panel8.Controls.Add(this.panelSchedules4);
            this.guna2Panel8.Controls.Add(this.lblDate4);
            this.guna2Panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.guna2Panel8.Location = new System.Drawing.Point(660, 10);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.Padding = new System.Windows.Forms.Padding(10);
            this.guna2Panel8.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 4, 4);
            this.guna2Panel8.Size = new System.Drawing.Size(220, 488);
            this.guna2Panel8.TabIndex = 3;
            // 
            // panelSchedules4
            // 
            this.panelSchedules4.AutoScroll = true;
            this.panelSchedules4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSchedules4.Location = new System.Drawing.Point(10, 37);
            this.panelSchedules4.Name = "panelSchedules4";
            this.panelSchedules4.Size = new System.Drawing.Size(200, 441);
            this.panelSchedules4.TabIndex = 5;
            // 
            // lblDate4
            // 
            this.lblDate4.AutoSizeMode = AntdUI.TAutoSize.Height;
            this.lblDate4.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDate4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDate4.Location = new System.Drawing.Point(10, 10);
            this.lblDate4.Name = "lblDate4";
            this.lblDate4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblDate4.Size = new System.Drawing.Size(200, 27);
            this.lblDate4.TabIndex = 1;
            this.lblDate4.Text = "04/11/2025";
            this.lblDate4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.guna2Panel5.BorderRadius = 12;
            this.guna2Panel5.BorderThickness = 1;
            this.guna2Panel5.Controls.Add(this.panelSchedules3);
            this.guna2Panel5.Controls.Add(this.lblDate3);
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.guna2Panel5.Location = new System.Drawing.Point(440, 10);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Padding = new System.Windows.Forms.Padding(10);
            this.guna2Panel5.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 4, 4);
            this.guna2Panel5.Size = new System.Drawing.Size(220, 488);
            this.guna2Panel5.TabIndex = 2;
            // 
            // panelSchedules3
            // 
            this.panelSchedules3.AutoScroll = true;
            this.panelSchedules3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSchedules3.Location = new System.Drawing.Point(10, 37);
            this.panelSchedules3.Name = "panelSchedules3";
            this.panelSchedules3.Size = new System.Drawing.Size(200, 441);
            this.panelSchedules3.TabIndex = 5;
            // 
            // lblDate3
            // 
            this.lblDate3.AutoSizeMode = AntdUI.TAutoSize.Height;
            this.lblDate3.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDate3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDate3.Location = new System.Drawing.Point(10, 10);
            this.lblDate3.Name = "lblDate3";
            this.lblDate3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblDate3.Size = new System.Drawing.Size(200, 27);
            this.lblDate3.TabIndex = 1;
            this.lblDate3.Text = "03/11/2025";
            this.lblDate3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayColumn1
            // 
            this.dayColumn1.BackColor = System.Drawing.Color.Transparent;
            this.dayColumn1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dayColumn1.BorderRadius = 12;
            this.dayColumn1.BorderThickness = 1;
            this.dayColumn1.Controls.Add(this.panelSchedules2);
            this.dayColumn1.Controls.Add(this.lblDate2);
            this.dayColumn1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dayColumn1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.dayColumn1.Location = new System.Drawing.Point(220, 10);
            this.dayColumn1.Name = "dayColumn1";
            this.dayColumn1.Padding = new System.Windows.Forms.Padding(10);
            this.dayColumn1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 4, 4);
            this.dayColumn1.Size = new System.Drawing.Size(220, 488);
            this.dayColumn1.TabIndex = 1;
            // 
            // panelSchedules2
            // 
            this.panelSchedules2.AutoScroll = true;
            this.panelSchedules2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSchedules2.Location = new System.Drawing.Point(10, 37);
            this.panelSchedules2.Name = "panelSchedules2";
            this.panelSchedules2.Size = new System.Drawing.Size(200, 441);
            this.panelSchedules2.TabIndex = 5;
            // 
            // lblDate2
            // 
            this.lblDate2.AutoSizeMode = AntdUI.TAutoSize.Height;
            this.lblDate2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDate2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDate2.Location = new System.Drawing.Point(10, 10);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblDate2.Size = new System.Drawing.Size(200, 27);
            this.lblDate2.TabIndex = 1;
            this.lblDate2.Text = "02/11/2025";
            this.lblDate2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayColumn
            // 
            this.dayColumn.BackColor = System.Drawing.Color.Transparent;
            this.dayColumn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dayColumn.BorderRadius = 12;
            this.dayColumn.BorderThickness = 1;
            this.dayColumn.Controls.Add(this.panelSchedules1);
            this.dayColumn.Controls.Add(this.lblDate1);
            this.dayColumn.Dock = System.Windows.Forms.DockStyle.Left;
            this.dayColumn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.dayColumn.Location = new System.Drawing.Point(0, 10);
            this.dayColumn.Name = "dayColumn";
            this.dayColumn.Padding = new System.Windows.Forms.Padding(10);
            this.dayColumn.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 4, 4);
            this.dayColumn.Size = new System.Drawing.Size(220, 488);
            this.dayColumn.TabIndex = 0;
            // 
            // panelSchedules1
            // 
            this.panelSchedules1.AutoScroll = true;
            this.panelSchedules1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSchedules1.Location = new System.Drawing.Point(10, 37);
            this.panelSchedules1.Name = "panelSchedules1";
            this.panelSchedules1.Size = new System.Drawing.Size(200, 441);
            this.panelSchedules1.TabIndex = 5;
            // 
            // lblDate1
            // 
            this.lblDate1.AutoSizeMode = AntdUI.TAutoSize.Height;
            this.lblDate1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDate1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDate1.Location = new System.Drawing.Point(10, 10);
            this.lblDate1.Name = "lblDate1";
            this.lblDate1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblDate1.Size = new System.Drawing.Size(200, 27);
            this.lblDate1.TabIndex = 1;
            this.lblDate1.Text = "01/11/2025";
            this.lblDate1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.guna2Panel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.guna2Panel6.BorderRadius = 12;
            this.guna2Panel6.BorderThickness = 1;
            this.guna2Panel6.Controls.Add(this.lblEndDate);
            this.guna2Panel6.Controls.Add(this.label31);
            this.guna2Panel6.Controls.Add(this.lblStartDate);
            this.guna2Panel6.Controls.Add(this.label21);
            this.guna2Panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel6.FillColor = System.Drawing.Color.White;
            this.guna2Panel6.Location = new System.Drawing.Point(0, 10);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Padding = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.guna2Panel6.Size = new System.Drawing.Size(867, 42);
            this.guna2Panel6.TabIndex = 21;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSizeMode = AntdUI.TAutoSize.Width;
            this.lblEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblEndDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lblEndDate.Location = new System.Drawing.Point(218, 5);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(96, 32);
            this.lblEndDate.TabIndex = 8;
            this.lblEndDate.Text = "07/11/2025";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.AutoSizeMode = AntdUI.TAutoSize.Width;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Dock = System.Windows.Forms.DockStyle.Left;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label31.Location = new System.Drawing.Point(201, 5);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(17, 32);
            this.label31.TabIndex = 7;
            this.label31.Text = " - ";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSizeMode = AntdUI.TAutoSize.Width;
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lblStartDate.Location = new System.Drawing.Point(105, 5);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(96, 32);
            this.lblStartDate.TabIndex = 6;
            this.lblStartDate.Text = "01/11/2025";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSizeMode = AntdUI.TAutoSize.Width;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Dock = System.Windows.Forms.DockStyle.Left;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label21.Location = new System.Drawing.Point(20, 5);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 32);
            this.label21.TabIndex = 5;
            this.label21.Text = "Tuần học: ";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Student_ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 723);
            this.Controls.Add(this.panelMain);
            this.Name = "Student_ScheduleForm";
            this.Text = "Student_ScheduleForm";
            this.Load += new System.EventHandler(this.Student_ScheduleForm_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelInfor.ResumeLayout(false);
            this.panelInfor.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.panelScrollContainer.ResumeLayout(false);
            this.guna2Panel17.ResumeLayout(false);
            this.guna2Panel17.PerformLayout();
            this.guna2Panel14.ResumeLayout(false);
            this.guna2Panel14.PerformLayout();
            this.guna2Panel11.ResumeLayout(false);
            this.guna2Panel11.PerformLayout();
            this.guna2Panel8.ResumeLayout(false);
            this.guna2Panel8.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.dayColumn1.ResumeLayout(false);
            this.dayColumn1.PerformLayout();
            this.dayColumn.ResumeLayout(false);
            this.dayColumn.PerformLayout();
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna2Panel panelMain;
        private Guna2Panel panelHeader;
        private AntdUI.Label lblHeader;
        private Guna2Panel panelInfor;
        private Guna2Panel guna2Panel2;
        private Guna2Panel guna2Panel3;
        private AntdUI.Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Guna2DateTimePicker dateSchedule;
        private AntdUI.Label label11;
        private Guna2Panel guna2Panel1;
        private Label lblFooter;
        private Guna2Panel panelScrollContainer;
        private Guna2Panel guna2Panel17;
        private Guna2Panel panelSchedules7;
        private AntdUI.Label lblDate7;
        private Guna2Panel guna2Panel14;
        private Guna2Panel panelSchedules6;
        private AntdUI.Label lblDate6;
        private Guna2Panel guna2Panel11;
        private Guna2Panel panelSchedules5;
        private AntdUI.Label lblDate5;
        private Guna2Panel guna2Panel8;
        private Guna2Panel panelSchedules4;
        private AntdUI.Label lblDate4;
        private Guna2Panel guna2Panel5;
        private Guna2Panel panelSchedules3;
        private AntdUI.Label lblDate3;
        private Guna2Panel dayColumn1;
        private Guna2Panel panelSchedules2;
        private AntdUI.Label lblDate2;
        private Guna2Panel dayColumn;
        private Guna2Panel panelSchedules1;
        private AntdUI.Label lblDate1;
        private Guna2Panel guna2Panel6;
        private AntdUI.Label lblEndDate;
        private AntdUI.Label label31;
        private AntdUI.Label lblStartDate;
        private AntdUI.Label label21;
    }
}