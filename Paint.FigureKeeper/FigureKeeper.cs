using Paint.Domain.Figures;

namespace Paint.FigureKeeper
{
    public class FigureKeeper
    {
        private bool isAlreadyEmptied = false;
        private Graphics graphics;
        private List<IFigure> figuresList;
        private Stack<IFigure> redoStack;
        private FigureKeeper? reserve;
        public FigureKeeper(Graphics graphics)
        {
            //isAlreadyEmptied = true;
            this.graphics = graphics;
            figuresList = new();
            redoStack = new();
        }
        private FigureKeeper(FigureKeeper other)
        {
            isAlreadyEmptied = other.isAlreadyEmptied;
            graphics = other.graphics;
            figuresList = new(other.figuresList);
            redoStack = new(other.redoStack);
            reserve = other.reserve;
        }
        private void Reset(FigureKeeper other)
        {
            isAlreadyEmptied = other.isAlreadyEmptied;
            graphics = other.graphics;
            figuresList = other.figuresList;
            redoStack = other.redoStack;
            reserve = other.reserve;
        }
        public void AddFigure(IFigure figure)
        {

            redoStack.Clear();
            if (reserve != null && isAlreadyEmptied)
            {
                Reset(reserve);
                AddFigure(figure);
            }
            else
            {
                figuresList.Add(figure);
            }
        }
        public void MakeReserve()
        {
            redoStack.Clear();
            if (reserve != null && isAlreadyEmptied)
            {
                reserve.MakeReserve();
            }
            else
            {
                reserve = new(this);
                figuresList.Clear();
            }
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
            if (!isAlreadyEmptied)
            {
                if (figuresList.Count > 0)
                {
                    redoStack.Push(figuresList.Last());
                    figuresList.RemoveAt(figuresList.Count - 1);
                    DrawFigures();
                }
                else
                {
                    isAlreadyEmptied = true;
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
            if (isAlreadyEmptied)
            {
                
                if (reserve?.redoStack.Count > 0)
                {
                    reserve.Redo();
                }
                else
                {
                    isAlreadyEmptied = false;
                    DrawFigures();
                }
            }
            else
            {
                if (redoStack.Count > 0)
                {
                    redoStack.Peek().Draw(graphics);
                    figuresList.Add(redoStack.Pop());
                }
            }
        }
    }
}
