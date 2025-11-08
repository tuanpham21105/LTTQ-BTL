using prj_LTTQ_BTL.Data.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_LTTQ_BTL.Data.repository
{
    internal class EnrollmentRepository : BaseRepository
    {
        public DataTable GetEnrollments(int page, int pageSize)
        {
            string query;

            if (page == -1)
            {
                query = @"
                    SELECT e.id, 
                           e.enrollment_date, 
                           e.status, 
                           e.student_id, -- Thêm student_id
                           e.course_id,  -- Thêm course_id
                           s.full_name AS student_name, 
                           c.name AS course_name
                    FROM Enrollment e
                    JOIN Student s ON e.student_id = s.id
                    JOIN Course c ON e.course_id = c.id
                    ORDER BY e.enrollment_date DESC";
            }
            else
            {
                int offset = (page - 1) * pageSize;
                query = $@"
                    SELECT e.id, 
                           e.enrollment_date, 
                           e.status, 
                           e.student_id, -- Thêm student_id
                           e.course_id,  -- Thêm course_id
                           s.full_name AS student_name, 
                           c.name AS course_name
                    FROM Enrollment e
                    JOIN Student s ON e.student_id = s.id
                    JOIN Course c ON e.course_id = c.id
                    ORDER BY e.enrollment_date DESC
                    OFFSET {offset} ROWS
                    FETCH NEXT {pageSize} ROWS ONLY";
            }

            return GetDataTable(query);
        }
        public DataRow GetEnrollmentById(Guid id)
        {
            string query = $@"
                SELECT e.id, 
                       e.enrollment_date, 
                       e.status, 
                       e.student_id, 
                       e.course_id, 
                       s.full_name AS student_name, 
                       c.name AS course_name
                FROM Enrollment e
                JOIN Student s ON e.student_id = s.id
                JOIN Course c ON e.course_id = c.id
                WHERE e.id = '{id}'";
            DataTable result = GetDataTable(query);
            return result.Rows.Count > 0 ? result.Rows[0] : null;
        }
        //public void AddEnrollment(Guid id, Guid studentId, Guid courseId, DateTime enrollmentDate)
        //{
        //    string query = $@"
        //        INSERT INTO Enrollment (id, student_id, course_id, enrollment_date, status)
        //        VALUES ('{id}', '{studentId}', '{courseId}', '{enrollmentDate:yyyy-MM-dd}', 'Enrolled')
        //    ";
        //    UpdateData(query);
        //}
        public void UpdateEnrollment(Guid id, Guid studentId, Guid courseId, DateTime enrollmentDate, string status)
        {
            string query = $@"
                UPDATE Enrollment
                SET student_id = '{studentId}',
                    course_id = '{courseId}',
                    enrollment_date = '{enrollmentDate:yyyy-MM-dd}',
                    status = '{status}'
                WHERE id = '{id}'
            ";
            UpdateData(query);
        }
        public void DeleteEnrollment(Guid id)
        {
            string query = $@"
                UPDATE Enrollment
                SET status = 'Cancelled'
                WHERE id = '{id}'
            ";
            UpdateData(query);
        }
        public DataTable SearchEnrollments(string keyword)
        {
            string query = $@"
                SELECT e.id, e.enrollment_date, e.status,
                       s.full_name AS student_name, 
                       c.name AS course_name
                FROM Enrollment e
                JOIN Student s ON e.student_id = s.id
                JOIN Course c ON e.course_id = c.id
                WHERE s.full_name LIKE N'%{keyword}%' 
                   OR c.name LIKE N'%{keyword}%'
                ORDER BY e.enrollment_date DESC";
            return GetDataTable(query);
        }
    }
}
