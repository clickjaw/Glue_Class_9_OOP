
namespace MovieList.Classes{
    public class BoxOffice : FavoriteMovie{

        public override decimal budget{get; set;} = 10000000;
        public override decimal gross { get; set;} = 12200000;
        public override decimal profit { get; set;} = 2200000;

        public override void MoneyMade()
        {   
            decimal income = (gross - budget);
            Console.WriteLine($@"{movieName}'s budget was ${budget} and the worldwide gross was ${gross}.
The profit on {movieName} was ${income}");
            
        }

    }
}