using System;
using System.Collections.Generic;
using System.Linq;

public static class Languages
{
    public static List<string> NewList() => [];

    public static List<string> GetExistingLanguages()
    {
        var list = NewList();
        list.Add("C#");
        list.Add("Clojure");
        list.Add("Elm");
        return list;
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        var list = languages;
        list.Add(language);
        return list;
    }

    public static int CountLanguages(List<string> languages) => languages.Count;

    public static bool HasLanguage(List<string> languages, string language) => languages.Contains(language);

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)

    {

        if (languages.Count == 0)
        {
            return false;
        }

        if (languages.Count is 2 or 3)
        {
            if (languages.IndexOf("C#").Equals(0) || languages.IndexOf("C#").Equals(1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        if (languages.First().Equals("C#"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        HashSet<string> newList = [];

        foreach (string language in languages)
        {
            newList.Add(language);
            
        }
        return newList.Count == languages.Count;
        
    }
}
