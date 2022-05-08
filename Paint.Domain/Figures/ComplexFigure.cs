namespace Paint.Domain.Figures
{
    public abstract class ComplexFigure : Figure
    {
        protected List<Point> points;
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
            if (isDrawing)
            {
                points.Add(tempPoint);
                if (points.Count > 1 && tempPoint != points.First())
                {
                    DrawBase(graphics);
                }
                else
                {
                    Size penSize = new((int)pen.Width, (int)pen.Width);
                    graphics.FillEllipse(new SolidBrush(pen.Color), new(Point.Subtract(tempPoint, penSize / 2), penSize));
                }
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
