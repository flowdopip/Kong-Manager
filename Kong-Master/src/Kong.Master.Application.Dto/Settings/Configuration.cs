namespace Kong.Master.Application.Dto.Settings
{
    public class Configuration
    {
        public string Serf_Log { get; set; }

        public bool Cassandra_Ssl { get; set; }

        public string Nginx_Acc_Logs { get; set; }

        public int Cassandra_Repl_Factor { get; set; }

        public string Cassandra_Keyspace { get; set; }

        public bool Anonymous_Reports { get; set; }

        public string Lua_Code_Cache { get; set; }
    }
}