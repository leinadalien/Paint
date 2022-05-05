namespace Paint.Domain.Figures
{
    public class Polygon : ComplexFigure
    {
        public Polygon(Color fillColor, Color strokeColor, int strokeWidth)
        {
            pen = new(strokeColor, strokeWidth);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
            brush = new(fillColor);
            points = new();
        }
        public override FigureType Type { get { return FigureType.Polygon; } }
        public override void EndDrawing(Graphics graphics)
        {
            if (points.Count != 0)
            {
                graphics.FillPolygon(brush, points.ToArray());
                graphics.DrawPolygon(pen, points.ToArray());
            }
            isDrawing = false;
        }
        protected override void DrawBase(Graphics graphics, Pen pen)
        {
            graphics.DrawLines(pen, points.ToArray());
        }
    }
}
