using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System;
using AntdUI;
using Guna.UI2.WinForms;
using Label = AntdUI.Label;

namespace prj_LTTQ_BTL.Forms.Student
{
    partial class Student_ScoreInforForm
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
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.panelGraph = new Guna.UI2.WinForms.Guna2Panel();
            this.chartScore = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelInfor = new Guna.UI2.WinForms.Guna2Panel();
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
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboboxClasses = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new AntdUI.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new AntdUI.Label();
            this.panelHeaderGap = new Guna.UI2.WinForms.Guna2Panel();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHeader = new AntdUI.Label();
            this.panelMain.SuspendLayout();
            this.panelGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartScore)).BeginInit();
            this.panelInfor.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.panelHeaderGap.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelMain.Controls.Add(this.panelGraph);
            this.panelMain.Controls.Add(this.panelInfor);
            this.panelMain.Controls.Add(this.guna2Panel4);
            this.panelMain.Controls.Add(this.guna2Panel3);
            this.panelMain.Controls.Add(this.guna2Panel1);
            this.panelMain.Controls.Add(this.panelHeaderGap);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(886, 516);
            this.panelMain.TabIndex = 0;
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
            this.panelGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraph.Location = new System.Drawing.Point(0, 296);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Padding = new System.Windows.Forms.Padding(10);
            this.panelGraph.Size = new System.Drawing.Size(886, 220);
            this.panelGraph.TabIndex = 21;
            // 
            // chartScore
            // 
            this.chartScore.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.chartScore.Size = new System.Drawing.Size(866, 200);
            this.chartScore.TabIndex = 0;
            // 
            // panelInfor
            // 
            this.panelInfor.AutoSize = true;
            this.panelInfor.BackColor = System.Drawing.Color.White;
            this.panelInfor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panelInfor.BorderThickness = 1;
            this.panelInfor.Controls.Add(this.tableLayoutPanel2);
            this.panelInfor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfor.Location = new System.Drawing.Point(0, 214);
            this.panelInfor.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelInfor.Name = "panelInfor";
            this.panelInfor.Padding = new System.Windows.Forms.Padding(10);
            this.panelInfor.Size = new System.Drawing.Size(886, 82);
            this.panelInfor.TabIndex = 20;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(866, 62);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // labelTotalNumbers
            // 
            this.labelTotalNumbers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalNumbers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelTotalNumbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.labelTotalNumbers.Location = new System.Drawing.Point(194, 34);
            this.labelTotalNumbers.Name = "labelTotalNumbers";
            this.labelTotalNumbers.Size = new System.Drawing.Size(669, 25);
            this.labelTotalNumbers.TabIndex = 5;
            this.labelTotalNumbers.Text = "Bài kiểm tra ";
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label6.Location = new System.Drawing.Point(194, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(669, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "/ 10  Điểm";
            // 
            // labelNumbers
            // 
            this.labelNumbers.AutoSizeMode = AntdUI.TAutoSize.Width;
            this.labelNumbers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNumbers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelNumbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.labelNumbers.Location = new System.Drawing.Point(176, 34);
            this.labelNumbers.Name = "labelNumbers";
            this.labelNumbers.Size = new System.Drawing.Size(12, 25);
            this.labelNumbers.TabIndex = 3;
            this.labelNumbers.Text = "0";
            this.labelNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSizeMode = AntdUI.TAutoSize.Width;
            this.labelAverage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAverage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelAverage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.labelAverage.Location = new System.Drawing.Point(176, 3);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(12, 25);
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
            this.lblAverage.Size = new System.Drawing.Size(167, 25);
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
            this.lblProgress.Size = new System.Drawing.Size(167, 25);
            this.lblProgress.TabIndex = 0;
            this.lblProgress.Text = "Đã làm: ";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.AutoSize = true;
            this.guna2Panel4.Controls.Add(this.guna2Panel5);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 160);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.guna2Panel4.Size = new System.Drawing.Size(886, 54);
            this.guna2Panel4.TabIndex = 19;
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
            this.guna2Panel5.Size = new System.Drawing.Size(886, 44);
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
            this.label2.Size = new System.Drawing.Size(99, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Điểm số";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.AutoSize = true;
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.guna2Panel3.BorderRadius = 12;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.tableLayoutPanel1);
            this.guna2Panel3.CustomizableEdges.TopLeft = false;
            this.guna2Panel3.CustomizableEdges.TopRight = false;
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 98);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Padding = new System.Windows.Forms.Padding(10);
            this.guna2Panel3.Size = new System.Drawing.Size(886, 62);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(866, 42);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.comboboxClasses.Location = new System.Drawing.Point(262, 3);
            this.comboboxClasses.Name = "comboboxClasses";
            this.comboboxClasses.Size = new System.Drawing.Size(601, 36);
            this.comboboxClasses.TabIndex = 0;
            this.comboboxClasses.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 36);
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
            this.guna2Panel1.Size = new System.Drawing.Size(886, 44);
            this.guna2Panel1.TabIndex = 17;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.guna2Panel2.BorderRadius = 12;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.CustomizableEdges.BottomLeft = false;
            this.guna2Panel2.CustomizableEdges.BottomRight = false;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.guna2Panel2.Size = new System.Drawing.Size(886, 44);
            this.guna2Panel2.TabIndex = 12;
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
            this.label1.Size = new System.Drawing.Size(76, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bộ lọc";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHeaderGap
            // 
            this.panelHeaderGap.AutoSize = true;
            this.panelHeaderGap.Controls.Add(this.panelHeader);
            this.panelHeaderGap.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderGap.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderGap.Name = "panelHeaderGap";
            this.panelHeaderGap.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panelHeaderGap.Size = new System.Drawing.Size(886, 54);
            this.panelHeaderGap.TabIndex = 16;
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
            this.panelHeader.Size = new System.Drawing.Size(886, 44);
            this.panelHeader.TabIndex = 12;
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
            this.lblHeader.Size = new System.Drawing.Size(297, 34);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Bảng điểm học viên";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Student_ScoreInforForm
            // 
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(886, 516);
            this.Controls.Add(this.panelMain);
            this.Name = "Student_ScoreInforForm";
            this.Text = "Student_ScoreInforForm";
            this.Load += new System.EventHandler(this.Student_ScoreInforForm_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartScore)).EndInit();
            this.panelInfor.ResumeLayout(false);
            this.panelInfor.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.panelHeaderGap.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // 🧩 Components
        Guna2Panel panelMain;
        private Guna2Panel panelGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartScore;
        private Guna2Panel panelInfor;
        private Label lblProgress;
        private Label lblAverage;
        private Guna2Panel guna2Panel4;
        private Guna2Panel guna2Panel5;
        private Label label2;
        private Guna2Panel guna2Panel3;
        private Guna2ComboBox comboboxClasses;
        private Guna2Panel guna2Panel1;
        private Guna2Panel guna2Panel2;
        private Label label1;
        private Guna2Panel panelHeaderGap;
        private Guna2Panel panelHeader;
        private Label lblHeader;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelTotalNumbers;
        private Label label6;
        private Label labelNumbers;
        private Label labelAverage;
    }
}