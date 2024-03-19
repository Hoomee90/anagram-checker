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
			Anagram newAnagram = new();
			Assert.AreEqual(typeof(Anagram), newAnagram.GetType());
		}
	}
}