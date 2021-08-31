using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftCipher
{
    public static class Caesar_Cipher
    {
        #region Encrypt
        /// <summary>
        /// This function takes the text with a key and returns the encrypted text.
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Key"></param>
        /// <returns>encryptedText</returns>
        public static string Encrypt(string Text, int Key) 
        {
            string text = Text;
            int key = Key;

            int lengthText = text.Length;
            int[] numberOfLetters = new int[lengthText];
            char[] Code = new char[lengthText];

            char[] Alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            // Find whole text numbers
            for (int i = 0; i < lengthText; i++)
            {
                char temp = text[i];
                // Find the number of each letter
                for (int j = 0; j < 26; j++)
                {   //Alphabet[j] == temp
                    if (temp.Equals(Alphabet[j]))
                    {
                        numberOfLetters[i] = j;

                    }
                }
            }

            //Convert numbers
            for (int i = 0; i < lengthText; i++)
            {
                numberOfLetters[i] += key;
                if (numberOfLetters[i] > 25)
                {
                    numberOfLetters[i] -= 26;
                }
            }

            //Convert numbers to letters
            for (int i = 0; i < lengthText; i++)
            {
                Code[i] = Alphabet[numberOfLetters[i]];
            }

            string encryptedText = new string(Code);
            return encryptedText;
        }
        #endregion

        #region Decrypt
        /// <summary>
        /// This function takes the encrypted text with the key and returns the decrypted text.
        /// </summary>
        /// <param name="Code"></param>
        /// <param name="Key"></param>
        /// <returns>decryptedText</returns>
        public static string Decrypt(string Code, int Key)
        {
            string code = Code;
            int key = Key;

            int lengthCode = code.Length;
            int[] numberOfLetters = new int[lengthCode];
            char[] text = new char[lengthCode];

            char[] Alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            // Find whole text numbers
            for (int i = 0; i < lengthCode; i++)
            {
                char temp = code[i];
                // Find the number of each letter
                for (int j = 0; j < 26; j++)
                {   //Alphabet[j] == temp
                    if (temp.Equals(Alphabet[j]))
                    {
                        numberOfLetters[i] = j;

                    }
                }
            }

            //Convert numbers
            for (int i = 0; i < lengthCode; i++)
            {
                numberOfLetters[i] -= key;
                if (numberOfLetters[i] < 0)
                {
                    numberOfLetters[i] += 26;
                }
            }

            //Convert numbers to letters
            for (int i = 0; i < lengthCode; i++)
            {
                text[i] = Alphabet[numberOfLetters[i]];
            }
            string decryptedText = new string(text);
            return decryptedText;
        }   
        #endregion
    }
}
