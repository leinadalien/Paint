namespace Paint.Domain.Figures
{
    public class BrokenLine : IFigure
    {
        protected List<Point> points;
        public FigureType Type { get { return FigureType.BrokenLine; } }
        public BrokenLine()
        {
            points = new();
        }
        public void AddPoint(Point point)
        {
            points.Add(point);
        }
        public void PreDraw(Graphics graphics, Pen pen, Point tempPoint)
        {
            if (points.Count > 0)
            {
                points.Add(tempPoint);
                if (points.Count > 1 && tempPoint != points.First())
                {
                    DrawBase(graphics, pen);
                } else
                {
                    Size penSize = new((int)pen.Width, (int)pen.Width);
                    graphics.FillEllipse(new SolidBrush(pen.Color), new(Point.Subtract(tempPoint, penSize / 2), penSize));
                }
                points.RemoveAt(points.Count - 1);
            }
        }
        public void Draw(Graphics graphics, Pen pen)
        {
            if (points.Count == 1)
            {
                Size penSize = new((int)pen.Width, (int)pen.Width);
                graphics.FillEllipse(new SolidBrush(pen.Color), new(Point.Subtract(points.First(), penSize / 2), penSize));
            } else
            {
                DrawBase(graphics, pen);
            }
        }
        public virtual void EndDrawing(Graphics graphics, Pen pen)
        {
            CancelDrawing();
        }
        protected virtual void DrawBase(Graphics graphics, Pen pen)
        {
            graphics.DrawLines(pen, points.ToArray());
        }
        public void CancelDrawing()
        {
            points.Clear();
        }
        
    }
}
