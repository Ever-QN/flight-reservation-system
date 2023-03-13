using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    internal class Flight
    {
        private string flightCode;
        private string airlineName;
        private string originAirport;
        private string destinationAirport;
        private string day;
        private int seats;
        private int costPerSeat;

        public string FlightCode { get { return flightCode; } set { flightCode = value; } }
        public string AirlineName { get {  return airlineName; } set { airlineName = value; } }
        public string OriginAirport { get { return originAirport; } set { originAirport = value; } }
        public string DestinationAirport { get { return destinationAirport; } set {  destinationAirport = value; } }
        public string Day { get { return day; } set { day = value; } }
        public int Seats { get {  return seats; } set {  seats = value; } }
        public int CostPerSeat { get {  return costPerSeat; } set {  costPerSeat = value; } }
    }
}
