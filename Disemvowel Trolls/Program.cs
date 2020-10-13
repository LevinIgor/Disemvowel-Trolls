using System;
using System.Linq;
using System.Text.RegularExpressions;
/*
Trolls are attacking your comment section!
A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.
Your task is to write a function that takes a string and return a new string with all vowels removed.
For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!". 
*/
namespace Disemvowel_Trolls
{

    public static class Kata
    {
        static void Main(string[] args)
        {
            Kata.Disemvowel("This website is for losers LOL!");
        }
        public static string Disemvowel(string str)
        {
            char[] charVowels = { 'A','E', 'I','O','U', 'a', 'e', 'i', 'o', 'u' };
            char[] charArray = str.ToCharArray();
            string finishString="";
            bool point = true;
            for (int i = 0; i < charArray.Length; i++)
            {
                for (int j = 0; j < charVowels.Length; j++)
                {
                    if (charArray[i].Equals(charVowels[j]))
                    {
                        point = true;
                        break;
                    }
                    else
                    {
                        point = false;
                    }
                   
                }
                if (!point)
                {
                    finishString += charArray[i];
                }

            }

            return finishString;
           
        }

        public static string Disemvowel1(string str)
        {
            return Regex.Replace(str, "[aeiou]", "", RegexOptions.IgnoreCase);
        }

        public static string Disemvowel2(string str)
        {
            return string.Concat(str.Where(ch => !"aeiouAEIOU".Contains(ch)));
        }
    }
}
