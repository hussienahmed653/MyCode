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

        public List<Employees> GetEmployees(int? id )
        {
            sqlconnection();
            if(id.HasValue)
            {
                cmd = new SqlCommand("HrGetByID", con);
                cmd.Parameters.AddWithValue("id", id);
            }
            else
            {
                cmd = new SqlCommand("hrget", con);
            }
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    employees.Add(new Employees()
                    {
                        ID = reader.IsDBNull(0) ? null : reader.GetInt32(0),
                        Fname = reader.IsDBNull(1) ? null : reader.GetString(1),
                        Lname = reader.IsDBNull(2) ? null : reader.GetString(2),
                        Email = reader.IsDBNull(3) ? null : reader.GetString(3),
                        address_name = reader.IsDBNull(4) ? null : reader.GetString(4),
                        Salary_id = reader.IsDBNull(5) ? null : reader.GetInt32(5),
                        Dept_id = reader.IsDBNull(6) ? null : reader.GetInt32(6),
                        Dept_name = reader.IsDBNull(7) ? null : reader.GetString(7),
                        Salary = reader.IsDBNull(8) ? null : reader.GetDecimal(8),
                        Reason = reader.IsDBNull(9) ? null : reader.GetString(9),
                    });
                }
                con.Close();
            }
            return employees;
        }
    }
}
