namespace Paint.Domain.Figures
{
    public class Line : IFigure
    {
        private Point startPoint;
        private bool isDrawing = false;

        public FigureType Type { get { return FigureType.Line; } }

        public void CancelDrawing()
        {
            isDrawing = false;
        }

        public void Draw(Graphics graphics, Pen pen, Point point)
        {
            if (!isDrawing)
            {
                startPoint = point;
                isDrawing = true;
                
            }
            PreDraw(graphics, pen, point);
            if (point != startPoint)
            {
                EndDrawing(graphics, pen, point);
            }
        }

        public void EndDrawing(Graphics graphics, Pen pen, Point point)
        {
            CancelDrawing();
        }
        public void PreDraw(Graphics graphics, Pen pen, Point point)
        {
            if (isDrawing)
            {
                if (point != startPoint)
                {
                    graphics.DrawLine(pen, startPoint, point);
                } else
                {
                    Size penSize = new((int)pen.Width, (int)pen.Width);
                    graphics.FillEllipse(pen.Brush, new(Point.Subtract(point, penSize / 2), penSize));
                }
            }
        }
    }
}
