namespace Paint.Domain.Figures
{
    public class BrokenLine : ComplexFigure
    {
        public BrokenLine(Color fillColor, Color strokeColor, int strokeWidth) : base(fillColor, strokeColor, strokeWidth)
        {
            name = "Broken line";
            type = FigureType.BrokenLine;
        }
        protected override void DrawBase(Graphics graphics)
        {
            graphics.DrawLines(pen, points.ToArray());
        }
    }
}
