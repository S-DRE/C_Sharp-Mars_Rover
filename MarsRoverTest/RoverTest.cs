using MarsRover;

namespace MarsRoverTest;

public class RoverTest
{
    private Rover rover;

    public RoverTest()
    {
        rover = new Rover();
    }

    [Theory] // Test with multiple data - Parametrized
    [InlineData("L", "0:0:W")]
    [InlineData("LL", "0:0:S")]
    [InlineData("LLL", "0:0:E")]
    [InlineData("LLLL", "0:0:N")]
    public void TheRoverRotatesToTheLeft(string command, string expectedResult)
    {
        var startingPosition = rover.Execute(command);

        Assert.Equal(expectedResult, startingPosition);
    }
    

    [Fact] // <-- Single test
    public void ThatStartsIn00N()
    {
        var startingPosition = rover.Execute("");

        var expectedStartingPosition = "0:0:N";
        Assert.Equal(expectedStartingPosition, startingPosition);
    }
    
    [Theory] // Test with multiple data - Parametrized
    [InlineData("R", "0:0:E")]
    [InlineData("RR", "0:0:S")]
    [InlineData("RRR", "0:0:W")]
    [InlineData("RRRR", "0:0:N")]
    public void TheRoverRotatesToTheRight(string command, string expectedResult)
    {
        var startingPosition = rover.Execute(command);

        Assert.Equal(expectedResult, startingPosition);
    }
    
    [Fact] // <-- Single test
    public void TheRoverMovesNorthOnceFrom00NTo01N()
    {
        var startingPosition = rover.Execute("M");

        var newPosition = "0:1:N";
        Assert.Equal(newPosition, startingPosition);
    }
    
    [Fact] // <-- Single test
    public void TheRoverMovesNorthTwiceFrom00NTo02N()
    {
        var startingPosition = rover.Execute("MM");

        var newPosition = "0:2:N";
        Assert.Equal(newPosition, startingPosition);
    }
    
    [Fact] // <-- Single test
    public void TheRoverMovesNorthTenTimesFrom00NTo00N()
    {
        var startingPosition = rover.Execute("MMMMMMMMMM");

        var newPosition = "0:0:N";
        Assert.Equal(newPosition, startingPosition);
    }
    
    [Fact] // <-- Single test
    public void TheRoverMovesSouthOnceFrom00NTo09S()
    {
        var startingPosition = rover.Execute("LLM");

        var newPosition = "0:9:S";
        Assert.Equal(newPosition, startingPosition);
    }
    
    [Fact] // <-- Single test
    public void TheRoverMovesSouthTwiceFrom00NTo08S()
    {
        var startingPosition = rover.Execute("LLMM");

        var newPosition = "0:8:S";
        Assert.Equal(newPosition, startingPosition);
    }
    
    [Fact] // <-- Single test
    public void TheRoverMovesSouthTenTimesFrom00NTo00S()
    {
        var startingPosition = rover.Execute("LLMMMMMMMMMM");

        var newPosition = "0:0:S";
        Assert.Equal(newPosition, startingPosition);
    }
    
    

}