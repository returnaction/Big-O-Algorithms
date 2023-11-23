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
            //string str = "Nikita";
            //ReverseString2(str);


            // Problem Three
            //string str = "Nikita";
            //var result = CountVowelsConsts(str);

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
                    letters[str[i]] = temp + 1;
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

        // Problem Three Function that counts the number of vowels and consonants within a given string
        public static Dictionary<string, int> CountVowelsConsts(string str)
        {
            Dictionary<string, int> result = new();

            result.Add("vowels", 0);        
            result.Add("consts", 0);        

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'y')
                {
                    int temp = result["vowels"];
                    result["vowels"] = temp + 1;
                }
                else
                {
                    int temp = result["consts"];
                    result["consts"] = temp + 1;
                }

            }

            return result;

        }




    }
}
