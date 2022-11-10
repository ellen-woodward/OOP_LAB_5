namespace Q9
{
    static class Program
    {
        static void Main(string[] args)
        {
            string text = "This is a test sentance";

            Console.WriteLine($"The no. of words in \"{text}\" is {text.WordCount()}");
        }

        public static int WordCount(this string text)
        {
            string[] words = text.Split(' ');
            return words.Length;
        }
    }
}

// find a better way to do this in 2022 version??
