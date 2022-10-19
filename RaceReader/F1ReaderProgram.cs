using RaceReader.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Reader
{
    public class F1ReaderProgram
    {
        private readonly IF1Service _f1Service;
        public F1ReaderProgram(IF1Service f1Service)
        {
            _f1Service = f1Service;
        }

        public async void Execute()
        {
            GetRaceInformation();
        }

        private async void GetRaceInformation()
        {
            // Get All races
            var races = await _f1Service.GetAllRaces();
            // Get All circuit names
            var circuits = await _f1Service.GetAllCircuits();
            // Get all circuits for a given season
             var circuits2021 = await _f1Service.GetCircuitsForSeason();
        }
    }
}
