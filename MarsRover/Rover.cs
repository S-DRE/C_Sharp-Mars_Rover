using MarsRoverTest;

namespace MarsRover;

public class Rover
{
    private Direction compass = new North();

    public string Execute(string command)
    {
        foreach (var instruction in command)
        {
            compass = compass.RotateLeft();
        }
        return $"0:0:{compass.Symbol}";
    }
}