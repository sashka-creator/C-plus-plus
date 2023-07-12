using System;
using System.Collections.Generic;

namespace MorseTranslator
{
    class Program1
    {
        static Dictionary<char, string> morseAlphabet = new Dictionary<char, string>()
        {
            {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."}, {'E', "."}, {'F', "..-."}, {'G', "--."},
            {'H', "...."}, {'I', ".."}, {'J', ".---"}, {'K', "-.-"}, {'L', ".-.."}, {'M', "--"}, {'N', "-."},
            {'O', "---"}, {'P', ".--."}, {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"}, {'U', "..-"},
            {'V', "...-"}, {'W', ".--"}, {'X', "-..-"}, {'Y', "-.--"}, {'Z', "--.."},
            {'0', "-----"}, {'1', ".----"}, {'2', "..---"}, {'3', "...--"}, {'4', "....-"},
            {'5', "....."}, {'6', "-...."}, {'7', "--..."}, {'8', "---.."}, {'9', "----."},
            {' ', "/"} // Пробіл
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Enter text to translate to Morse code:");
            string input = Console.ReadLine().ToUpper();

            string translatedText = TranslateToMorseCode(input);
            Console.WriteLine("Translated text:");
            Console.WriteLine(translatedText);

            Console.ReadLine();
        }

        static string TranslateToMorseCode(string text)
        {
            string translatedText = "";

            foreach (char letter in text)
            {
                if (morseAlphabet.ContainsKey(letter))
                {
                    translatedText += morseAlphabet[letter] + " ";
                }
                else
                {
                    
                    translatedText += letter;
                }
            }

            return translatedText;
        }
    }
}

namespace MorseTranslator
{
    class Program2
    {
        static Dictionary<string, char> reverseMorseAlphabet = new Dictionary<string, char>();

        static void Main(string[] args)
        {
            CreateReverseMorseAlphabet();

            Console.WriteLine("Enter Morse code to translate to text:");
            string input = Console.ReadLine();

            string translatedText = TranslateFromMorseCode(input);
            Console.WriteLine("Translated text:");
            Console.WriteLine(translatedText);

            Console.ReadLine();
        }

        static void CreateReverseMorseAlphabet()
        {
            foreach (KeyValuePair<char, string> entry in morseAlphabet)
            {
                reverseMorseAlphabet[entry.Value] = entry.Key;
            }
        }

        static string TranslateFromMorseCode(string morseCode)
        {
            string[] morseWords = morseCode.Split(' ');
            string translatedText = "";

            foreach (string morseWord in morseWords)
            {
                if (reverseMorseAlphabet.ContainsKey(morseWord))
                {
                    translatedText += reverseMorseAlphabet[morseWord];
                }
                else
                {
                    
                    translatedText += morseWord;
                }
            }

            return translatedText;
        }
    }
}

