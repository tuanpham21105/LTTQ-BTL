using prj_LTTQ_BTL.Data.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_LTTQ_BTL.Data.repository
{
    internal class TeacherRepository: BaseRepository
    {
        // Create a new teacher
        public void CreateTeacher(Guid id, string fullName, string specialization, string qualification, string phoneNumber, string email, string address, DateTime startDate)
        {
            string query = $@"
                INSERT INTO Teacher (id, full_name, specialization, qualification, phone_number, email, address, start_date)
                VALUES ('{id}', N'{fullName}', N'{specialization}', N'{qualification}', '{phoneNumber}', '{email}', N'{address}', '{startDate:yyyy-MM-dd}')
            ";
            UpdateData(query);
        }
        // Read a teacher by ID
        public DataRow GetTeacherById(Guid id)
        {
            string query = $"SELECT * FROM Teacher WHERE id = '{id}'";
            DataTable result = GetDataTable(query);
            return result.Rows.Count > 0 ? result.Rows[0] : null;
        }
        // Read all teachers
        public DataTable GetAllTeachers(int pageNumber, int pageSize)
        {
            string query;

            if (pageNumber == -1)
            {
                query = "SELECT * FROM Teacher ORDER BY full_name";
            }
            else
            {
                int offset = (pageNumber - 1) * pageSize;
                query = $@"
                    SELECT *
                    FROM Teacher
                    ORDER BY full_name
                    OFFSET {offset} ROWS
                    FETCH NEXT {pageSize} ROWS ONLY
                ";
            }
            return GetDataTable(query);
        }
        // Update a teacher
        public void UpdateTeacher(Guid id, string fullName, string specialization, string qualification, string phoneNumber, string email, string address, DateTime startDate)
        {
            string query = $@"
                UPDATE Teacher
                SET full_name = N'{fullName}',
                    specialization = N'{specialization}',
                    qualification = N'{qualification}',
                    phone_number = '{phoneNumber}',
                    email = '{email}',
                    address = N'{address}',
                    start_date = '{startDate:yyyy-MM-dd}'
                WHERE id = '{id}'
            ";
            UpdateData(query);
        }
        public void DeleteTeacher(Guid id)
        {
            string query = $"DELETE FROM Teacher WHERE id = '{id}'";
            UpdateData(query);
        }
        // Search teachers by keyword
        public DataTable SearchTeachers(string keyword)
        {
            string query = $@"
                SELECT *
                FROM Teacher
                WHERE full_name LIKE N'%{keyword}%' OR
                      specialization LIKE N'%{keyword}%' OR
                      qualification LIKE N'%{keyword}%' OR
                      phone_number LIKE '%{keyword}%' OR
                      email LIKE '%{keyword}%' OR
                      address LIKE N'%{keyword}%'
            ";
            return GetDataTable(query);
        }

    }
}
