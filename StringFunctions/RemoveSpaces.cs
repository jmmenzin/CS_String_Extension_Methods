using System;

namespace StringFunctions
{
    public static class RemoveSpaces
    {
        //removes all spaces from a string of words and returns the new string
        public static string RemoveSpace(this string str)
        {
            string[] arr = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string final = "";
            foreach (string item in arr)
            {
                final += item;
            }
            return final;
        }
    }
}
