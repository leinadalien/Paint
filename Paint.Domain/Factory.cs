using Paint.Domain.Figures;

namespace Paint.Domain
{
    public static class Factory
    {
        public static IFigure CreateFigure(FigureType figureType)
        {
            switch(figureType)
            {
                case FigureType.Line:
                    return new Line();
                /*case FigureType.Polygon:
                    return new Polygon(points);
                case FigureType.Rectangle:
                    return new Figures.Rectangle(points);
                case FigureType.Ellipse:
                    return new Ellipse(points);*/
                case FigureType.BrokenLine:
                    return new BrokenLine();
                default:
                    throw new ArgumentException("Invalid type of figure");
            }
        }
    }
}
