namespace MarsRoverTest;

public class DirectionTest
{
    [Theory]
    [MemberData(nameof(DirectionsDataForLeftRotation))]
    public void ThatItChangesToPreviusOrientationWhenRotatesLeft(Direction originalDirection,
        Direction expectedDirection)
    {
        Assert.Equivalent(expectedDirection, originalDirection.RotateLeft());
    }

    public static IEnumerable<object[]> DirectionsDataForLeftRotation =>
        new List<object[]>
        {
            new object[] { new North(), new West() },
            new object[] { new West(), new South() },
            new object[] { new South(), new East() },
            new object[] { new East(), new North() },
        };
    
    [Theory]
    [MemberData(nameof(DirectionsDataForRightRotation))]
    public void ThatItChangesToNextOrientationWhenRotatesRight(Direction originalDirection,
        Direction expectedDirection)
    {
        Assert.Equivalent(expectedDirection, originalDirection.RotateRight());
    }

    public static IEnumerable<object[]> DirectionsDataForRightRotation =>
        new List<object[]>
        {
            new object[] { new North(), new East() },
            new object[] { new West(), new North() },
            new object[] { new South(), new West() },
            new object[] { new East(), new South() },
        };
}