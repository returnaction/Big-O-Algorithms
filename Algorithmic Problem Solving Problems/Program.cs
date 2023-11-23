using System.Linq;

namespace Algorithmic_Problem_Solving_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problem One

            string str = "difference";
            DetectDublicate(str);

        }

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
    }
}
