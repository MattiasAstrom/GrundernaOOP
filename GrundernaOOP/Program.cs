namespace GrundernaOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle firstCircle = new(5);
            Circle secondCircle = new(6);

            Console.WriteLine($"Area of the first circle with a radius of {firstCircle.GetRadius().ToString()} and the areas is: {firstCircle.GetArea().ToString()}");
            Console.WriteLine($"Area of the first circle with a radius of {secondCircle.GetRadius().ToString()} and the areas is: {secondCircle.GetArea().ToString()}");
        }
    }

    class Circle
    {
        int _radius;
        public Circle(int radius)
        {
            _radius = radius;
        }
        public int GetRadius()
        {
            return _radius;
        }
        public int  GetArea()
        {
            return (int)(_radius * _radius * Math.PI);
        }
    }
}