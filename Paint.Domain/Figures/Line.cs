﻿namespace Paint.Domain.Figures
{
    public class Line : IFigure
    {
        private Point startPoint;
        private bool isDrawing = false;

        public FigureType Type { get { return FigureType.Line; } }

        public void Draw(Graphics graphics, Pen pen, Point point)
        {

            graphics.DrawLine(pen, startPoint, point);
            if (point != startPoint)
            {
                EndDrawing();
            }

        }

        public void EndDrawing()
        {
            isDrawing = false;
        }

        public void MakePoint(Point point)
        {
            if (!isDrawing)
            {
                startPoint = point;
                isDrawing = true;
            } else
            {
                EndDrawing();
            }
        }

        public void PreDraw(Graphics graphics, Pen pen, Point point)
        {
            if (isDrawing)
            {
                graphics.DrawLine(pen, startPoint, point);
            }
            
        }
    }
}