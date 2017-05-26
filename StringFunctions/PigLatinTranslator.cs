using System;
using System.Collections.Generic;
using System.Linq;

namespace StringFunctions
{
    public static class PigLatinTranslator
    {
        public static char[] letters = new char[52] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
        public static char[] consonants = { 'q', 'w', 'r', 't', 'y', 'p', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
        public static char[] punct = { '.', ',', '?', '!', ' ' };

        //translates a string of words to piglatin and returns the new string
        public static string PigLatin(this string str)
        {
            //creates a list of non-letter characters in the string to be used as separators
            List<char> sep = new List<char>();
            foreach (char c in str.ToArray())
            {
                if (!letters.Contains(c))
                {
                    if (!sep.Contains(c))
                    {
                        sep.Add(c);
                    }                    
                }
            }

            //splits the string into an array of strings using the separators found above
            string[] arr = str.SplitInclSep(sep.ToArray());
            string[] pig = new string[arr.Length];

            //cycles through each word in the string array
            for (int k = 0; k<arr.Length; k++)
            {                 
                char[] chArr = arr[k].ToArray();
                bool upper = char.IsUpper(chArr[0]);
                string final;

                //checks if the current index of the string array contains a letter
                if (Char.IsLetter(chArr[0]))
                {
                    //if first letter of word is consinent, moves first letter to end and adds "ay"
                    if (consonants.Contains(char.ToLower(chArr[0])))
                    {
                        char[] pigl = new char[chArr.Length + 2];
                        for (int i=1; i<chArr.Length; i++)
                        {
                            pigl[i - 1] = chArr[i];
                        }
                        pigl[pigl.Length - 3] = char.ToLower(chArr[0]);
                        pigl[pigl.Length - 2] = 'a';
                        pigl[pigl.Length - 1] = 'y';
                        
                        //checks if first letter was capitalized and fixes as needed
                        if (upper)
                        {
                            pigl[0] = char.ToUpper(pigl[0]);
                        }

                        final = new string(pigl);
                    }

                    //if first letter of word is not consinent (vowel), adds "way" to end of the word
                    else
                    {
                        final = arr[k] + "way";
                    }
                }
                //if current index of string array is a punctuation, adds it back to the new string array unchanged
                else
                {
                    final = arr[k];
                }

                //replaces old word with newly translated word
                arr[k] = final;
            }
            //returns translated string
            return string.Join("", arr);
        }
    }
}