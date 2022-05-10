namespace Paint.Figures
{
    internal class Polygon : ComplexFigure
    {
        internal Polygon(Color fillColor, Color strokeColor, int strokeWidth) : base(fillColor, strokeColor, strokeWidth) { }
        protected override void DrawBase(Graphics graphics)
        {
            graphics.FillPolygon(brush, points.ToArray());
            graphics.DrawPolygon(pen, points.ToArray());
        }
    }
    public class PolygonCreator : FigureCreator
    {
        public override string FigureType { get { return "Polygon"; } }
        public override IFigure Create(Color fillColor, Color strokeColor, int strokeWidth)
        {
            return new Polygon(fillColor, strokeColor, strokeWidth);
        }
    }
}
