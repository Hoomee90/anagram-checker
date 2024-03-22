using System;
using AnagramChecker.Models;

namespace AnagramChecker
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
			Console.WriteLine("Welcome to AnagramChecker");
			Console.WriteLine("We'll tell you which of a list of words are anagrams of a certain word");
			Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
			Console.WriteLine("First we need to choose which words we'll be using");
			MakeAnagram();
		
			static void MakeAnagram()
			{
				Console.WriteLine("Please enter the word we'll be looking for anagrams of");
				string anagramWord = Console.ReadLine();
				Console.WriteLine("Now please enter the list of that word's potential anagrams");
				Console.WriteLine("Put a space between each word");
				string[] anagramList = Console.ReadLine().Split(' ');
				Anagram anagram = new(anagramWord, anagramList);
				ConfirmOrEditAnagram(anagram);
			}
			
			static void ConfirmOrEditAnagram(Anagram anagram)
			{
				Console.WriteLine("-----------------------------------------");
				Console.WriteLine("We have collected your input");
				Console.WriteLine("The chosen word is \"{0}\"", anagram.TestWord);
				Console.WriteLine("And the words to check are \"{0}\" and \"{1}\"", string.Join(", ", anagram.Guesses, 0, anagram.Guesses.Length - 1), anagram.Guesses[^1]);
				Console.WriteLine("Is this correct??");
				Console.WriteLine("'y' to continue, or anything else to reenter your words");
				string userResponse = Console.ReadLine().ToLower();
				Console.WriteLine("-----------------------------------------");
				if (userResponse == "y")
				{
					DisplayAnagrams(anagram);
				} else {
					Console.WriteLine("Guess those words sucked");
					MakeAnagram();
				}
			}
			
			static void DisplayAnagrams(Anagram anagram)
			{

			}
		}
	}
}
