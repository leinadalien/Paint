using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Domain.Figures
{
    public interface IFigure
    {
        public FigureType Type { get; }
        public void AddPoint(Point point);
        public void PreDraw(Graphics graphics, Pen pen, Brush brush, Point tempPoint);
        public void Draw(Graphics graphics, Pen pen, Brush brush);
        public void EndDrawing(Graphics graphics, Pen pen, Brush brush);
        public void CancelDrawing();
    }
}
