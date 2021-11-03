using WordGuessLibrary;
using static System.Console;

namespace WordGuessGame{
	internal class Program{
		static void Main(string[] args){
			OutputEncoding = InputEncoding = System.Text.Encoding.Unicode;
			string word, description;
			do{
				Write("Введите слово: ");
				word = ReadLine();
				Write("Опишите слово: ");
				description = ReadLine();
			}
			while(!WordGuess.IsWord(word) || string.IsNullOrEmpty(description));
			string wordGuessed = new string('*', word.Length);
			do{
				char character;
				do{
					Clear();
					WriteLine("Слово: " + wordGuessed);
					WriteLine("Описание: " + description);
					Write("Введите букву: ");
					string input = ReadLine();
					character = (input.Length == 1 && char.IsLetter(input[0])) ? input[0] : '*';
				}
				while(character == '*');
				wordGuessed = WordGuess.ShowCharacters(word, wordGuessed, WordGuess.FindCharacterOccurences(word, character));
			}
			while(word != wordGuessed);
			WriteLine($"Слово \"{wordGuessed}\" отгадано!");
		}
	}
}