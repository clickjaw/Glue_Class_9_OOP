//name, rating, year released, budget, income

namespace MovieList.Classes{
    public abstract class Movie{

        public abstract string movieName{get; set;}
        public abstract int rating{get; set;}
        public abstract int yearReleased{get; set;}
        public abstract decimal budget{get; set;}
        public abstract decimal gross{get; set;}
        public abstract decimal profit{get; set;}

        public abstract void MoneyMade();
        public abstract void AboutMovie();
        public abstract void RatingSystem();
    }
}