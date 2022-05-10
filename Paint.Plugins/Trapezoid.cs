using Paint.Figures;

namespace Paint.Plugins
{
    internal class Trapezoid : ComplexFigure
    {
        private int height;
        internal Trapezoid(Color fillColor, Color strokeColor, int strokeWidth) : base(fillColor, strokeColor, strokeWidth) { }
        protected override void DrawBase(Graphics graphics)
        {
            graphics.FillPolygon(brush, points.ToArray());
            graphics.DrawPolygon(pen, points.ToArray());
        }
        private Point MirrorPointOf(Point point)
        {
            Point result = new(point.X - points.Last().X, point.Y - points.Last().Y);
            result.X += points.First().X;
            result.Y += points.First().Y;
            return result;
        }
        public override void AddPoint(Point point)
        {
            if (points.Count == 1)
            {
                points.Add(new(point.X, points.First().Y));
            }
            if (points.Count == 3)
            {
                isDrawing = false;
            }
            else
            {
                base.AddPoint(point);
            }
        }
        public override void PreDraw(Graphics graphics, Point tempPoint)
        {
            if (isDrawing && points.Count > 0)
            {
                points.Add(tempPoint);
                if (points.Count > 2)
                {
                    points.Add(MirrorPointOf(tempPoint));
                    DrawBase(graphics);
                    points.RemoveAt(points.Count - 1);
                }
                else
                {
                    graphics.DrawLine(pen, points[0], points[1]);
                }
                points.RemoveAt(points.Count - 1);
            }
        }
    }
    public class TrapezoidCreator : FigureCreator
    {
        public override string FigureType { get { return "Trapezoid"; } }
        public override IFigure Create(Color fillColor, Color strokeColor, int strokeWidth)
        {
            return new Trapezoid(fillColor, strokeColor, strokeWidth);
        }
    }
}