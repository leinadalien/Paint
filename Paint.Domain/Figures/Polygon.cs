namespace Paint.Domain.Figures
{
    public class Polygon : IFigure
    {
        private List<Point> points;
        private Graphics _graphics;
        private Pen _pen;
        public FigureType Type { get { return FigureType.Polygon; } }
        public Polygon()
        {
            points = new();
        }
        public void CancelDrawing()
        {

            _graphics.DrawPolygon(_pen, points.ToArray());
            points.Clear();
        }

        public void Draw(Graphics graphics, Pen pen, Point point)
        {
            if (points.Count == 0)
            {
                points.Add(point);
                _graphics = graphics;
                _pen = pen;
            }
            points.Add(point);
            graphics.DrawLines(pen, points.ToArray());
        }

        public void PreDraw(Graphics graphics, Pen pen, Point point)
        {
            if (points.Count > 0)
            {
                points.Add(point);
                graphics.DrawLines(pen, points.ToArray());
                points.RemoveAt(points.Count - 1);
            }
        }
    }
}
