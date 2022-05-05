using Paint.Domain.Figures;

namespace Paint.FigureKeeper
{
    public class FigureKeeper
    {
        private Graphics graphics;
        private List<IFigure> figuresList;
        private Stack<IFigure> redoStack;
        private List<int> startDrawingPointers;
        public FigureKeeper(Graphics graphics)
        {
            this.graphics = graphics;
            figuresList = new();
            redoStack = new();
            startDrawingPointers = new();
            startDrawingPointers.Add(0);
        }
        public void AddFigure(IFigure figure)
        {
            figuresList.Add(figure);
            redoStack.Clear();
        }
        public void ClearCanvas()
        {
            if (startDrawingPointers.Last() != figuresList.Count)
            {
                startDrawingPointers.Add(figuresList.Count);
                redoStack.Clear();
            }
        }
        public void DrawFigures()
        {
            graphics.Clear(Color.White);
            for(int i = startDrawingPointers.Last(); i < figuresList.Count; i++)
            {
                figuresList[i].Draw(graphics);
            }
        }
        public void Undo()
        {
            if (figuresList.Count > 0)
            {
                if (startDrawingPointers.Last() != figuresList.Count)
                {
                    redoStack.Push(figuresList.Last());
                    figuresList.RemoveAt(figuresList.Count - 1);
                }
                else
                {
                    startDrawingPointers.RemoveAt(startDrawingPointers.Count - 1);
                }
                DrawFigures();
            }
        }
        public void Redo()
        {
            if (redoStack.Count > 0)
            {
                if (startDrawingPointers.Last() != figuresList.Count)
                {
                    figuresList.Add(redoStack.Pop());
                }
                DrawFigures();
            }
        }
    }
}
