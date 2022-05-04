namespace Paint.Domain.Figures
{
    public class Polygon : ComplexFigure
    {
        public Polygon()
        {
            points = new();
        }
        public override void EndDrawing(Graphics graphics, Pen pen, Brush brush)
        {
            if (points.Count != 0)
            {
                graphics.FillPolygon(brush, points.ToArray());
                graphics.DrawPolygon(pen, points.ToArray());
            }
            CancelDrawing();
        }
        protected override void DrawBase(Graphics graphics, Pen pen)
        {
            graphics.DrawLines(pen, points.ToArray());
        }
    }
}
