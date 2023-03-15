using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    internal class AirportManager
    {
        private string airports_text = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Files", "airports.csv");
        public static List<Airport> airports = new List<Airport>();

        public AirportManager()
        {
            populateAirports();
        }

        private void populateAirports()
        {
            Airport airport;
            try
            {
				foreach (string line in System.IO.File.ReadLines(airports_text))
				{
					string[] parts = line.Split(",");

					string airportCode = parts[0];
					string airportName = parts[1];

					airport = new Airport(airportCode, airportName);
					airports.Add(airport);
				}
			}
            catch (Exception e)
            {
                airport = new Airport("error", "error");
                airports.Add(airport);
            }

        }
        public static List<Airport> GetAirports()
        {
            return airports;
        }
    }
}
