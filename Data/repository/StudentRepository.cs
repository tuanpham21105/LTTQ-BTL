using prj_LTTQ_BTL.Data.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace prj_LTTQ_BTL.Data.repository
{
    internal class StudentRepository : BaseRepository
    {
        public void CreateStudent(Guid id, string fullName, DateTime birthDate, string gender, string phoneNumber, string email, string address)
        {
            string query = $@"
                INSERT INTO Student (id, full_name, birth_date, gender, phone_number, email, address)
                VALUES ('{id}', N'{fullName}', '{birthDate:yyyy-MM-dd}', N'{gender}', '{phoneNumber}', '{email}', N'{address}')
            ";
            UpdateData(query);
        }

        public DataRow GetStudentById(Guid id)
        {
            string query = $@"
                SELECT 
                    s.id,
                    s.full_name,
                    s.birth_date,
                    s.gender,
                    s.phone_number,
                    s.email,
                    s.address,
                    u.status
                FROM Student s
                JOIN [User] u ON s.id = u.id
                WHERE s.id = '{id}'";
            DataTable result = GetDataTable(query);
            return result.Rows.Count > 0 ? result.Rows[0] : null;
        }
        public DataTable GetAllStudents(int pageNumber, int pageSize)
        {
            string query;

            if (pageNumber == -1)
            {
                query = @"
                SELECT 
                    s.id,
                    s.full_name,
                    s.birth_date,
                    s.gender,
                    s.phone_number,
                    s.email,
                    s.address,
                    u.status
                FROM Student s
                JOIN [User] u ON s.id = u.id
                ORDER BY s.full_name";
            }
            else
            {
                int offset = (pageNumber - 1) * pageSize;
                query = $@"
                SELECT 
                    s.id,
                    s.full_name,
                    s.birth_date,
                    s.gender,
                    s.phone_number,
                    s.email,
                    s.address,
                    u.status
                FROM Student s
                JOIN [User] u ON s.id = u.id
                ORDER BY s.full_name
                OFFSET {offset} ROWS
                FETCH NEXT {pageSize} ROWS ONLY";
            }

            return GetDataTable(query);
        }
        public void UpdateStudent(Guid id, string fullName, DateTime birthDate, string gender, string phoneNumber, string email, string address, string status)
        {
            string query = $@"
                UPDATE Student
                SET full_name = N'{fullName}',
                    birth_date = '{birthDate:yyyy-MM-dd}',
                    gender = N'{gender}',
                    phone_number = '{phoneNumber}',
                    email = '{email}',
                    address = N'{address}'
                WHERE id = '{id}';

                UPDATE [User]
                SET status = '{status}',
                    update_at = GETDATE()
                WHERE id = '{id}';
            ";
            UpdateData(query);
        }
        public void DeleteStudent(Guid id)
        {
            string query = $@"
                UPDATE [User]
                SET status = 'Inactive',
                    update_at = GETDATE()
                WHERE id = '{id}'
            ";
            UpdateData(query);
        }
        public DataTable SearchStudents(string keyword)
        {
            string query = $@"
                SELECT 
                    s.id,
                    s.full_name,
                    s.birth_date,
                    s.gender,
                    s.phone_number,
                    s.email,
                    s.address,
                    u.status
                FROM Student s
                JOIN [User] u ON s.id = u.id
                WHERE s.full_name LIKE N'%{keyword}%' 
                   OR s.phone_number LIKE '%{keyword}%' 
                   OR s.email LIKE '%{keyword}%'
                ORDER BY s.full_name";
            return GetDataTable(query);
        }
    }
}
