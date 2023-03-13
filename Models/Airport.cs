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

		public string AirportCode { get { return airportCode; } set { airportCode = value; } }
		public string AirportName { get { return airportName; } set { airportName = value; } }
		public Airport() { }
        public Airport(string airportCode, string airportName) {
			this.AirportCode = airportCode;
			this.AirportName = airportName;
		}
    }
}
