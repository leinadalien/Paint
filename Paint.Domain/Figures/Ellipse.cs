namespace Paint.Domain.Figures
{
    public class Ellipse : Rectangle
    {
        protected override void DrawBase(Graphics graphics, Pen pen)
        {
            graphics.DrawEllipse(pen, new(startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y));
        }
    }
}