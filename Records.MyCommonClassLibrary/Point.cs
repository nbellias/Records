namespace Records.MyCommonClassLibrary
{
    public record Point(double X, double Y)
    {
        public void Deconstruct(out double x, out double y)
        {
            x = X;
            y = Y;
        }
    }
}