using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        if (String.IsNullOrEmpty(input)){
            return false;
        }

        char[] chars = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'z', 'w', 'y'];

        int[] isletters = new int[26];

        string inputLower = input.ToLower();

        bool result = true;

        foreach (char letter in inputLower)
        {
            if (Char.IsLetter(letter))
            {
                switch (letter)
                {
                    case 'a':
                        isletters[0] += 1;
                        break;
                    case 'b':
                        isletters[1] += 1;
                        break;
                    case 'c':
                        isletters[2] += 1;
                        break;
                    case 'd':
                        isletters[3] += 1;
                        break;
                    case 'e':
                        isletters[4] += 1;
                        break;
                    case 'f':
                        isletters[5] += 1;
                        break;
                    case 'g':
                        isletters[6] += 1;
                        break;
                    case 'h':
                        isletters[7] += 1;
                        break;
                    case 'i':
                        isletters[8] += 1;
                        break;
                    case 'j':
                        isletters[9] += 1;
                        break;
                    case 'k':
                        isletters[10] += 1;
                        break;
                    case 'l':
                        isletters[11] += 1;
                        break;
                    case 'm':
                        isletters[12] += 1;
                        break;
                    case 'n':
                        isletters[13] += 1;
                        break;
                    case 'o':
                        isletters[14] += 1;
                        break;
                    case 'p':
                        isletters[15] += 1;
                        break;
                    case 'q':
                        isletters[16] += 1;
                        break;
                    case 'r':
                        isletters[17] += 1;
                        break;
                    case 's':
                        isletters[18] += 1;
                        break;
                    case 't':
                        isletters[19] += 1;
                        break;
                    case 'u':
                        isletters[20] += 1;
                        break;
                    case 'v':
                        isletters[21] += 1;
                        break;
                    case 'x':
                        isletters[22] += 1;
                        break;
                    case 'z':
                        isletters[23] += 1;
                        break;
                    case 'w':
                        isletters[24] += 1;
                        break;
                    case 'y':
                        isletters[25] += 1;
                        break;
                    default:
                        break;
                }

            }
        }
        foreach (int number in isletters)
        {
            if (number == 0)
            {
                result = false;
                break;
            }
        }

        return result;
    }
}
