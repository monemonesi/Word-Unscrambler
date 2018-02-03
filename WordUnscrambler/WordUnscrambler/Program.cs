using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueWordUnscrambler = true;

            do
            {
                Console.WriteLine("Choose your option: F for file, M for manual");

                var option = Console.ReadLine() ?? string.Empty;

                switch (option.ToUpper())
                {
                    case "F":
                        Console.Write("Please insert the file name with scrambled words: ");
                        ExecuteScrambledWordsFromFile();
                        break;
                    case "M":
                        Console.Write("Please enter the scrambled words manually: ");
                        ExecuteScrambledWordsFromManualInput();
                        break;
                    default:
                        Console.Write("Invalid option");
                        break;
                }

                // second do-while loop for user decision: do you want co continue?
                var continueWordUnscramblerDecision = string.Empty;
                do
                {
                    Console.WriteLine("Do you want to continue? Y or N?");
                    continueWordUnscramblerDecision = Console.ReadLine() ?? string.Empty;
                } while (
                    !continueWordUnscramblerDecision.Equals("Y", StringComparison.OrdinalIgnoreCase) && 
                    !continueWordUnscramblerDecision.Equals("N",StringComparison.OrdinalIgnoreCase));

                continueWordUnscrambler = continueWordUnscramblerDecision.Equals("Y", StringComparison.OrdinalIgnoreCase);

            } while (continueWordUnscrambler);
        }

        private static void ExecuteScrambledWordsFromFile()
        {
        }

        private static void ExecuteScrambledWordsFromManualInput()
        {
        }
    }
}
