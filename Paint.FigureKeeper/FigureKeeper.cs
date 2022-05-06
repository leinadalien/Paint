using Paint.Domain.Figures;

namespace Paint.FigureKeeper
{
    public class FigureKeeper
    {
        private bool isEmptied = true;
        private Graphics graphics;
        internal List<IFigure> figuresList;
        private Stack<IFigure> redoStack;
        private FigureKeeper? reserve;
        public FigureKeeper(Graphics graphics)
        {
            this.graphics = graphics;
            figuresList = new();
            redoStack = new();
        }
        private FigureKeeper(FigureKeeper other)
        {
            isEmptied = other.isEmptied;
            graphics = other.graphics;
            figuresList = new(other.figuresList);
            redoStack = new(other.redoStack);
            reserve = other.reserve;
        }
        public void AddFigure(IFigure figure)
        {
            if (isEmptied && reserve != null && redoStack.Count > 0)
            {
                reserve.AddFigure(figure);
                figuresList = new(reserve.figuresList);
                redoStack.Clear();
                isEmptied = false;
                reserve = reserve.reserve;
            }
            else
            {
                figuresList.Add(figure);
                redoStack.Clear();
                isEmptied = false;
            }
        }
        public void MakeReserve()
        {
            reserve = new(this);
            isEmptied = true;
            figuresList.Clear();
            redoStack.Clear();
        }
        public void DrawFigures()
        {
            graphics.Clear(Color.White);
            foreach(var figure in figuresList)
            {
                figure.Draw(graphics);
            }
        }
        public void Undo()
        {
            if (!isEmptied)
            {
                if (figuresList.Count > 0)
                {
                    redoStack.Push(figuresList.Last());
                    figuresList.RemoveAt(figuresList.Count - 1);
                    DrawFigures();
                }
                else
                {
                    isEmptied = true;
                    reserve?.DrawFigures();
                }
            }
            else
            {
                reserve?.Undo();
            }
           
        }
        public void Redo()
        {
            if (isEmptied)
            {
                if (reserve != null)
                {
                    if (reserve.redoStack.Count == 0)
                    {
                        DrawFigures();
                        isEmptied = false;
                    }
                    else
                    {
                        reserve.Redo();
                    }
                }
                else
                {
                    isEmptied = false;
                    redoStack.Peek().Draw(graphics);
                    figuresList.Add(redoStack.Pop());
                }
            }
            else if (redoStack.Count > 0)
            {
                redoStack.Peek().Draw(graphics);
                figuresList.Add(redoStack.Pop());
            }
        }
    }
}
