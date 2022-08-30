using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace MyStore.Pages.Clients
{
    public class IndexModel : PageModel
    {
        public List<ClientInfo> ListClient = new List<ClientInfo>();
        public void OnGet()
        {
            try
            {
                String connectionString = "Data Source=.\\mssqlserver01;Initial Catalog=mysote;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString)) 
                {
                    connection.Open();
                    String sql = "SELECT *  from clients";
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ClientInfo clientInfo = new ClientInfo();
                                clientInfo.id = "" + reader.GetInt32(0);
                                clientInfo.name = reader.GetString(1);
                                clientInfo.email = reader.GetString(2);
                                clientInfo.phone = reader.GetString(3);
                                clientInfo.address = reader.GetString(4);
                                clientInfo.created_at = reader.GetDateTime(5).ToString();

                                ListClient.Add(clientInfo);
                            }
                        }
                        
                    }
                }


            }
            catch(Exception ex)
            {
                   Console.WriteLine("Exception : " + ex.ToString());
            }
        }
        public class ClientInfo
        {
            public String id;
            public String name;
            public String email;
            public String phone;
            public String address;
            public String created_at;
        }
    }
}
