using Guna.UI2.WinForms;
using prj_LTTQ_BTL.Forms.Student;
using prj_LTTQ_BTL.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_LTTQ_BTL.Forms.Manager
{
    public partial class ManagerMenuForm : Form
    {
        private readonly Color primaryColor = Color.FromArgb(0, 120, 215);
        private readonly Color secondaryColor = Color.FromArgb(43, 136, 216);
        private readonly Color backgroundColor = Color.FromArgb(243, 243, 243);
        private readonly Color cardColor = Color.White;
        private readonly Color textPrimary = Color.Black;
        private readonly Color textSecondary = Color.FromArgb(85, 85, 85);
        private readonly Color dangerColor = Color.FromArgb(232, 17, 35);
        private readonly Color borderColor = Color.FromArgb(204, 204, 204);
        private bool isPanelStudentVisible = false;
        private Form activeForm = null;

        public ManagerMenuForm()
        {
            InitializeComponent();
            InitializeEvent();
        }
        private void InitializeEvent()
        {
            btnStudentList.Click += (s, e) =>
            {
                SidebarBtn_Click(btnStudentList, "Danh sách học viên");
            };
            btnTeacher.Click += (s, e) =>
            {
                SidebarBtn_Click(btnTeacher, "Danh sách giáo viên");
            };
            btnCourse.Click += (s, e) =>
            {
                SidebarBtn_Click(btnCourse, "Danh sách khóa học");
            };
            btnStudentScore.Click += (s, e) =>
            {
                SidebarBtn_Click(btnStudentScore, "Danh sách điểm học viên");
            };
            btnStudentAttendance.Click += (s, e) =>
            {
                SidebarBtn_Click(btnStudentAttendance, "Danh sách điểm danh học viên");
            };
            btnClass.Click += (s, e) =>
            {
                SidebarBtn_Click(btnClass, "Danh sách lớp học");
            };
            btnStudent.Click += (s, e) =>
            {
                TogglePanelStudent(); 
            };

        }
        private void SidebarBtn_Click(Guna2Button btn, string formType)
        {
           
            btnStudentList.BackColor = Color.Transparent;
            btnTeacher.BackColor = Color.Transparent;
            btnCourse.BackColor = Color.Transparent;

            btn.BackColor = secondaryColor;

            if (activeForm != null)
            {
                activeForm.Close();
            }

            switch (formType)
            {
                case "Danh sách học viên":
                    activeForm = new Manager_StudentCRUDForm();
                    break;
                case "Danh sách giáo viên":
                    activeForm = new Manager_TeacherCRUDForm();
                    break;
                case "Danh sách khóa học":
                    activeForm = new Manager_CourseCRUDForm();
                    break;
                case "Danh sách điểm học viên":
                    activeForm = new Manager_StudentScoreCRUDForm();
                    break;
                case "Danh sách điểm danh học viên":
                    activeForm = new Manager_StudentAttendanceCRUDForm();
                    break;
                case "Danh sách lớp học":
                    activeForm = new Manager_ClassCRUDForm();
                    break;
            }

            FormUtils.OpenChildForm(panelMain, activeForm);
        }
        private void ManagerMenuForm_Load(object sender, EventArgs e)
        {

        }
        private void TogglePanelStudent()
        {
            if (isPanelStudentVisible)
            {
                panelStudent.Visible = false;
                isPanelStudentVisible = false;
            }
            else
            {
                panelStudent.Visible = true;
                isPanelStudentVisible = true;
            }
        }
        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnStudentScore_Click(object sender, EventArgs e)
        {

        }
    }
}
