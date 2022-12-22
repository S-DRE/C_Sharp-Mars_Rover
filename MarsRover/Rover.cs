namespace MarsRover;

public class Rover
{
    public string Execute(string command)
    {
        var direction = "N";
        
        foreach (var instruction in command)
        {
            if (direction.Equals("N")) direction = "W";
            else if (direction.Equals("W")) direction = "S";
            else if (direction.Equals("S")) direction = "E";
            else if (direction.Equals("E")) direction = "N";
        }
        return $"0:0:{direction}";
    }
}