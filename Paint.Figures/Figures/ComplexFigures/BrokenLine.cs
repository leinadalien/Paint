namespace Paint.Figures
{
    internal class BrokenLine : ComplexFigure
    {
        internal BrokenLine(Color fillColor, Color strokeColor, int strokeWidth) : base(fillColor, strokeColor, strokeWidth) { }
        protected override void DrawBase(Graphics graphics)
        {
            graphics.DrawLines(pen, points.ToArray());
        }
    }
    public class BrokenLineCreator : FigureCreator
    {
        public override string FigureType { get { return "Broken line"; } }
        public override IFigure Create(Color fillColor, Color strokeColor, int strokeWidth)
        {
            return new BrokenLine(fillColor, strokeColor, strokeWidth);
        }
    }
}
