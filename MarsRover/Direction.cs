namespace MarsRoverTest;

abstract public class Direction
{
    abstract public string Symbol { get; }

    public abstract Direction RotateLeft();
}

public class North : Direction
{
    public override string Symbol => "N";
    public override Direction RotateLeft() => new West();
}

public class West : Direction
{
    public override string Symbol => "W";

    public override Direction RotateLeft() => new South();
}

public class South : Direction
{
    public override string Symbol => "S";
    public override Direction RotateLeft() => new East();
}

public class East : Direction
{
    public override string Symbol => "E";
    public override Direction RotateLeft() => new North();
}