using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQL_Connection
{
    public class ContactsRepository : IContactsRepository
    {
        private string Conection_SQL = "Data Source=AMIN-LAPTOP\\SQLEXPRESS;Initial Catalog=Contacts;Integrated Security=True";

        public bool Delete(string ID)
        {
            SqlConnection connection = new SqlConnection(Conection_SQL);
            try
            {
                string query = "delete from tblContact where ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("ID", ID);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }

        public DataTable GetContact(string ID)
        {
            string query = $"Select * From tblContact Where ID = {ID}";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, Conection_SQL);
            adapter.Fill(data);
            return data;
        }

        public bool Insert(string name,string family,string phone,string address)
        {
            SqlConnection connection = new SqlConnection(Conection_SQL);
            try
            {
                string query = "Insert Into tblContact (Name,Family,Phone,Address) values (@name,@family,@phone,@address)";
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("name", name);
                command.Parameters.AddWithValue("family", family);
                command.Parameters.AddWithValue("phone", phone);
                command.Parameters.AddWithValue("address", address);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch
            {
                 return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }

        public DataTable Search(string txtSearch)
        {
            string query = "Select * From tblContact Where Name Like @name Or Family Like @family";
            DataTable data = new DataTable();
            SqlConnection connection = new SqlConnection(Conection_SQL);

            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@name", "%" + txtSearch + "%");
                command.Parameters.AddWithValue("@family", "%" + txtSearch + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                connection.Open();
                command.ExecuteNonQuery();
                adapter.Fill(data);

            }
            catch 
            {

                return null;
            }
            finally
            {
                connection.Close();                
            }
            return data;
        }

        public DataTable SelectAll()
        {
            string query = "Select * From tblContact";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query,Conection_SQL);
            adapter.Fill(data);
            return data;
        }

        public bool Update(string ID , string name, string family, string phone, string address)
        {
            SqlConnection connection = new SqlConnection(Conection_SQL);
            try
            {
                string query = "Update tblContact set Name=@name,Family=@family,Phone=@phone,Address=@address where ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("name", name);
                command.Parameters.AddWithValue("family", family);
                command.Parameters.AddWithValue("phone", phone);
                command.Parameters.AddWithValue("address", address);
                command.Parameters.AddWithValue("ID", ID);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
    }
}