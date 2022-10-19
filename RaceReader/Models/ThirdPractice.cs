using Newtonsoft.Json;

public class ThirdPractice
{
    [JsonProperty("date")]
    public string Date { get; set; }

    [JsonProperty("time")]
    public string Time { get; set; }
}

