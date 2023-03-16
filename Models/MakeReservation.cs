using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Assignment2.Models;

namespace Assignment2.Models
{
    public class reservationMaking
    {
        private readonly List<Flight> flights;
        private readonly FlightManager flightManager;
        private readonly AirportManager airportManager;

        public reservationMaking(FlightManager flightManager, AirportManager airportManager)
        {
            this.flightManager = flightManager;
            this.airportManager = airportManager;
            flights = flightManager.GetFlights();
        }

        public Reservation makeReservation(Flight chosenFlight, string name, string citizenship)
        {
            if (chosenFlight == null)
            {
                throw new ArgumentException("No flights selected");
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Please enter your name");
            }

            if (string.IsNullOrWhiteSpace(citizenship))
            {
                throw new ArgumentException("Citizenship field not completed");
            }

            if (chosenFlight.Capacity <= 0)
            {
                throw new ArgumentException("The flight is completely booked");
            }

            var reservationCode = GenerateReservationCode();

            var reservation = new Reservation
            {
                PassengerName = name,
                Citizenship = citizenship,
                ReservationCode = reservationCode,
                Flight = chosenFlight
            };

            chosenFlight.Capacity--;

            {
                var line = $"{reservation.ReservationCode},{reservation.Flight.FlightCode},{reservation.PassengerName},{reservation.Citizenship}";

                File.AppendAllText("reservations.csv", line + Environment.NewLine);
            }

            return reservation;
        }
    }
}
