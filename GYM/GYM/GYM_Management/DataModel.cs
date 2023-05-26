using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Web.Security;

namespace GYM
{
    internal class DataModel
    {
        System.Data.SqlClient.SqlConnectionStringBuilder builder;
        SqlConnection conn;
        public DataModel()
        {
            builder = new System.Data.SqlClient.SqlConnectionStringBuilder();
            builder["Data Source"] = "HUYNH\\SQLEXPRESS";
            builder["integrated Security"] = true;
            builder["Initial Catalog"] = "QLGYM";
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            builder.UserID = userName;
            builder["Password"] = "";
            conn = new SqlConnection(builder.ConnectionString);
            conn.Open();
        }

        public List<Dictionary<string, string>> FetchAllRowUr()
        {
            List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
            Dictionary<string, string> column;
            string sqlQuery = "SELECT Username, Pass, Role FROM Employee";

            SqlCommand command = new SqlCommand(sqlQuery, this.conn);

            try
            {
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {    //Every new row will create a new dictionary that holds the columns
                    column = new Dictionary<string, string>();

                    column["Username"] = reader["Username"].ToString();
                    column["Pass"] = reader["Pass"].ToString();
                    column["Role"] = reader["Role"].ToString();
                    rows.Add(column); //Place the dictionary into the list
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //If an exception occurs, write it to the console
                Console.WriteLine(ex.ToString());
            }

            return rows;

        }

        public List<Dictionary<string, string>> FetchAllRow()
        {
            List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
            Dictionary<string, string> column;
            string sqlQuery = "SELECT E_ID, IDS, Name, Address, Phone, Dob, Gender, Username, Pass, Role FROM Employee";

            SqlCommand command = new SqlCommand(sqlQuery, this.conn);


            try
            {
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {    //Every new row will create a new dictionary that holds the columns
                    column = new Dictionary<string, string>();

                    column["E_ID"] = reader["E_ID"].ToString();
                    column["IDS"] = reader["IDS"].ToString();
                    column["Name"] = reader["Name"].ToString();
                    column["Address"] = reader["Address"].ToString();
                    column["Phone"] = reader["Phone"].ToString();
                    column["Dob"] = reader["Dob"].ToString();
                    column["Gender"] = reader["Gender"].ToString();
                    column["Username"] = reader["Username"].ToString();
                    column["Pass"] = reader["Pass"].ToString();
                    column["Role"] = reader["Role"].ToString();
                    rows.Add(column); //Place the dictionary into the list
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //If an exception occurs, write it to the console
                Console.WriteLine(ex.ToString());
            }

            return rows;

        }

        public bool AddNewRow(string eid, String ids, string name, string address, string phone, string dob, string gender, string username, string pass, string role)
        {
            string addCmd = "INSERT INTO Employee (E_ID, IDS, Name, Address, Phone, Dob, Gender, Username, Pass, Role) values (@val1, @val2, @val3, @val4, @val5,@val6, @val7, @val8, @val9, @val10)";
            
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = conn;
                comm.CommandText = addCmd;
                comm.Parameters.AddWithValue("@val1", eid);
                comm.Parameters.AddWithValue("@val2", ids);
                comm.Parameters.AddWithValue("@val3", name);
                comm.Parameters.AddWithValue("@val4", address);
                comm.Parameters.AddWithValue("@val5", phone);
                comm.Parameters.AddWithValue("@val6", dob);
                comm.Parameters.AddWithValue("@val7", gender);
                comm.Parameters.AddWithValue("@val8", username);
                comm.Parameters.AddWithValue("@val9", pass);
                comm.Parameters.AddWithValue("@val10", role);

                try
                {
                    comm.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return false;
                }
            }
        }

        public bool RemoveRow(string id)
        {
            string delCmd = "DELETE FROM Employee where E_ID = @val1";
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = conn;
                comm.CommandText = delCmd;
                comm.Parameters.AddWithValue("@val1", id);

                try
                {
                    comm.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return false;
                }
            }
        }

        public bool UpdateRow(string eid, String ids, string name, string address, string phone, string dob, string gender, string username, string pass, string role)
        {
            string udtCmd = "update Employee set IDS = @val2,name = @val3, address =  @val4, phone = @val5, dob =  @val6, gender = @val7, username = @val8 , pass = @val9, role = @val10 where E_ID = @val1";
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = conn;
                comm.CommandText = udtCmd;
                comm.Parameters.AddWithValue("@val1", eid);
                comm.Parameters.AddWithValue("@val2", ids);
                comm.Parameters.AddWithValue("@val3", name);
                comm.Parameters.AddWithValue("@val4", address);
                comm.Parameters.AddWithValue("@val5", phone);
                comm.Parameters.AddWithValue("@val6", dob);
                comm.Parameters.AddWithValue("@val7", gender);
                comm.Parameters.AddWithValue("@val8", username);
                comm.Parameters.AddWithValue("@val9", pass);
                comm.Parameters.AddWithValue("@val10", role);

                try
                {
                    comm.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return false;
                }
            }
        }

    }
}
