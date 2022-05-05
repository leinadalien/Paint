namespace Paint.Domain.Figures
{
    public class Line : Figure
    {
        private Point startPoint;
        private Point endPoint;
        public Line(Color fillColor, Color strokeColor, int strokeWidth) : base(fillColor, strokeColor, strokeWidth)
        {
            name = "Line";
            type = FigureType.Line;
        }
        public override void AddPoint(Point point)
        {
            if (!isDrawing)
            {
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
        public override void PreDraw(Graphics graphics, Point tempPoint)
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
        public override void Draw(Graphics graphics)
        {
            if (endPoint != startPoint)
            {
                DrawBase(graphics);
                isDrawing = false;
            }
        }
        public override void EndDrawing(Graphics graphics)
        {
            if (isDrawing)
            {
                CancelDrawing();
            }
        }
        protected override void DrawBase(Graphics graphics)
        {
            graphics.DrawLine(pen, startPoint, endPoint); 
        }
    }
}
