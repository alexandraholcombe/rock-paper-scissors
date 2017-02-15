using System;

namespace RockPaperScissors.Objects
{
  public class Game
  {
    private string _player1;
    private string _player2;

    public Game(string player1, string player2)
    {
      _player1 = player1;
      _player2 = player2;
    }

    public string GetPlayer1()
    {
      return _player1;
    }

    public string GetPlayer2()
    {
      return _player2;
    }

    public string PlayGame()
    {
      string player1 = GetPlayer1();
      string player2 = GetPlayer2();

      string player1Win = "Player 1 Wins!";
      string player2Win = "Player 2 Wins!";
      string draw = "Draw!";

      if (player1.Equals(player2))
      {
        return draw;
      }
      else if (player1.Equals("rock") && player2.Equals("scissors"))
      {
        return player1Win;
      }
      else
      {
        return "oops";
      }
    }
  }

}
