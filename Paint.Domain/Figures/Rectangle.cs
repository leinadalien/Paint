namespace Paint.Domain.Figures
{
    public class Rectangle : IFigure
    {
        private Point firstPoint;
        private bool isDrawing = false;
        public FigureType Type { get { return FigureType.Rectangle; } }
        
        public void EndDrawing(Graphics graphics, Pen pen, Point point)
        {
            CancelDrawing();
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
                EndDrawing(graphics, pen, firstPoint);
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
                DrawBase(graphics, pen, startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);
            }
        }
        protected virtual void DrawBase(Graphics graphics, Pen pen, int startX, int startY, int width, int height)
        {
            graphics.DrawRectangle(pen, startX, startY, width, height);
        }
        public void CancelDrawing()
        {
            isDrawing = false;
        }
    }
}
