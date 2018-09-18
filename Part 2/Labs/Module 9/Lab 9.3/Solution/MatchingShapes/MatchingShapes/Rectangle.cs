namespace Wincubate.CS7.MatchingShapesLab
{
    struct Rectangle
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle( int width, int height ) => (Width, Height) = (width, height);
    }
}
