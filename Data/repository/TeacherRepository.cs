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
        public void CreateTeacher(Guid id, string fullName, string specialization, string qualification, string phoneNumber, string email, string address, DateTime startDate)
        {
            string query = $@"
                INSERT INTO Teacher (id, full_name, specialization, qualification, phone_number, email, address, start_date)
                VALUES ('{id}', N'{fullName}', N'{specialization}', N'{qualification}', '{phoneNumber}', '{email}', N'{address}', '{startDate:yyyy-MM-dd}')
            ";
            UpdateData(query);
        }
        public DataRow GetTeacherById(Guid id)
        {
            string query = $@"
                SELECT 
                    t.id,
                    t.full_name,
                    t.specialization,
                    t.qualification,
                    t.phone_number,
                    t.email,
                    t.address,
                    t.start_date,
                    u.status
                FROM Teacher t
                JOIN [User] u ON t.id = u.id
                WHERE t.id = '{id}'";
            DataTable result = GetDataTable(query);
            return result.Rows.Count > 0 ? result.Rows[0] : null;
        }
        public DataTable GetAllTeachers(int pageNumber, int pageSize)
        {
            string query;

            if (pageNumber == -1)
            {
                query = @"
                    SELECT 
                        t.id,
                        t.full_name,
                        t.specialization,
                        t.qualification,
                        t.phone_number,
                        t.email,
                        t.address,
                        t.start_date,
                        u.status
                    FROM Teacher t
                    JOIN [User] u ON t.id = u.id
                    ORDER BY t.full_name";
            }
            else
            {
                int offset = (pageNumber - 1) * pageSize;
                query = $@"
                    SELECT 
                        t.id,
                        t.full_name,
                        t.specialization,
                        t.qualification,
                        t.phone_number,
                        t.email,
                        t.address,
                        t.start_date,
                        u.status
                    FROM Teacher t
                    JOIN [User] u ON t.id = u.id
                    ORDER BY t.full_name
                    OFFSET {offset} ROWS
                    FETCH NEXT {pageSize} ROWS ONLY";
            }

            return GetDataTable(query);
        }
        public void UpdateTeacher(Guid id, string fullName, string specialization, string qualification, string phoneNumber, string email, string address, DateTime startDate, string status)
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
                WHERE id = '{id}';

                UPDATE [User]
                SET status = '{status}',
                    update_at = GETDATE()
                WHERE id = '{id}';
            ";
            UpdateData(query);
        }
        public void DeleteTeacher(Guid id)
        {
            string query = $@"
                UPDATE [User]
                SET status = 'Inactive',
                    update_at = GETDATE()
                WHERE id = '{id}'
            ";
            UpdateData(query);
        }
        public DataTable SearchTeachers(string keyword)
        {
            string query = $@"
                SELECT 
                    t.id,
                    t.full_name,
                    t.specialization,
                    t.qualification,
                    t.phone_number,
                    t.email,
                    t.address,
                    t.start_date,
                    u.status
                FROM Teacher t
                JOIN [User] u ON t.id = u.id
                WHERE t.full_name LIKE N'%{keyword}%' OR
                      t.specialization LIKE N'%{keyword}%' OR
                      t.qualification LIKE N'%{keyword}%' OR
                      t.phone_number LIKE '%{keyword}%' OR
                      t.email LIKE '%{keyword}%' OR
                      t.address LIKE N'%{keyword}%'
                ORDER BY t.full_name";
            return GetDataTable(query);
        }

    }
}
