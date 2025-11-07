using prj_LTTQ_BTL.Data.repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_LTTQ_BTL.Services
{
    internal class StudentService
    {
        private readonly StudentRepository _studentRepository;
        public StudentService()
        {
            _studentRepository = new StudentRepository();
        }
        public void CreateStudent(Guid id, string fullName, DateTime birthDate, string gender, string phoneNumber, string email, string address)
        {
            _studentRepository.CreateStudent(id, fullName, birthDate, gender, phoneNumber, email, address);
        }
        public DataRow GetStudentById(Guid id)
        {
            return _studentRepository.GetStudentById(id);
        }
        public DataTable GetAllStudents(int pageNumber = -1, int pageSize = 10)
        {
            return _studentRepository.GetAllStudents(pageNumber, pageSize);
        }
        public void UpdateStudent(Guid id, string fullName, DateTime birthDate, string gender, string phoneNumber, string email, string address, string status)
        {
            _studentRepository.UpdateStudent(id, fullName, birthDate, gender, phoneNumber, email, address, status);
        }
        public void DeleteStudent(Guid id)
        {
            _studentRepository.DeleteStudent(id);
        }
        public DataTable SearchStudents(string keyword)
        {
            return _studentRepository.SearchStudents(keyword);
        }
    }
}
