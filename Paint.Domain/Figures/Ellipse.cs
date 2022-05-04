namespace Paint.Domain.Figures
{
    public class Ellipse : Rectangle
    {
        protected override void DrawBase(Graphics graphics, Pen pen, int startX, int startY, int width, int height)
        {
            graphics.DrawEllipse(pen, startX, startY, width, height);
        }
    }
}
