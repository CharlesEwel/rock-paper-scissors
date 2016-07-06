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
    public string Shoot1P (string input1)
    {
      Random r = new Random();
      List<string> possibilities = new List<string>{"rock", "paper", "scissors"};
      string input2 = possibilities[r.Next(3)];
      if (input1 == input2)
      {
        return "This round was a draw";
      }
      else if ((input1=="rock"&&input2=="scissors") || (input1=="scissors"&&input2=="paper") || (input1=="paper"&&input2=="rock"))
      {
        return "Human wins";
      }
      else
      {
        return "AI wins";
      }
    }
  }
}
