using Paint.Domain.Figures;

namespace Paint.Domain
{
    public class FigureKeeper
    {
        private Graphics graphics;
        private Pen pen;
        private Brush brush;
        private List<IFigure> undoList;
        private Stack<IFigure> redoStack;
        public FigureKeeper(Graphics graphics, Pen pen, Brush brush)
        {
            this.graphics = graphics;
            this.pen = pen;
            this.brush = brush;
            undoList = new();
            redoStack = new();
        }
        public void DrawFigures()
        {
            foreach (var figure in undoList)
            {
                figure.Draw(graphics, pen, brush);
            }
        }
    }
}
