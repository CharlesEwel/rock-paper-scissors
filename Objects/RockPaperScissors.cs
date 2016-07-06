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
      else if ((input1=="rock"&&input2=="scissors") || (input1=="scissors"&&input2=="paper") || (input1=="paper"&&input2=="rock"))
      {
        return "User1 wins";
      }
      else
      {
        return "User2 wins";
      }
    }
  }
}
