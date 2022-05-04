using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Domain.Figures
{
    public abstract class SimpleFigure : Figure, IFigure
    {
        protected Point startPoint;
        protected Point endPoint;
        private Point firstPoint;
        public FigureType Type { get { return FigureType.Rectangle; } }
        public void AddPoint(Point point)
        {
            if (!isDrawing)
            {
                firstPoint = point;
                startPoint = point;
                endPoint = point;
                isDrawing = true;
            }
            else
            {
                endPoint = point;
                isDrawing = false;
            }
        }
        public void PreDraw(Graphics graphics, Pen pen, Brush brush, Point tempPoint)
        {
            if (isDrawing)
            {
                startPoint = firstPoint;
                endPoint = tempPoint;
                if (tempPoint.X < startPoint.X)
                {
                    (startPoint.X, endPoint.X) = (tempPoint.X, startPoint.X);
                }
                if (tempPoint.Y < startPoint.Y)
                {
                    (startPoint.Y, endPoint.Y) = (tempPoint.Y, startPoint.Y);
                }
                if (startPoint.X != endPoint.X && startPoint.Y != endPoint.Y)
                {
                    DrawBase(graphics, pen, brush);
                }
                else
                {
                    if (startPoint != endPoint)
                    {
                        graphics.DrawLine(pen, startPoint, endPoint);
                    }
                }
            }
        }
        public void Draw(Graphics graphics, Pen pen, Brush brush)
        {
            if (endPoint.X < firstPoint.X)
            {
                (startPoint.X, endPoint.X) = (endPoint.X, firstPoint.X);
            }
            if (endPoint.Y < firstPoint.Y)
            {
                (startPoint.Y, endPoint.Y) = (endPoint.Y, firstPoint.Y);
            }
            if (startPoint.X != endPoint.X && startPoint.Y != endPoint.Y)
            {
                DrawBase(graphics, pen, brush);
            }
            else
            {
                if (startPoint != endPoint)
                {
                    graphics.DrawLine(pen, startPoint, endPoint);
                }
                else
                {
                    Size penSize = new((int)pen.Width, (int)pen.Width);
                    graphics.FillEllipse(new SolidBrush(pen.Color), new(Point.Subtract(endPoint, penSize / 2), penSize));
                }
            }
        }
        public void EndDrawing(Graphics graphics, Pen pen, Brush brush)
        {
            CancelDrawing();
        }
        protected abstract void DrawBase(Graphics graphics, Pen pen, Brush brush);
        public void CancelDrawing()
        {
            isDrawing = false;
        }
    }
}
