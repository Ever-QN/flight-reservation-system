using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls.Shapes;

namespace Assignment2.Models
{
	class FlightManager
	{
		private string flights_text = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Files", "flights.csv");
		public static List<Flight> flights = new List<Flight>();
		public static List<string> daysList = new List<string>();
		public FlightManager() 
		{
            populateFlights();
		}

		private void populateFlights()
        {
            Flight flight;
            try 
            {
				foreach (string line in System.IO.File.ReadLines(flights_text))
				{
					string[] parts = line.Split(",");

					string flightCode = parts[0];
					string airlineName = parts[1];
					string originAirport = parts[2];
					string destinationAirport = parts[3];
					string day = parts[4];
					string time = parts[5];
					int seats = int.Parse(parts[6]);
					double costOfSeats = double.Parse(parts[7]);


					flight = new Flight(flightCode, airlineName, originAirport, destinationAirport, day, time, seats, costOfSeats);
					flights.Add(flight);
				}
			}
			catch (Exception e)
			{
				flight = new Flight("error", "error", "error", "error", "error", "error", int.Parse("0"), double.Parse("0"));
				flights.Add(flight);
			}
			
		}

		/*
		 * get all of the flights
		 * @return arraylist of flights
		 */
		public static List<Flight> GetFlights()
        {
            return flights;
        }
		
		public static List<string> GetDays()
		{
			string[] daysArray = { "Any", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
			daysList.AddRange(daysArray);
			return daysList;
		}

		/*
		 * find flight with code
		 * #param code Flight code
		 * @retutn flight objects
		 */

		/* 
		 * find flight between the airports on specific day
		 * #param from airport code
		 * #param to airport code
		 * #param Weekday of the week
		 * @return flight found
		 */
	}
}
