namespace Paint.Domain.Figures
{
    public class Rectangle : Figure
    {
        public Rectangle(List<Point> points)
        {
            this.points = points;
            Type = FigureType.Rectangle;
        }
    }
}
