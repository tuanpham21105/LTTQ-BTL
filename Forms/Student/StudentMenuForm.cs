using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntdUI.Svg;
using Guna.UI2.WinForms;
using prj_LTTQ_BTL.Data;
using prj_LTTQ_BTL.Services;
using prj_LTTQ_BTL.Utils;

namespace prj_LTTQ_BTL.Forms.Student
{
    public partial class StudentMenuForm : Form
    {
        private Form activeForm = null;

        public StudentMenuForm()
        {
            InitializeComponent();
            InitializeEvent();
        }

        private void InitializeEvent()
        {

            btnTTHV.Click += (s, e) =>
            {
                SidebarBtn_Click(btnTTHV);
            };

            btnLH.Click += (s, e) =>
            {
                SidebarBtn_Click(btnLH);
            };

            btnLichHoc.Click += (s, e) =>
            {
                SidebarBtn_Click(btnLichHoc);
            };

            btnKH.Click += (s, e) =>
            {
                SidebarBtn_Click(btnKH);
            };

            btnDiemSo.Click += (s, e) =>
            {
                SidebarBtn_Click(btnDiemSo);
            };

            btnHP.Click += (s, e) =>
            {
                SidebarBtn_Click(btnHP);
            };
        }

        private void StudentMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void SidebarBtn_Click(Guna2Button btn)
        {
            btnTTHV.BackColor = Color.Transparent;
            btnLH.BackColor = Color.Transparent;
            btnLichHoc.BackColor = Color.Transparent;
            btnKH.BackColor = Color.Transparent;
            btnDiemSo.BackColor = Color.Transparent;
            btnHP.BackColor = Color.Transparent;

            btn.BackColor = secondaryColor;

            if (activeForm != null)
            {
                activeForm.Close();
            }

            switch (btn.Text)
            {
                case "Thông tin học viên":
                    activeForm = new Student_StudentInforForm();
                    break;
                case "Lớp học của học viên":
                    activeForm = new Student_ClassCRUDForm();
                    break;
                case "Lịch học":
                    break;
                case "Khóa học":
                    activeForm = new Student_CourseCRUDForm();
                    break;
                case "Điểm số":
                    break;
                case "Học phí":
                    break;
            }

            FormUtils.OpenChildForm(panelMain, activeForm);
        }

        private void btnTTHV_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
