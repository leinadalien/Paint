namespace Paint.Domain.Figures
{
    internal class Rectangle : SimpleFigure
    {
        internal Rectangle(Color fillColor, Color strokeColor, int strokeWidth) : base(fillColor, strokeColor, strokeWidth)
        {
            type = FigureType.Rectangle;
        }
        protected override void DrawBase(Graphics graphics)
        {
            graphics.FillRectangle(brush, new(startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y));
            graphics.DrawRectangle(pen, new(startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y));
        }
    }
    public class RectangleCreator : FigureCreator
    {
        public override string FigureType { get { return "Rectangle"; } }
        public override IFigure Create(Color fillColor, Color strokeColor, int strokeWidth)
        {
            return new Rectangle(fillColor, strokeColor, strokeWidth);
        }
    }
}
