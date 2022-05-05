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
        public Color FillColor { get { return brush.Color; } set { brush.Color = value; } }
        public Color StrokeColor { get { return pen.Color; } set { pen.Color = value; } }
        public int StrokeWidth { get { return (int)pen.Width; } set { pen.Width = value; } }
        public bool IsDrawing { get { return isDrawing; } }
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
                CancelDrawing();
            }
        }
        public void PreDraw(Graphics graphics, Point tempPoint)
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
                    DrawBase(graphics);
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
        public void Draw(Graphics graphics)
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
                DrawBase(graphics);
            }
            else
            {
                graphics.DrawLine(pen, startPoint, endPoint);
            }
        }
        public void EndDrawing(Graphics graphics)
        {
            Draw(graphics);
            isDrawing = false;
        }
        protected abstract void DrawBase(Graphics graphics);
        public void CancelDrawing()
        {
            isDrawing = false;
        }
    }
}
