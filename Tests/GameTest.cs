using Xunit;
using RockPaperScissors.Objects;
using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
  public class GameTest
  {
    [Fact]
      public void PlayGame_CheckForSameInputByBothPlayer_draw()
      {
        string player1Input = "rock";
        string player2Input = "rock";
        Game testGame = new Game(player1Input,player2Input);
        string result = Game.PlayGame();
        string expectedResult = "draw"
        Assert.Equal(expectedResult, result);
      }

  }
}
