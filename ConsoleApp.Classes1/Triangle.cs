namespace ConsoleApp.Classes1
{
    public class Triangle : Polygon
    {
        public int Height { get; set; }

        public Triangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public override int Area()
        {
            return (1/2*Height * Width);  

        }
    }
}
