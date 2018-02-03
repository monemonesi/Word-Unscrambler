using System;
using System.IO;

namespace WordUnscrambler.Workers
{
    class FileReader
    {
        public string[] Read(string wordListFileName)
        {
            string[] fileContent;
            try
            {
                fileContent = File.ReadAllLines(wordListFileName);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return fileContent;
        }
    }
}
