using MarsRoverTest;

namespace MarsRover;

public class Rover
{
    private Direction compass = new North();
    
    private int xCoord = 0;
    private int yCoord = 0;
        
    private int gridDimension = 10;

    public string Execute(string command)
    {
       

        foreach (var instruction in command)
        {
            switch (instruction)
            {
                case 'L':
                    compass = compass.RotateLeft();
                    break;
                case 'R':
                    compass = compass.RotateRight();
                    break;
                case 'M':
                {
                    PerformMovement();
                    break;
                }
            }
        }

        return $"{xCoord}:{yCoord}:{compass.Symbol}";
    }

    private void PerformMovement()
    {
        switch (compass.Symbol)
        {
            case "N":
                yCoord = (yCoord + 1) % gridDimension;
                break;
            case "S":
                yCoord = (yCoord - 1 + gridDimension) % gridDimension;
                break;
            case "E":
                xCoord = (xCoord + 1) % gridDimension;
                break;
            case "W":
                xCoord = (xCoord - 1 + gridDimension) % gridDimension;
                break;
        }
    }
}