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
        public void SetStartPoint(Point point);
        public void Preview(Graphics graphics, Pen pen, Point mousePosition);
        public void Draw(Graphics graphics, Pen pen, Point endPoint);
    }
}
