using RaceReader.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var test = "";
            return raceNames;
        }

        public async Task<List<string>> GetAllCircuits()
        {
            return null;
        }



        public async Task<List<string>> GetCircuitsForSeason()
        {
            return null;
        }
    }

}
