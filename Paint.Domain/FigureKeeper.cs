using Paint.Figures;

namespace Paint.Domain.FigureKeeper
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
            this.graphics = graphics;
            figuresList = new();
            redoStack = new();
        }
        public void AddFigure(IFigure figure)
        {
            redoStack.Clear();
            if (reserve != null && isAlreadyEmptied)
            {
                ResetTo(reserve);
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
                reserve = GetCopyFrom(this);
                figuresList.Clear();
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
                    if (reserve != null)
                    {
                        isAlreadyEmptied = true;
                        reserve?.DrawFigures();
                    }
                }
            }
            else
            {
                reserve?.Undo();
            }
        }
        public void Redo()
        {
            if (reserve?.redoStack.Count > 0)
            {
                reserve.Redo();
            }
            else
            {
                if (!isAlreadyEmptied)
                {
                    if (redoStack.Count > 0)
                    {
                        redoStack.Peek().Draw(graphics);
                        figuresList.Add(redoStack.Pop());
                    }
                }
                else
                {
                    DrawFigures();
                    isAlreadyEmptied = false;
                }
            }
        }
        private FigureKeeper GetCopyFrom(FigureKeeper other)
        {
            FigureKeeper result = new(other.graphics)
            {
                figuresList = new(other.figuresList),
                redoStack = new(other.redoStack),
                reserve = other.reserve
            };
            return result;
        }
        private void ResetTo(FigureKeeper other)
        {
            isAlreadyEmptied = other.isAlreadyEmptied;
            graphics = other.graphics;
            figuresList = other.figuresList;
            redoStack = other.redoStack;
            reserve = other.reserve;
        }
        private void DrawFigures()
        {
            graphics.Clear(Color.White);
            foreach (var figure in figuresList)
            {
                figure.Draw(graphics);
            }
        }
        public List<IFigure> GetDrawedFigures()
        {
            List<IFigure> result = new();
            if (!isAlreadyEmptied)
            {
                result = figuresList;
            }
            else if(reserve != null)
            {
                result = reserve.GetDrawedFigures();
            }
            return result;
        }
        public void Clear()
        {
            reserve = null;
            figuresList.Clear();
            redoStack.Clear();
            isAlreadyEmptied = false;
        }
        public void DrawCurrentFigures()
        {
            if (!isAlreadyEmptied)
            {
                DrawFigures();
            }
            else if (reserve != null)
            {
                reserve.DrawCurrentFigures();
            }
        }
    }
}