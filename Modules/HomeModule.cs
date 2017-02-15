using Nancy;
using System;
using RockPaperScissors.Objects;

namespace RockPaperScissors
{
  public class HomeModule: NancyModule
  {
    public HomeModule()
    {
      Get["/"] =_=> {
        return View["index.cshtml"];
      };

      Post["/results"] = _ => {
        // string player1Input = "";
        // string player2Input = "";
        //
        // if (Request.Form["player1"] != null)
        // {
        //   player1Input = Request.Form["player1"].ToString();
        //   return player1Input;
        // }
        // if (Request.Form["player2"] != null)
        // {
        //   player2Input = Request.Form["player2"].ToString();
        //   return player2Input;
        // }
        string player1Input = Request.Form["player1"].ToString();
        string player2Input = Request.Form["player2"].ToString();
        Game newGame = new Game(player1Input,player2Input);
        return View["results.cshtml", newGame];
      };
    }
  }
}
