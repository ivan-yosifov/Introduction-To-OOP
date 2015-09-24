/* Pig Latin is a nonsense language. To create a word in pig Latin, you remove the fi rst letter and then add the fi rst letter and “ay” at the end of the word. For example, “dog” becomes “ogday” and “cat” becomes “atcay”. Write a program that allows the user to enter a word. Output the pig Latin version.
 * Save the file as PigLatin.cs
 */
using System;

namespace PigLatin
{
    class PigLatin
    {
        static void Main(string[] args)
        {
            string word, pigLatinWord;

            Console.Write("Enter a word: ");
            word = Console.ReadLine();

            pigLatinWord = word.Substring(1) + word.Substring(0, 1) + "ay";

            Console.WriteLine("{0} in pig Latin is {1}", word, pigLatinWord);

        }
    }
}
