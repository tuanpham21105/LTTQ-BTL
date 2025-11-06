using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using prj_LTTQ_BTL.Data;
using FontStyle = System.Drawing.FontStyle;
using Label = System.Windows.Forms.Label;

namespace prj_LTTQ_BTL.Forms.Student
{
    partial class Student_CourseCRUDForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtMaDangKy = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new AntdUI.Label();
            this.btnXoaDangKy = new Guna.UI2.WinForms.Guna2Button();
            this.dgvEnrollment = new Guna.UI2.WinForms.Guna2DataGridView();
            this.enrollment_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollment_student_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollment_course_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollment_course_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollment_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearchDangKy = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new AntdUI.Label();
            this.panelKhoaHoc = new Guna.UI2.WinForms.Guna2Panel();
            this.panel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.tblInfo = new System.Windows.Forms.TableLayoutPanel();
            this.txtMoTa = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDesc = new AntdUI.Label();
            this.txtHocPhi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFee = new AntdUI.Label();
            this.txtSoBuoiHoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLessons = new AntdUI.Label();
            this.txtTenKhoaHoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblName = new AntdUI.Label();
            this.btnDangKy = new Guna.UI2.WinForms.Guna2Button();
            this.dgvCourse = new Guna.UI2.WinForms.Guna2DataGridView();
            this.course_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_of_lessons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course_fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearchKhoaHoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new AntdUI.Label();
            this.headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new AntdUI.Label();
            this.panelMain.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollment)).BeginInit();
            this.guna2Panel6.SuspendLayout();
            this.panelKhoaHoc.SuspendLayout();
            this.panel.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.tblInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.guna2Panel3);
            this.panelMain.Controls.Add(this.panelKhoaHoc);
            this.panelMain.Controls.Add(this.headerPanel);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(706, 542);
            this.panelMain.TabIndex = 1;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.AutoSize = true;
            this.guna2Panel3.Controls.Add(this.guna2Panel4);
            this.guna2Panel3.Controls.Add(this.guna2Panel6);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 552);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.guna2Panel3.Size = new System.Drawing.Size(689, 392);
            this.guna2Panel3.TabIndex = 3;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.AutoSize = true;
            this.guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.guna2Panel4.BorderRadius = 12;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.guna2Panel5);
            this.guna2Panel4.Controls.Add(this.dgvEnrollment);
            this.guna2Panel4.CustomizableEdges.TopLeft = false;
            this.guna2Panel4.CustomizableEdges.TopRight = false;
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel4.FillColor = System.Drawing.Color.White;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 50);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Padding = new System.Windows.Forms.Padding(1, 10, 1, 10);
            this.guna2Panel4.Size = new System.Drawing.Size(689, 342);
            this.guna2Panel4.TabIndex = 5;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.AutoSize = true;
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.Controls.Add(this.tableLayoutPanel1);
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel5.Location = new System.Drawing.Point(1, 242);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.guna2Panel5.Size = new System.Drawing.Size(687, 90);
            this.guna2Panel5.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.txtMaDangKy, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnXoaDangKy, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(667, 80);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // txtMaDangKy
            // 
            this.txtMaDangKy.BorderRadius = 5;
            this.txtMaDangKy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaDangKy.DefaultText = "";
            this.txtMaDangKy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaDangKy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaDangKy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDangKy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDangKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaDangKy.Enabled = false;
            this.txtMaDangKy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDangKy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaDangKy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDangKy.Location = new System.Drawing.Point(203, 4);
            this.txtMaDangKy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaDangKy.Name = "txtMaDangKy";
            this.txtMaDangKy.PlaceholderText = "";
            this.txtMaDangKy.SelectedText = "";
            this.txtMaDangKy.Size = new System.Drawing.Size(461, 32);
            this.txtMaDangKy.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 34);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã đăng ký học";
            // 
            // btnXoaDangKy
            // 
            this.btnXoaDangKy.BorderRadius = 5;
            this.btnXoaDangKy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaDangKy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaDangKy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaDangKy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaDangKy.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXoaDangKy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnXoaDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDangKy.ForeColor = System.Drawing.Color.White;
            this.btnXoaDangKy.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnXoaDangKy.HoverState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDangKy.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnXoaDangKy.Location = new System.Drawing.Point(484, 43);
            this.btnXoaDangKy.Name = "btnXoaDangKy";
            this.btnXoaDangKy.Size = new System.Drawing.Size(180, 34);
            this.btnXoaDangKy.TabIndex = 10;
            this.btnXoaDangKy.Text = "Xóa đăng ký";
            this.btnXoaDangKy.Click += new System.EventHandler(this.btnXoaDangKy_Click);
            // 
            // dgvEnrollment
            // 
            this.dgvEnrollment.AllowUserToAddRows = false;
            this.dgvEnrollment.AllowUserToDeleteRows = false;
            this.dgvEnrollment.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvEnrollment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEnrollment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEnrollment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEnrollment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEnrollment.ColumnHeadersHeight = 35;
            this.dgvEnrollment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.enrollment_id,
            this.enrollment_student_id,
            this.enrollment_course_id,
            this.enrollment_course_name,
            this.enrollment_date});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEnrollment.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEnrollment.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvEnrollment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dgvEnrollment.Location = new System.Drawing.Point(1, 10);
            this.dgvEnrollment.MultiSelect = false;
            this.dgvEnrollment.Name = "dgvEnrollment";
            this.dgvEnrollment.ReadOnly = true;
            this.dgvEnrollment.RowHeadersVisible = false;
            this.dgvEnrollment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvEnrollment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvEnrollment.Size = new System.Drawing.Size(687, 232);
            this.dgvEnrollment.TabIndex = 1;
            this.dgvEnrollment.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEnrollment.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEnrollment.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEnrollment.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEnrollment.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEnrollment.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvEnrollment.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dgvEnrollment.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvEnrollment.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvEnrollment.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEnrollment.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEnrollment.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEnrollment.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvEnrollment.ThemeStyle.ReadOnly = true;
            this.dgvEnrollment.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEnrollment.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEnrollment.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEnrollment.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEnrollment.ThemeStyle.RowsStyle.Height = 22;
            this.dgvEnrollment.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.dgvEnrollment.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEnrollment.DataSourceChanged += new System.EventHandler(this.dgvEnrollment_DataSourceChanged);
            this.dgvEnrollment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnrollment_CellClick);
            this.dgvEnrollment.CurrentCellChanged += new System.EventHandler(this.dgvEnrollment_CurrentCellChanged);
            // 
            // enrollment_id
            // 
            this.enrollment_id.DataPropertyName = "id";
            this.enrollment_id.HeaderText = "Mã đăng ký";
            this.enrollment_id.MinimumWidth = 6;
            this.enrollment_id.Name = "enrollment_id";
            this.enrollment_id.ReadOnly = true;
            // 
            // enrollment_student_id
            // 
            this.enrollment_student_id.DataPropertyName = "student_id";
            this.enrollment_student_id.HeaderText = "Mã học viên";
            this.enrollment_student_id.MinimumWidth = 6;
            this.enrollment_student_id.Name = "enrollment_student_id";
            this.enrollment_student_id.ReadOnly = true;
            // 
            // enrollment_course_id
            // 
            this.enrollment_course_id.DataPropertyName = "course_id";
            this.enrollment_course_id.HeaderText = "Mã khóa học";
            this.enrollment_course_id.MinimumWidth = 6;
            this.enrollment_course_id.Name = "enrollment_course_id";
            this.enrollment_course_id.ReadOnly = true;
            // 
            // enrollment_course_name
            // 
            this.enrollment_course_name.DataPropertyName = "name";
            this.enrollment_course_name.HeaderText = "Tên khóa học";
            this.enrollment_course_name.MinimumWidth = 6;
            this.enrollment_course_name.Name = "enrollment_course_name";
            this.enrollment_course_name.ReadOnly = true;
            // 
            // enrollment_date
            // 
            this.enrollment_date.DataPropertyName = "enrollment_date";
            this.enrollment_date.HeaderText = "Ngày đăng ký";
            this.enrollment_date.MinimumWidth = 6;
            this.enrollment_date.Name = "enrollment_date";
            this.enrollment_date.ReadOnly = true;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.guna2Panel6.BorderRadius = 12;
            this.guna2Panel6.BorderThickness = 1;
            this.guna2Panel6.Controls.Add(this.txtSearchDangKy);
            this.guna2Panel6.Controls.Add(this.label6);
            this.guna2Panel6.CustomizableEdges.BottomLeft = false;
            this.guna2Panel6.CustomizableEdges.BottomRight = false;
            this.guna2Panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel6.FillColor = System.Drawing.Color.White;
            this.guna2Panel6.Location = new System.Drawing.Point(0, 10);
            this.guna2Panel6.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Padding = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.guna2Panel6.Size = new System.Drawing.Size(689, 40);
            this.guna2Panel6.TabIndex = 4;
            // 
            // txtSearchDangKy
            // 
            this.txtSearchDangKy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSearchDangKy.BorderRadius = 8;
            this.txtSearchDangKy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchDangKy.DefaultText = "";
            this.txtSearchDangKy.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtSearchDangKy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchDangKy.Location = new System.Drawing.Point(384, 5);
            this.txtSearchDangKy.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearchDangKy.Name = "txtSearchDangKy";
            this.txtSearchDangKy.PlaceholderText = "Search enrollments...";
            this.txtSearchDangKy.SelectedText = "";
            this.txtSearchDangKy.Size = new System.Drawing.Size(300, 30);
            this.txtSearchDangKy.TabIndex = 0;
            this.txtSearchDangKy.TextChanged += new System.EventHandler(this.txtSearchDangKy_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSizeMode = AntdUI.TAutoSize.Width;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label6.Location = new System.Drawing.Point(20, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "Các khóa học đã đăng ký";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelKhoaHoc
            // 
            this.panelKhoaHoc.AutoSize = true;
            this.panelKhoaHoc.Controls.Add(this.panel);
            this.panelKhoaHoc.Controls.Add(this.guna2Panel1);
            this.panelKhoaHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKhoaHoc.Location = new System.Drawing.Point(0, 40);
            this.panelKhoaHoc.Name = "panelKhoaHoc";
            this.panelKhoaHoc.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelKhoaHoc.Size = new System.Drawing.Size(689, 512);
            this.panelKhoaHoc.TabIndex = 2;
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel.BorderRadius = 12;
            this.panel.BorderThickness = 1;
            this.panel.Controls.Add(this.guna2Panel2);
            this.panel.Controls.Add(this.dgvCourse);
            this.panel.CustomizableEdges.TopLeft = false;
            this.panel.CustomizableEdges.TopRight = false;
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.FillColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(0, 50);
            this.panel.Name = "panel";
            this.panel.Padding = new System.Windows.Forms.Padding(1, 10, 1, 10);
            this.panel.Size = new System.Drawing.Size(689, 462);
            this.panel.TabIndex = 5;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.AutoSize = true;
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Controls.Add(this.tblInfo);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(1, 242);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.guna2Panel2.Size = new System.Drawing.Size(687, 210);
            this.guna2Panel2.TabIndex = 2;
            // 
            // tblInfo
            // 
            this.tblInfo.AutoSize = true;
            this.tblInfo.ColumnCount = 2;
            this.tblInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblInfo.Controls.Add(this.txtMoTa, 1, 3);
            this.tblInfo.Controls.Add(this.lblDesc, 0, 3);
            this.tblInfo.Controls.Add(this.txtHocPhi, 1, 2);
            this.tblInfo.Controls.Add(this.lblFee, 0, 2);
            this.tblInfo.Controls.Add(this.txtSoBuoiHoc, 1, 1);
            this.tblInfo.Controls.Add(this.lblLessons, 0, 1);
            this.tblInfo.Controls.Add(this.txtTenKhoaHoc, 1, 0);
            this.tblInfo.Controls.Add(this.lblName, 0, 0);
            this.tblInfo.Controls.Add(this.btnDangKy, 1, 4);
            this.tblInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblInfo.Location = new System.Drawing.Point(10, 10);
            this.tblInfo.Name = "tblInfo";
            this.tblInfo.RowCount = 5;
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblInfo.Size = new System.Drawing.Size(667, 200);
            this.tblInfo.TabIndex = 4;
            // 
            // txtMoTa
            // 
            this.txtMoTa.BorderRadius = 5;
            this.txtMoTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTa.DefaultText = "";
            this.txtMoTa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMoTa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMoTa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMoTa.Enabled = false;
            this.txtMoTa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMoTa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTa.Location = new System.Drawing.Point(203, 124);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.PlaceholderText = "";
            this.txtMoTa.SelectedText = "";
            this.txtMoTa.Size = new System.Drawing.Size(461, 32);
            this.txtMoTa.TabIndex = 9;
            // 
            // lblDesc
            // 
            this.lblDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblDesc.Location = new System.Drawing.Point(3, 123);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(194, 34);
            this.lblDesc.TabIndex = 8;
            this.lblDesc.Text = "Mô tả khóa học";
            // 
            // txtHocPhi
            // 
            this.txtHocPhi.BorderRadius = 5;
            this.txtHocPhi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHocPhi.DefaultText = "";
            this.txtHocPhi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHocPhi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHocPhi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHocPhi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHocPhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHocPhi.Enabled = false;
            this.txtHocPhi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHocPhi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHocPhi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHocPhi.Location = new System.Drawing.Point(203, 84);
            this.txtHocPhi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHocPhi.Name = "txtHocPhi";
            this.txtHocPhi.PlaceholderText = "";
            this.txtHocPhi.SelectedText = "";
            this.txtHocPhi.Size = new System.Drawing.Size(461, 32);
            this.txtHocPhi.TabIndex = 7;
            // 
            // lblFee
            // 
            this.lblFee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblFee.Location = new System.Drawing.Point(3, 83);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(194, 34);
            this.lblFee.TabIndex = 6;
            this.lblFee.Text = "Học phí";
            // 
            // txtSoBuoiHoc
            // 
            this.txtSoBuoiHoc.BorderRadius = 5;
            this.txtSoBuoiHoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoBuoiHoc.DefaultText = "";
            this.txtSoBuoiHoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoBuoiHoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoBuoiHoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoBuoiHoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoBuoiHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoBuoiHoc.Enabled = false;
            this.txtSoBuoiHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoBuoiHoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoBuoiHoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoBuoiHoc.Location = new System.Drawing.Point(203, 44);
            this.txtSoBuoiHoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoBuoiHoc.Name = "txtSoBuoiHoc";
            this.txtSoBuoiHoc.PlaceholderText = "";
            this.txtSoBuoiHoc.SelectedText = "";
            this.txtSoBuoiHoc.Size = new System.Drawing.Size(461, 32);
            this.txtSoBuoiHoc.TabIndex = 5;
            // 
            // lblLessons
            // 
            this.lblLessons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLessons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLessons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblLessons.Location = new System.Drawing.Point(3, 43);
            this.lblLessons.Name = "lblLessons";
            this.lblLessons.Size = new System.Drawing.Size(194, 34);
            this.lblLessons.TabIndex = 4;
            this.lblLessons.Text = "Số lượng buổi";
            // 
            // txtTenKhoaHoc
            // 
            this.txtTenKhoaHoc.BorderRadius = 5;
            this.txtTenKhoaHoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKhoaHoc.DefaultText = "";
            this.txtTenKhoaHoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenKhoaHoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenKhoaHoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKhoaHoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKhoaHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenKhoaHoc.Enabled = false;
            this.txtTenKhoaHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenKhoaHoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKhoaHoc.Location = new System.Drawing.Point(203, 4);
            this.txtTenKhoaHoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenKhoaHoc.Name = "txtTenKhoaHoc";
            this.txtTenKhoaHoc.PlaceholderText = "";
            this.txtTenKhoaHoc.SelectedText = "";
            this.txtTenKhoaHoc.Size = new System.Drawing.Size(461, 32);
            this.txtTenKhoaHoc.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblName.Location = new System.Drawing.Point(3, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(194, 34);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Tên khóa học";
            // 
            // btnDangKy
            // 
            this.btnDangKy.BorderRadius = 5;
            this.btnDangKy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangKy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangKy.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDangKy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnDangKy.HoverState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Location = new System.Drawing.Point(484, 163);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(180, 34);
            this.btnDangKy.TabIndex = 10;
            this.btnDangKy.Text = "Đăng ký khóa học";
            this.btnDangKy.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // dgvCourse
            // 
            this.dgvCourse.AllowUserToAddRows = false;
            this.dgvCourse.AllowUserToDeleteRows = false;
            this.dgvCourse.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvCourse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCourse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCourse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCourse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCourse.ColumnHeadersHeight = 35;
            this.dgvCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.course_id,
            this.course_name,
            this.course_description,
            this.number_of_lessons,
            this.course_fee});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCourse.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCourse.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dgvCourse.Location = new System.Drawing.Point(1, 10);
            this.dgvCourse.MultiSelect = false;
            this.dgvCourse.Name = "dgvCourse";
            this.dgvCourse.ReadOnly = true;
            this.dgvCourse.RowHeadersVisible = false;
            this.dgvCourse.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvCourse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCourse.Size = new System.Drawing.Size(687, 232);
            this.dgvCourse.TabIndex = 1;
            this.dgvCourse.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCourse.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCourse.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCourse.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCourse.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCourse.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCourse.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dgvCourse.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCourse.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCourse.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCourse.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCourse.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCourse.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvCourse.ThemeStyle.ReadOnly = true;
            this.dgvCourse.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCourse.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCourse.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCourse.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCourse.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCourse.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.dgvCourse.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCourse.DataSourceChanged += new System.EventHandler(this.dgvCourse_DataSourceChanged);
            this.dgvCourse.CurrentCellChanged += new System.EventHandler(this.dgvCourse_CurrentCellChanged);
            // 
            // course_id
            // 
            this.course_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.course_id.DataPropertyName = "id";
            this.course_id.HeaderText = "Mã khóa học";
            this.course_id.MinimumWidth = 6;
            this.course_id.Name = "course_id";
            this.course_id.ReadOnly = true;
            // 
            // course_name
            // 
            this.course_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.course_name.DataPropertyName = "name";
            this.course_name.HeaderText = "Tên khóa học";
            this.course_name.MinimumWidth = 6;
            this.course_name.Name = "course_name";
            this.course_name.ReadOnly = true;
            // 
            // course_description
            // 
            this.course_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.course_description.DataPropertyName = "description";
            this.course_description.HeaderText = "Mô tả";
            this.course_description.MinimumWidth = 6;
            this.course_description.Name = "course_description";
            this.course_description.ReadOnly = true;
            // 
            // number_of_lessons
            // 
            this.number_of_lessons.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.number_of_lessons.DataPropertyName = "number_of_lessons";
            this.number_of_lessons.HeaderText = "Số buổi học";
            this.number_of_lessons.MinimumWidth = 6;
            this.number_of_lessons.Name = "number_of_lessons";
            this.number_of_lessons.ReadOnly = true;
            // 
            // course_fee
            // 
            this.course_fee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.course_fee.DataPropertyName = "fee";
            this.course_fee.HeaderText = "Học phí";
            this.course_fee.Name = "course_fee";
            this.course_fee.ReadOnly = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.guna2Panel1.BorderRadius = 12;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.txtSearchKhoaHoc);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.CustomizableEdges.BottomLeft = false;
            this.guna2Panel1.CustomizableEdges.BottomRight = false;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 10);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.guna2Panel1.Size = new System.Drawing.Size(689, 40);
            this.guna2Panel1.TabIndex = 4;
            // 
            // txtSearchKhoaHoc
            // 
            this.txtSearchKhoaHoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSearchKhoaHoc.BorderRadius = 8;
            this.txtSearchKhoaHoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchKhoaHoc.DefaultText = "";
            this.txtSearchKhoaHoc.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtSearchKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchKhoaHoc.Location = new System.Drawing.Point(384, 5);
            this.txtSearchKhoaHoc.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearchKhoaHoc.Name = "txtSearchKhoaHoc";
            this.txtSearchKhoaHoc.PlaceholderText = "Search courses...";
            this.txtSearchKhoaHoc.SelectedText = "";
            this.txtSearchKhoaHoc.Size = new System.Drawing.Size(300, 30);
            this.txtSearchKhoaHoc.TabIndex = 0;
            this.txtSearchKhoaHoc.TextChanged += new System.EventHandler(this.txtSearch_text_changed);
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
            this.label1.Size = new System.Drawing.Size(147, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng ký khóa học";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Transparent;
            this.headerPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.headerPanel.BorderRadius = 12;
            this.headerPanel.BorderThickness = 1;
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.FillColor = System.Drawing.Color.White;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Padding = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.headerPanel.Size = new System.Drawing.Size(689, 40);
            this.headerPanel.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSizeMode = AntdUI.TAutoSize.Width;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(94, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Khóa học";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Student_CourseCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(706, 542);
            this.Controls.Add(this.panelMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Student_CourseCRUDForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Courses Management";
            this.Load += new System.EventHandler(this.FormStudent_CourseCRUD_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollment)).EndInit();
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.panelKhoaHoc.ResumeLayout(false);
            this.panelKhoaHoc.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.tblInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna2Panel panelMain;
        private Guna2Panel guna2Panel3;
        private Guna2Panel guna2Panel4;
        private Guna2Panel guna2Panel5;
        private TableLayoutPanel tableLayoutPanel1;
        private Guna2TextBox txtMaDangKy;
        private AntdUI.Label label5;
        private Guna2Button btnXoaDangKy;
        private Guna2DataGridView dgvEnrollment;
        private DataGridViewTextBoxColumn enrollment_id;
        private DataGridViewTextBoxColumn enrollment_student_id;
        private DataGridViewTextBoxColumn enrollment_course_id;
        private DataGridViewTextBoxColumn enrollment_course_name;
        private DataGridViewTextBoxColumn enrollment_date;
        private Guna2Panel guna2Panel6;
        private Guna2TextBox txtSearchDangKy;
        private AntdUI.Label label6;
        private Guna2Panel panelKhoaHoc;
        private Guna2Panel panel;
        private Guna2Panel guna2Panel2;
        private TableLayoutPanel tblInfo;
        private Guna2TextBox txtMoTa;
        private AntdUI.Label lblDesc;
        private Guna2TextBox txtHocPhi;
        private AntdUI.Label lblFee;
        private Guna2TextBox txtSoBuoiHoc;
        private AntdUI.Label lblLessons;
        private Guna2TextBox txtTenKhoaHoc;
        private AntdUI.Label lblName;
        private Guna2Button btnDangKy;
        private Guna2DataGridView dgvCourse;
        private DataGridViewTextBoxColumn course_id;
        private DataGridViewTextBoxColumn course_name;
        private DataGridViewTextBoxColumn course_description;
        private DataGridViewTextBoxColumn number_of_lessons;
        private DataGridViewTextBoxColumn course_fee;
        private Guna2Panel guna2Panel1;
        private Guna2TextBox txtSearchKhoaHoc;
        private AntdUI.Label label1;
        private Guna2Panel headerPanel;
        private AntdUI.Label lblTitle;
    }
}