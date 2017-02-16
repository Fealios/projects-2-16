using System;
using System.Collections.Generic;

namespace ScrabbleApp.Objects
{
  public class Score
  {
    private string _userInput;
    private char[] _letterArray;

    public Score(string input)
    {
      _userInput = input;
      _letterArray = input.ToCharArray();
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
