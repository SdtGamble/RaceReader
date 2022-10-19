using RaceReader.Clients;

namespace RaceReader.Services
{
    public class F1Service : IF1Service
    {
        private readonly F1Client f1Client;

        public F1Service(F1Client _f1Client)
        {
            f1Client = _f1Client;
        }

        public async Task<List<string>> GetAllRaces()
        {
            var f1Data = await f1Client.GetF1Data();
            var raceNames = new List<string>();
            raceNames = f1Data.MRData.RaceTable.Races.Select(r => r.RaceName).ToList();
            return raceNames;
        }

        public async Task<List<string>> GetAllCircuits()
        {
            var f1Data = await f1Client.GetF1Data();
            var circuitNames = new List<string>();
            circuitNames = f1Data.MRData.RaceTable.Races.Select(r => r.Circuit.CircuitName).ToList();
            return circuitNames;
        }

        public async Task<string> GetCircuitForRound(string roundNumber)
        {
            var f1Data = await f1Client.GetF1Data();
            var circuitName = f1Data.MRData.RaceTable.Races.Where(n => n.Round == roundNumber)
                .Select(r => r.Circuit.CircuitName).FirstOrDefault()
                ?? "Not Found";
            return circuitName;
        }
    }

}
