namespace Paint.Figures
{
    public abstract class ComplexFigure : Figure
    {
        protected List<Point> points;
        public override IEnumerable<Point> AnchorPoints { get { return points; } set { points = value.ToList(); } }
        protected ComplexFigure(Color fillColor, Color strokeColor, int strokeWidth) : base(fillColor, strokeColor, strokeWidth)
        {
            points = new();
        }
        public override void AddPoint(Point point)
        {
            isDrawing = true;
            drawingCanceled = false;
            points.Add(point);
        }
        public override void PreDraw(Graphics graphics, Point tempPoint)
        {
            if (isDrawing && points.Count > 0)
            {
                points.Add(tempPoint);
                DrawBase(graphics);
                points.RemoveAt(points.Count - 1);
            }
        }
        public override void Draw(Graphics graphics)
        {
            if (isDrawing)
            {
                if (points.Count > 1)
                {
                    DrawBase(graphics);
                }
            }
            else
            {
                EndDrawing(graphics);
            }
        }
        public override void EndDrawing(Graphics graphics)
        {
            if (points.Count > 1)
            {
                DrawBase(graphics);
                isDrawing = false;
            }
            else
            {
                CancelDrawing();
            }
        }
        public override void CancelDrawing()
        {
            points.Clear();
            base.CancelDrawing();
        }
    }
}
