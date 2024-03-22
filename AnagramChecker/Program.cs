using System;
using System.Threading;
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
				Console.WriteLine("And the words to check are \"{0}\" and \"{1}\"", string.Join("\" \"", anagram.Guesses, 0, anagram.Guesses.Length - 1), anagram.Guesses[^1]);
				Console.WriteLine("Is this correct??");
				Console.WriteLine("'y' to continue, or anything else to reenter your words");
				string userResponse = Console.ReadLine().ToLower();
				Console.WriteLine("-----------------------------------------");
				if (userResponse == "y")
				{
					CheckAnagrams(anagram);
				} 
				else 
				{
					Console.WriteLine("Guess those words sucked");
					MakeAnagram();
				}
			}
			
			static void CheckAnagrams(Anagram anagram)
			{
				Console.WriteLine("Now would you like to know only the words that are made up of exactly the same letters with the exact same length?");
				Console.WriteLine("Or would you like to see partial matches, requiring words only be made up of only characters present in the input word?");
				Console.WriteLine("enter 'full' or 'partial' as appropriate");
				string userResponse = Console.ReadLine().ToLower();
				Console.WriteLine("-----------------------------------------");
				if (userResponse == "full")
				{
					DisplayAnagrams(anagram, false);
				} 
				else if (userResponse == "partial")
				{
					DisplayAnagrams(anagram, true);
				}
				else
				{
					Console.WriteLine("Looks like you can't follow directions very well");
					Console.WriteLine("Try again");
					CheckAnagrams(anagram);
				}
			}
			
			static void DisplayAnagrams(Anagram anagram, bool partial)
			{
				Console.WriteLine("Of your list of words, the full {0}anagrams of \"{1}\" are:", partial ? "and partial " : "", anagram.TestWord);
				string[] anagramList = anagram.FilterAnagrams(partial);
				foreach (string word in anagramList)
				{
					Console.WriteLine("\"{0}\"", word);
				}
				Console.Write("press enter to continue");
				Console.ReadLine();
				Console.WriteLine("-----------------------------------------");
				Finish();
			}
			
			static void Finish()
			{
				Console.WriteLine("Was that useful to you?");
				Console.WriteLine("Did you have fun?");
				Console.WriteLine("'y' for yes, or anything else for not");
				Thread.Sleep(1700);
				Console.WriteLine("Just kidding! We don't care");
				Console.WriteLine("Get out of here");
			}
		}
	}
}
