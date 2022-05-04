using Paint.Domain.Figures;

namespace Paint.Domain
{
    public class FigureKeeper
    {
        private Graphics graphics;
        private Pen pen;
        private List<IFigure> undoList;
        private Stack<IFigure> redoStack;
        public FigureKeeper(Graphics graphics, Pen pen)
        {
            this.graphics = graphics;
            this.pen = pen;
            undoList = new();
            redoStack = new();
        }
        public void DrawFigures()
        {
            foreach (var figure in undoList)
            {
                figure.Draw(graphics, pen);
            }
        }
    }
}
