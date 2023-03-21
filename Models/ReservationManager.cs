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
        private static reservationMaking reservation;

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
         * Find the reservation by code
         * #param reservation code
         * @return the reservation object(s)
         */
        public static Reservation findreservationbycode(string reservationCode)
        {
            foreach (Reservation reservation in reservations)
            {
                if (reservation.Equals(reservationCode))
                    return reservation;
            }
            return null;
        }

        /*
         * Find reservation by code / airline / name
         * #param reservation code
         * #param reservation airline
         * #param name of traveller
         * @return reservation object(s)
         * (To.String)
         */
        public static Reservation Findreservation(string reservationCode, string airline, string name)
        {
            foreach (Reservation reservation in reservations)
            {
                if (reservation.Equals(reservationCode) && reservation.Equals(airline) && reservation.Equals(name))
                    return reservation;
                else if (reservation.Equals(reservationCode) && reservation.Equals(airline))
                    return reservation;
                else if (reservation.Equals(reservationCode) && reservation.Equals(name))
                    return reservation;
                else if (reservation.Equals(airline) && reservation.Equals(name))
                    return reservation;
                else if (reservation.Equals(airline))
                    return reservation;
                else if (reservation.Equals(name))
                    return reservation;
                else
                    return reservation;
            }
            return null;
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
