using Paint.Domain.Figures;

namespace Paint.Domain
{
    public static class Factory
    {
        public static IFigure CreateFigure(Color fillColor, Color strokeColor, int strokeWidth, FigureType figureType)
        {
            switch(figureType)
            {
                case FigureType.Line:
                    return new Line(fillColor, strokeColor, strokeWidth);
                case FigureType.Polygon:
                    return new Polygon(fillColor, strokeColor, strokeWidth);
                case FigureType.Rectangle:
                    return new Figures.Rectangle(fillColor, strokeColor, strokeWidth);
                case FigureType.Ellipse:
                    return new Ellipse(fillColor, strokeColor, strokeWidth);
                case FigureType.BrokenLine:
                    return new BrokenLine(fillColor, strokeColor, strokeWidth);
                default:
                    throw new ArgumentException("Invalid type of figure");
            }
        }
    }
}
