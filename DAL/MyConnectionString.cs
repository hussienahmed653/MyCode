using System.Data.SqlClient;

namespace _3_Layer_architecture.DAL
{
    public class MyConnectionString
    {
        protected SqlConnection con;
        IConfiguration configuration;
        string config;
        public MyConnectionString()
        {
            configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            config = configuration["ConnectionStrings:DefaultConnection"] ?? "";
        }

        public void sqlconnection()
        {
            con = new SqlConnection(config);
            con.Open();
        }
    }
}
