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
				string anagramList = Console.ReadLine();
				
			}
		}
	}
}
