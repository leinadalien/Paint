namespace Paint.Domain.Figures
{
    public class Line : IFigure
    {
        private Point startPoint;
        private bool isDrawing = false;

        public FigureType Type { get { return FigureType.Line; } }

        public void Draw(Graphics graphics, Pen pen, Point point)
        {
            if (!isDrawing)
            {
                startPoint = point;
                isDrawing = true;
                
            }
            PreDraw(graphics, pen, point);
            if (point != startPoint)
            {
                CancelDrawing();
            }
        }

        public void CancelDrawing()
        {
            isDrawing = false;
        }
        public void PreDraw(Graphics graphics, Pen pen, Point point)
        {
            if (isDrawing)
            {
                graphics.DrawLine(pen, startPoint, point);
            }
        }
    }
}
