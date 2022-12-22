using MarsRover;

namespace MarsRoverTest;

public class RoverTest
{
    [Fact] // <-- Single test
    public void ThatStartsIn00N()
    {
        Rover rover = new Rover();

        String startingPosition = rover.Execute("");
        
        Assert.Equal("0:0:N", startingPosition);
    }
}