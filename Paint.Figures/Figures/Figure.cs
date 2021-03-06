namespace Paint.Figures
{
    public abstract class Figure : IFigure
    {
        protected bool isDrawing = false;
        protected bool drawingCanceled = false;
        protected Pen pen;
        protected SolidBrush brush;
        protected Figure(Color fillColor, Color strokeColor, int strokeWidth)
        {
            pen = new(strokeColor, strokeWidth);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
            brush = new(fillColor);
        }
        public abstract IEnumerable<Point> AnchorPoints { get; set; }
        public bool DrawingCanceled { get { return drawingCanceled; } }
        public Color FillColor { get { return brush.Color; } set { brush.Color = value; } }
        public Color StrokeColor { get { return pen.Color; } set { pen.Color = value; } }
        public int StrokeWidth { get { return (int)pen.Width; } set { pen.Width = value; } }
        public bool IsDrawing { get { return isDrawing; } }
        public abstract void AddPoint(Point point);
        public abstract void PreDraw(Graphics graphics, Point tempPoint);
        public abstract void Draw(Graphics graphics);
        public abstract void EndDrawing(Graphics graphics);
        public virtual void DrawTarget(Graphics graphics, Point tempPoint)
        {
            Size penSize = new((int)pen.Width, (int)pen.Width);
            graphics.FillEllipse(new SolidBrush(pen.Color), new(Point.Subtract(tempPoint, penSize / 2), penSize));
        }
        public virtual void CancelDrawing()
        {
            isDrawing = false;
            drawingCanceled = true;
        }
        protected abstract void DrawBase(Graphics graphics);
    }
}
