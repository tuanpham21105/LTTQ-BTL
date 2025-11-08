using prj_LTTQ_BTL.Data.repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_LTTQ_BTL.Services
{
    internal class EnrollmentService
    {
        private readonly EnrollmentRepository _enrollmentRepository;

        public EnrollmentService()
        {
            _enrollmentRepository = new EnrollmentRepository();
        }

        public DataTable GetEnrollments(int pageNumber = -1, int pageSize = 10)
        {
            return _enrollmentRepository.GetEnrollments(pageNumber, pageSize);
        }
        public DataRow GetEnrollmentById(Guid id)
        {
            return _enrollmentRepository.GetEnrollmentById(id);
        }

        public void UpdateEnrollment(Guid id, Guid studentId, Guid courseId, DateTime enrollmentDate, string status)
        {
            _enrollmentRepository.UpdateEnrollment(id, studentId, courseId, enrollmentDate, status);
        }
        public void DeleteEnrollment(Guid id)
        {
            _enrollmentRepository.DeleteEnrollment(id);
        }
        public DataTable SearchEnrollments(string keyword)
        {
            return _enrollmentRepository.SearchEnrollments(keyword);
        }
    }
}
