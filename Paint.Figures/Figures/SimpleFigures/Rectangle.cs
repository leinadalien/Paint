namespace Paint.Figures
{
    public class Rectangle : SimpleFigure
    {
        public Rectangle(Color fillColor, Color strokeColor, int strokeWidth) : base(fillColor, strokeColor, strokeWidth) { }
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
