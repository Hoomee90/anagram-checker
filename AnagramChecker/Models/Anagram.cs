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
		
		public string[] FilterAnagrams(bool allowPartial = false)
		{
			string[] anagrams = Guesses.Where(word => allowPartial ? ArePartial(TestWord, word) : AreAnagrams(TestWord, word)).ToArray();
			return anagrams;
		}
		
		public static bool AreAnagrams(string word1, string word2)
		{
			if (word1.Length != word2.Length)
			{
				return false;
			}
			
			return word1.OrderBy(c => c).SequenceEqual(word2.OrderBy(c => c));
		}
		
		public static bool ArePartial(string word1, string word2)
		{
			return word2.All(c => word1.Contains(c));
		}
	}
}