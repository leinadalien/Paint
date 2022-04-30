﻿namespace Paint.Domain.Figures
{
    public class BrokenLine : IFigure
    {
        private List<Point> points;
        public FigureType Type { get { return FigureType.BrokenLine; } }
        public BrokenLine()
        {
            points = new();
        }

        public void MakePoint(Point point)
        {
            points.Add(point);
        }

        public void Draw(Graphics graphics, Pen pen, Point point)
        {
            points.Add(point);
            graphics.DrawLines(pen, points.ToArray());
        }

        public void EndDrawing()
        {
            points.Clear();
        }

        public void PreDraw(Graphics graphics, Pen pen, Point point)
        {
            if (points.Count > 0)
            {
                points.Add(point);
                graphics.DrawLines(pen, points.ToArray());
                points.Remove(point);
            }
        }
    }
}