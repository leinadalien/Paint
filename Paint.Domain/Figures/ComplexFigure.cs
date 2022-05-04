using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Domain.Figures
{
    public abstract class ComplexFigure : Figure, IFigure
    {
        protected List<Point> points;
        public FigureType Type { get { return FigureType.BrokenLine; } }
        public void AddPoint(Point point)
        {
            points.Add(point);
        }
        public void PreDraw(Graphics graphics, Pen pen, Brush brush, Point tempPoint)
        {
            if (points.Count > 0)
            {
                points.Add(tempPoint);
                if (points.Count > 1 && tempPoint != points.First())
                {
                    DrawBase(graphics, pen);
                }
                else
                {
                    Size penSize = new((int)pen.Width, (int)pen.Width);
                    graphics.FillEllipse(new SolidBrush(pen.Color), new(Point.Subtract(tempPoint, penSize / 2), penSize));
                }
                points.RemoveAt(points.Count - 1);
            }
        }
        public void Draw(Graphics graphics, Pen pen, Brush brush)
        {
            if (points.Count == 1)
            {
                Size penSize = new((int)pen.Width, (int)pen.Width);
                graphics.FillEllipse(new SolidBrush(pen.Color), new(Point.Subtract(points.First(), penSize / 2), penSize));
            }
            else
            {
                DrawBase(graphics, pen);
            }
        }
        public virtual void EndDrawing(Graphics graphics, Pen pen, Brush brush)
        {
            CancelDrawing();
        }
        protected abstract void DrawBase(Graphics graphics, Pen pen);
        public void CancelDrawing()
        {
            points.Clear();
        }
    }
}
