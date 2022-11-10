using System;
namespace Q1
{
    public abstract class Game
    {
        private readonly string _name;
        public string Name
        {
            get { return _name; }
        }
        protected decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Game(string name, decimal price, DateTime releaseDate)
        {
            _name = name;
            Price = price;
            ReleaseDate = releaseDate;
        }

        public Game(string name, decimal price) : this(name, price, DateTime.Now)
        {
        }

        public Game() : this("", 0) { }

        public abstract void UpdatePrice(decimal percentageIncrease);
        //{
        //    Price *= (1 + percentageIncrease);
        //}

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}. Release Date: {ReleaseDate}";
        }
    }
}

