using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace prj_LTTQ_BTL.Data.Repository
{
    internal class BaseRepository
    {
        static string dbConnect = Environment.GetEnvironmentVariable("DB_CONNECTION");
        string strConnect = $"Server={dbConnect};DataBase=LTTQ_BTL_DB;Integrated Security=true;Trusted_Connection=True;TrustServerCertificate=True;";
        public SqlConnection sqlConnect = null;
        public void OpenConnect()
        {
            sqlConnect = new SqlConnection(strConnect);
            if (sqlConnect.State != ConnectionState.Open)
                sqlConnect.Open();
        }

        public void CloseConnect()
        {
            if (sqlConnect.State != ConnectionState.Closed)
                sqlConnect.Close();
            sqlConnect.Dispose();
        }

        public DataTable GetDataTable(string query)
        {
            DataTable dt = new DataTable();
            OpenConnect();
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnect);
            adapter.Fill(dt);
            CloseConnect();
            return dt;
        }


        public void UpdateData(string cmd)
        {
            OpenConnect();
            SqlCommand command = new SqlCommand(cmd, sqlConnect);
            command.ExecuteNonQuery();
            command.Dispose();
            CloseConnect();
        }
    }
}
