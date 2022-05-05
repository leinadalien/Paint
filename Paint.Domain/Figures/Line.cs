namespace Paint.Domain.Figures
{
    public class Line : Figure, IFigure
    {
        private Point startPoint;
        private Point endPoint;
        public FigureType Type { get { return FigureType.Line; } }
        public Color FillColor { get { return brush.Color; } set { brush.Color = value; } }
        public Color StrokeColor { get { return pen.Color; } set { pen.Color = value; } }
        public int StrokeWidth { get { return (int)pen.Width; } set { pen.Width = value; } }
        public bool IsDrawing { get { return isDrawing; } }
        public Line(Color fillColor, Color strokeColor, int strokeWidth)
        {
            pen = new(strokeColor, strokeWidth);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
            brush = new(fillColor);
        }
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
        public void PreDraw(Graphics graphics, Point tempPoint)
        {
            if (isDrawing)
            {
                endPoint = tempPoint;
                if (tempPoint != startPoint)
                {
                    DrawBase(graphics);
                }
                else
                {
                    Size penSize = new((int)pen.Width, (int)pen.Width);
                    graphics.FillEllipse(new SolidBrush(pen.Color), new(Point.Subtract(endPoint, penSize / 2), penSize));
                }
            }
        }
        public void Draw(Graphics graphics)
        {
            if (endPoint != startPoint)
            {
                DrawBase(graphics);
                CancelDrawing();
            }
        }
        public void EndDrawing(Graphics graphics)
        {
            Draw(graphics);
            isDrawing = false;
        }
        protected virtual void DrawBase(Graphics graphics)
        {
            graphics.DrawLine(pen, startPoint, endPoint); 
        }
        public void CancelDrawing()
        {
            isDrawing = false;
        }
    }
}
