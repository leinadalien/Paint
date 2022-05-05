namespace Paint.Domain.Figures
{
    public class BrokenLine : ComplexFigure
    {
        public BrokenLine(Color fillColor, Color strokeColor, int strokeWidth) : base(fillColor, strokeColor, strokeWidth)
        {
            name = "Broken line";
            type = FigureType.BrokenLine;
        }
        public override void EndDrawing(Graphics graphics)
        {
            if (points.Count != 0)
            {
                graphics.DrawLines(pen, points.ToArray());
            }
            isDrawing = false;
        }
        protected override void DrawBase(Graphics graphics)
        {
            graphics.DrawLines(pen, points.ToArray());
        }
    }
}
