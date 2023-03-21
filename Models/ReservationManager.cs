using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    class ReservationManager
    {
        /*
         * location of reservation code 
         * (binary or text)
         */
        public const string reservation_binary = "res/reservation.txt";

        public static List<Reservation> reservations = new List<Reservation>();
        private static ReservationMaking reservation;

		/*
         * getReservation return the list of reservations
         * #param - no parameters
         * @return list of reservations
         */
		public static List<Reservation> GetReservations()
        {
            return reservations;
        }

		/*
         * Find reservation by code / airline / name
         * #param reservation code
         * #param reservation airline
         * #param name of traveller
         * @return reservation object(s)
         * (To.String)
         */
		public static List<Reservation> Findreservation(string reservationCode, string airline, string name)
        {
            List<Reservation> found = new List<Reservation>();

            foreach (Reservation reservation in reservations)
            {
                string reservationcode = reservation.ReservationCode;
                string reservationAirline = reservation.Airline;
                string reservationName = reservation.Name;

                if (reservationcode.Equals(reservationCode) && reservationAirline.Equals(airline) && reservationName.Equals(name))
                {
                    found.Add(reservation);
                }
                else if (reservationcode.Equals(reservationCode) && reservationAirline.Equals(airline))
                {
                    found.Add(reservation);
                }
                else if (reservationcode.Equals(reservationCode) && reservationName.Equals(name))
                {
                    found.Add(reservation);
                }
                else if (reservationAirline.Equals(airline) && reservationName.Equals(name))
				{
					found.Add(reservation);
				}
				else if (reservationcode.Equals(reservationCode))
				{
					found.Add(reservation);
				}
				else if (reservationAirline.Equals(airline))
				{
					found.Add(reservation);
				}
				else if (reservationName.Equals(name))
				{
					found.Add(reservation);
				}
				else
				{
					found.Add(reservation);
				}
			}
            return found;
        }

        // Added GenerateReservationCode method
        /*
         * Generate a reservation code with the format LDDDD (one letter followed by four digits)
         * #param - no parameters
         * @return string - reservation code
         */
        public static string GenerateReservationCode()
        {
            Random random = new Random();
            const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char randomLetter = alphabet[random.Next(alphabet.Length)];
            int randomDigits = random.Next(1000, 10000);

            return $"{randomLetter}{randomDigits}";
        }
    }
}
