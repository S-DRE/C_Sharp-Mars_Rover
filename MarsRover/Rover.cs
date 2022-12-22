using MarsRoverTest;

namespace MarsRover;

public class Rover
{
    private Direction compass = new North();
    private int gridDimension = 10;

    public string Execute(string command)
    {
        var y = 0;

        foreach (var instruction in command)
        {
            if (instruction.Equals('L'))
                compass = compass.RotateLeft();
            if (instruction.Equals('R'))
                compass = compass.RotateRight();
            if (instruction.Equals('M'))
            {
                if (compass.Symbol.Equals("N"))
                    y = (y + 1) % gridDimension;
                if (compass.Symbol.Equals("S"))
                    y = (y - 1 + gridDimension) % gridDimension;
            }
        }

        return $"0:{y}:{compass.Symbol}";
    }
}