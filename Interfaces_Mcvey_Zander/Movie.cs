using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Mcvey_Zander
{
    class Movie : IGenre
    {
        public string Esrb { get ; set ; }
        public string Genre { get ; set ; }
        public string Title { get ; set ; }

        public Movie(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

        public void PlayMovie()
        {
            Console.WriteLine($"{Title} is starting, SSssshhhhhhh!!!");
        }

        public string Describe()
        {
            return $"{Title} is a {Genre} movie, rated {Esrb}";
        }
    }
}
