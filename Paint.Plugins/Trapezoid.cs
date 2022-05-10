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
            Point result = new(points.First().X + points[1].X - point.X, point.Y);
            return result;
        }
        public override void AddPoint(Point point)
        {
            if (points.Count == 1)
            {
                points.Add(new(point.X, points.First().Y));
            } else 
            if (points.Count == 2)
            {
                isDrawing = false;
                points.Add(point);
                points.Add(MirrorPointOf(point));
                if (points[3].X > points[2].X)
                {
                    (points[2], points[3]) = ((points[3], points[2]));
                }
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
                if (points.Count == 1)
                {
                    points.Add(new(tempPoint.X, points.First().Y));
                    DrawBase(graphics);
                    points.RemoveAt(points.Count - 1);
                } else 
                if (points.Count == 2)
                {
                    points.Add(tempPoint);
                    points.Add(MirrorPointOf(tempPoint));
                    if (points[3].X > points[2].X)
                    {
                        (points[2], points[3]) = ((points[3], points[2]));
                    }
                    DrawBase(graphics);
                    points.RemoveAt(points.Count - 1);
                    points.RemoveAt(points.Count - 1);
                }
            }
        }
        public override void EndDrawing(Graphics graphics)
        {
            if (points.Count > 2)
            {
                DrawBase(graphics);
                isDrawing = false;
            }
            else
            {
                CancelDrawing();
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