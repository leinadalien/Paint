namespace Paint.Domain.Figures
{
    public abstract class Figure : IFigure
    {
        protected bool isDrawing = false;
        protected bool drawingCanceled = false;
        protected Pen pen;
        protected SolidBrush brush;
        protected string name;
        protected FigureType type;
        protected Figure(Color fillColor, Color strokeColor, int strokeWidth)
        {
            name = "Undefined";
            pen = new(strokeColor, strokeWidth);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
            brush = new(fillColor);
        }
        public string Name { get { return name; } }
        public bool DrawingCanceled { get { return drawingCanceled; } }
        public FigureType Type { get { return type; } }
        public Color FillColor { get { return brush.Color; } set { brush.Color = value; } }
        public Color StrokeColor { get { return pen.Color; } set { pen.Color = value; } }
        public int StrokeWidth { get { return (int)pen.Width; } set { pen.Width = value; } }
        public bool IsDrawing { get { return isDrawing; } }
        public abstract void AddPoint(Point point);
        public abstract void PreDraw(Graphics graphics, Point tempPoint);
        public abstract void Draw(Graphics graphics);
        public abstract void EndDrawing(Graphics graphics);
        public virtual void CancelDrawing()
        {
            isDrawing = false;
            drawingCanceled = true;
        }
        protected abstract void DrawBase(Graphics graphics);
    }
}
