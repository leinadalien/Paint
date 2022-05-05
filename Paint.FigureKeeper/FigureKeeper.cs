using Paint.Domain.Figures;

namespace Paint.FigureKeeper
{
    public class FigureKeeper
    {
        private Graphics graphics;
        private List<IFigure> figuresList;
        private Stack<IFigure> redoStack;
        private int undoPointer;
        private int figuresPointer;
        private List<(int startPointer, int endPointer)> figurePointers;
        public FigureKeeper(Graphics graphics)
        {
            this.graphics = graphics;
            figuresList = new();
            redoStack = new();
            figurePointers = new();
            figurePointers.Add((0, -1));
            undoPointer = 0;
            figuresPointer = -1;
        }
        public void AddFigure(IFigure figure)
        {
            figuresPointer++;
            if (redoStack.Count > 0)
            {
                List<IFigure> temp = new(figuresList);
                figuresList.Clear();
                for (int i = 0; i < figuresPointer; i++)
                {
                    figuresList.Add(temp[i]);
                }
            }
            figuresList.Add(figure);
            figurePointers[undoPointer] = (figurePointers[undoPointer].startPointer, figuresPointer);
            redoStack.Clear();   
        }
        public void ClearCanvas()
        {
            if (figurePointers[undoPointer].endPointer - figurePointers[undoPointer].startPointer != -1)
            {
                figurePointers.Add((figurePointers[undoPointer].endPointer + 1, figuresPointer));
                undoPointer++;
            }
        }
        public void DrawFigures()
        {
            graphics.Clear(Color.White);
            for(int i = figurePointers[undoPointer].startPointer; i <= figuresPointer; i++)
            {
                figuresList[i].Draw(graphics);
            }
        }
        public void Undo()
        {
            
            if (figuresPointer >= 0)
            {
                if (figuresPointer < figurePointers[undoPointer].startPointer)
                {
                    undoPointer--;
                } else
                {
                    redoStack.Push(figuresList.ElementAt(figuresPointer));
                    figuresPointer--;
                }
                DrawFigures();
            }
            
        }
        public void Redo()
        {
            if (figuresPointer == figurePointers[undoPointer].endPointer)
            {
                if(undoPointer < figurePointers.Count - 1)
                {
                    undoPointer++;
                    DrawFigures();
                }
            }
            else
            {
                if (redoStack.Count > 0)
                {
                    figuresPointer++;
                    redoStack.Pop().Draw(graphics);
                }
            }
        }
    }
}
