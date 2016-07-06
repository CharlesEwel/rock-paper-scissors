using Xunit;
namespace RockPaperScissors.Objects
{
  public class RockPaperScissorsTest
  {
    [Fact]
    public void Shoot_SameInputs_Draw()
    {
      Game newGame = new Game ();
      Assert.Equal("This round was a draw", newGame.Shoot("rock","rock"));
    }
    [Fact]
    public void Shoot_RockScissors_Winner()
    {
      Game newGame = new Game ();
      Assert.Equal("User1 wins", newGame.Shoot("rock","scissors"));
    }
    [Fact]
    public void Shoot_RockPaper_Winner()
    {
      Game newGame = new Game ();
      Assert.Equal("User2 wins", newGame.Shoot("rock","paper"));
    }
  }
}
