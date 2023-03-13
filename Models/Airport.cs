using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using CsvHelper;
using System.Globalization;

namespace Assignment2.Models
{

	internal class Airport
	{
		private string airportCode;
		private string airportName;

		public string AirportCode { get { return airportCode; } private set { airportCode = value; } }
		public string AirportName { get { return airportName; } private set { airportName = value; } }
		public Airport() { }
        public Airport(string airportCode, string airportName) {
			AirportCode = airportCode;
			AirportName = airportName;
		}
    }
}
