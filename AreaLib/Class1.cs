namespace AreaLib
{
    public static class AreaCalc
    {
        public static double AreaOf(double radius)
        {
            return Math.PI*Math.Pow(radius, 2);
        }
        public static double AreaOf(double a, double b, double c)
        {
            var p = (a + b + c)/2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}