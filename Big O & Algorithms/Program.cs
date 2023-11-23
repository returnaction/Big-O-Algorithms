namespace Big_O___Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Even or Odd

            Console.WriteLine(CheckForEven(3));
            Console.WriteLine(CheckForEven(2));
        }

        // Time complexity O(1) constant
        public static bool CheckForEven(int number)
        {
            return number % 2 == 0 ? true : false;
        }
    }
}
