namespace MarsRoverTest;

abstract public class Direction
{
    abstract public string Symbol { get; }

    public abstract Direction RotateLeft();

    public abstract Direction RotateRight();
}

public class North : Direction
{
    public override string Symbol => "N";
    public override Direction RotateLeft() => new West();

    public override Direction RotateRight() => new East();
}

public class West : Direction
{
    public override string Symbol => "W";

    public override Direction RotateLeft() => new South();

    public override Direction RotateRight() => new North();
}

public class South : Direction
{
    public override string Symbol => "S";
    public override Direction RotateLeft() => new East();

    public override Direction RotateRight() => new West();
}

public class East : Direction
{
    public override string Symbol => "E";
    public override Direction RotateLeft() => new North();

    public override Direction RotateRight() => new South();
}