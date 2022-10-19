using Newtonsoft.Json;

public class Qualifying
{
    [JsonProperty("date")]
    public string Date { get; set; }

    [JsonProperty("time")]
    public string Time { get; set; }
}

