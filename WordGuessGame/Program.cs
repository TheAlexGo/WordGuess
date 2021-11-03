using System;
using WordGuessLibrary;

namespace WordGuessGame{
	internal class Program{
		static void Main(string[] args){
			OutputEncoding = InputEncoding = System.Text.Encoding.Unicode;
			string word, description;
			do{
				Console.Write("Введите слово: ");
				word = ReadLine();
				Console.Write("Опишите слово: ");
				description = Console.ReadLine();
			}
			while(!WordGuess.IsWord(word) || string.IsNullOrEmpty(description));
			string wordGuessed = new string('*', word.Length);
			do{
				char character;
				do{
					Console.Clear();
					Console.WriteLine($"Слово: {wordGuessed}");
					Console.WriteLine($"Описание: {description}");
					Console.Write("Введите букву: ");
					string input = Console.ReadLine();
					character = (input.Length == 1 && char.IsLetter(input[0])) ? input[0] : '*';
				}
				while(character == '*');
				wordGuessed = WordGuess.ShowCharacters(word, wordGuessed, WordGuess.FindCharacterOccurences(word, character));
			}
			while(word != wordGuessed);
			Console.WriteLine($"Слово \"{wordGuessed}\" отгадано!");
			Console.ReadLine();
		}
	}
}