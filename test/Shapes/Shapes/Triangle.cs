namespace Shapes;

public struct Triangle(double A, double B, double C) : IShape
{
    public readonly double Square
    {
        get
        {
            var p = (A + B + C) / 2;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }

    public readonly bool IsRigth => A * A == B * B + C * C || B * B == A * A + C * C || C * C == A * A + B * B;

    public override string ToString() => $"triangle (A = {A}, B = {B}, C = {C})";

}
