using Newtonsoft.Json;

public class Race
{
    [JsonProperty("season")]
    public string Season { get; set; }

    [JsonProperty("round")]
    public string Round { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("raceName")]
    public string RaceName { get; set; }

    [JsonProperty("Circuit")]
    public Circuit Circuit { get; set; }

    [JsonProperty("date")]
    public string Date { get; set; }

    [JsonProperty("time")]
    public string Time { get; set; }

    [JsonProperty("FirstPractice")]
    public FirstPractice FirstPractice { get; set; }

    [JsonProperty("SecondPractice")]
    public SecondPractice SecondPractice { get; set; }

    [JsonProperty("ThirdPractice")]
    public ThirdPractice ThirdPractice { get; set; }

    [JsonProperty("Qualifying")]
    public Qualifying Qualifying { get; set; }

    [JsonProperty("Sprint")]
    public Sprint Sprint { get; set; }
}

