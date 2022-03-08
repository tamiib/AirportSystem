﻿using DomainModel.Models;
using FlightManagementWebAPI.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightManagementWebAPI.Repositories
{
    public class UserRepository
    {
        private readonly AirportSystemContext _airportSystemContext;

        public UserRepository(AirportSystemContext airportSystemContext)
        {
            _airportSystemContext = airportSystemContext;
        }
        public User GetUser(string username, string password)
        {
            return _airportSystemContext.Users.FirstOrDefault(user => user.Username == username && user.Password == password);

        }
        public List<User> GetUsers()
        {
            return _airportSystemContext.Users.ToList();
        }
        public void InsertUser(User user)
        {
            _airportSystemContext.Users.Add(user);
            _airportSystemContext.SaveChanges();
        }

    }
}

