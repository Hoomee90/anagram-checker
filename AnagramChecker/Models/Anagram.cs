using System;
using System.Linq;

namespace AnagramChecker.Models
{
	public class Anagram
	{
		public string TestWord { get; set;}
		
		public string[] Guesses { get; set;}
		
		public char[] Letters 
		{ 
			get { return TestWord.ToCharArray(); }
		}
		
		public Anagram(string word, string[] guessArray)
		{
			TestWord = word;
			Guesses = guessArray;
		}
		
		// public string[] FilterGuesses()
		// {

		// }
		
		public static bool AreAnagrams(string word1, string word2)
		{
			return word1.OrderBy(c => c).SequenceEqual(word2.OrderBy(c => c));
		}
	}
}