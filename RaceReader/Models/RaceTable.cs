using Newtonsoft.Json;

public class RaceTable
{
    [JsonProperty("season")]
    public string Season { get; set; }

    [JsonProperty("Races")]
    public List<Race> Races { get; set; }
}

