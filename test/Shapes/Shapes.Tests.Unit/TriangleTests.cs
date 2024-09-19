using Xunit;

namespace Shapes.Tests.Unit;

public class TriangleTests
{
    [Fact]
    public void Square_Is_Calculated_Correctly()
    {
        var triangle = new Triangle(5, 4, 3);

        Assert.Equal(6, triangle.Square);
    }

    [Fact]
    public void Rightness_Is_Detected_Correctly()
    {
        var rightTriangle = new Triangle(5, 4, 3);
        var triangle = new Triangle(6, 5, 5);

        Assert.True(rightTriangle.IsRigth);
        Assert.False(triangle.IsRigth);
    }
}
