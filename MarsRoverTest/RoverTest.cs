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

}