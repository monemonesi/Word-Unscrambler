
namespace WordUnscrambler
{
    class Constants
    {
        public const string optionUserInputHowEnterScrambledWords = 
            "How do you want to enter the scrambled word(s)? For do it Manually press M. If you want load a file press F.";
        public const string optionContinueTheProgram =
            "Would you like to Continue? Y-yes or N-no?";

        public const string enterScrambledWordViaFile =
            "Enter full path including the file name";
        public const string enterScrambledWordManually =
            "Enter word(s) (manually separated by comma)";
        public const string enteredScrambledwordNotRecognize = 
            "The entered option was not recognized ";

        public const string errorInLoadingScrumbledWords =
            "Scrumbled words can not be loaded";
        public const string errorProgramWillBeTerminated =
            "the program will be terminated";

        public const string matchFound =
            "MATCH FOUND FOR {0}: {1}";
        public const string matchNotFound =
            "NO MATCHES HAVE BEEN FOUND";

        public const string yes = "Y";
        public const string no = "N";
        public const string file = "F";
        public const string manual = "M";

        public const string wordListFileName = "wordList.txt";

    }
}
