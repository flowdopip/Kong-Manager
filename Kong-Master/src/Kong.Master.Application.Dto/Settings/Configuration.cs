namespace Kong.Master.Application.Dto.Settings
{
    public class Configuration
    {
        public string Serf_Log { get; set; }

        public bool Cassandra_Ssl { get; set; }

        public string Nginx_Acc_Logs { get; set; }
    }
}