using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagmentSQL.DataAccess.SqlDbContex
{
    public static class SqlDataBaseConnect
    {
        public static string Connect()
        {

            try
            {
                SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
                sqlConnectionStringBuilder.DataSource = "localhost";
                sqlConnectionStringBuilder.InitialCatalog = "UserDB";
                sqlConnectionStringBuilder.IntegratedSecurity = true;

                string connectionString = sqlConnectionStringBuilder.ConnectionString;
                return connectionString;
            }
            catch (Exception)
            {

                MessageBox.Show("Data base connection error!!!");
            }

            return null;
        
        }
    }
}
