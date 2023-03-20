using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Models
{
	class Reservation
	{
		private string reservationCode;		
		private string flightCode;
		private string airline;
		private double costPerSeat;	
		private string name;
		private string citizenship;
		private string active;

		private Flight flight;

		public string ReservationCode { get { return reservationCode; } set { reservationCode = value; } }
		public string FlightCode { get { return flightCode; } set { flightCode = value; } }
		public string Airline { get { return airline; } set { airline = value; } }
		public double CostPerSeat { get { return costPerSeat; } set { costPerSeat = value; } }
		public string Name { get { return name; } set { name = value; } }	
		public string Citizenship { get { return citizenship; } set { citizenship = value; } }
		public string Active { get { return active; } set { active = value; } }

		/*
		 * constructor
		 */
		public Reservation (string reservationCode, string flightCode, string airline, double costPerSeat, string name, string citizenship, string active)
		{
			this.reservationCode = reservationCode;
			this.flightCode = flightCode;
			this.airline = airline;
			this.costPerSeat = costPerSeat;
			this.name = name;
			this.citizenship = citizenship;
			this.active = active;
		}
		public override string ToString()
		{
			return string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}", reservationCode, flightCode, airline, costPerSeat, name, citizenship, active);
		}
	}
}
