namespace Paint.Domain.Figures
{
    public class Rectangle //: IFigure
    {
        private List<Point> points;
        public FigureType Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Point StartPoint { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Draw(Graphics graphics, Pen pen)
        {
            throw new NotImplementedException();
        }
        public Rectangle(List<Point> points)
        {
            this.points = points;
        }
    }
}
