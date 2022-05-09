namespace Paint.Domain.Figures
{
    public abstract class FigureCreator
    {
        public abstract IFigure Create(Color fillColor, Color strokeColor, int strokeWidth);
        public abstract string FigureType { get; }
    }
}
