using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_Hushchyn
{
    public abstract class Bus
    {
        public string Model { get; set; }
        public int PassengerCapacity { get; set; }
        public bool HasAirConditioner { get; set; }
        public bool HasToilet { get; set; }
        public bool HasPowerOutlets { get; set; }
        public bool HasInternet { get; set; }

        protected Bus(string model, int passengerCapacity, bool hasAirConditioner, bool hasToilet, bool hasPowerOutlets, bool hasInternet)
        {
            Model = model;
            PassengerCapacity = passengerCapacity;
            HasAirConditioner = hasAirConditioner;
            HasToilet = hasToilet;
            HasPowerOutlets = hasPowerOutlets;
            HasInternet = hasInternet;
        }
    }
}
