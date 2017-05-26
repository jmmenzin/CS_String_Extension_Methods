using System.Collections.Generic;
using System.Linq;

namespace StringFunctions
{
    public static class SplitIncludeSeparator
    {
        //splits a string into an array of words, with the separators included as separate members of the array
        public static string[] SplitInclSep(this string str, char[] sep)
        {
            List<string> strList = new List<string>();
            List<char> current = new List<char>();
            char[] chArr = str.ToArray();

            //cycles through all characters in string to determine if they are separators
            foreach (var item in chArr)
            {
                /*if char is a separator, adds the current list of characters to the array as a string, clears the current list, 
                and adds the separator to the array as a string*/
                if (sep.Contains(item))
                {
                    if (current.Count > 0)
                    {
                        strList.Add(new string(current.ToArray()));
                        current.Clear();
                    }
                    strList.Add(item.ToString());
                }
                //if char is not a separator, adds the char to the current list to create the next word
                else
                {
                    current.Add(item);
                }
            }
            //if the end of the string is reached without a separator, the current word is added to the string array
            if (current.Count() > 0)
            {
                strList.Add(new string(current.ToArray()));
            }

            //returns the list of strings as a string array
            return strList.ToArray();
        }
    }
}
