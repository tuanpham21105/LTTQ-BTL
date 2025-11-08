using prj_LTTQ_BTL.Data.repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_LTTQ_BTL.Services
{
    internal class TeacherService
    {
        private readonly TeacherRepository _teacherRepository;
        public TeacherService()
        {
            _teacherRepository = new TeacherRepository();
        }
        public void CreateTeacher(Guid id, string fullName, string specialization, string qualification, string phoneNumber, string email, string address, DateTime startDate)
        {
            _teacherRepository.CreateTeacher(id, fullName, specialization, qualification, phoneNumber, email, address, startDate);
        }
        public DataRow GetTeacherById(Guid id)
        {
            return _teacherRepository.GetTeacherById(id);
        }
        public DataTable GetAllTeachers(int pageNumber, int pageSize)
        {
            return _teacherRepository.GetAllTeachers(pageNumber, pageSize);
        }
        public void UpdateTeacher(Guid id, string fullName, string specialization, string qualification, string phoneNumber, string email, string address, DateTime startDate, string status)
        {
            _teacherRepository.UpdateTeacher(id, fullName, specialization, qualification, phoneNumber, email, address, startDate, status);
        }
        public void DeleteTeacher(Guid id)
        {
            _teacherRepository.DeleteTeacher(id);
        }

        public DataTable SearchTeachers(string keyword)
        {
            return _teacherRepository.SearchTeachers(keyword);
        }

    }
}
