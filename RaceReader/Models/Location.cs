using Newtonsoft.Json;

public class Location
{
    [JsonProperty("lat")]
    public string Lat { get; set; }

    [JsonProperty("long")]
    public string Long { get; set; }

    [JsonProperty("locality")]
    public string Locality { get; set; }

    [JsonProperty("country")]
    public string Country { get; set; }
}

