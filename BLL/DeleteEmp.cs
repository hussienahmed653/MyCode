using _3_Layer_architecture.DAL;
using System.Data.SqlClient;
using System.Data;

namespace _3_Layer_architecture.BLL
{
    public class DeleteEmp : MyConnectionString
    {
        public void deleteemp(int id)
        {
            sqlconnection();
            SqlCommand cmd = new SqlCommand("DELETEEMP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
