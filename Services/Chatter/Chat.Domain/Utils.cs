using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Domain
{
    public class Utils
    {
        static Random rand = new Random();
        static char[] Consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
        static char[] Vowels = { 'a','e','i','o','u' };
        public char[] GenerateLetters(int minNumberOfLetters, int maxNumberOfLetters)
        {
            var numLetters = rand.Next(minNumberOfLetters, maxNumberOfLetters + 1);
            var numVowels = rand.Next(Math.Max(1, numLetters / 5), numLetters / 2);
            char[] result = new char[numLetters];
            for (int i = 0; i < numVowels; i++)
            {
                result[i] = Vowels[rand.Next(Vowels.Length)];
            }
            for (int i = numVowels; i<numLetters; i++)
            {
                result[i] = Consonants[rand.Next(Consonants.Length)];
            }

            Shuffle<char>(result);

            return result;
        }

        public bool WordContainsAllLetters(string word, char[] letters)
        {
            string lowercase = word.ToLower().Trim();
            return letters.All(l => word.Contains(l));
        }

        private static void Shuffle<T>(T[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                int r = i + (int)(rand.NextDouble() * (n - i));
                T t = array[r];
                array[r] = array[i];
                array[i] = t;
            }
        }
    }
}
