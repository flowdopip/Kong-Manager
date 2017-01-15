namespace Kong.Master.Application.Dto.Consumers
{
    using System;

    public class Consumers
    {
        public string Username { get; set; }

        public TimeSpan Created_At { get; set; }

        public Guid Id { get; set; }
    }
}
