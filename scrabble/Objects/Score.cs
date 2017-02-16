using System;
using System.Collections.Generic;

namespace ScrabbleApp.Objects
{
    public class Score
    {
        private string _userInput;
        private char[] _letterArray;
        private Dictionary<string, int> _cipher = new Dictionary<string, int>
        {
            {"AEIOULNRST", 1},
            {"DG", 2},
            {"BCMP", 3},
            {"FHVWY", 4},
            {"K", 5},
            {"JX", 8},
            {"QZ", 10}
        };

        public Score(string input)
        {
            _userInput = input;
            _letterArray = input.ToCharArray();
        }

        public int GetLetterScore(char letter)
        {
            foreach(KeyValuePair<string, int> entry in _cipher)
            {
                if (entry.Key.Contains(letter.ToString().ToUpper()))
                {
                    return entry.Value;
                }
            }
            return 0;
        }

        public string GetInput()
        {
            return _userInput;
        }

        public void SetInput(string input)
        {
            _userInput = input;
        }

        public char[] GetLetterArray()
        {
            return _letterArray;
        }

        public void SetLetterArray(string word)
        {
            _letterArray = word.ToCharArray();
        }
    }//end class
}//end namespace
