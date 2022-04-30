namespace Paint.Domain.Figures
{
    public class Line : IFigure
    {
        private Point startPoint;
        private Point endPoint;
        public FigureType Type { get { return FigureType.Line; }}

        public Point StartPoint { get; set; }

        public void Draw(Graphics graphics, Pen pen, Point endPoint)
        {
            graphics.DrawLine(pen, startPoint, endPoint);
        }

        public void SetStartPoint(Point point)
        {
            startPoint = point;
        }

        public void Preview(Graphics graphics, Pen pen, Point mousePosition)
        {
           Draw(graphics, pen, mousePosition);
        }
    }
}
