using System.Data.SqlClient;

namespace SimpleBotCore.Config
{
    public class SQLConfigConnection
    {
        public string Server { get; set; } = "(localdb)\\mssqllocaldb";
        public string Database { get; set; } = "SimpleBot";
        public bool? Enabled { get; set; }
        public string Password { get; set; }
        public string UserId { get; set; }
        public bool MultipleActiveResultSets { get; set; } = true;
        public bool TrustedConnection { get; set; } = true;

        public string GetConnectionDefault()
        {
 
            return $"Password={Password};Persist Security Info=True;User ID={UserId};Initial Catalog={Database};Data Source={Server}";
        }
    }
}