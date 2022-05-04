namespace Paint.Domain.Figures
{
    public class Rectangle : IFigure
    {
        protected Point startPoint;
        protected Point endPoint;
        private Point firstPoint;
        private bool isDrawing = false;
        public FigureType Type { get { return FigureType.Rectangle; } }
        public void AddPoint(Point point)
        {
            if (!isDrawing)
            {
                firstPoint = point;
                startPoint = point;
                endPoint = point;
                isDrawing = true;
            }
            else
            {
                endPoint = point;
                isDrawing = false;
            }
        }
        public void PreDraw(Graphics graphics, Pen pen, Point tempPoint)
        {
            if (isDrawing)
            {
                startPoint = firstPoint;
                endPoint = tempPoint;
                if (tempPoint.X < startPoint.X)
                {
                    (startPoint.X, endPoint.X) = (tempPoint.X, startPoint.X);
                }
                if (tempPoint.Y < startPoint.Y)
                {
                    (startPoint.Y, endPoint.Y) = (tempPoint.Y, startPoint.Y);
                }
                if (startPoint.X != endPoint.X && startPoint.Y != endPoint.Y)
                {
                    DrawBase(graphics, pen);
                }
                else
                {
                    if (startPoint != endPoint)
                    {
                        graphics.DrawLine(pen, startPoint, endPoint);
                    }
                }
            }
        }
        public void Draw(Graphics graphics, Pen pen)
        {
            if (endPoint.X < firstPoint.X)
            {
                (startPoint.X, endPoint.X) = (endPoint.X, firstPoint.X);
            }
            if (endPoint.Y < firstPoint.Y)
            {
                (startPoint.Y, endPoint.Y) = (endPoint.Y, firstPoint.Y);
            }
            if (startPoint.X != endPoint.X && startPoint.Y != endPoint.Y)
            {
                DrawBase(graphics, pen);
            }
            else
            {
                if (startPoint != endPoint)
                {
                    graphics.DrawLine(pen, startPoint, endPoint);
                }
                else
                {
                    Size penSize = new((int)pen.Width, (int)pen.Width);
                    graphics.FillEllipse(new SolidBrush(pen.Color), new(Point.Subtract(endPoint, penSize / 2), penSize));
                }
            }
        }
        public void EndDrawing(Graphics graphics, Pen pen)
        {
            CancelDrawing();
        }
        protected virtual void DrawBase(Graphics graphics, Pen pen)
        {
            graphics.DrawRectangle(pen, new(startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y));
        }
        public void CancelDrawing()
        {
            isDrawing = false;
        }
    }
}
