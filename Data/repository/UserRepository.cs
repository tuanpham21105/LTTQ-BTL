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
        // Create a new user
        public void CreateUser(Guid id, string username, string password, string roleName)
        {
            // Check if the username already exists
            string checkQuery = $"SELECT COUNT(*) FROM [User] WHERE username = '{username}'";
            DataTable checkResult = GetDataTable(checkQuery);
            int count = Convert.ToInt32(checkResult.Rows[0][0]);

            if (count > 0)
            {
                throw new Exception("The username already exists. Please choose a different username.");
            }

            // Insert the new user
            string query = $@"
                INSERT INTO [User] (id, username, [password], role_name)
                VALUES ('{id}', '{username}', '{password}', '{roleName}')
            ";
            UpdateData(query);
        }
        // Read a user by ID
        public DataRow GetUserById(Guid id)
        {
            string query = $"SELECT * FROM [User] WHERE id = '{id}'";
            DataTable result = GetDataTable(query);
            return result.Rows.Count > 0 ? result.Rows[0] : null;
        }
        // Read all users
        public DataTable GetAllUsers(int page, int pageSize)
        {
            string query;
            if (page == -1)
            {
                // Query all users without pagination
                query = "SELECT * FROM [User] ORDER BY username";
            }
            else
            {
                // Query users with pagination
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
        // Update a user
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
        // Delete a user
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
    }
}
