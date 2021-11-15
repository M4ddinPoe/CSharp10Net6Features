namespace CSharp10Features.StructureTypeImprovments
{
    public struct Rectangle
    {
        // Default Contructor war vor C#10 nicht möglich
        public Rectangle()
        {
            Height = 0;
            Width = 0;
        }

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public int Height { get; init; }

        public int Width { get; init; }
    }
}