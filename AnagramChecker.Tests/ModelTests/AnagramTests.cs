using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnagramChecker.Models;
using System;
using System.Linq;

namespace AnagramChecker.Tests
{
	[TestClass]
	public class AnagramTests
	{
		[TestMethod]
		public void AnagramConstructor_CreateInstanceOfAnagram_Anagram()
		{
			Anagram newAnagram = new("despair", new[] {"guess1", "guess2"});
			Assert.AreEqual(typeof(Anagram), newAnagram.GetType());
		}
		
		[TestMethod]
		public void GetTestWord_ReturnsTestWord_String()
		{
			string word = "despair";
			Anagram newAnagram = new(word, new[] {"guess1", "guess2"});
			string result = newAnagram.TestWord;
			Assert.AreEqual(word, result);
		}
		
		[TestMethod]
		public void SetTestWord_SetsValueOfTestWord_Void()
		{
			Anagram newAnagram = new("despair", new[] {"guess1", "guess2"});
			string newWord = "hope";
			newAnagram.TestWord = newWord;
			Assert.AreEqual(newWord, newAnagram.TestWord);
		}
		
		[TestMethod]
		public void GetGuesses_ReturnsGuesses_StringArray()
		{
			string[] guesses = {"magic", "praised", "hope"};
			Anagram newAnagram = new("despair", guesses);
			string[] result = newAnagram.Guesses;
			Assert.AreEqual(guesses, result);
		}
		
		[TestMethod]
		public void SetGuesses_SetsValueOfGuesses_StringArray()
		{
			Anagram newAnagram = new("despair", new[] {"magic", "praised", "hope"});
			string[] newGuesses = {"aspired", "tragedy", "wish", "grief"};
			newAnagram.Guesses = newGuesses;
			Assert.AreEqual(newGuesses, newAnagram.Guesses);
		}
		
		[TestMethod]
		public void GetLetters_ReturnsLetters_CharArray()
		{
			string word = "despair";
			char[] letters = new[] {'d', 'e', 's', 'p', 'a', 'i', 'r'};
			Anagram newAnagram = new(word, new[] {"guess1", "guess2"});
			char[] result = newAnagram.Letters;
			Assert.IsTrue(letters.SequenceEqual(result));
		}
		
		[TestMethod]
		public void SetLetters_SetsValueOfLettersOnTestWordSet_Void()
		{
			Anagram newAnagram = new("despair", new[] {"guess1", "guess2"});
			char[] letters = new[] {'h', 'o', 'p', 'e'};
			newAnagram.TestWord = "hope";
			char[] result = newAnagram.Letters;
			Assert.IsTrue(letters.SequenceEqual(result));
		}
		
		[TestMethod]
		
		public void AreAnagrams_DeterminesWhenInputsNotAnagrams_Bool()
		{
			bool result = Anagram.AreAnagrams("dessert", "witch");
			Assert.IsFalse(result);
		}
		
		[TestMethod]
		
		public void AreAnagrams_DeterminesWhenInputsAreAnagrams_Bool()
		{
			bool result = Anagram.AreAnagrams("dessert", "tressed");
			Assert.IsTrue(result);
		}
		
		[TestMethod]
		public void	FilterAnagrams_DeterminesWhenNoAnagrams_StringArray()
		{
			Anagram newAnagram = new("despair", new[] {"curse", "miracle", "gem"});
			string[] result = newAnagram.FilterAnagrams();
			Assert.AreEqual(Array.Empty<string>(), result);
		}
		
		// [TestMethod]
		// public void	FilterAnagrams_FindsAllAnagramsOfTestWordInGuesses_StringArray()
		// {
		// 	Anagram newAnagram = new("despair", new[] {"magic", "praised", "tragedy", "wish", "aspired"});
		// 	string[] result = newAnagram.FilterAnagrams();
		// 	Assert.AreEqual(new[] {"praised", "aspire"}, result);
		// }
	}
}