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
        public void Draw(Graphics graphics, Pen pen, Point point)
        {
            if (points.Count == 0)
            {
                points.Add(point);
            }
            points.Add(point);
            graphics.DrawLines(pen, points.ToArray());
        }

        public virtual void EndDrawing(Graphics graphics, Pen pen, Point point)
        {
            CancelDrawing();
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

        public void CancelDrawing()
        {
            points.Clear();
        }
    }
}
