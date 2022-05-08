using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Domain.Figures
{
    public interface IFigure
    {
        public string Name { get; }
        public FigureType Type { get; }
        public Color FillColor { get; set; }
        public Color StrokeColor { get; set; }
        public int StrokeWidth { get; set; }
        public bool IsDrawing { get; }
        public bool DrawingCanceled { get; }
        public void AddPoint(Point point);
        public void PreDraw(Graphics graphics,Point tempPoint);
        public void Draw(Graphics graphics);
        public void EndDrawing(Graphics graphics);
        public void DrawTarget(Graphics graphics, Point tempPoint);
        public void CancelDrawing();
    }
}
