namespace Paint.Domain.Figures
{
    public class Ellipse : SimpleFigure
    {
        public Ellipse(Color fillColor, Color strokeColor, int strokeWidth)
        {
            pen = new(strokeColor, strokeWidth);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
            brush = new(fillColor);
        }
        protected override void DrawBase(Graphics graphics)
        {
            graphics.FillEllipse(brush, new(startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y));
            graphics.DrawEllipse(pen, new(startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y));
        }
    }
}