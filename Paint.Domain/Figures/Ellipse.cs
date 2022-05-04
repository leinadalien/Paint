namespace Paint.Domain.Figures
{
    public class Ellipse : SimpleFigure
    {
        protected override void DrawBase(Graphics graphics, Pen pen, Brush brush)
        {
            graphics.FillEllipse(brush, new(startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y));
            graphics.DrawEllipse(pen, new(startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y));
        }
    }
}