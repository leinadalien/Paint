namespace Paint.Domain.Figures
{
    public class Ellipse : SimpleFigure
    {
        public Ellipse(Color fillColor, Color strokeColor, int strokeWidth) : base(fillColor, strokeColor, strokeWidth)
        {
            name = "Ellipse";
            type = FigureType.Ellipse;
        }
        protected override void DrawBase(Graphics graphics)
        {
            graphics.FillEllipse(brush, new(startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y));
            graphics.DrawEllipse(pen, new(startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y));
        }
    }
}