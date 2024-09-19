using Xunit;

namespace Shapes.Tests.Unit;

public class CircleTests
{
    [Fact]
    public void Square_Is_Calculated_Correctly()
    {
        var circle = new Circle(10);

        Assert.Equal(100 * Math.PI, circle.Square);
    }
}
