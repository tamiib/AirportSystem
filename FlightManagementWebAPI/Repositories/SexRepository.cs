using DomainModel.Models;
using FlightManagementWebAPI.DatabaseContext;
using System.Collections.Generic;
using System.Linq;

namespace FlightManagementWebAPI.Repositories
{
    public class SexRepository
    {
        private readonly AirportSystemContext _airportSystemContext;

        public SexRepository(AirportSystemContext airportSystemContext)
        {
            _airportSystemContext = airportSystemContext;
        }

        public List<Sex> GetSexes()
        {
            return _airportSystemContext.Sexes.ToList();
        }
    }
}
