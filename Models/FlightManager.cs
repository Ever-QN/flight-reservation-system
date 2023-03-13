using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls.Shapes;

namespace Assignment2.Models
{
	internal class FlightManager
	{
        private string flights_text = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Files", "flights.csv");
        public static List<Flight> flights = new List<Flight>();

        public FlightManager() 
		{

		}

		private void populateFlights()
        {
            Flight flight;

			foreach (string line in System.IO.File.ReadLines(flights_text))
			{
                string[] parts = line.Split(",");

                string flightCode = parts[0];
                string airlineName = parts[1];
                string originAirport = parts[2];
                string destinationAirport = parts[3];
                string day = parts[4];
                int seats = int.Parse(parts[5]);
                double costOfSeats = double.Parse(parts[6]);


                flight = new Flight(flightCode, airlineName, originAirport, destinationAirport, day, seats, costOfSeats);
                flights.Add(flight);
            }
		}

	}
}
