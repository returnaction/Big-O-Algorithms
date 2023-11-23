
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


            // Task 2: Less than 100

            //int[] arr = [2, 55, 6, 1, 5];
            //int[] arr2 = [6, 3, 4, 17,101];

            //Console.WriteLine("\nIf number less than 100");
            //Console.WriteLine(LessThan100(arr));
            //Console.WriteLine(LessThan100(arr2));


            // Task 3: Repeated Names

            //string[] names = { "Nikita", "Kastet", "John" };
            //string[] names2 = { "Nikita", "Kastet", "Nikita" };
            //Console.WriteLine(RepeatedNames(names));
            //Console.WriteLine(RepeatedNames(names2));


            // Task 4: SortList
            int[] arr = { 5, 3, 2, 1, 4 };

            Console.WriteLine("\tBefore sorting:");
            foreach (int num in arr)
                Console.Write($"{num} "); ;

            Console.WriteLine("\n\tAfter sorting:");
            MySort(arr);

            foreach(int num in arr)
                Console.Write($"{num} ");
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

        // Time complexity O(n squared) quadratic
        public static bool RepeatedNames(string[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        return true;
                }
            }
            return false;
        }

        // Time complexity O(n squared) quadratic
        public static void MySort(int[] arr)
        {
            bool swapped = true;

            while (swapped)
            {
                swapped = false;

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }
            }
        }

    }
}
