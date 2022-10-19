using Newtonsoft.Json;

public class MRData
{
    [JsonProperty("xmlns")]
    public string Xmlns { get; set; }

    [JsonProperty("series")]
    public string Series { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("limit")]
    public string Limit { get; set; }

    [JsonProperty("offset")]
    public string Offset { get; set; }

    [JsonProperty("total")]
    public string Total { get; set; }

    [JsonProperty("RaceTable")]
    public RaceTable RaceTable { get; set; }
}

