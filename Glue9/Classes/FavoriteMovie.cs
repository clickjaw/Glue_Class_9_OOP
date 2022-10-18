//name, rating, year released, budget, income

namespace MovieList.Classes{
    public abstract class FavoriteMovie: Movie{
        public override string movieName{get; set;} = "Office Space";
        public override int rating{get; set;} = 80;
        public override int yearReleased{get; set;} = 1999;

        public override void AboutMovie()
        {
            Console.WriteLine($"{movieName} is my favorite movie.");
            Console.WriteLine($"{movieName} was released in {yearReleased}");
            // Console.WriteLine($"It's rating is great at {rating} stars.");
        }

        public override void RatingSystem(){
            if (rating >= 80){
                Console.WriteLine($"{movieName}'s rating was {rating}. It had a score of greater than 80 so it's fantastic.");
            }else{
                Console.WriteLine($"{movieName} didn't rate well.");
            }

            }
        

    }
}