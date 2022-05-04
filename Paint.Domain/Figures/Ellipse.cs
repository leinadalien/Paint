namespace Paint.Domain.Figures
{
    public class Ellipse : IFigure
    {
        private Point firstPoint;
        bool isDrawing = false;
        public FigureType Type { get { return FigureType.Ellipse; } }

        public void CancelDrawing()
        {
            isDrawing = false;
        }

        public void Draw(Graphics graphics, Pen pen, Point point)
        {
            if (!isDrawing)
            {
                firstPoint = point;
                isDrawing = true;
            }
            PreDraw(graphics, pen, point);
            if (point != firstPoint)
            {
                CancelDrawing();
            }
        }

        public void PreDraw(Graphics graphics, Pen pen, Point point)
        {
            if (isDrawing)
            {
                Point startPoint = firstPoint;
                Point endPoint = point;
                if (point.X < startPoint.X)
                {
                    (startPoint.X, endPoint.X) = (point.X, startPoint.X);
                }
                if (point.Y < startPoint.Y)
                {
                    (startPoint.Y, endPoint.Y) = (point.Y, startPoint.Y);
                }
                graphics.DrawEllipse(pen, startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);
            }
        }
    }
}
