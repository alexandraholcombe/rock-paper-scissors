using Xunit;
using RockPaperScissors.Objects;
using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
  public class GameTest
  {
    public string player1Win = "Player 1 Wins!";
    public string player2Win = "Player 2 Wins!";
    public string draw = "Draw!";

    [Fact]
    public void PlayGame_ForSameInputByBothPlayer_draw()
    {
      string player1Input = "rock";
      string player2Input = "rock";
      Game testGame = new Game(player1Input,player2Input);
      string result = testGame.PlayGame();
      string expectedResult = draw;
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void PlayGame_ForPlayer1RockPlayer2Scissors_player1()
    {
      string player1Input = "rock";
      string player2Input = "scissors";
      Game testGame = new Game(player1Input, player2Input);
      string result = testGame.PlayGame();
      string expectedResult = player1Win;
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void PlayGame_ForPlayer1ScissorsPlayer2Paper_player1()
    {
      string player1Input = "scissors";
      string player2Input = "paper";
      Game testGame = new Game(player1Input,player2Input);
      string result = testGame.PlayGame();
      string expectedResult = player1Win;
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void PlayGame_ForPlayer1PaperPlayer2Rock_player1()
    {
      string player1Input = "paper";
      string player2Input = "rock";
      Game testGame = new Game(player1Input,player2Input);
      string result = testGame.PlayGame();
      string expectedResult = player1Win;
      Assert.Equal(expectedResult, result);
    }

  }
}
