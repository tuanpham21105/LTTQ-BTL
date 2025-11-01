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
            this.lblTitle = new AntdUI.Label();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMaximize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLH = new Guna.UI2.WinForms.Guna2Button();
            this.btnKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnTTHV = new Guna.UI2.WinForms.Guna2Button();
            this.brandPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblBrand = new AntdUI.Label();
            this.picBrand = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnLichHoc = new Guna.UI2.WinForms.Guna2Button();
            this.btnDiemSo = new Guna.UI2.WinForms.Guna2Button();
            this.btnHP = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader.SuspendLayout();
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
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(280, 32);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panelMain.Size = new System.Drawing.Size(1085, 736);
            this.panelMain.TabIndex = 0;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // panelHeader
            // 
            this.panelHeader.AutoSize = true;
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panelHeader.BorderThickness = 1;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Controls.Add(this.btnMaximize);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(280, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1085, 32);
            this.panelHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(158, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = " Student Menu";
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
            this.btnMinimize.Location = new System.Drawing.Point(950, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 32);
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
            this.btnMaximize.Location = new System.Drawing.Point(995, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(45, 32);
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
            this.btnClose.Location = new System.Drawing.Point(1040, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 32);
            this.btnClose.TabIndex = 3;
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.panelSidebar.Controls.Add(this.btnHP);
            this.panelSidebar.Controls.Add(this.btnDiemSo);
            this.panelSidebar.Controls.Add(this.btnLichHoc);
            this.panelSidebar.Controls.Add(this.btnLH);
            this.panelSidebar.Controls.Add(this.btnKH);
            this.panelSidebar.Controls.Add(this.btnTTHV);
            this.panelSidebar.Controls.Add(this.brandPanel);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.panelSidebar.ShadowDecoration.Depth = 10;
            this.panelSidebar.ShadowDecoration.Enabled = true;
            this.panelSidebar.Size = new System.Drawing.Size(280, 768);
            this.panelSidebar.TabIndex = 2;
            // 
            // btnLH
            // 
            this.btnLH.BorderRadius = 8;
            this.btnLH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLH.FillColor = System.Drawing.Color.Transparent;
            this.btnLH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLH.ForeColor = System.Drawing.Color.White;
            this.btnLH.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnLH.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLH.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLH.Location = new System.Drawing.Point(15, 195);
            this.btnLH.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnLH.Name = "btnLH";
            this.btnLH.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLH.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnLH.Size = new System.Drawing.Size(250, 50);
            this.btnLH.TabIndex = 18;
            this.btnLH.Text = "Lớp học của học viên";
            this.btnLH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnKH
            // 
            this.btnKH.BorderRadius = 8;
            this.btnKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKH.FillColor = System.Drawing.Color.Transparent;
            this.btnKH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKH.ForeColor = System.Drawing.Color.White;
            this.btnKH.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnKH.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnKH.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKH.Location = new System.Drawing.Point(15, 145);
            this.btnKH.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnKH.Name = "btnKH";
            this.btnKH.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnKH.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnKH.Size = new System.Drawing.Size(250, 50);
            this.btnKH.TabIndex = 16;
            this.btnKH.Text = "Khóa học";
            this.btnKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnTTHV
            // 
            this.btnTTHV.BorderRadius = 8;
            this.btnTTHV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTTHV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTTHV.FillColor = System.Drawing.Color.Transparent;
            this.btnTTHV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTTHV.ForeColor = System.Drawing.Color.White;
            this.btnTTHV.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnTTHV.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnTTHV.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTTHV.Location = new System.Drawing.Point(15, 95);
            this.btnTTHV.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnTTHV.Name = "btnTTHV";
            this.btnTTHV.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnTTHV.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnTTHV.Size = new System.Drawing.Size(250, 50);
            this.btnTTHV.TabIndex = 8;
            this.btnTTHV.Text = "Thông tin học viên";
            this.btnTTHV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTTHV.Click += new System.EventHandler(this.btnTTHV_Click);
            // 
            // brandPanel
            // 
            this.brandPanel.BackColor = System.Drawing.Color.Transparent;
            this.brandPanel.Controls.Add(this.lblBrand);
            this.brandPanel.Controls.Add(this.picBrand);
            this.brandPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.brandPanel.Location = new System.Drawing.Point(15, 15);
            this.brandPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brandPanel.Name = "brandPanel";
            this.brandPanel.Padding = new System.Windows.Forms.Padding(11, 15, 11, 15);
            this.brandPanel.Size = new System.Drawing.Size(250, 80);
            this.brandPanel.TabIndex = 7;
            // 
            // lblBrand
            // 
            this.lblBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(62, 15);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(177, 50);
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
            this.picBrand.Location = new System.Drawing.Point(11, 15);
            this.picBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBrand.Name = "picBrand";
            this.picBrand.Size = new System.Drawing.Size(51, 50);
            this.picBrand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBrand.TabIndex = 1;
            this.picBrand.TabStop = false;
            // 
            // btnLichHoc
            // 
            this.btnLichHoc.BorderRadius = 8;
            this.btnLichHoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLichHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLichHoc.FillColor = System.Drawing.Color.Transparent;
            this.btnLichHoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLichHoc.ForeColor = System.Drawing.Color.White;
            this.btnLichHoc.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnLichHoc.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLichHoc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLichHoc.Location = new System.Drawing.Point(15, 245);
            this.btnLichHoc.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnLichHoc.Name = "btnLichHoc";
            this.btnLichHoc.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLichHoc.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnLichHoc.Size = new System.Drawing.Size(250, 50);
            this.btnLichHoc.TabIndex = 20;
            this.btnLichHoc.Text = "Lịch học";
            this.btnLichHoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnDiemSo
            // 
            this.btnDiemSo.BorderRadius = 8;
            this.btnDiemSo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiemSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiemSo.FillColor = System.Drawing.Color.Transparent;
            this.btnDiemSo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDiemSo.ForeColor = System.Drawing.Color.White;
            this.btnDiemSo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnDiemSo.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDiemSo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDiemSo.Location = new System.Drawing.Point(15, 295);
            this.btnDiemSo.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnDiemSo.Name = "btnDiemSo";
            this.btnDiemSo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDiemSo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnDiemSo.Size = new System.Drawing.Size(250, 50);
            this.btnDiemSo.TabIndex = 21;
            this.btnDiemSo.Text = "Điểm số";
            this.btnDiemSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnHP
            // 
            this.btnHP.BorderRadius = 8;
            this.btnHP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHP.FillColor = System.Drawing.Color.Transparent;
            this.btnHP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHP.ForeColor = System.Drawing.Color.White;
            this.btnHP.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnHP.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnHP.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHP.Location = new System.Drawing.Point(15, 345);
            this.btnHP.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnHP.Name = "btnHP";
            this.btnHP.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHP.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnHP.Size = new System.Drawing.Size(250, 50);
            this.btnHP.TabIndex = 22;
            this.btnHP.Text = "Học phí";
            this.btnHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // StudentMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1365, 768);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StudentMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Menu";
            this.Load += new System.EventHandler(this.StudentMenuForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
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
        private Label lblTitle;
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
    }
}