using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTicket
{
     class Program
    {
        static void Main(string[] args)
        {
            var Manager=new Manager();
            List<Movie> movies = new List<Movie>();
            List<ImaxMovie> imaxes = new List<ImaxMovie>();
            List<Booking> bookings = new List<Booking>();
            try
            {
                int choose;
                do
                {
                    MainMenu();
                    choose = int.Parse(Console.ReadLine());
                    switch (choose)
                    {
                        case 1:
                            Manager.EnterInfor();
                            LoginAsManager(movies, imaxes);
                            break;
                        case 2:
                            LoginAsCustomer(movies, imaxes, bookings);
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Thank for your using!");
                            break;
                        default:
                            Console.WriteLine("Input failed!!");
                            break;
                    }
                } while (choose != 3);
            }catch (Exception e) { Console.WriteLine(e); }
        }
       static void MainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("*******************************************************");
            Console.WriteLine("*****           WELCOME TO *** CINEMA             *****");
            Console.WriteLine("*        - Full enjoyment with classic movies -       *");
            Console.WriteLine("*                                                     *");
            Console.WriteLine("*   Three halls for you - More halls, more choices.   *");
            Console.WriteLine("*                                                     *");
            Console.WriteLine("*  1. Log in as a Manager                             *");
            Console.WriteLine("*                                                     *");
            Console.WriteLine("*  2. Log in as a customer                            *");
            Console.WriteLine("*                                                     *");
            Console.WriteLine("*  3. Quit the app.                                   *");
            Console.WriteLine("*                                                     *");
            Console.WriteLine("*******************************************************");
            Console.WriteLine();
            Console.WriteLine("Please choose your choice: ");
        }
       static  void ShowLibrarianMenu()
        {
            Console.WriteLine("1. Add new movies.");
            Console.WriteLine("2. View all movies.");
            Console.WriteLine("3. Search movie by title.");
            Console.WriteLine("4. Search book by genre.");
            Console.WriteLine("5. Update movie.");
            Console.WriteLine("6. Delete movie.");
            Console.WriteLine("7. Log out.");


        }
       static void LoginAsManager(List<Movie> movies, List<ImaxMovie> imaxes)
        {
            try
            {
                var
                Manager = new Manager();
                int choose;
                do
                {
                    ShowLibrarianMenu();
                    choose = int.Parse(Console.ReadLine());
                    switch (choose)
                    {
                        case 1:
                            Manager.AddMovie(movies, imaxes);
                            break;
                        case 2:
                            Manager.ViewMovie(movies, imaxes);
                            break;
                        case 3:
                            Manager.SearchByTitle(movies, imaxes);
                            break;
                        case 4:
                            Manager.SearchByGenre(movies, imaxes);
                            break;
                        case 5:
                            Manager.Update(movies, imaxes);
                            break;
                        case 6:
                            Manager.Delete(movies, imaxes);
                            break;
                        case 7:
                            MainMenu();
                            break;
                        default:
                            Console.WriteLine("Input failed!!");
                            break;
                    }
                } while (choose != 7);
            }catch (Exception ex)
            { Console.WriteLine(ex); }
        }

        static void ShowStudentMenu()
        {
            Console.WriteLine("1. View all movies.");
            Console.WriteLine("2. Search movie by title.");
            Console.WriteLine("3. Search movie by genre.");
            Console.WriteLine("4. Make booking.");
            Console.WriteLine("5. View booking.");
            Console.WriteLine("6. Log out.");

        }
        static void LoginAsCustomer(List<Movie> movies, List<ImaxMovie> imaxes, List<Booking> bookings)
        {
            Customer customer1 = new Customer();
            Booking booking= new Booking();
            int choose;
            do
            {
                ShowStudentMenu();
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        customer1.ViewMovie(movies, imaxes);
                        break;
                    case 2:
                        customer1.SearchByTitle(movies, imaxes);
                        break;
                    case 3:
                        customer1.SearchByGenre(movies, imaxes);
                        break;
                    case 4:
                        customer1.MakeBooking(movies, imaxes, bookings);    
                        break;
                    case 5:
                        booking.ShowBookingList(bookings);
                        break;
                    case 6:
                        MainMenu();
                        break;
                    default:
                        Console.WriteLine("Input failed!!");
                        break;
                }
            } while (choose != 6);
        }
    }
}
