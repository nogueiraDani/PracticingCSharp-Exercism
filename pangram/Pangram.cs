using System;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        if (String.IsNullOrEmpty(input)){
            return false;
        }

        const string letters = "abcdefghijklmnopqrstuvwxyz";
        string inputLower = input.ToLower();

        return letters.All(letter => inputLower.Contains(letter));
    }
}
