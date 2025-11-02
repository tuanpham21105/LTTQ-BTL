using prj_LTTQ_BTL.Data.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace prj_LTTQ_BTL.Data.repository
{
    internal class StudentRepository : BaseRepository
    {
        // Create a new student
        public void CreateStudent(Guid id, string fullName, DateTime birthDate, string gender, string phoneNumber, string email, string address)
        {
            string query = $@"
                INSERT INTO Student (id, full_name, birth_date, gender, phone_number, email, address)
                VALUES ('{id}', N'{fullName}', '{birthDate:yyyy-MM-dd}', N'{gender}', '{phoneNumber}', '{email}', N'{address}')
            ";
            UpdateData(query);
        }

        // Read a student by ID
        public DataRow GetStudentById(Guid id)
        {
            string query = $"SELECT * FROM Student WHERE id = '{id}'";
            DataTable result = GetDataTable(query);
            return result.Rows.Count > 0 ? result.Rows[0] : null;
        }

        // Read all students 
        public DataTable GetAllStudents(int pageNumber, int pageSize)
        {
            string query;

            if (pageNumber == -1)
            {
                query = "SELECT * FROM Student ORDER BY full_name";
            }
            else
            {
                int offset = (pageNumber - 1) * pageSize;
                query = $@"
                    SELECT *
                    FROM Student
                    ORDER BY full_name
                    OFFSET {offset} ROWS
                    FETCH NEXT {pageSize} ROWS ONLY
                ";
                //full_name as 'Họ và tên', birth_date as 'Ngày sinh', gender as 'Giới tính', phone_number as 'Số điện thoại', email as 'Email', address as 'Địa chỉ'
            }

            return GetDataTable(query);
        }
        // Update a student
        public void UpdateStudent(Guid id, string fullName, DateTime birthDate, string gender, string phoneNumber, string email, string address)
        {
            string query = $@"
                UPDATE Student
                SET full_name = N'{fullName}',
                    birth_date = '{birthDate:yyyy-MM-dd}',
                    gender = N'{gender}',
                    phone_number = '{phoneNumber}',
                    email = '{email}',
                    address = N'{address}'
                WHERE id = '{id}'
            ";
            UpdateData(query);
        }
        // Delete a student
        public void DeleteStudent(Guid id)
        {
            string query = $"DELETE FROM Student WHERE id = '{id}'";
            UpdateData(query);
        }
        public DataTable SearchStudents(string keyword)
        {
            string query = $@"
        SELECT * 
        FROM Student 
        WHERE full_name LIKE '%{keyword}%' 
           OR phone_number LIKE '%{keyword}%' 
           OR email LIKE '%{keyword}%'
        ORDER BY full_name";
            return GetDataTable(query);
        }
    }
}
