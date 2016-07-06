using Nancy;
using System;
using System.Collections.Generic;

namespace RockPaperScissors.Objects
{
  public class Game
  {
    public string Shoot (string input1, string input2)
    {
      if(input1 == input2)
      {
        return "This round was a draw";
      }
      else
      {
        return "This round was not a draw";
      }
    }
  }
}
