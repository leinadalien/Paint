namespace Paint.Domain.Figures
{
    public class Polygon : ComplexFigure
    {
        public Polygon(Color fillColor, Color strokeColor, int strokeWidth) : base(fillColor, strokeColor, strokeWidth)
        {
            name = "Polygon";
            type = FigureType.Polygon;
        }
        protected override void DrawBase(Graphics graphics)
        {
            graphics.FillPolygon(brush, points.ToArray());
            graphics.DrawPolygon(pen, points.ToArray());
        }
    }
}
