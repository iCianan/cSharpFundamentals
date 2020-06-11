using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public static class CaesarCipherEncryptor
    {
        // Given a non empty string of lowercase characters and a non negative integer representing a key
        // write a function that returns a new string obtained by shifting every leter in the input string by k positions in the alphabet, where k is the key.

        public static string Encryptor(string str, int key)
        {
            char[] newLetters = new char[str.Length];
            // prevent a large key from breaking code
            int newKey = key % 26;

            for (int i = 0; i < str.Length; i++)
            {
                newLetters[i] = getNewLetter(str[i], newKey);
            }

            return new string(newLetters);
        }

        private static char getNewLetter(char letter, int key)
        {
            int newLetterCode = letter + key;
            return newLetterCode <= 122 ? (char)newLetterCode : (char)(96 + newLetterCode % 122);
        }
    }
}
