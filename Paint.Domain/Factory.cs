using Paint.Domain.Figures;

namespace Paint.Domain
{
    public class Factory
    {
        public Figure Create(List<Point> points, FigureType figureType)
        {
            switch(figureType)
            {
                case FigureType.Line:
                    return new Line(points);
                case FigureType.Polygon:
                    return new Polygon(points);
                case FigureType.Rectangle:
                    return new Figures.Rectangle(points);
                case FigureType.Ellipse:
                    return new Ellipse(points);
                case FigureType.BrokenLine:
                    return new BrokenLine(points);
                default:
                    throw new ArgumentException("Invalid type of figure");
            }
        }
    }
}
