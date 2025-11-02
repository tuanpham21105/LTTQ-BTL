using prj_LTTQ_BTL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_LTTQ_BTL.Forms.Manager
{
    public partial class Manager_StudentCRUDForm : Form
    {
        private readonly StudentService _studentService;
        private int _currentPage = 1;
        private const int PageSize = 10;
        public Manager_StudentCRUDForm()
        {
            InitializeComponent();
            _studentService = new StudentService();
        }
        private void LoadStudents()
        {
            DataTable students = _studentService.GetAllStudents(_currentPage, PageSize);
            dgvStudents.DataSource = students;
        }
        private void Manager_StudentCRUDFormTrue_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _currentPage++;
            LoadStudents();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                LoadStudents();
            }
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
