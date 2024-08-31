using _3_Layer_architecture.DAL;
using System.Data.SqlClient;
using System.Data;
namespace _3_Layer_architecture.BLL
{
    public class InsertValues : MyConnectionString
    {
        public void Insertvalues(string fname, string lname, string email, int address, int dept_id)
        {
            sqlconnection();
            SqlCommand cmd = new SqlCommand("INSERTDATA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("fname", fname);
            cmd.Parameters.AddWithValue("lname", lname);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("address", address);
            cmd.Parameters.AddWithValue("dept_id", dept_id);
            cmd.ExecuteNonQuery();
        }
    }
}
