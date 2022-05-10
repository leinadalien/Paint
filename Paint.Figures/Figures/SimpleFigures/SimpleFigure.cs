namespace Paint.Figures
{
    public abstract class SimpleFigure : Figure
    {
        protected Point startPoint;
        protected Point endPoint;
        private Point firstPoint;
        protected SimpleFigure(Color fillColor, Color strokeColor, int strokeWidth) : base(fillColor, strokeColor, strokeWidth) { }
        public override void AddPoint(Point point)
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
        public override void PreDraw(Graphics graphics, Point tempPoint)
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
                    DrawBase(graphics);
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
        public override void Draw(Graphics graphics)
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
                DrawBase(graphics);
            }
            else
            {
                graphics.DrawLine(pen, startPoint, endPoint);
            }
        }
        public override void EndDrawing(Graphics graphics)
        {
            if (isDrawing)
            {
                CancelDrawing();
            }
        }
    }
}
