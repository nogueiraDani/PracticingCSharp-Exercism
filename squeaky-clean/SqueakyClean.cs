using System;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder myStringBuilder = new StringBuilder();

        if (string.IsNullOrEmpty(identifier))
        {
            return myStringBuilder.ToString();
        }

        foreach (char c in identifier)
        {
            bool isSpace = char.IsWhiteSpace(c);
            bool isControl = char.IsControl(c);
            bool isLetter = char.IsLetter(c);
            bool isNumber = char.IsNumber(c);

            if (isSpace)
            {
                myStringBuilder.Append('_');
            }
            else if (isControl)
            {
                myStringBuilder.Append("CTRL");
            }
            else if (!isLetter || isNumber)
            {
                if (c.ToString().Equals("-"))
                {
                    myStringBuilder.Append(c);
                }
                else
                {
                    myStringBuilder.Append("");
                }
            }
            else
            {
                myStringBuilder.Append(c);
            }
        }


        StringBuilder newStringBuilder = new StringBuilder();


        for (int i = 0; i < myStringBuilder.Length; i++)
        {
            string[] greekAlphabet = { "α", "β", "γ", "δ", "ε", "ζ", "η", "θ", "ι", "κ", "λ", "μ", "ν", "ξ", "ο", "π", "ρ", "σ", "ς", "τ", "υ", "φ", "χ", "ψ", "ω" };

            bool kebabCase = false;
            bool greekLetter = false;

            if (myStringBuilder[i].Equals('-'))
            {
                newStringBuilder.Append("");
                String newString = myStringBuilder[i + 1].ToString();
                String letter = newString.ToUpper();
                newStringBuilder.Append(letter);
                i++;
                kebabCase = true;
            }

            foreach (string letter in greekAlphabet)
            {
                if (myStringBuilder[i].ToString().Equals(letter))
                {
                    newStringBuilder.Append("");
                    greekLetter = true;
                }
            }

            if (!kebabCase && !greekLetter)
            {
                newStringBuilder.Append(myStringBuilder[i]);
            }
        }

        return newStringBuilder.ToString();
    }
}

/*
Outra forma de executar:

﻿using System.Text;
public static class Identifier
{
    private static bool IsGreekLowercase(char c) => (c >= 'α' && c <= 'ω');
    
    public static string Clean(string identifier)
    {
        var stringBuilder = new StringBuilder();
        var isAfterDash = false;
        foreach (var c in identifier)
        {
            stringBuilder.Append(c switch
            {
                _ when IsGreekLowercase(c) => default,
                _ when isAfterDash => char.ToUpperInvariant(c),
                _ when char.IsWhiteSpace(c) => '_',
                _ when char.IsControl(c) => "CTRL",
                _ when char.IsLetter(c) => c,
                _ => default,
            });
            isAfterDash = c.Equals('-');
        }
        return stringBuilder.ToString();
    }
}

*/

