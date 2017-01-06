namespace Kong.Master.Application.Dto.Api
{
    using System;

    public class Data
    {
        public string Upstream_Url { get; set; }

        public string Strip_Request_Path { get; set; }

        public string Request_Path { get; set; }

        public Guid Id{ get; set; }

        public TimeSpan Created_At { get; set; }

        public bool Preserve_Host { get; set; }

        public string Name { get; set; }

        public string Request_Host { get; set; }

    }
}