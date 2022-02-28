using FlightManagementWebAPI.DatabaseContext;
using DomainModel.Models;
using System.Collections.Generic;
using System.Linq;

namespace FlightManagementWebAPI.Repositories
{

    public class PassengerRepository
    {
        AirportSystemContext _airportSystemContext;
        public PassengerRepository(AirportSystemContext airportSystemContext)
        {
            _airportSystemContext = airportSystemContext;
        }

        public IEnumerable<Passenger> GetPassengers(int flightId)
        {
            return _airportSystemContext.Passengers.Where(Passenger => Passenger.FlightId== flightId).ToList();
        }

        public void InsertPassenger(Passenger passenger)
        {
            _airportSystemContext.Passengers.Add(passenger);
            _airportSystemContext.SaveChanges();
        }
        public Passenger GetPassenger(int passengerId)
        {
            return _airportSystemContext.Passengers.FirstOrDefault(passenger => passenger.Id == passengerId);
        }
        public void UpdatePassenger(Passenger passenger)
        {
            var passengerForUpdate = GetPassenger(passenger.Id);
            if (passengerForUpdate != null)
            {
                passengerForUpdate.Name = passenger.Name;
                passengerForUpdate.Surname = passenger.Surname;
                passengerForUpdate.Sex = passenger.Sex;
                passengerForUpdate.FlightId = passenger.FlightId;

                _airportSystemContext.SaveChanges();
            }
        }
        public void DeletePassenger(int passengerId)
        {
            var passengerForDelete = GetPassenger(passengerId);
            if (passengerForDelete != null)
            {
                _airportSystemContext.Passengers.Remove(passengerForDelete);
                _airportSystemContext.SaveChanges();
            }
        }

        public void CheckPassenger(int passengerId)
        {
            var passenger = GetPassenger(passengerId);
            if (passenger != null)
            {
                passenger.IsChecked = true;
                _airportSystemContext.SaveChanges();
            }
        }

        public List<Passenger> GetCheckedPassengers(bool Checked)
        {
            return _airportSystemContext.Passengers.Where(passenger => passenger.IsChecked == Checked).ToList();
        }
    }
}
