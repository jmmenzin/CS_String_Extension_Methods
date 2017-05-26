using System.Linq;

namespace StringFunctions
{
    public static class RemoveFirstCharacter
    {
        //removes first character from a string and returns shortened string
        public static string RemoveFirstChar(this string str)
        {
            char[] chArr = str.ToArray();
            char[] finalArr;
            finalArr = new char[chArr.Length - 1];
            for (int i = 1; i < chArr.Length; i++)
            {
                finalArr[i - 1] = chArr[i];
            }
            return new string(finalArr);
        }
    }
}
