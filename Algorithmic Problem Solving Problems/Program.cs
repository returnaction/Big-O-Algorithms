using System.Linq;

namespace Algorithmic_Problem_Solving_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problem One

            //string str = "difference";
            //DetectDublicate(str);


            // Problem Two
            string str = "Nikita";
            ReverseString2(str);
        }

        // Function to detect and print duplicate character from the given string
        public static void DetectDublicate(string str)
        {
            SortedDictionary<char, int> letters = new();

            for (int i = 0; i < str.Length; i++)
            {
                if (letters.ContainsKey(str[i]))
                {
                    int temp = letters[str[i]];
                    letters.Remove(str[i]);
                    letters.Add(str[i] , temp + 1);
                }
                else
                {
                    letters.Add(str[i], 1);
                }
            }

            foreach(KeyValuePair<char, int> letter in letters)
            {
                if (letter.Value > 1)
                    Console.WriteLine($"{letter.Key} = {letter.Value} times" );
            }
        }


        // Problem Two Function that reverses a string, utilizing recursion
        private static void ReverseString(string str)
        {
            if(str.Length > 1)
            {
                ReverseString(str.Substring(1));
            }

            Console.Write(str[0]);
        }

        // Problem Two Function that reverses a string, utilizing recursion

        private static void ReverseString2(string str)
        {
            if (str == null || str.Length <= 1)
                Console.WriteLine(str);
            else
            {
                Console.Write(str[str.Length - 1]);
                ReverseString2(str.Substring(0, (str.Length - 1)));
            }
        }






    }
}
