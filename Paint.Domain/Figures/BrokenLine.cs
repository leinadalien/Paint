namespace Paint.Domain.Figures
{
    public class BrokenLine : Figure
    {
        public BrokenLine(List<Point> points)
        {
            this.points = points;
            Type = FigureType.BrokenLine;
        }
    }
}
