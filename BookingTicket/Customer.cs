using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTicket
{
    class Customer : Person, ISearch
    {
        public int CusID { get; set; }
        public List<Movie> Movies { get { return this.Movies; } set { this.Movies = value; } }
        public List<ImaxMovie> Imaxes { get { return this.Imaxes; } set { this.Imaxes = value; } }
        public List<Booking> Bookings { get; set; }
        public Customer(int cusid ,string name, string addressm, string email, string phone, List<Movie> movies, List<ImaxMovie> imax) : base(name, addressm, email, phone)
        {
            this.CusID = cusid;
            this.Movies = movies;
            this.Imaxes = imax;
        }
        public Customer() { }
        
        /*Display*/
        public void ViewMovie(List<Movie> movies, List<ImaxMovie> imaxes)
        {
            for (int i = 0; i < movies.Count; i++)
                movies[i].DisplayMovie();
            for (int i = 0; i < imaxes.Count; i++)
                imaxes[i].DisplayMovie();
        }
        /*Search*/
        public void SearchByTitle(List<Movie> movies, List<ImaxMovie> imaxes)
        {
            Console.WriteLine("Enter the Movie you are looking for");
            string title = Console.ReadLine();
            for (int i = 0; i < movies.Count; i++)
            {
                if (movies[i].Title.Equals(title))
                {
                    movies[i].DisplayMovie();
                }
                else
                {
                    for (int j = 0; j < imaxes.Count; j++)
                    {
                        if (imaxes[j].Title.Equals(title))
                        { imaxes[j].DisplayMovie(); }
                        else
                        { Console.WriteLine("Invalid Movie!"); }
                    }
                }
            }
        }
        public void SearchByGenre(List<Movie> movies, List<ImaxMovie> imaxes)
        {
            Console.WriteLine("Enter the Genre you want to watch: ");
            string genre = Console.ReadLine();
            for (int i = 0; i < movies.Count; i++)
            {
                if (movies[i].Genre.Equals(genre))
                {
                    movies[i].DisplayMovie();
                }
                else
                {
                    for (int j = 0; j < imaxes.Count; j++)
                    {
                        if (imaxes[j].Genre.Equals(genre))
                        { imaxes[j].DisplayMovie(); }
                        else
                        { Console.WriteLine("Invalid Movie!"); }
                    }
                }
            }
        }
        /*Make Booking*/
        public void MakeBooking(List<Movie> movies, List<ImaxMovie> imaxes,List<Booking>bookings)
        {
            try
            {
                Console.WriteLine("your information to make a booking: ");
                Customer customer = new Customer();
                customer.EnterInfo();
                Booking booking = new Booking();
                Console.WriteLine("Input the number of seats you want to book: ");
                booking.NumberOfSeats = int.Parse(Console.ReadLine());
                booking.BookingDate = DateTime.Now;
                Console.WriteLine("Enter the Movie you are looking for: ");
                booking.MovieTitle = Console.ReadLine();
                for (int i = 0; i < movies.Count; i++)
                {
                    if (movies[i].Title.Equals(booking.MovieTitle))
                    {
                        Console.WriteLine($"Successfully booked {movies[i].Title}");
                        break;
                    }
                    else
                    {
                        for (int j = 0; j < imaxes.Count; j++)
                        {
                            if (imaxes[j].Title.Equals(booking.MovieTitle))
                            {
                                Console.WriteLine($"Successfully booked {imaxes[j].Title}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid Movie!");
                                break;
                            }
                        }
                    }
                }
                booking = new Booking(booking.BookingID, booking.NumberOfSeats, booking.MovieTitle, booking.BookingDate, customer);
                bookings.Add(booking);
            }
            catch (Exception ex)
            { Console.WriteLine(ex.ToString()); }
        }
    }
}
