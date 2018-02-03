using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordUnscrambler.Data;

namespace WordUnscrambler.Workers
{
    public class WordMatcher
    {
        public List<MatchedWord> Match(string[] scrambledWords, string[] wordList)
        {
            var matchedWords = new List<MatchedWord>();

            foreach (var scrambleWords in scrambledWords)
            {
                foreach (var word in wordList)
                {
                    //first case: the 2 word are identicals
                    if (scrambleWords.Equals(word,StringComparison.OrdinalIgnoreCase))
                    {
                        matchedWords.Add(BuildMatchedWord(scrambleWords,word));
                    }
                    //Seconde case: same letter in different order
                    else
                    {
                        //Create 2 sorted char arrays
                        var scrambledWordArray = scrambleWords.ToCharArray();
                        var wordArray = word.ToCharArray();

                        Array.Sort(scrambledWordArray);
                        Array.Sort(wordArray);

                        //Rebuild string from the sorted char arrays
                        var sortedScrambledWord = new string(scrambledWordArray);
                        var sortedWord = new string(wordArray);

                        if (sortedScrambledWord.Equals(sortedWord, StringComparison.OrdinalIgnoreCase))
                        {
                            matchedWords.Add(BuildMatchedWord(scrambleWords, word));
                        }

                    }
                }
            }
            
 

            return matchedWords;
        }//end Match method

        //Helper Methods
        private MatchedWord BuildMatchedWord(string scrambleWords, string word)
        {
            MatchedWord _matchedWord = new MatchedWord
            {
                ScrambledWord = scrambleWords,
                CorrectWord = word
            };

            return _matchedWord;
        }




    }//end Class
}