using System;

namespace StringFunctions
{
    class TestProgram
    {
        static void Main()
        {
            Console.WriteLine("Original Sample String:");
            string ex = "Hello, this is a Test!!";            
            Console.WriteLine(ex + "\n");

            Console.WriteLine("Test of RemoveSpace:");
            string nospace = ex.RemoveSpace();            
            Console.WriteLine(nospace + "\n");

            Console.WriteLine("Test of RemoveFirstCharacter:");
            string remfir = ex.RemoveFirstChar();
            Console.WriteLine(remfir + "\n");

            Console.WriteLine("Test of Pig Latin Translator:");
            string piglatin = ex.PigLatin();
            Console.WriteLine(piglatin + "\n");

            Console.WriteLine("Test of SplitIncludeSeparators:");
            string[] spl = ex.SplitInclSep(new char[] { ' ',',','!' });
            for(int i = 0; i < spl.Length; i++)
            {
                Console.WriteLine("Array[{0}] = " + spl[i], i);
            }
        }
    }
}