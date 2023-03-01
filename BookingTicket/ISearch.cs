using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTicket
{
    internal interface ISearch
    {
        void SearchByTitle(List<Movie> movies, List<ImaxMovie> imaxes);
        void SearchByGenre(List<Movie> movies, List<ImaxMovie> imaxes);
    }
}
