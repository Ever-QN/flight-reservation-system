﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Models
{
	internal class FlightManager
	{
        private string USERS_TEXT = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Files", "flights.csv");
        public static List<Airport> users = new List<Airport>();
        public FlightManager() 
		{
		}

	}
}
