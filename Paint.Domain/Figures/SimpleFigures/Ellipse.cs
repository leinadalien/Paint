namespace Paint.Domain.Figures
{
    internal class Ellipse : SimpleFigure
    {
        internal Ellipse(Color fillColor, Color strokeColor, int strokeWidth) : base(fillColor, strokeColor, strokeWidth) { }
        protected override void DrawBase(Graphics graphics)
        {
            graphics.FillEllipse(brush, new(startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y));
            graphics.DrawEllipse(pen, new(startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y));
        }
    }
    public class EllipseCreator : FigureCreator
    {
        public override string FigureType { get { return "Ellipse"; } }
        public override IFigure Create(Color fillColor, Color strokeColor, int strokeWidth)
        {
            return new Ellipse(fillColor, strokeColor, strokeWidth);
        }
    }
}