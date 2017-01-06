namespace Kong.Master.Infrastructure.Serialization
{
    public static class JsonSerializer
    {
        public static T Deserialize<T>(string json)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
        }
    }
}
