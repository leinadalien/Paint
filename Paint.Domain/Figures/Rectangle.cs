namespace Paint.Domain.Figures
{
    public class Rectangle : SimpleFigure
    {
        protected override void DrawBase(Graphics graphics, Pen pen, Brush brush)
        {
            graphics.FillRectangle(brush, new(startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y));
            graphics.DrawRectangle(pen, new(startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y));
        }
    }
}
