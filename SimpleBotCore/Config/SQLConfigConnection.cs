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

        public string GetConnectionDefault()
        {
            return $"\"Server={Server};Database={Database};MultipleActiveResultSets={MultipleActiveResultSets}\"";
        }

        public string GetConnectionAtlas()
        {
            return $"\"Server={Server};Database={Database};User Id={UserId};Password={Password};MultipleActiveResultSets={MultipleActiveResultSets}\"";
        }
    }
}