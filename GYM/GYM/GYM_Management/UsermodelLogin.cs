using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM
{
    class UserModelLogin
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public UserModelLogin() { }
        public UserModelLogin(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
        public bool CheckIfAccountExists(SqlConnection connection, string user, string pad, string role)
        {
            string query = "SELECT COUNT(*) FROM Account WHERE username = @username and pad = @pad and phanquyen = @pq";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@username", user);
                command.Parameters.AddWithValue("@pad", pad);
                command.Parameters.AddWithValue("@pq", role);

                int count = (int)command.ExecuteScalar();
                connection.Close();
                return count > 0;

            }

        }

        public string GetRoleForUser(SqlConnection connection, string username)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            SqlCommand command = new SqlCommand("SELECT phanquyen FROM Account WHERE username=@Username", connection);
            command.Parameters.AddWithValue("@Username", username);

            string role = Convert.ToString(command.ExecuteScalar());

            connection.Close();

            return role;
        }
    }
}