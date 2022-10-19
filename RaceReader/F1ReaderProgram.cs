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
            PrintRaceInformation(races, "Races");
            // Get All circuit names
            var circuits = await _f1Service.GetAllCircuits();
            PrintRaceInformation(circuits, "Circuits");
            // Get all circuits for a given season
            var circuit = await _f1Service.GetCircuitForRound("1");
            Console.WriteLine("Circuit for round 1 \n" + circuit);
        }

        private void PrintRaceInformation(List<string> list, string informationTitle)
        {
            Console.WriteLine(informationTitle);
            list.ForEach(i => Console.Write("{0}\n", i));
        }
    }
}
