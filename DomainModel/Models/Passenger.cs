using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class Passenger
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
      //  public char Sex { get; set; }

        public int SexId { get; set; }
        public Sex Sex { get; set; }
        public int FlightId { get; set; }
        public Flight Flight { get; set; }

        public bool IsChecked { get; set; }



    }
}
