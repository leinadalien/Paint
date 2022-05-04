namespace Paint.Domain.Figures
{
    public class Line : IFigure
    {
        private Point startPoint;
        private Point endPoint;
        private bool isDrawing = false;
        public FigureType Type { get { return FigureType.Line; } }
       
        public void AddPoint(Point point)
        {
            if (!isDrawing)
            {
                startPoint = point;
                endPoint = point;
                isDrawing = true;
            } else
            {
                endPoint = point;
                isDrawing = false;
            }
        }
        public void PreDraw(Graphics graphics, Pen pen, Brush brush, Point tempPoint)
        {
            if (isDrawing)
            {
                endPoint = tempPoint;
                if (tempPoint != startPoint)
                {
                    DrawBase(graphics, pen);
                }
                else
                {
                    Size penSize = new((int)pen.Width, (int)pen.Width);
                    graphics.FillEllipse(new SolidBrush(pen.Color), new(Point.Subtract(endPoint, penSize / 2), penSize));
                }
            }
        }
        public void Draw(Graphics graphics, Pen pen, Brush brush)
        {
            if (endPoint != startPoint)
            {
                DrawBase(graphics, pen);
                CancelDrawing();
            }
            else
            {
                Size penSize = new((int)pen.Width, (int)pen.Width);
                graphics.FillEllipse(new SolidBrush(pen.Color), new(Point.Subtract(endPoint, penSize / 2), penSize));
            }
        }
        public void EndDrawing(Graphics graphics, Pen pen, Brush brush)
        {
            CancelDrawing();
        }
        protected virtual void DrawBase(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, startPoint, endPoint); 
        }
        public void CancelDrawing()
        {
            isDrawing = false;
        }
    }
}
