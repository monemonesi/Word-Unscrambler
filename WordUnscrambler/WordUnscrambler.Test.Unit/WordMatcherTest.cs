using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordUnscrambler.Workers;

namespace WordUnscrambler.Test.Unit
{
    [TestClass]
    public class WordMatcherTest
    {
        private readonly WordMatcher _wordMatcher = new WordMatcher();

        [TestMethod]
        public void ScrambledWordsMatcheWithOneWord()
        {
            string[] words = { "now", "more", "test", "have", "fun" };
            string[] scrambledWords = {"ufn"};

            var matchedWords = _wordMatcher.Match(scrambledWords, words);

            Assert.IsTrue(matchedWords.Count == 1);
            Assert.IsTrue(matchedWords[0].ScrambledWord.Equals("ufn"));
            Assert.IsTrue(matchedWords[0].CorrectWord.Equals("fun"));
        }

        [TestMethod]
        public void ScrambledWordsMatcheWithMultipleWords()
        {
            string[] words = { "now", "more", "test", "have", "fun" };
            string[] scrambledWords = { "ufn" , "om", "test"};

            var matchedWords = _wordMatcher.Match(scrambledWords, words);

            Assert.IsTrue(matchedWords.Count == 2);
            Assert.IsTrue(matchedWords[0].ScrambledWord.Equals("ufn"));
            Assert.IsTrue(matchedWords[0].CorrectWord.Equals("fun"));
            Assert.IsTrue(matchedWords[1].ScrambledWord.Equals("test"));
            Assert.IsTrue(matchedWords[1].CorrectWord.Equals("test"));

        }
    }
}
