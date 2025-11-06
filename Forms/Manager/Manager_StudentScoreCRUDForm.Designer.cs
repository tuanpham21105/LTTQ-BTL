using Guna.UI2.WinForms;

namespace prj_LTTQ_BTL.Forms.Manager
{
    partial class Manager_StudentScoreCRUDForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHeader = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearchStudent = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboboxClasses = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new AntdUI.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelHeaderGap = new Guna.UI2.WinForms.Guna2Panel();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.panelGraph = new Guna.UI2.WinForms.Guna2Panel();
            this.chartScore = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelInfor = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel10 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRefreshGraph = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTotalNumbers = new AntdUI.Label();
            this.label6 = new AntdUI.Label();
            this.labelNumbers = new AntdUI.Label();
            this.labelAverage = new AntdUI.Label();
            this.lblAverage = new AntdUI.Label();
            this.lblProgress = new AntdUI.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new AntdUI.Label();
            this.guna2Panel9 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new AntdUI.Label();
            this.txtDiemSo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new AntdUI.Label();
            this.label5 = new AntdUI.Label();
            this.txtTenBaiKT = new Guna.UI2.WinForms.Guna2TextBox();
            this.dateNgayKT = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panelDgvScores = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvExam = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelWarning1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label10 = new AntdUI.Label();
            this.panelWarning = new Guna.UI2.WinForms.Guna2Panel();
            this.label9 = new AntdUI.Label();
            this.panelButtons = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new AntdUI.Label();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvStudent = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exam_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exam_score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel2.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panelHeaderGap.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartScore)).BeginInit();
            this.panelInfor.SuspendLayout();
            this.guna2Panel10.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel9.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelDgvScores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExam)).BeginInit();
            this.panelWarning1.SuspendLayout();
            this.panelWarning.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            this.guna2Panel8.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
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
            this.lblHeader.Size = new System.Drawing.Size(252, 34);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Quản lý điểm số học viên";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.label1.Size = new System.Drawing.Size(124, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bộ lọc học viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.guna2Panel2.BorderRadius = 12;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.txtSearchStudent);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.CustomizableEdges.BottomLeft = false;
            this.guna2Panel2.CustomizableEdges.BottomRight = false;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.guna2Panel2.Size = new System.Drawing.Size(783, 44);
            this.guna2Panel2.TabIndex = 12;
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSearchStudent.BorderRadius = 8;
            this.txtSearchStudent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchStudent.DefaultText = "";
            this.txtSearchStudent.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtSearchStudent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchStudent.Location = new System.Drawing.Point(478, 5);
            this.txtSearchStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.PlaceholderText = "Search students...";
            this.txtSearchStudent.SelectedText = "";
            this.txtSearchStudent.Size = new System.Drawing.Size(300, 34);
            this.txtSearchStudent.TabIndex = 5;
            this.txtSearchStudent.TextChanged += new System.EventHandler(this.txtSearchStudent_TextChanged);
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
            this.panelHeader.Size = new System.Drawing.Size(783, 44);
            this.panelHeader.TabIndex = 12;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.AutoSize = true;
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.guna2Panel3.BorderRadius = 12;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.guna2Panel6);
            this.guna2Panel3.Controls.Add(this.tableLayoutPanel1);
            this.guna2Panel3.CustomizableEdges.TopLeft = false;
            this.guna2Panel3.CustomizableEdges.TopRight = false;
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 98);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Padding = new System.Windows.Forms.Padding(10);
            this.guna2Panel3.Size = new System.Drawing.Size(783, 293);
            this.guna2Panel3.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.comboboxClasses, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(763, 42);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // comboboxClasses
            // 
            this.comboboxClasses.BackColor = System.Drawing.Color.Transparent;
            this.comboboxClasses.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.comboboxClasses.BorderRadius = 8;
            this.comboboxClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboboxClasses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboboxClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxClasses.FocusedColor = System.Drawing.Color.Empty;
            this.comboboxClasses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboboxClasses.ForeColor = System.Drawing.Color.Black;
            this.comboboxClasses.ItemHeight = 30;
            this.comboboxClasses.Location = new System.Drawing.Point(231, 3);
            this.comboboxClasses.Name = "comboboxClasses";
            this.comboboxClasses.Size = new System.Drawing.Size(529, 36);
            this.comboboxClasses.TabIndex = 0;
            this.comboboxClasses.SelectedIndexChanged += new System.EventHandler(this.comboboxClasses_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chọn lớp học";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoSize = true;
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.CustomizableEdges.BottomLeft = false;
            this.guna2Panel1.CustomizableEdges.BottomRight = false;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 54);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(783, 44);
            this.guna2Panel1.TabIndex = 17;
            // 
            // panelHeaderGap
            // 
            this.panelHeaderGap.AutoSize = true;
            this.panelHeaderGap.Controls.Add(this.panelHeader);
            this.panelHeaderGap.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderGap.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderGap.Name = "panelHeaderGap";
            this.panelHeaderGap.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panelHeaderGap.Size = new System.Drawing.Size(783, 54);
            this.panelHeaderGap.TabIndex = 16;
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelMain.Controls.Add(this.panelGraph);
            this.panelMain.Controls.Add(this.panelInfor);
            this.panelMain.Controls.Add(this.guna2Panel4);
            this.panelMain.Controls.Add(this.guna2Panel9);
            this.panelMain.Controls.Add(this.guna2Panel7);
            this.panelMain.Controls.Add(this.guna2Panel3);
            this.panelMain.Controls.Add(this.guna2Panel1);
            this.panelMain.Controls.Add(this.panelHeaderGap);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 450);
            this.panelMain.TabIndex = 1;
            // 
            // panelGraph
            // 
            this.panelGraph.BackColor = System.Drawing.Color.White;
            this.panelGraph.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panelGraph.BorderRadius = 12;
            this.panelGraph.BorderThickness = 1;
            this.panelGraph.Controls.Add(this.chartScore);
            this.panelGraph.CustomizableEdges.TopLeft = false;
            this.panelGraph.CustomizableEdges.TopRight = false;
            this.panelGraph.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGraph.Location = new System.Drawing.Point(0, 1130);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Padding = new System.Windows.Forms.Padding(10);
            this.panelGraph.Size = new System.Drawing.Size(783, 361);
            this.panelGraph.TabIndex = 26;
            // 
            // chartScore
            // 
            this.chartScore.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            chartArea1.AxisX.Title = "Ngày kiểm tra";
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            chartArea1.AxisY.Title = "Điểm số";
            chartArea1.Name = "MainArea";
            this.chartScore.ChartAreas.Add(chartArea1);
            this.chartScore.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend";
            this.chartScore.Legends.Add(legend1);
            this.chartScore.Location = new System.Drawing.Point(10, 10);
            this.chartScore.Name = "chartScore";
            series1.BorderWidth = 3;
            series1.ChartArea = "MainArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            series1.Legend = "Legend";
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            series1.MarkerSize = 8;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Score";
            this.chartScore.Series.Add(series1);
            this.chartScore.Size = new System.Drawing.Size(763, 341);
            this.chartScore.TabIndex = 0;
            // 
            // panelInfor
            // 
            this.panelInfor.AutoSize = true;
            this.panelInfor.BackColor = System.Drawing.Color.White;
            this.panelInfor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panelInfor.BorderThickness = 1;
            this.panelInfor.Controls.Add(this.guna2Panel10);
            this.panelInfor.Controls.Add(this.tableLayoutPanel2);
            this.panelInfor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfor.Location = new System.Drawing.Point(0, 1001);
            this.panelInfor.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelInfor.Name = "panelInfor";
            this.panelInfor.Padding = new System.Windows.Forms.Padding(10);
            this.panelInfor.Size = new System.Drawing.Size(783, 129);
            this.panelInfor.TabIndex = 25;
            // 
            // guna2Panel10
            // 
            this.guna2Panel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel10.Controls.Add(this.btnRefreshGraph);
            this.guna2Panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel10.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel10.Location = new System.Drawing.Point(10, 72);
            this.guna2Panel10.Name = "guna2Panel10";
            this.guna2Panel10.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.guna2Panel10.Size = new System.Drawing.Size(763, 47);
            this.guna2Panel10.TabIndex = 16;
            this.guna2Panel10.Visible = false;
            // 
            // btnRefreshGraph
            // 
            this.btnRefreshGraph.BorderRadius = 5;
            this.btnRefreshGraph.DefaultAutoSize = true;
            this.btnRefreshGraph.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefreshGraph.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnRefreshGraph.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefreshGraph.ForeColor = System.Drawing.Color.White;
            this.btnRefreshGraph.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnRefreshGraph.Location = new System.Drawing.Point(620, 10);
            this.btnRefreshGraph.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnRefreshGraph.Name = "btnRefreshGraph";
            this.btnRefreshGraph.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnRefreshGraph.Size = new System.Drawing.Size(143, 37);
            this.btnRefreshGraph.TabIndex = 5;
            this.btnRefreshGraph.Text = "Làm mới biểu đồ";
            this.btnRefreshGraph.Click += new System.EventHandler(this.btnRefreshGraph_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.labelTotalNumbers, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelNumbers, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelAverage, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblAverage, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblProgress, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(763, 62);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // labelTotalNumbers
            // 
            this.labelTotalNumbers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalNumbers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelTotalNumbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.labelTotalNumbers.Location = new System.Drawing.Point(162, 34);
            this.labelTotalNumbers.Name = "labelTotalNumbers";
            this.labelTotalNumbers.Size = new System.Drawing.Size(598, 25);
            this.labelTotalNumbers.TabIndex = 5;
            this.labelTotalNumbers.Text = "Bài kiểm tra ";
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label6.Location = new System.Drawing.Point(162, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(598, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "/ 10  Điểm";
            // 
            // labelNumbers
            // 
            this.labelNumbers.AutoSizeMode = AntdUI.TAutoSize.Width;
            this.labelNumbers.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelNumbers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelNumbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.labelNumbers.Location = new System.Drawing.Point(148, 34);
            this.labelNumbers.Name = "labelNumbers";
            this.labelNumbers.Size = new System.Drawing.Size(8, 25);
            this.labelNumbers.TabIndex = 3;
            this.labelNumbers.Text = "0";
            this.labelNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSizeMode = AntdUI.TAutoSize.Width;
            this.labelAverage.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelAverage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelAverage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.labelAverage.Location = new System.Drawing.Point(148, 3);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(8, 25);
            this.labelAverage.TabIndex = 2;
            this.labelAverage.Text = "0";
            this.labelAverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSizeMode = AntdUI.TAutoSize.Width;
            this.lblAverage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAverage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAverage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblAverage.Location = new System.Drawing.Point(3, 3);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(111, 25);
            this.lblAverage.TabIndex = 1;
            this.lblAverage.Text = "Điểm trung bình: ";
            // 
            // lblProgress
            // 
            this.lblProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProgress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblProgress.Location = new System.Drawing.Point(3, 34);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(139, 25);
            this.lblProgress.TabIndex = 0;
            this.lblProgress.Text = "Đã làm: ";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.AutoSize = true;
            this.guna2Panel4.Controls.Add(this.guna2Panel5);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 947);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.guna2Panel4.Size = new System.Drawing.Size(783, 54);
            this.guna2Panel4.TabIndex = 24;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.guna2Panel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.guna2Panel5.BorderRadius = 12;
            this.guna2Panel5.BorderThickness = 1;
            this.guna2Panel5.Controls.Add(this.label2);
            this.guna2Panel5.CustomizableEdges.BottomLeft = false;
            this.guna2Panel5.CustomizableEdges.BottomRight = false;
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel5.FillColor = System.Drawing.Color.White;
            this.guna2Panel5.Location = new System.Drawing.Point(0, 10);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Padding = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.guna2Panel5.Size = new System.Drawing.Size(783, 44);
            this.guna2Panel5.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSizeMode = AntdUI.TAutoSize.Width;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label2.Location = new System.Drawing.Point(20, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thống kê điểm số của học viên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel9
            // 
            this.guna2Panel9.AutoSize = true;
            this.guna2Panel9.BackColor = System.Drawing.Color.White;
            this.guna2Panel9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.guna2Panel9.BorderRadius = 12;
            this.guna2Panel9.BorderThickness = 1;
            this.guna2Panel9.Controls.Add(this.tableLayoutPanel3);
            this.guna2Panel9.Controls.Add(this.panelDgvScores);
            this.guna2Panel9.Controls.Add(this.panelWarning1);
            this.guna2Panel9.Controls.Add(this.panelWarning);
            this.guna2Panel9.Controls.Add(this.panelButtons);
            this.guna2Panel9.CustomizableEdges.TopLeft = false;
            this.guna2Panel9.CustomizableEdges.TopRight = false;
            this.guna2Panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel9.Location = new System.Drawing.Point(0, 445);
            this.guna2Panel9.Name = "guna2Panel9";
            this.guna2Panel9.Padding = new System.Windows.Forms.Padding(10);
            this.guna2Panel9.Size = new System.Drawing.Size(783, 502);
            this.guna2Panel9.TabIndex = 23;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtDiemSo, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtTenBaiKT, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.dateNgayKT, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 317);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(763, 132);
            this.tableLayoutPanel3.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label8.Location = new System.Drawing.Point(3, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 36);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ngày kiểm tra";
            // 
            // txtDiemSo
            // 
            this.txtDiemSo.BorderRadius = 8;
            this.txtDiemSo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiemSo.DefaultText = "";
            this.txtDiemSo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiemSo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiemSo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiemSo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiemSo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiemSo.Enabled = false;
            this.txtDiemSo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiemSo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiemSo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiemSo.Location = new System.Drawing.Point(231, 49);
            this.txtDiemSo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiemSo.Name = "txtDiemSo";
            this.txtDiemSo.PlaceholderText = "";
            this.txtDiemSo.SelectedText = "";
            this.txtDiemSo.Size = new System.Drawing.Size(529, 37);
            this.txtDiemSo.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label7.Location = new System.Drawing.Point(3, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 39);
            this.label7.TabIndex = 3;
            this.label7.Text = "Điểm số";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 39);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên bài kiểm tra";
            // 
            // txtTenBaiKT
            // 
            this.txtTenBaiKT.BorderRadius = 8;
            this.txtTenBaiKT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenBaiKT.DefaultText = "";
            this.txtTenBaiKT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenBaiKT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenBaiKT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenBaiKT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenBaiKT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenBaiKT.Enabled = false;
            this.txtTenBaiKT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenBaiKT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenBaiKT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenBaiKT.Location = new System.Drawing.Point(231, 4);
            this.txtTenBaiKT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenBaiKT.Name = "txtTenBaiKT";
            this.txtTenBaiKT.PlaceholderText = "";
            this.txtTenBaiKT.SelectedText = "";
            this.txtTenBaiKT.Size = new System.Drawing.Size(529, 37);
            this.txtTenBaiKT.TabIndex = 2;
            // 
            // dateNgayKT
            // 
            this.dateNgayKT.BorderRadius = 8;
            this.dateNgayKT.Checked = true;
            this.dateNgayKT.CustomFormat = "HH:mm - dd/MM/yyyy ";
            this.dateNgayKT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateNgayKT.Enabled = false;
            this.dateNgayKT.FillColor = System.Drawing.Color.White;
            this.dateNgayKT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayKT.Location = new System.Drawing.Point(231, 93);
            this.dateNgayKT.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateNgayKT.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateNgayKT.Name = "dateNgayKT";
            this.dateNgayKT.ShowUpDown = true;
            this.dateNgayKT.Size = new System.Drawing.Size(529, 36);
            this.dateNgayKT.TabIndex = 6;
            this.dateNgayKT.Value = new System.DateTime(2025, 11, 3, 0, 0, 0, 0);
            // 
            // panelDgvScores
            // 
            this.panelDgvScores.Controls.Add(this.dgvExam);
            this.panelDgvScores.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDgvScores.Location = new System.Drawing.Point(10, 86);
            this.panelDgvScores.Name = "panelDgvScores";
            this.panelDgvScores.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelDgvScores.Size = new System.Drawing.Size(763, 231);
            this.panelDgvScores.TabIndex = 17;
            // 
            // dgvExam
            // 
            this.dgvExam.AllowUserToAddRows = false;
            this.dgvExam.AllowUserToDeleteRows = false;
            this.dgvExam.AllowUserToResizeColumns = false;
            this.dgvExam.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dgvExam.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvExam.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvExam.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvExam.ColumnHeadersHeight = 32;
            this.dgvExam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exam_name,
            this.exam_score,
            this.date});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExam.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvExam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExam.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dgvExam.Location = new System.Drawing.Point(0, 10);
            this.dgvExam.MultiSelect = false;
            this.dgvExam.Name = "dgvExam";
            this.dgvExam.ReadOnly = true;
            this.dgvExam.RowHeadersVisible = false;
            this.dgvExam.RowHeadersWidth = 51;
            this.dgvExam.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvExam.Size = new System.Drawing.Size(763, 211);
            this.dgvExam.TabIndex = 1;
            this.dgvExam.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dgvExam.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvExam.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvExam.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvExam.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvExam.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvExam.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dgvExam.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.dgvExam.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvExam.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.dgvExam.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvExam.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvExam.ThemeStyle.HeaderStyle.Height = 32;
            this.dgvExam.ThemeStyle.ReadOnly = true;
            this.dgvExam.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvExam.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvExam.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvExam.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.dgvExam.ThemeStyle.RowsStyle.Height = 22;
            this.dgvExam.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.dgvExam.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvExam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExam_CellClick);
            // 
            // panelWarning1
            // 
            this.panelWarning1.AutoSize = true;
            this.panelWarning1.BackColor = System.Drawing.Color.Transparent;
            this.panelWarning1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panelWarning1.BorderRadius = 6;
            this.panelWarning1.Controls.Add(this.label10);
            this.panelWarning1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWarning1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelWarning1.Location = new System.Drawing.Point(10, 48);
            this.panelWarning1.Name = "panelWarning1";
            this.panelWarning1.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panelWarning1.Size = new System.Drawing.Size(763, 38);
            this.panelWarning1.TabIndex = 16;
            this.panelWarning1.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(20, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "❗ Học viên chưa có điểm trong lớp";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelWarning
            // 
            this.panelWarning.AutoSize = true;
            this.panelWarning.BackColor = System.Drawing.Color.Transparent;
            this.panelWarning.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panelWarning.BorderRadius = 6;
            this.panelWarning.Controls.Add(this.label9);
            this.panelWarning.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWarning.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelWarning.Location = new System.Drawing.Point(10, 10);
            this.panelWarning.Name = "panelWarning";
            this.panelWarning.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panelWarning.Size = new System.Drawing.Size(763, 38);
            this.panelWarning.TabIndex = 13;
            this.panelWarning.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.label9.Location = new System.Drawing.Point(20, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(284, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "❌ Không có thông tin của học viên trong lớp";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.Transparent;
            this.panelButtons.Controls.Add(this.btnThem);
            this.panelButtons.Controls.Add(this.btnXoa);
            this.panelButtons.Controls.Add(this.btnLuu);
            this.panelButtons.Controls.Add(this.btnHuy);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.FillColor = System.Drawing.Color.White;
            this.panelButtons.Location = new System.Drawing.Point(10, 449);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(0, 4, 9, 4);
            this.panelButtons.Size = new System.Drawing.Size(763, 43);
            this.panelButtons.TabIndex = 12;
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 5;
            this.btnThem.DefaultAutoSize = true;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnThem.Location = new System.Drawing.Point(405, 4);
            this.btnThem.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnThem.Size = new System.Drawing.Size(111, 35);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm điểm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 5;
            this.btnXoa.DefaultAutoSize = true;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnXoa.Location = new System.Drawing.Point(516, 4);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnXoa.Size = new System.Drawing.Size(101, 35);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa điểm";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BorderRadius = 5;
            this.btnLuu.DefaultAutoSize = true;
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnLuu.Location = new System.Drawing.Point(617, 4);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnLuu.Size = new System.Drawing.Size(68, 35);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Visible = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BorderRadius = 5;
            this.btnHuy.DefaultAutoSize = true;
            this.btnHuy.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnHuy.Location = new System.Drawing.Point(685, 4);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnHuy.Size = new System.Drawing.Size(69, 35);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.AutoSize = true;
            this.guna2Panel7.Controls.Add(this.guna2Panel8);
            this.guna2Panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel7.Location = new System.Drawing.Point(0, 391);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.guna2Panel7.Size = new System.Drawing.Size(783, 54);
            this.guna2Panel7.TabIndex = 22;
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.guna2Panel8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.guna2Panel8.BorderRadius = 12;
            this.guna2Panel8.BorderThickness = 1;
            this.guna2Panel8.Controls.Add(this.label4);
            this.guna2Panel8.CustomizableEdges.BottomLeft = false;
            this.guna2Panel8.CustomizableEdges.BottomRight = false;
            this.guna2Panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel8.FillColor = System.Drawing.Color.White;
            this.guna2Panel8.Location = new System.Drawing.Point(0, 10);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.Padding = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.guna2Panel8.Size = new System.Drawing.Size(783, 44);
            this.guna2Panel8.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSizeMode = AntdUI.TAutoSize.Width;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label4.Location = new System.Drawing.Point(20, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 34);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cập nhật điểm số của học viên";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.Controls.Add(this.dgvStudent);
            this.guna2Panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel6.Location = new System.Drawing.Point(10, 52);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.guna2Panel6.Size = new System.Drawing.Size(763, 231);
            this.guna2Panel6.TabIndex = 4;
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.AllowUserToResizeColumns = false;
            this.dgvStudent.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dgvStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvStudent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvStudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudent.ColumnHeadersHeight = 32;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.full_name,
            this.birth_date,
            this.gender,
            this.phone_number,
            this.email,
            this.address});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dgvStudent.Location = new System.Drawing.Point(0, 10);
            this.dgvStudent.MultiSelect = false;
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowHeadersVisible = false;
            this.dgvStudent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvStudent.Size = new System.Drawing.Size(763, 221);
            this.dgvStudent.TabIndex = 1;
            this.dgvStudent.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dgvStudent.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvStudent.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvStudent.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvStudent.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvStudent.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvStudent.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dgvStudent.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.dgvStudent.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvStudent.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.dgvStudent.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStudent.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStudent.ThemeStyle.HeaderStyle.Height = 32;
            this.dgvStudent.ThemeStyle.ReadOnly = true;
            this.dgvStudent.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStudent.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStudent.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvStudent.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.dgvStudent.ThemeStyle.RowsStyle.Height = 22;
            this.dgvStudent.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.dgvStudent.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 23.81392F;
            this.id.HeaderText = "Mã học viên";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Width = 110;
            // 
            // full_name
            // 
            this.full_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.full_name.DataPropertyName = "full_name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.full_name.DefaultCellStyle = dataGridViewCellStyle3;
            this.full_name.FillWeight = 23.81392F;
            this.full_name.HeaderText = "Tên học viên";
            this.full_name.MinimumWidth = 6;
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            this.full_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.full_name.Width = 112;
            // 
            // birth_date
            // 
            this.birth_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.birth_date.DataPropertyName = "birth_date";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.birth_date.DefaultCellStyle = dataGridViewCellStyle4;
            this.birth_date.FillWeight = 23.81392F;
            this.birth_date.HeaderText = "Ngày sinh";
            this.birth_date.MinimumWidth = 6;
            this.birth_date.Name = "birth_date";
            this.birth_date.ReadOnly = true;
            this.birth_date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.birth_date.Width = 96;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gender.DataPropertyName = "gender";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gender.DefaultCellStyle = dataGridViewCellStyle5;
            this.gender.FillWeight = 23.81392F;
            this.gender.HeaderText = "Giới tính";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gender.Width = 89;
            // 
            // phone_number
            // 
            this.phone_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phone_number.DataPropertyName = "phone_number";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.phone_number.DefaultCellStyle = dataGridViewCellStyle6;
            this.phone_number.HeaderText = "Số điện thoại";
            this.phone_number.MinimumWidth = 6;
            this.phone_number.Name = "phone_number";
            this.phone_number.ReadOnly = true;
            this.phone_number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "email";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.email.DefaultCellStyle = dataGridViewCellStyle7;
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.address.DataPropertyName = "address";
            this.address.FillWeight = 23.81392F;
            this.address.HeaderText = "Địa chỉ";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.address.Width = 77;
            // 
            // exam_name
            // 
            this.exam_name.DataPropertyName = "name";
            this.exam_name.HeaderText = "Tên bài kiểm tra";
            this.exam_name.MinimumWidth = 6;
            this.exam_name.Name = "exam_name";
            this.exam_name.ReadOnly = true;
            // 
            // exam_score
            // 
            this.exam_score.DataPropertyName = "score";
            this.exam_score.HeaderText = "Điểm số";
            this.exam_score.MinimumWidth = 6;
            this.exam_score.Name = "exam_score";
            this.exam_score.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "created_date";
            this.date.HeaderText = "Ngày thực hiện";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // Manager_StudentScoreCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Name = "Manager_StudentScoreCRUDForm";
            this.Text = "Manager_StudentScoreCRUDFOrm";
            this.Load += new System.EventHandler(this.Manager_StudentScoreCRUDForm_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.panelHeaderGap.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartScore)).EndInit();
            this.panelInfor.ResumeLayout(false);
            this.panelInfor.PerformLayout();
            this.guna2Panel10.ResumeLayout(false);
            this.guna2Panel10.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.guna2Panel9.ResumeLayout(false);
            this.guna2Panel9.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panelDgvScores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExam)).EndInit();
            this.panelWarning1.ResumeLayout(false);
            this.panelWarning1.PerformLayout();
            this.panelWarning.ResumeLayout(false);
            this.panelWarning.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel8.ResumeLayout(false);
            this.guna2Panel8.PerformLayout();
            this.guna2Panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Label lblHeader;
        private AntdUI.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel panelHeaderGap;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2ComboBox comboboxClasses;
        private AntdUI.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchStudent;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        private AntdUI.Label label4;
        private Guna.UI2.WinForms.Guna2Panel panelInfor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private AntdUI.Label labelTotalNumbers;
        private AntdUI.Label label6;
        private AntdUI.Label labelNumbers;
        private AntdUI.Label labelAverage;
        private AntdUI.Label lblAverage;
        private AntdUI.Label lblProgress;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private AntdUI.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel9;
        private Guna.UI2.WinForms.Guna2Panel panelDgvScores;
        private Guna.UI2.WinForms.Guna2DataGridView dgvExam;
        private Guna.UI2.WinForms.Guna2Panel panelWarning1;
        private AntdUI.Label label10;
        private Guna.UI2.WinForms.Guna2Panel panelWarning;
        private AntdUI.Label label9;
        private Guna.UI2.WinForms.Guna2Panel panelButtons;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private AntdUI.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtDiemSo;
        private AntdUI.Label label7;
        private AntdUI.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtTenBaiKT;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateNgayKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private Guna2Button btnThem;
        private Guna2Button btnXoa;
        private Guna2Button btnLuu;
        private Guna2Panel panelGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartScore;
        private Guna2Panel guna2Panel10;
        private Guna2Button btnRefreshGraph;
        private Guna2Panel guna2Panel6;
        private Guna2DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn exam_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn exam_score;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}