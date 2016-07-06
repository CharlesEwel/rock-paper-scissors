using Nancy;
using System;
using System.Collections.Generic;

namespace RockPaperScissors.Objects
{
  public class Game
  {
    public string Shoot (string input1, string input2)
    {
      if (input1 == input2)
      {
        return "This round was a draw";
      }
      else if (input1 == "rock")
      {
        if (input2 == "paper")
        {
          return "User2 wins";
        }
        else
        {
          return "User1 wins";
        }
      }
      else if (input1 == "paper")
      {
        if (input2 == "rock")
        {
          return "User1 wins";
        }
        else
        {
          return "User2 wins";
        }
      }
      else if (input1 == "scissors")
      {
        if (input2 == "rock")
        {
          return "User2 wins";
        }
        else
        {
          return "User1 wins";
        }
      }
      else
      {
        return "Invalid game";
      }
    }
  }
}
