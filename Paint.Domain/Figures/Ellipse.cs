namespace Paint.Domain.Figures
{
    public class Ellipse : Figure
    {
        public Ellipse(List<Point> points)
        {
            this.points = points;
            Type = FigureType.Ellipse;
        }
    }
}
