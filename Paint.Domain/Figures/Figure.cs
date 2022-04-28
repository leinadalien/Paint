namespace Paint.Domain.Figures
{
    public abstract class Figure
    {
        protected List<Point> points { get; set; }
        public FigureType Type { get; set; }
        protected virtual void Draw() { }
    }
}