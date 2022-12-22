using MarsRoverTest;

namespace MarsRover;

public class Rover
{
    private Direction compass = new North();

    public string Execute(string command)
    {
        foreach (var instruction in command)
        {
            if (instruction.Equals('L'))
                compass = compass.RotateLeft();
            if (instruction.Equals('R'))
                compass = compass.RotateRight();
        }

        return $"0:0:{compass.Symbol}";
    }
}