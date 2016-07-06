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
      Get["/"] = _ => View["index.cshtml"];
      Get["/two-players"] = _ => View["two_players.cshtml", "Prepare for Rock, Paper, Scissors"];
      Get["/vs-computer"] = _ => View["vs_computer.cshtml", "Prepare for Rock, Paper, Scissors"];
      Post["/shoot"] = _ => {
        Game newGame = new Game();
        string result = newGame.Shoot(Request.Form["input1"], Request.Form["input2"]);
        return View["two_players.cshtml", result];
      };
      Post["/shoot1P"] = _ => {
        Game newGame = new Game();
        string result = newGame.Shoot1P(Request.Form["inputhuman"]);
        return View["vs_computer.cshtml", result];
      };
    }
  }
}
