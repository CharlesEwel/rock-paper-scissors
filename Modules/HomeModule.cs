using Nancy;
using System;
using RockPaperScissors.Objects;
using System.Collections.Generic;

namespace RockPaperScissors
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml", "Prepare for Rock, Paper, Scissors"];
      Post["/shoot"] = _ => {
        Game newGame = new Game();
        string result = newGame.Shoot(Request.Form["input1"], Request.Form["input2"]);
        return View["index.cshtml", result];
      };
    }
  }
}
