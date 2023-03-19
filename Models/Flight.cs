using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Models
{

	/*
	 * flight constructor with flight code
	 */

	/*
	 * flight constructor with all data members
	 */

	/*
	 * getters and setters for all members
	 */
	internal class Flight
    {
        private string flightCode;
        private string airlineName;
        private string originAirport;
        private string destinationAirport;
        private string day;
        private string time;
        private int seats;
        private double costPerSeat;

        public string FlightCode { get { return flightCode; } set { flightCode = value; } }
        public string AirlineName { get {  return airlineName; } set { airlineName = value; } }
        public string OriginAirport { get { return originAirport; } set { originAirport = value; } }
        public string DestinationAirport { get { return destinationAirport; } set {  destinationAirport = value; } }
        public string Day { get { return day; } set { day = value; } }
        public string Time { get { return time; } set { time = value; } }
        public int Seats { get {  return seats; } set {  seats = value; } }
        public double CostPerSeat { get {  return costPerSeat; } set {  costPerSeat = value; } }

        public Flight () { }

        public Flight (string flightCode, string airlineName, string originAirport, string destinationAirport, string day, string time, int seats, double costPerSeat)
        {
            this.flightCode = flightCode;
            this.AirlineName = airlineName;
            this.OriginAirport = originAirport;
            this.DestinationAirport = destinationAirport;
            this.Day = day;
            this.Time = time;
            this.Seats = seats;
            this.CostPerSeat = costPerSeat;
        }

		public override string ToString()
		{
            return string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}{8}", FlightCode, AirlineName, OriginAirport, DestinationAirport, Day, Time, Seats, CostPerSeat, Environment.NewLine);
		}
	}
}
