using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(IsAbecedarian("abdest")); // True
        Console.WriteLine(IsAbecedarian("agnosy")); // True
        Console.WriteLine(IsAbecedarian("biopsy")); // False
        Console.WriteLine(IsAbecedarian("deux"));   // True
        Console.WriteLine(IsAbecedarian("dimpsy")); // True
    }

    static bool IsAbecedarian(string word)
    {
        for (int i = 0; i < word.Length - 1; i++)
        {
            if (word[i] > word[i + 1])
            {
                return false;
            }
        }
        return true;
    }
}