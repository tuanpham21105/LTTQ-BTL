using System.Drawing;
using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace prj_LTTQ_BTL.Forms.Student
{
    partial class Student_ClassCRUDForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.panelTableContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvClassList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelDetail = new Guna.UI2.WinForms.Guna2Panel();
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblClassNameValue = new System.Windows.Forms.Label();
            this.lblMaxStudents = new System.Windows.Forms.Label();
            this.lblMaxStudentsValue = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblStartDateValue = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.lblTeacherValue = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourseNameValue = new System.Windows.Forms.Label();
            this.lblCourseDesc = new System.Windows.Forms.Label();
            this.lblCourseDescValue = new System.Windows.Forms.Label();
            this.lblLessons = new System.Windows.Forms.Label();
            this.lblLessonsValue = new System.Windows.Forms.Label();
            this.lblCourseFee = new System.Windows.Forms.Label();
            this.lblCourseFeeValue = new System.Windows.Forms.Label();
            this.panelButtons = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAttendance = new Guna.UI2.WinForms.Guna2Button();
            this.btnGrades = new Guna.UI2.WinForms.Guna2Button();
            this.lblHeader = new AntdUI.Label();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaxStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMain.SuspendLayout();
            this.panelTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassList)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelDetail.SuspendLayout();
            this.tblDetail.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelMain.Controls.Add(this.panelTableContainer);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Controls.Add(this.panelDetail);
            this.panelMain.Controls.Add(this.panelButtons);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(3);
            this.panelMain.Size = new System.Drawing.Size(898, 500);
            this.panelMain.TabIndex = 0;
            // 
            // panelTableContainer
            // 
            this.panelTableContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelTableContainer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panelTableContainer.BorderThickness = 1;
            this.panelTableContainer.Controls.Add(this.dgvClassList);
            this.panelTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTableContainer.Location = new System.Drawing.Point(3, 47);
            this.panelTableContainer.Name = "panelTableContainer";
            this.panelTableContainer.Padding = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.panelTableContainer.Size = new System.Drawing.Size(892, 200);
            this.panelTableContainer.TabIndex = 4;
            // 
            // dgvClassList
            // 
            this.dgvClassList.AllowUserToAddRows = false;
            this.dgvClassList.AllowUserToDeleteRows = false;
            this.dgvClassList.AllowUserToResizeColumns = false;
            this.dgvClassList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dgvClassList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClassList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvClassList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClassList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClassList.ColumnHeadersHeight = 32;
            this.dgvClassList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colClassName,
            this.colCourseId,
            this.colMaxStudents,
            this.colStartDate,
            this.colTeacherId});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClassList.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvClassList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClassList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dgvClassList.Location = new System.Drawing.Point(3, 5);
            this.dgvClassList.MultiSelect = false;
            this.dgvClassList.Name = "dgvClassList";
            this.dgvClassList.ReadOnly = true;
            this.dgvClassList.RowHeadersVisible = false;
            this.dgvClassList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvClassList.Size = new System.Drawing.Size(886, 192);
            this.dgvClassList.TabIndex = 0;
            this.dgvClassList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dgvClassList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvClassList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvClassList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvClassList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvClassList.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvClassList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dgvClassList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.dgvClassList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvClassList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.dgvClassList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvClassList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClassList.ThemeStyle.HeaderStyle.Height = 32;
            this.dgvClassList.ThemeStyle.ReadOnly = true;
            this.dgvClassList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvClassList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClassList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvClassList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvClassList.ThemeStyle.RowsStyle.Height = 22;
            this.dgvClassList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.dgvClassList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panelHeader.BorderThickness = 1;
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Controls.Add(this.txtSearch);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.FillColor = System.Drawing.Color.White;
            this.panelHeader.Location = new System.Drawing.Point(3, 3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.panelHeader.Size = new System.Drawing.Size(892, 44);
            this.panelHeader.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSearch.BorderRadius = 8;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(587, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search classes...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(300, 34);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_text_changed);
            // 
            // panelDetail
            // 
            this.panelDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelDetail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panelDetail.BorderRadius = 5;
            this.panelDetail.BorderThickness = 1;
            this.panelDetail.Controls.Add(this.tblDetail);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDetail.Location = new System.Drawing.Point(3, 247);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Padding = new System.Windows.Forms.Padding(5);
            this.panelDetail.Size = new System.Drawing.Size(892, 200);
            this.panelDetail.TabIndex = 2;
            // 
            // tblDetail
            // 
            this.tblDetail.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblDetail.ColumnCount = 2;
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblDetail.Controls.Add(this.lblClassName, 0, 0);
            this.tblDetail.Controls.Add(this.lblClassNameValue, 1, 0);
            this.tblDetail.Controls.Add(this.lblMaxStudents, 0, 1);
            this.tblDetail.Controls.Add(this.lblMaxStudentsValue, 1, 1);
            this.tblDetail.Controls.Add(this.lblStartDate, 0, 2);
            this.tblDetail.Controls.Add(this.lblStartDateValue, 1, 2);
            this.tblDetail.Controls.Add(this.lblTeacher, 0, 3);
            this.tblDetail.Controls.Add(this.lblTeacherValue, 1, 3);
            this.tblDetail.Controls.Add(this.lblCourseName, 0, 4);
            this.tblDetail.Controls.Add(this.lblCourseNameValue, 1, 4);
            this.tblDetail.Controls.Add(this.lblCourseDesc, 0, 5);
            this.tblDetail.Controls.Add(this.lblCourseDescValue, 1, 5);
            this.tblDetail.Controls.Add(this.lblLessons, 0, 6);
            this.tblDetail.Controls.Add(this.lblLessonsValue, 1, 6);
            this.tblDetail.Controls.Add(this.lblCourseFee, 0, 7);
            this.tblDetail.Controls.Add(this.lblCourseFeeValue, 1, 7);
            this.tblDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblDetail.Location = new System.Drawing.Point(5, 5);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 8;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblDetail.Size = new System.Drawing.Size(882, 190);
            this.tblDetail.TabIndex = 0;
            // 
            // lblClassName
            // 
            this.lblClassName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblClassName.Location = new System.Drawing.Point(4, 1);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(169, 22);
            this.lblClassName.TabIndex = 0;
            this.lblClassName.Text = "Class Name:";
            this.lblClassName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClassNameValue
            // 
            this.lblClassNameValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClassNameValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblClassNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lblClassNameValue.Location = new System.Drawing.Point(180, 1);
            this.lblClassNameValue.Name = "lblClassNameValue";
            this.lblClassNameValue.Size = new System.Drawing.Size(698, 22);
            this.lblClassNameValue.TabIndex = 1;
            this.lblClassNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaxStudents
            // 
            this.lblMaxStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaxStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblMaxStudents.Location = new System.Drawing.Point(4, 24);
            this.lblMaxStudents.Name = "lblMaxStudents";
            this.lblMaxStudents.Size = new System.Drawing.Size(169, 22);
            this.lblMaxStudents.TabIndex = 2;
            this.lblMaxStudents.Text = "Max Students:";
            this.lblMaxStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaxStudentsValue
            // 
            this.lblMaxStudentsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaxStudentsValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaxStudentsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lblMaxStudentsValue.Location = new System.Drawing.Point(180, 24);
            this.lblMaxStudentsValue.Name = "lblMaxStudentsValue";
            this.lblMaxStudentsValue.Size = new System.Drawing.Size(698, 22);
            this.lblMaxStudentsValue.TabIndex = 3;
            this.lblMaxStudentsValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblStartDate.Location = new System.Drawing.Point(4, 47);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(169, 22);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "Start Date:";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStartDateValue
            // 
            this.lblStartDateValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStartDateValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStartDateValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lblStartDateValue.Location = new System.Drawing.Point(180, 47);
            this.lblStartDateValue.Name = "lblStartDateValue";
            this.lblStartDateValue.Size = new System.Drawing.Size(698, 22);
            this.lblStartDateValue.TabIndex = 5;
            this.lblStartDateValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTeacher
            // 
            this.lblTeacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblTeacher.Location = new System.Drawing.Point(4, 70);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(169, 22);
            this.lblTeacher.TabIndex = 6;
            this.lblTeacher.Text = "Teacher ID:";
            this.lblTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTeacherValue
            // 
            this.lblTeacherValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTeacherValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTeacherValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lblTeacherValue.Location = new System.Drawing.Point(180, 70);
            this.lblTeacherValue.Name = "lblTeacherValue";
            this.lblTeacherValue.Size = new System.Drawing.Size(698, 22);
            this.lblTeacherValue.TabIndex = 7;
            this.lblTeacherValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCourseName
            // 
            this.lblCourseName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblCourseName.Location = new System.Drawing.Point(4, 93);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(169, 22);
            this.lblCourseName.TabIndex = 8;
            this.lblCourseName.Text = "Course Name:";
            this.lblCourseName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCourseNameValue
            // 
            this.lblCourseNameValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCourseNameValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCourseNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lblCourseNameValue.Location = new System.Drawing.Point(180, 93);
            this.lblCourseNameValue.Name = "lblCourseNameValue";
            this.lblCourseNameValue.Size = new System.Drawing.Size(698, 22);
            this.lblCourseNameValue.TabIndex = 9;
            this.lblCourseNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCourseDesc
            // 
            this.lblCourseDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCourseDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblCourseDesc.Location = new System.Drawing.Point(4, 116);
            this.lblCourseDesc.Name = "lblCourseDesc";
            this.lblCourseDesc.Size = new System.Drawing.Size(169, 22);
            this.lblCourseDesc.TabIndex = 10;
            this.lblCourseDesc.Text = "Course Description:";
            this.lblCourseDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCourseDescValue
            // 
            this.lblCourseDescValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCourseDescValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCourseDescValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lblCourseDescValue.Location = new System.Drawing.Point(180, 116);
            this.lblCourseDescValue.Name = "lblCourseDescValue";
            this.lblCourseDescValue.Size = new System.Drawing.Size(698, 22);
            this.lblCourseDescValue.TabIndex = 11;
            this.lblCourseDescValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLessons
            // 
            this.lblLessons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLessons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLessons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblLessons.Location = new System.Drawing.Point(4, 139);
            this.lblLessons.Name = "lblLessons";
            this.lblLessons.Size = new System.Drawing.Size(169, 22);
            this.lblLessons.TabIndex = 12;
            this.lblLessons.Text = "Number of Lessons:";
            this.lblLessons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLessonsValue
            // 
            this.lblLessonsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLessonsValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLessonsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lblLessonsValue.Location = new System.Drawing.Point(180, 139);
            this.lblLessonsValue.Name = "lblLessonsValue";
            this.lblLessonsValue.Size = new System.Drawing.Size(698, 22);
            this.lblLessonsValue.TabIndex = 13;
            this.lblLessonsValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCourseFee
            // 
            this.lblCourseFee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCourseFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblCourseFee.Location = new System.Drawing.Point(4, 162);
            this.lblCourseFee.Name = "lblCourseFee";
            this.lblCourseFee.Size = new System.Drawing.Size(169, 27);
            this.lblCourseFee.TabIndex = 14;
            this.lblCourseFee.Text = "Course Fee:";
            this.lblCourseFee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCourseFeeValue
            // 
            this.lblCourseFeeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCourseFeeValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCourseFeeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lblCourseFeeValue.Location = new System.Drawing.Point(180, 162);
            this.lblCourseFeeValue.Name = "lblCourseFeeValue";
            this.lblCourseFeeValue.Size = new System.Drawing.Size(698, 27);
            this.lblCourseFeeValue.TabIndex = 15;
            this.lblCourseFeeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelButtons.Controls.Add(this.btnAttendance);
            this.panelButtons.Controls.Add(this.btnGrades);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelButtons.Location = new System.Drawing.Point(3, 447);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(0, 10, 20, 10);
            this.panelButtons.Size = new System.Drawing.Size(892, 50);
            this.panelButtons.TabIndex = 3;
            // 
            // btnAttendance
            // 
            this.btnAttendance.BorderRadius = 5;
            this.btnAttendance.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAttendance.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAttendance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnAttendance.Location = new System.Drawing.Point(592, 10);
            this.btnAttendance.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(140, 30);
            this.btnAttendance.TabIndex = 0;
            this.btnAttendance.Text = "🧾 Xem điểm danh";
            // 
            // btnGrades
            // 
            this.btnGrades.BorderRadius = 5;
            this.btnGrades.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGrades.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnGrades.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGrades.ForeColor = System.Drawing.Color.White;
            this.btnGrades.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnGrades.Location = new System.Drawing.Point(732, 10);
            this.btnGrades.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Size = new System.Drawing.Size(140, 30);
            this.btnGrades.TabIndex = 1;
            this.btnGrades.Text = "📊 Xem điểm số";
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
            this.lblHeader.Size = new System.Drawing.Size(80, 34);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Lớp học";
            // 
            // colId
            // 
            this.colId.HeaderText = "Class Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colClassName
            // 
            this.colClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colClassName.DataPropertyName = "name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colClassName.DefaultCellStyle = dataGridViewCellStyle3;
            this.colClassName.HeaderText = "Class Name";
            this.colClassName.Name = "colClassName";
            this.colClassName.ReadOnly = true;
            this.colClassName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colCourseId
            // 
            this.colCourseId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCourseId.DataPropertyName = "course_id";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colCourseId.DefaultCellStyle = dataGridViewCellStyle4;
            this.colCourseId.HeaderText = "Course Id";
            this.colCourseId.Name = "colCourseId";
            this.colCourseId.ReadOnly = true;
            this.colCourseId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colMaxStudents
            // 
            this.colMaxStudents.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaxStudents.DataPropertyName = "max_students";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colMaxStudents.DefaultCellStyle = dataGridViewCellStyle5;
            this.colMaxStudents.HeaderText = "Max Students";
            this.colMaxStudents.Name = "colMaxStudents";
            this.colMaxStudents.ReadOnly = true;
            this.colMaxStudents.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colStartDate
            // 
            this.colStartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStartDate.DataPropertyName = "start_date";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colStartDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.colStartDate.HeaderText = "Start Date";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.ReadOnly = true;
            this.colStartDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colTeacherId
            // 
            this.colTeacherId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTeacherId.DataPropertyName = "teacher_id";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colTeacherId.DefaultCellStyle = dataGridViewCellStyle7;
            this.colTeacherId.HeaderText = "Teacher ID";
            this.colTeacherId.Name = "colTeacherId";
            this.colTeacherId.ReadOnly = true;
            this.colTeacherId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Student_ClassCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 500);
            this.Controls.Add(this.panelMain);
            this.Name = "Student_ClassCRUDForm";
            this.Text = "Student_ClassCRUDForm";
            this.Load += new System.EventHandler(this.Student_ClassCRUDForm_Load);
            this.panelMain.ResumeLayout(false);
            this.panelTableContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassList)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelDetail.ResumeLayout(false);
            this.tblDetail.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna2Panel panelMain;
        private Guna2Panel panelDetail;
        private Label lblClassName;
        private Label lblClassNameValue;
        private Label lblCourseName;
        private Label lblCourseNameValue;
        private Label lblCourseDesc;
        private Label lblCourseDescValue;
        private Label lblLessons;
        private Label lblLessonsValue;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tblDetail;
        private Label lblMaxStudents;
        private Label lblMaxStudentsValue;
        private Label lblStartDate;
        private Label lblStartDateValue;
        private Label lblTeacher;
        private Label lblTeacherValue;
        private Label lblCourseFee;
        private Label lblCourseFeeValue;
        private Guna2Panel panelButtons;
        private Guna2Button btnAttendance;
        private Guna2Button btnGrades;
        private Guna2Panel panelHeader;
        private Guna2Panel panelTableContainer;
        private Guna2DataGridView dgvClassList;
        private Guna2TextBox txtSearch;
        private AntdUI.Label lblHeader;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colClassName;
        private DataGridViewTextBoxColumn colCourseId;
        private DataGridViewTextBoxColumn colMaxStudents;
        private DataGridViewTextBoxColumn colStartDate;
        private DataGridViewTextBoxColumn colTeacherId;
    }
}