using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTicket
{
    class Movie
    {
        protected int movieid, durationmins;
        protected string title, genre ;
        protected decimal price;
        public int MovieId 
        { 
            get { return this.movieid; } 
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("MovieID not valid!");
                }
                this.movieid = value;
            } 
        }
        public string Title
        {
            get { return title; }
            set
            {
                try {
                    if (value.Length == 0)
                    {
                        throw new ArgumentException("Title not valid!");
                    }
                    title = value; }
                catch (StackOverflowException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
                
        }
        public string Genre {
            get { return genre; }
            set
            {
                if (value.Length ==0)
                {
                    throw new ArgumentException("Genre not valid!");
                }
                genre=value;
            }
        }
        public decimal Price
        {
            get { return price;}
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }

                price = value;
            }
        }   
        public int DurationMins {
            get { return durationmins;}
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }

                durationmins = value;
            }
        }

        public Movie(int movieId, string title, string genre, int durationMins, decimal price)
        {
            MovieId = movieId;
            Title = title;
            Genre = genre;
            DurationMins = durationMins;
            Price = price;
            
        }
        public Movie()
        { }
        public void InputMovie()
        {
            try
            {
                Console.Write("Input the ID of movie: ");
                MovieId = int.Parse(Console.ReadLine());
                

                Console.Write("Input movie title: ");
                Title = Console.ReadLine();

                Console.Write("Input genre of movie: ");
                Genre = Console.ReadLine();

                Console.Write("Input duration of movie: ");
                DurationMins = int.Parse(Console.ReadLine());

                Console.Write("Input price of movie: ");
                Price = decimal.Parse(Console.ReadLine());
            } catch(Exception ex) { Console.WriteLine(ex); }
           
        }

        public virtual void DisplayMovie()
        {
            Console.WriteLine("---Movie inforamtion---");
            Console.WriteLine($"Movie ID: {MovieId}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Duration: {DurationMins}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine("-----------------------");
        }
    }
    class ImaxMovie : Movie
    {
        
        public ImaxMovie() :base()  
        {
        }
        public override void DisplayMovie()
        {
            base.DisplayMovie();
            Console.WriteLine("IMAX Movie");
            Console.WriteLine($"Price: {base.Price * (decimal)1.5}");
        }
    }
}
