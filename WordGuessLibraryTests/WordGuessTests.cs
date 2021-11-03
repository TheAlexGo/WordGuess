using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordGuessLibrary;

namespace WordGuessLibraryTests{
	[TestClass] public class WordGuessTests{
		[TestMethod] public void FindCharacterOccurences_NullAndN_ExpectedEmpty() => CollectionAssert.AreEqual(new int[]{}, WordGuess.FindCharacterOccurences(null, 'N'));

		[TestMethod] public void FindCharacterOccurences_EmptyAndN_ExpectedEmpty() => CollectionAssert.AreEqual(new int[]{}, WordGuess.FindCharacterOccurences("", 'N'));

		[TestMethod] public void FindCharacterOccurences_AppleAndT_ExpectedEmpty() => CollectionAssert.AreEqual(new int[]{}, WordGuess.FindCharacterOccurences("Apple", 'T'));

		[TestMethod] public void FindCharacterOccurences_AppleAndA_Expected0() => CollectionAssert.AreEqual(new int[]{0}, WordGuess.FindCharacterOccurences("Apple", 'A'));

		[TestMethod] public void FindCharacterOccurences_AppleAndA_Expected1And2() => CollectionAssert.AreEqual(new int[]{1, 2}, WordGuess.FindCharacterOccurences("Apple", 'P'));

		[TestMethod] public void ShowCharacters_AppleAnd_ppleAndNull_Expected_pple() => Assert.AreEqual("*pple", WordGuess.ShowCharacters("Apple", "*pple", null));

		[TestMethod] public void ShowCharacters_AppleAnd_ppleAndEmpty_Expected_pple() => Assert.AreEqual("*pple", WordGuess.ShowCharacters("Apple", "*pple", new int[]{}));

		[TestMethod] public void ShowCharacters_AppleAndAppleAnd0_ExpectedApple() => Assert.AreEqual("Apple", WordGuess.ShowCharacters("Apple", "Apple", new int[]{0}));

		[TestMethod] public void ShowCharacters_AppleAnd_ppleAnd0_ExpectedApple() => Assert.AreEqual("Apple", WordGuess.ShowCharacters("Apple", "*pple", new int[]{0}));

		[TestMethod] public void ShowCharacters_AppleAndA__leAnd1And2_ExpectedApple() => Assert.AreEqual("Apple", WordGuess.ShowCharacters("Apple", "A**le", new int[]{1, 2}));

		[TestMethod] public void IsWord_Null_ExpectedTrue() => Assert.AreEqual(false, WordGuess.IsWord(null));

		[TestMethod] public void IsWord_Empty_ExpectedTrue() => Assert.AreEqual(false, WordGuess.IsWord(""));

		[TestMethod] public void IsWord_Apple_ExpectedTrue() => Assert.AreEqual(true, WordGuess.IsWord("Apple"));

		[TestMethod] public void IsWord_Яблоко_ExpectedTrue() => Assert.AreEqual(true, WordGuess.IsWord("Яблоко"));

		[TestMethod] public void IsWord_Apple3_ExpectedTrue() => Assert.AreEqual(false, WordGuess.IsWord("Apple3"));
	}
}