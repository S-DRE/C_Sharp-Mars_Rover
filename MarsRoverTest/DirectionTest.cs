namespace MarsRoverTest;

public class DirectionTest
{
    [Theory]
    [MemberData(nameof(DirectionsData))]
    public void ThatItChangesToPreviusOrientationWhenRotatesLeft(Direction originalDirection,
        Direction expectedDirection)
    {
        Assert.Equivalent(expectedDirection, originalDirection.RotateLeft());
    }

    public static IEnumerable<object[]> DirectionsData =>
        new List<object[]>
        {
            new object[] { new North(), new West() },
            new object[] { new West(), new South() },
            new object[] { new South(), new East() },
            new object[] { new East(), new North() },
        };
}