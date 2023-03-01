using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTicket
{
    class Booking
    {
        private string bookingid;
        private int numberofseats;
        private string movietitle;
        private DateTime bookingdate;
        private Customer customer;
        public string BookingID { get { return this.bookingid; } set {
                Random rnd = new Random();
                string Numrd_str = rnd.Next(1, 500).ToString();
               bookingid = Numrd_str; } }
        public int NumberOfSeats { get { return this.numberofseats; } set { this.numberofseats = value; } }
        public string MovieTitle { get { return this.movietitle; } set { this.movietitle = value;} }
        public DateTime BookingDate { get { return this.bookingdate; } set { this.bookingdate = value; } }
        public Customer Customer { get { return this.customer; } set { this.customer = value; } }

        public Booking(string bookingID, int numberOfSeats, string movieTitle, DateTime bookingDate, Customer customer)
        {
            BookingID = bookingID;
            NumberOfSeats = numberOfSeats;
            MovieTitle = movieTitle;
            BookingDate = bookingDate;
            Customer = customer;
        }

        public Booking() 
        { 
        }
        public void DisplayBooking()
        {

            Console.WriteLine("---Booking---");
            Console.WriteLine($"Booking ID: {BookingID}");
            Console.WriteLine($"Number of seats: {NumberOfSeats}");
            Console.WriteLine($"Movie: {MovieTitle}");
            Console.WriteLine($"Booking date: {BookingDate}");
            Console.WriteLine($"Customer: {Customer.Name}");
            Console.WriteLine($"Email: {Customer.Email}");
            Console.WriteLine($"Phone number: {Customer.Phone}");
            Console.WriteLine("-------------");
        }

        public void ShowBookingList(List<Booking> bookings)
        {
            for (int i = 0; i < bookings.Count; i++)
                bookings[i].DisplayBooking();
        }
    }
}
