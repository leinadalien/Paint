using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Domain.Figures
{
    public abstract class ComplexFigure : Figure, IFigure
    {
        protected List<Point> points;
        public abstract FigureType Type { get; }
        public Color FillColor { get { return brush.Color; } set { brush.Color = value; } }
        public Color StrokeColor { get { return pen.Color; } set { pen.Color = value; } }
        public int StrokeWidth { get { return (int)pen.Width; } set { pen.Width = value; } }
        public bool IsDrawing { get { return isDrawing; } }
        public void AddPoint(Point point)
        {
            isDrawing = true;
            points.Add(point);
        }
        public void PreDraw(Graphics graphics, Point tempPoint)
        {
            if (isDrawing)
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
        public void Draw(Graphics graphics)
        {
            if (isDrawing)
            {
                if (points.Count > 1)
                {
                    DrawBase(graphics, pen);
                }
            } else
            {
                EndDrawing(graphics);
            }
            
        }
        public abstract void EndDrawing(Graphics graphics);
        protected abstract void DrawBase(Graphics graphics, Pen pen);
        public void CancelDrawing()
        {
            points.Clear();
            isDrawing = false;
        }
    }
}
