namespace Paint.Domain.Figures
{
    public class Polygon : Figure 
    {
        public Polygon(List<Point> points)
        {
            this.points = points;
            Type = FigureType.Polygon;
        }
    }
}
