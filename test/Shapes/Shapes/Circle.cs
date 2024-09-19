namespace Shapes
{
    public struct Circle(double Radius) : IShape
    {
        public readonly double Square => Radius * Radius * Math.PI;

        public override string ToString() => $"circle (R = {Radius})";
    }
}
