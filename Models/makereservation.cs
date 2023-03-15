using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2OBJ
{
    public class reservationMaking
    {
        private readonly List<Flight> flights;

        public reservationMaking()
        {
            flights = new List<Flight>();

            using (var reader = new StreamReader("flights.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var parts = line.Split(',');

                    var flight = new Flight
                    {
                        FlightCode = parts[0],
                        Airline = parts[1],
                        DepartureAirport = new Airport(parts[2]),
                        ArrivalAirport = new Airport(parts[3]),
                        DayOfWeek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), parts[4]),
                        DepartureTime = TimeSpan.Parse(parts[5]),
                        Capacity = int.Parse(parts[6]),
                        Price = decimal.Parse(parts[7])
                    };

                    flights.Add(flight);
                }
            }
        }

        public Reservation MakeReservations(Flight chosenFlight, string name, string citizenship)
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

            var reservationCode = GenerateReservationCode();

            var reservation = new Reservation
            {
                PassengerNames = name,
                Citizenships = citizenship,
                ReservationCode = reservationCode,
                Flights = chosenFlight

            };

            chosenFlight.Capacity--;

            {
                var line = $"{reservation.ReservationCode},{reservation.Flights.FlightCode},{reservation.PassengerNames},{reservation.Citizenships}";

                    File.AppendAllText("reservations.csv", line + Environment.NewLine);

            }

            return reservation;
        }
}        
