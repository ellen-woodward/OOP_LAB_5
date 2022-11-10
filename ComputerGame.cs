using System;
namespace Q1
{
    public class ComputerGame : Game
    {
        public string PEGIRating { get; set; }

        public ComputerGame()
        {
        }

        public ComputerGame(string name, decimal price, DateTime dateTime, string pegi)
            : base(name, price, dateTime)
        {
            PEGIRating = pegi;
        }

        public decimal GetDiscountPrice()
        {
            return Price * .9m;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Release Date: {ReleaseDate}, PEGI Rating: {PEGIRating}";
        }

        public override void UpdatePrice(decimal percentageIncrease)
        {
            Price *= (1 + percentageIncrease);
            Console.WriteLine("Updating price");
        }
    }
}

