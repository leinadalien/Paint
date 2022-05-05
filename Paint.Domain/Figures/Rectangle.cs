namespace Paint.Domain.Figures
{
    public class Rectangle : SimpleFigure
    {
        public Rectangle(Color fillColor, Color strokeColor, int strokeWidth)
        {
            pen = new(strokeColor, strokeWidth);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
            brush = new(fillColor);
        }
        protected override void DrawBase(Graphics graphics)
        {
            graphics.FillRectangle(brush, new(startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y));
            graphics.DrawRectangle(pen, new(startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y));
        }
    }
}
