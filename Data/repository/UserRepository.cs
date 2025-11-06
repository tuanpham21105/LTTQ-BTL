using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_LTTQ_BTL.Data.Repository
{
    internal class UserRepository: BaseRepository
    {
        public DataTable GetUserByUsernameAndPassword(string username, string password)
        {
            //username = username.Replace("'", "''");
            //password = password.Replace("'", "''");
            string query = $"SELECT id, username, r.name as role from [User] u join [Role] r on u.role_name = r.name WHERE username = '{username}' AND [password] = '{password}'";
            DataTable result = GetDataTable(query);
            return result.Rows.Count > 0 ? result : null;
        }
        public void CreateUser(Guid id, string username, string password, string roleName)
        {
            string checkQuery = $"SELECT COUNT(*) FROM [User] WHERE username = '{username}'";
            DataTable checkResult = GetDataTable(checkQuery);
            int count = Convert.ToInt32(checkResult.Rows[0][0]);

            if (count > 0)
            {
                throw new Exception("The username already exists. Please choose a different username.");
            }

            string query = $@"
                INSERT INTO [User] (id, username, [password], role_name)
                VALUES ('{id}', '{username}', '{password}', '{roleName}')
            ";
            UpdateData(query);
        }
        public DataRow GetUserById(Guid id)
        {
            string query = $"SELECT * FROM [User] WHERE id = '{id}'";
            DataTable result = GetDataTable(query);
            return result.Rows.Count > 0 ? result.Rows[0] : null;
        }
        public DataTable GetAllUserJoin(int page, int pageSize)
        {
            string query;
            if (page == -1)
            {
                query = @"
                        SELECT 
                            u.id,
                            u.username,
                            u.password,
                            u.role_name,
                            ISNULL(s.full_name, t.full_name) AS full_name,
                            ISNULL(s.email, t.email) AS email,
                            ISNULL(s.phone_number, t.phone_number) AS phone_number,
                            ISNULL(s.address, t.address) AS address,
                            s.birth_date,
                            s.gender,
                            t.specialization,
                            t.qualification,
                            t.start_date,
                            u.created_at
                        FROM [User] u
                        LEFT JOIN Student s ON u.id = s.id AND u.role_name = N'student'
                        LEFT JOIN Teacher t ON u.id = t.id AND u.role_name = N'teacher'";
            }
            else
            {
                int offset = (page - 1) * pageSize;
                query = $@"
                        SELECT 
                            u.id,
                            u.username,
                            u.password,
                            u.role_name,
                            ISNULL(s.full_name, t.full_name) AS full_name,
                            ISNULL(s.email, t.email) AS email,
                            ISNULL(s.phone_number, t.phone_number) AS phone_number,
                            ISNULL(s.address, t.address) AS address,
                            s.birth_date,
                            s.gender,
                            t.specialization,
                            t.qualification,
                            t.start_date,
                            u.created_at
                        FROM [User] u
                        LEFT JOIN Student s ON u.id = s.id AND u.role_name = N'student'
                        LEFT JOIN Teacher t ON u.id = t.id AND u.role_name = N'teacher'
                        ORDER BY u.username
                        OFFSET {offset} ROWS
                        FETCH NEXT {pageSize} ROWS ONLY
                ";
            }
            return GetDataTable(query);
        }
        public DataTable GetAllUsers(int page, int pageSize)
        {
            string query;
            if (page == -1)
            {
                query = "SELECT * FROM [User] ORDER BY username";
            }
            else
            {
                int offset = (page - 1) * pageSize;
                query = $@"
                    SELECT * 
                    FROM [User]
                    ORDER BY username
                    OFFSET {offset} ROWS
                    FETCH NEXT {pageSize} ROWS ONLY
                ";
            }
            return GetDataTable(query);
        }
        public void UpdateUser(Guid id, string username, string password, string roleName)
        {
            string query = $@"
                UPDATE [User]
                SET username = '{username}',
                    [password] = '{password}',
                    role_name = '{roleName}',
                    update_at = GETDATE()
                WHERE id = '{id}'
            ";
            UpdateData(query);
        }
        public void DeleteUser(Guid id)
        {
            string query = $"DELETE FROM [User] WHERE id = '{id}'";
            UpdateData(query);
        }
        public DataRow GetUserByUsername(string username)
        {
            string query = $"SELECT * FROM [User] WHERE username = '{username}'";
            DataTable result = GetDataTable(query);
            return result.Rows.Count > 0 ? result.Rows[0] : null;
        }
        public DataTable SearchUsers(string keyword)
        {
            string query = $@"
                SELECT 
                    u.id,
                    u.username,
                    u.password,
                    u.role_name,
                    ISNULL(s.full_name, t.full_name) AS full_name,
                    ISNULL(s.email, t.email) AS email,
                    ISNULL(s.phone_number, t.phone_number) AS phone_number,
                    ISNULL(s.address, t.address) AS address,
                    s.birth_date,
                    s.gender,
                    t.specialization,
                    t.qualification,
                    t.start_date,
                    u.created_at
                FROM [User] u
                LEFT JOIN Student s ON u.id = s.id AND u.role_name = N'student'
                LEFT JOIN Teacher t ON u.id = t.id AND u.role_name = N'teacher'
                WHERE 
                    (u.username LIKE N'%{keyword}%' OR
                     ISNULL(s.full_name, t.full_name) LIKE N'%{keyword}%' OR
                     ISNULL(s.email, t.email) LIKE N'%{keyword}%' OR
                     ISNULL(s.phone_number, t.phone_number) LIKE N'%{keyword}%')";
            return GetDataTable(query);
        }
    }
}
