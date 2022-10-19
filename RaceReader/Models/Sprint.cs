using Newtonsoft.Json;

public class Sprint
{
    [JsonProperty("date")]
    public string Date { get; set; }

    [JsonProperty("time")]
    public string Time { get; set; }
}

