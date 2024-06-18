using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;



public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        string newWord = word
        .ToLower()
        .Replace("-", "")
        .Replace(" ", "");

        HashSet<char> letters = [];

        foreach (char c in newWord)
        {
            if (letters.Contains(c))
            {
                return false;
            }
            letters.Add(c);
        }
        return true;
    }
}


