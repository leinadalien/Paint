namespace Paint.Domain.Figures
{
    public class Polygon : ComplexFigure
    {
        public Polygon(Color fillColor, Color strokeColor, int strokeWidth) : base(fillColor, strokeColor, strokeWidth)
        {
            name = "Polygon";
            type = FigureType.Polygon;
        }
        public override void EndDrawing(Graphics graphics)
        {
            if (points.Count != 0)
            {
                graphics.FillPolygon(brush, points.ToArray());
                graphics.DrawPolygon(pen, points.ToArray());
                isDrawing = false;
            }
            else
            {
                CancelDrawing();
            }
        }
        protected override void DrawBase(Graphics graphics)
        {
            graphics.DrawLines(pen, points.ToArray());
        }
    }
}
