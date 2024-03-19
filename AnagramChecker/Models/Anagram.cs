namespace AnagramChecker.Models
{
	public class Anagram
	{
		public string TestWord { get; set;}
		
		public string[] Guesses { get; set;}
		
		public Anagram(string word, string[] guessArray)
		{
			TestWord = word;
			Guesses = guessArray;
		}
	}
}