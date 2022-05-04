namespace Paint.Domain.Figures
{
    public class BrokenLine : ComplexFigure
    {
        public BrokenLine()
        {
            points = new();
        }
        protected override void DrawBase(Graphics graphics, Pen pen)
        {
            graphics.DrawLines(pen, points.ToArray());
        }
    }
}
