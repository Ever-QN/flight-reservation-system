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
        public readonly List<Flight> flights;
        public readonly FlightManager flightManager;
        public readonly AirportManager airportManager;

        public reservationMaking(FlightManager flightManager, AirportManager airportManager)
        {
            this.flightManager = flightManager;
            this.airportManager = airportManager;
            flights = FlightManager.GetFlights();
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

            if (chosenFlight.Seats <= 0)
            {
                throw new ArgumentException("The flight is completely booked");
            }

            var reservationCode = ReservationManager.reservation_binary;

            var reservation = new Reservation
            {
                PassengerName = name,
                Citizenship = citizenship,
                ReservationCode = reservationCode,
                Flight = chosenFlight
            };

            chosenFlight.Seats--;

            {
                var line = $"{reservation.ReservationCode},{reservation.flights.FlightCode},{reservation.PassengerName},{reservation.Citizenship}";

                File.AppendAllText("reservations.txt", line + Environment.NewLine);
            }

            return reservation;
        }
    }
}
