namespace Paint.Domain.Figures
{
    public class Line : Figure
    {
        public Line(List<Point> points)
        {
            this.points = points;
            Type = FigureType.Line;
        }
    }
}
