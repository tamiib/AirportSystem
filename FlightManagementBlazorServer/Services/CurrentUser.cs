using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightManagementBlazorServer.Services
{
    public class CurrentUser
    {   
        public static string Username { get; set; }
        public static string Role { get; set; }
        public static bool Added { get; set; }
        public static void SetRole(string role)
        {
            Role = role;
        }
        public static void SetUser(string user)
        {
            Username = user;
        }

    }
}
