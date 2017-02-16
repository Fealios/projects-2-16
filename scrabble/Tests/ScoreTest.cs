using Xunit;
using System.Collections.Generic;

namespace ScrabbleApp.Objects
{
  public class ScrabbleAppTest
  {
    [Fact]
    public void ScrabbleConstructor_GetSetWord_ReturnWord()
    {
      Score testScore = new Score("word");
      Assert.Equal("word", testScore.GetInput());
    }

    [Fact]
    public void SetLetterArray_SplitWord_ReturnLetters()
    {
      Score testScore = new Score("word");
      char[] expectedArray = "word".ToCharArray();
      for (var i = 0; i < testScore.GetLetterArray().Length; i++)
      {
        Assert.Equal(expectedArray[i], testScore.GetLetterArray()[i]);
      }
    }
  }
}
