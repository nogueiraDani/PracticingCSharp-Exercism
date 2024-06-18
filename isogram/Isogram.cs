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

        //outra forma de executar
        /*
        return word.ToLower()
        .Where(Char.IsLetter)
        .GroupBy(ltr => ltr)
        .All(ltr_grp => ltr_grp.Count() == 1);
        */
    }
}


