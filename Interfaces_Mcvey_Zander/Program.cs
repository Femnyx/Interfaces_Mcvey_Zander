using System;

namespace Interfaces_Mcvey_Zander
{
    class Program
    {
        static void Main(string[] args)
        {
            //This uses game's esrbParam, genreParam, and titleParam in their respensented spots then prints it to the program.
            Game myGame = new Game("E", "FPS", "Call of Dooty");
            Console.WriteLine(myGame.Describe());
            myGame.PlayGame();

            //This uses the movie's esrbParam, genreParam, and titleParam in their respensented spots then prints it to the program.
            Movie myMovie = new Movie("PG", "Family/Comedy", "Over the Hedge");
            Console.WriteLine(myMovie.Describe());
            myMovie.PlayMovie();
        }
    }
}
