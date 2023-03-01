using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTicket
{
    class Manager : Person, ISearch
    {
        public int ManagerID { get; set; }

        public List<Movie> Movies { get { return this.Movies; } set { this.Movies = value; } }
        public List<ImaxMovie> Imaxes { get { return this.Imaxes; } set { this.Imaxes = value; } }

        public Manager(int managerid, string name, string addressm, string email, string phone, List<Movie> movies, List<ImaxMovie> imaxes) : base(name, addressm, email, phone) 
        {
            this.ManagerID = managerid;
            this.Movies = movies;
            this.Imaxes= imaxes;
        }
        public Manager() 
        { 
        }
        
        public void EnterInfor()
        {
            try
            {
                base.EnterInfo();
                Console.Write("Input your Manager ID: ");
                ManagerID = int.Parse(Console.ReadLine());
            }
            catch( Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
           /* Add movie*/
        public void AddMovie(List<Movie> movies, List<ImaxMovie> imaxes)
        {
            try
            {
                Console.WriteLine("Input the number of movies want to add: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Is there an IMAX screening? [y/n]: ");
                    string question = Console.ReadLine();
                    if (question == "y" || question == "Y")
                    {
                        ImaxMovie imax = new ImaxMovie();
                        imax.InputMovie();
                        if (imax.Title == null || imax.Genre == null || imax.DurationMins == 0 || imax.Price == 0)
                        {
                            Console.WriteLine("Invalid movie! Please input again ");
                            imax.InputMovie();
                        }
                        imaxes.Add(imax);
                    }
                    else if(question == "n" || question == "N")
                    {
                        Movie movie = new Movie();
                        movie.InputMovie();
                        if (movie.Title == null || movie.Genre == null || movie.DurationMins == 0 || movie.Price == 0)
                        {
                            Console.WriteLine("Invalid movie! Please input again ");
                            movie.InputMovie();
                        }
                        else
                        { movies.Add(movie); }
                    }
                }
            }catch( Exception ex)
            { Console.WriteLine(ex); }
        }
        /*Display*/
        public void ViewMovie(List<Movie> movies, List<ImaxMovie> imaxes)
        {
            for (int i = 0; i < movies.Count; i++)
            {              
                    movies[i].DisplayMovie();
            }
            for (int i = 0; i < imaxes.Count; i++)
            {          
                    imaxes[i].DisplayMovie();
            }
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
        /*Update*/
        public void Update(List<Movie> movies, List<ImaxMovie> imaxes)
        {
            try
            {
                Console.WriteLine("Enter the Movie: ");
                string title = Console.ReadLine();
                for (int i = 0; i < movies.Count; i++)
                {
                    if (movies[i].Title.Equals(title))
                    {
                        movies[i].DisplayMovie();
                        Console.WriteLine(" Update Movie");
                        movies.Remove(movies[i]);
                        Movie movie = new Movie();
                        movie.InputMovie();
                        movies.Add(movie);
                        Console.WriteLine("Update successfully!");
                        break;
                    }
                    else
                    {
                        for (int j = 0; j < imaxes.Count; j++)
                        {
                            if (imaxes[j].Title.Equals(title))
                            {
                                imaxes[j].DisplayMovie();
                                Console.WriteLine(" Update Movie");
                                imaxes.Remove(imaxes[j]);
                                ImaxMovie imax = new ImaxMovie();
                                imax.InputMovie();
                                imaxes.Add(imax);
                                Console.WriteLine("Update successfully!");
                            }
                            else
                            { Console.WriteLine("Invalid Movie!"); }
                        }
                    }
                }
            }catch (Exception ex)
            { Console.WriteLine(ex); }
        }
        /*Delete*/
        public void Delete(List<Movie> movies, List<ImaxMovie> imaxes)
        {
            Console.WriteLine("Enter the Movie you are looking for");
            string title = Console.ReadLine();
            for (int i = 0; i < movies.Count; i++)
            {
                if (movies[i].Title.Equals(title))
                {
                    movies.Remove(movies[i]);
                    Console.WriteLine("Delete successfully!");
                }
                else
                {
                    for (int j = 0; j < imaxes.Count; j++)
                    {
                        if (imaxes[j].Title.Equals(title))
                        {
                            imaxes.Remove(imaxes[j]);
                            Console.WriteLine("Delete successfully!");
                        }
                        else
                        { Console.WriteLine("Invalid Movie!"); }
                    }
                }
            }
        }
    }
}
