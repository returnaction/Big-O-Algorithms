namespace Big_O___Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Even or Odd

            //Console.WriteLine("Even or Odd");
            //Console.WriteLine(CheckForEven(3));
            //Console.WriteLine(CheckForEven(2));

            // Task 2" Less than 100
            int[] arr = [2, 55, 6, 1, 5];
            int[] arr2 = [6, 3, 4, 17,101];

            Console.WriteLine("\nIf number less than 100");
            Console.WriteLine(LessThan100(arr));
            Console.WriteLine(LessThan100(arr2));

        }

        // Time complexity O(1) constant
        public static bool CheckForEven(int number)
        {
            return number % 2 == 0 ? true : false;
        }


        // Time complexity O(n) linear
        public static bool LessThan100(int[] arr)
        {
            foreach(int num in arr)
            {
                if (num >= 100)
                    return false;
            }

            return true;
        }
    }
}
