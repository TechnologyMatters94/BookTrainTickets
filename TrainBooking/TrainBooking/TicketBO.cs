using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainBooking
{
    public class TicketBO
    {
        private int id;
        private string name;
        private string source;
        private string destination;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Source { get => source; set => source = value; }
        public string Destination { get => destination; set => destination = value; }
    }
}
