using System;

namespace AnagramChecker.Models
{
	public class Anagram
	{
		public string TestWord { get; set;}
		
		public string[] Guesses { get; set;}
		
		public char[] Letters { get;}
		
		public Anagram(string word, string[] guessArray)
		{
			TestWord = word;
			Guesses = guessArray;
			Letters = word.ToCharArray();
		}
	}
}