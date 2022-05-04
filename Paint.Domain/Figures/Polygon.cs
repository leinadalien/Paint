namespace Paint.Domain.Figures
{
    public class Polygon : BrokenLine
    {
        public override void EndDrawing(Graphics graphics, Pen pen, Point point)
        {
            graphics.FillPolygon(pen.Brush,points.ToArray());
            graphics.DrawPolygon(pen, points.ToArray());
            CancelDrawing();
        }
    }
}
