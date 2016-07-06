using Xunit;
namespace RockPaperScissors.Objects
{
  public class RockPaperScissorsTest
  {
    [Fact]
    public void Shoot_SameInputs_Draw()
    {
      Game newGame = new Game ();
      Assert.Equal("This round was a draw", newGame.Shoot("Rock","Rock"));
    }
  }
}
