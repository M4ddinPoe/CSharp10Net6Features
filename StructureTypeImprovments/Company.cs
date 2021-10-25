namespace StructureTypeImprovments
{
    public struct Rectangle
    {
        //public Rectangle()
        //{
        //    this.Height = 0;
        //    this.Width = 0;
        //}

        public Rectangle(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }

        public int Height { get; init; }

        public int Width { get; init; }
    }
}