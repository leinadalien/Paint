namespace Paint.Domain.Figures
{
    public class Polygon //: IFigure
    {
        private List<Point> points;
        public FigureType Type { get { return FigureType.Polygon; } }

        public Point StartPoint { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Draw(Graphics graphics, Pen pen)
        {
            throw new NotImplementedException();
        }
        public Polygon(List<Point> points)
        {
            this.points = points;
        }
    }
}
