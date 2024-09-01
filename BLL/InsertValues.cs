using _3_Layer_architecture.DAL;
using System.Data.SqlClient;
using System.Data;
namespace _3_Layer_architecture.BLL
{
    public class InsertValues : MyConnectionString
    {
        public void Insertvalues(string fname, string lname, string email, string address_name, int salary_id, int dept_id)
        {
            sqlconnection();
            SqlCommand cmd = new SqlCommand("InsertData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("fname", fname);
            cmd.Parameters.AddWithValue("lname", lname);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("address", address_name);
            cmd.Parameters.AddWithValue("salary_id", salary_id);
            cmd.Parameters.AddWithValue("dept_id", dept_id);
            cmd.ExecuteNonQuery();
        }
    }
}
