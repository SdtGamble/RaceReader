using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceReader.Services
{
    public interface IF1Service
    {
        public Task<List<string>> GetAllRaces();
        public Task<List<string>> GetAllCircuits();
        public Task<List<string>> GetCircuitsForSeason();
    }
}
