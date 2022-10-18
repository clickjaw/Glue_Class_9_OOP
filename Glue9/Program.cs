using System;
using MovieList.Classes;

namespace MovieProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            ShowMovie();
        }

        public static void ShowMovie()
        {
            BoxOffice myMovie = new BoxOffice();
            myMovie.AboutMovie();
            myMovie.RatingSystem();
            myMovie.MoneyMade();

        }
    }
}