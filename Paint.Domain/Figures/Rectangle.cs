namespace Paint.Domain.Figures
{
    public class Rectangle : SimpleFigure
    {
        public Rectangle(Color fillColor, Color strokeColor, int strokeWidth) : base(fillColor, strokeColor, strokeWidth)
        {
            name = "Rectangle";
            type = FigureType.Rectangle;
        }
        protected override void DrawBase(Graphics graphics)
        {
            graphics.FillRectangle(brush, new(startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y));
            graphics.DrawRectangle(pen, new(startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y));
        }
    }
}
