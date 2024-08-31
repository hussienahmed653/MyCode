using _3_Layer_architecture.DAL;
using _3_Layer_architecture.DAL.Models;
using System.Data.SqlClient;
using System.Data;

namespace _3_Layer_architecture.BLL
{
    public class ImplentEmp : MyConnectionString
    {
        SqlCommand cmd;
        List<Employees> employees = [];

        public List<Employees> GetEmployees(int? id = null)
        {
            sqlconnection();
            if(id.HasValue)
            {
                cmd = new SqlCommand("GETDTABYID", con);
                cmd.Parameters.AddWithValue("id", id);
            }
            else
            {
                cmd = new SqlCommand("getdata", con);
            }
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    employees.Add(new Employees()
                    {
                        ID = reader.GetInt32(0),
                        Fname = reader.GetString(1),
                        Lname = reader.GetString(2),
                        Email = reader.GetString(3),
                        Address = reader.GetInt32(4),
                        address_name = reader.GetString(5),
                        Dept_id = reader.GetInt32(6),
                        Dept_name = reader.GetString(7),
                    });
                }
                con.Close();
            }
            return employees;
        }
    }
}
