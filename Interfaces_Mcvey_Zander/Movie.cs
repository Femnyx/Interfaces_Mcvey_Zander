using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Mcvey_Zander
{
    class Movie : IGenre
    {
       // The strings "Esrb", "Genre", and "Title" has a get and set for those strings.
        public string Esrb { get ; set ; }
        public string Genre { get ; set ; }
        public string Title { get ; set ; }

       // Sets Esrb to esrbParam, Genre to genreParam, and Title to titleParam. Along with the Params being set as strings.
        public Movie(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

       /// <summary>
       /// Writes the text that says the title is starting when they use PlayMovie().
       /// </summary>
        public void PlayMovie()
        {
            Console.WriteLine($"{Title} is starting, SSssshhhhhhh!!!");
        }

       /// <summary>
       /// It returns with the text about the movie title's genre and what is rated.
       /// </summary>
       /// <returns></returns>
        public string Describe()
        {
            return $"{Title} is a(n) {Genre} movie, rated {Esrb}";
        }
    }
}
