namespace Paint.Domain.Figures
{
    internal class Line : Figure
    {
        private Point startPoint;
        private Point endPoint;
        internal Line(Color fillColor, Color strokeColor, int strokeWidth) : base(fillColor, strokeColor, strokeWidth) { }
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
    public class LineCreator : FigureCreator
    {
        public override string FigureType { get { return "Line"; } }
        public override IFigure Create(Color fillColor, Color strokeColor, int strokeWidth)
        {
            return new Line(fillColor, strokeColor, strokeWidth);
        }
    }
}
