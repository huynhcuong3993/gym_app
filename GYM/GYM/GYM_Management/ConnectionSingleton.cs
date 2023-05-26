using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace GYM
{
    public static class ConnectionSingleton
    {
        public static SqlConnection GetConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder["Data Source"] = ".\\SQLEXPRESS";
            builder["integrated Security"] = true;
            builder["Initial Catalog"] = "CFManagement";
            builder.UserID = "";

            return new SqlConnection(builder.ConnectionString);
        }
    }
}
