using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Domain.Figures
{
    public interface IFigure
    {
        public FigureType Type { get;}
        public void MakePoint(Point point);
        public void Draw(Graphics graphics, Pen pen, Point point);
        public void EndDrawing();
        public void PreDraw(Graphics graphics, Pen pen, Point point);
    }
}
