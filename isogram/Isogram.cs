using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;



public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var newWord = word.ToLower().Where(char.IsLetter).ToList();
        return newWord.Distinct().Count() == newWord.Count;
    }
}


