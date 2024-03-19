namespace AnagramChecker.Models
{
	public class Anagram
	{
		public string Word { get; set;}
		
		public Anagram(string inputWord)
		{
			Word = inputWord;
		}
	}
}