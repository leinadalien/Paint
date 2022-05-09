using Paint.Domain.Figures;

namespace Paint.Plugins
{
    internal class Trapezoid : ComplexFigure
    {
        internal Trapezoid(Color fillColor, Color strokeColor, int strokeWidth) : base(fillColor, strokeColor, strokeWidth) { }
        protected override void DrawBase(Graphics graphics)
        {
            graphics.FillPolygon(brush, points.ToArray());
            graphics.DrawPolygon(pen, points.ToArray());
        }
    }
    public class TrapezoidCreator : FigureCreator
    {
        public override string FigureType { get { return "Trapezoid"; } }
        public override IFigure Create(Color fillColor, Color strokeColor, int strokeWidth)
        {
            return new Trapezoid(fillColor, strokeColor, strokeWidth);
        }
    }
}