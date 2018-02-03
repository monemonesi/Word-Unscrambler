using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordUnscrambler.Data;
using WordUnscrambler.Workers;

namespace WordUnscrambler
{
    class Program
    {
        private static readonly FileReader _fileReader = new FileReader();
        private static readonly WordMatcher _wordMatcher = new WordMatcher();
        

        static void Main(string[] args)
        {
            try
            {
                bool continueWordUnscrambler = true;
                do
                {
                    Console.WriteLine(Constants.optionUserInputHowEnterScrambledWords);

                    var option = Console.ReadLine() ?? string.Empty;

                    switch (option.ToUpper())
                    {
                        case Constants.file:
                            Console.Write(Constants.enterScrambledWordViaFile);
                            ExecuteScrambledWordsFromFile();
                            break;
                        case Constants.manual:
                            Console.Write(Constants.enterScrambledWordManually);
                            ExecuteScrambledWordsFromManualInput();
                            break;
                        default:
                            Console.WriteLine(Constants.enteredScrambledwordNotRecognize);
                            break;
                    }

                    // second do-while loop for user decision: do you want co continue?
                    var continueDecision = string.Empty;
                    do
                    {
                        Console.WriteLine(Constants.optionContinueTheProgram);
                        continueDecision = Console.ReadLine() ?? string.Empty;
                    } while (
                        !continueDecision.Equals(Constants.yes, StringComparison.OrdinalIgnoreCase) &&
                        !continueDecision.Equals(Constants.no, StringComparison.OrdinalIgnoreCase));

                    continueWordUnscrambler = continueDecision.Equals(Constants.yes, StringComparison.OrdinalIgnoreCase);

                } while (continueWordUnscrambler);

            }
            catch(Exception ex)
            {
                Console.WriteLine(Constants.errorProgramWillBeTerminated + ex.Message);
            }

        }//end Main

        private static void ExecuteScrambledWordsFromFile()
        {
            try
            {
                var fileName = Console.ReadLine() ?? string.Empty;
                string[] scrambledWords = _fileReader.Read(fileName);
                DisplayMatchedUnscrambledWords(scrambledWords);
            }
            catch (Exception ex)
            {
                Console.WriteLine(Constants.errorInLoadingScrumbledWords + ex.Message);
            }
            
        }

        private static void ExecuteScrambledWordsFromManualInput()
        {
            var manualInput = Console.ReadLine() ?? string.Empty;
            string[] scrambledWords = manualInput.Split(',');
            DisplayMatchedUnscrambledWords(scrambledWords);
        }

        private static void DisplayMatchedUnscrambledWords(string[] scrambledWords)
        {
            string[] wordList = _fileReader.Read(Constants.wordListFileName);

            List<MatchedWord> matchedWords = _wordMatcher.Match(scrambledWords, wordList);

            if (matchedWords.Any())
            {
                foreach(var matchedWord in matchedWords)
                {
                    Console.WriteLine(Constants.matchFound, matchedWord.ScrambledWord, matchedWord.CorrectWord);
                }
            }
            else
            {
                Console.WriteLine(Constants.matchNotFound);
            }
        }
    }
}
