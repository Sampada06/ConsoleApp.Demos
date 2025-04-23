namespace ConsoleApp.Classes1
{
    public class Rectangle : Polygon
    {
        public int Length { get; set; }

        public Rectangle(int width, int length)
        {
            Width = width;
            Length = length;
        }
        public override int Area()
        {
            return Length * Width;
        }
    }
}
