namespace Paint.Domain.Figures
{
    public class Line : IFigure
    {
        private Point startPoint;
        private bool isDrawing = false;

        public FigureType Type { get { return FigureType.Line; } }

        public void Draw(Graphics graphics, Pen pen, Point point)
        {
            if (!isDrawing)
            {
                startPoint = point;
                isDrawing = true;
                //Size size = new((int)pen.Width, (int)pen.Width);
                //graphics.FillEllipse(pen.Brush, new(Point.Subtract(point, size / 2), size));
            }
            graphics.DrawLine(pen, startPoint, point);
            if (point != startPoint)
            {
                CancelDrawing();
            }
        }

        public void CancelDrawing()
        {
            isDrawing = false;
        }
        public void PreDraw(Graphics graphics, Pen pen, Point point)
        {
            if (isDrawing)
            {
                graphics.DrawLine(pen, startPoint, point);
            }
        }
    }
}
