using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnagramChecker.Models;

namespace AnagramChecker.Tests
{
	[TestClass]
	public class AnagramTests
	{
		[TestMethod]
		public void AnagramConstructor_CreateInstanceOfAnagram_Anagram()
		{
			Anagram newAnagram = new("bread");
			Assert.AreEqual(typeof(Anagram), newAnagram.GetType());
		}
		
		[TestMethod]
		public void GetInputWord_ReturnsInputWord_String()
		{
			string word = "bread";
			Anagram newAnagram = new(word);
			string result = newAnagram.Word;
			Assert.AreEqual(word, result);
		}
	}
}