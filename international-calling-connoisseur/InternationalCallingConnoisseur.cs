using System;
using System.Collections.Generic;
using System.Linq;

public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary() => [];

    public static Dictionary<int, string> GetExistingDictionary()
    {
        Dictionary<int, string> dictionary = GetEmptyDictionary();
        dictionary.Add(1, "United States of America");
        dictionary.Add(55, "Brazil");
        dictionary.Add(91, "India");
        return dictionary;
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        Dictionary<int, string> dictionary = GetEmptyDictionary();
        dictionary.Add(countryCode, countryName);
        return dictionary;
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        existingDictionary.Add(countryCode, countryName);
        return existingDictionary;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode) => existingDictionary.TryGetValue(countryCode, out string value) ? value : "";


    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode) => existingDictionary.TryGetValue(countryCode, out string value);

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (CheckCodeExists(existingDictionary, countryCode))
        {
            existingDictionary[countryCode] = countryName;
            return existingDictionary;
        }
        else
        {
            return existingDictionary;
        }
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        existingDictionary.Remove(countryCode);
        return existingDictionary;
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        if (existingDictionary.Count == 0)
        {
            return "";
        }
        else
        {
            Dictionary<int, int> keyValueCountryLentgh = new Dictionary<int, int>();

            foreach (var item in existingDictionary)
            {
                keyValueCountryLentgh.Add(item.Key, item.Value.Length);
            }

            var ordered = keyValueCountryLentgh.OrderBy(x => x.Value).ToList();

            int indexOfBig = ordered[ordered.Count - 1].Key;
            return existingDictionary[indexOfBig];
        }
    }
}