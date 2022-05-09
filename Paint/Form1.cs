using Paint.Domain;
using Paint.Domain.Figures;
namespace Paint
{
    public partial class PaintForm : Form
    {
        private delegate void TempDrawer(Graphics graphics);
        private FigureCreator creator;
        private bool isMouseLeftButtonDown = false;
        private Point MouseCanvasPosition;
        private Bitmap bitmap;
        private Graphics graphics;
        private Color fillColor = Color.Transparent;
        private Color strokeColor = Color.Black;
        private int strokeWidth = 10;
        private bool isPenPaletteOpen = true;
        private bool isCanvasEmpty = true;
        private IFigure currentFigure;
        private FigureKeeper.FigureKeeper figureKeeper;
        public PaintForm()
        {
            creator = new LineCreator();
            InitializeComponent();
            bitmap = new(canvas.Width, canvas.Height);
            graphics = Graphics.FromImage(bitmap);
            figureKeeper = new(graphics);
            LoadStandartFigures();
            currentFigure = creator.Create(fillColor, strokeColor, strokeWidth);
        }
        private void CurrentFigureUpdate()
        {
            currentFigure.FillColor = fillColor;
            currentFigure.StrokeColor = strokeColor;
            currentFigure.StrokeWidth = strokeWidth;
        }
        private void LoadStandartFigures()
        {
            List<FigureCreator> creators = new()
            {
                new LineCreator(),
                new RectangleCreator(),
                new EllipseCreator(),
                new BrokenLineCreator(),
                new PolygonCreator(),
            };
            Button currentButton = new();
            creator = creators.First();
            standartFiguresFlowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            standartFiguresFlowLayoutPanel.AutoScroll = true;
            standartFiguresFlowLayoutPanel.Margin = new(5, 5, 5, 5);
            standartFiguresFlowLayoutPanel.Padding = new(5, 5, 5, 5);
            standartFiguresFlowLayoutPanel.Controls.Clear();
            foreach (var creator in creators)
            {
                Button button = new();
                button.FlatStyle = FlatStyle.Flat;
                button.Width = standartFiguresFlowLayoutPanel.ClientSize.Width - 40;
                button.Height = 30;
                button.Margin = new(5, 5, 5, 5);
                button.BackColor = Color.DarkGray;
                button.Text = creator.FigureType;
                if (creator == this.creator)
                {
                    currentButton = button;
                    button.BackColor = Color.LightGray;
                }
                button.Click += (sender, EventArgs) =>
                {
                    currentButton.BackColor = Color.DarkGray;
                    currentButton = button;
                    button.BackColor = Color.LightGray;
                    currentFigure = creator.Create(fillColor, strokeColor, strokeWidth);
                    this.creator = creator;
                };
                standartFiguresFlowLayoutPanel.Controls.Add(button);
            }
        }
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseLeftButtonDown = true;
            }
        }
        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseLeftButtonDown = false;
                currentFigure.AddPoint(e.Location);
                DrawOnTheTemp(currentFigure.Draw);
                if (!currentFigure.IsDrawing)
                {
                    currentFigure.Draw(graphics);
                    isCanvasEmpty = false;
                    figureKeeper.AddFigure(currentFigure);
                    currentFigure = creator.Create(fillColor, strokeColor, strokeWidth);
                    canvas.Image = bitmap;
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                currentFigure.EndDrawing(graphics);
                if (!currentFigure.DrawingCanceled)
                {
                    currentFigure.Draw(graphics);
                    isCanvasEmpty = false;
                    figureKeeper.AddFigure(currentFigure);
                    currentFigure = creator.Create(fillColor, strokeColor, strokeWidth);
                    canvas.Image = bitmap;
                }
                
            }
        }
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            MouseCanvasPosition = e.Location;
            TempDrawer tempDrawer;
            if (isMouseLeftButtonDown && !currentFigure.IsDrawing)
            {
                tempDrawer = (tempGraphics) => { currentFigure.DrawTarget(tempGraphics, e.Location); };
            }
            else
            {
                tempDrawer = (tempGraphics) => { currentFigure.PreDraw(tempGraphics, e.Location); };
            }
            DrawOnTheTemp(tempDrawer);
        }
        private void DrawOnTheTemp(TempDrawer tempDrawer)
        {
            Bitmap tempBitmap = new(bitmap);
            Graphics tempGraphics = Graphics.FromImage(tempBitmap);
            tempDrawer.Invoke(tempGraphics);
            canvas.Image = tempBitmap;
            canvas.Refresh();
            tempGraphics.Dispose();
            tempBitmap.Dispose();
        }
        private void ColorButton_SetColor(object sender, EventArgs e)
        {
            Color choosenColor = ((Button)sender).BackColor;
            if (isPenPaletteOpen)
            {
                strokeColor = choosenColor;
            } else
            {
                fillColor = choosenColor;
            }
            CurrentFigureUpdate();
            DrawOnTheTemp((tempGraphics) => { currentFigure.PreDraw(tempGraphics, MouseCanvasPosition); });
        }
        private void PenSizeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            strokeWidth = penSizeTrackBar.Value;
            currentFigure.StrokeWidth = penSizeTrackBar.Value;
            CurrentFigureUpdate();
            DrawOnTheTemp((tempGraphics) => { currentFigure.PreDraw(tempGraphics, MouseCanvasPosition);});
        }
        private void ClearCanvasButton_Click(object sender, EventArgs e)
        {
            if (!isCanvasEmpty)
            {
                figureKeeper.MakeReserve();
                currentFigure.CancelDrawing();
                graphics.Clear(Color.White);
                canvas.Image = bitmap;
            }
        }
        private void UndoButton_Click(object sender, EventArgs e)
        {
            figureKeeper.Undo();
            canvas.Image = bitmap;
            DrawOnTheTemp((tempGraphics) => { currentFigure.PreDraw(tempGraphics, MouseCanvasPosition); });
        }
        private void RedoButton_Click(object sender, EventArgs e)
        {
            figureKeeper.Redo();
            canvas.Image = bitmap;
            DrawOnTheTemp((tempGraphics) => { currentFigure.PreDraw(tempGraphics, MouseCanvasPosition); });
        }
        private void PenColorLabel_Click(object sender, EventArgs e)
        {
            isPenPaletteOpen = true;
            penColorLabel.BackColor = Color.FromArgb(64, 64, 64);
            penColorLabel.ForeColor = Color.DarkGray;
            fillColorLabel.BackColor = Color.Transparent;
            fillColorLabel.ForeColor = Color.Black;
        }
        private void FillColorLabel_Click(object sender, EventArgs e)
        {
            isPenPaletteOpen = false;
            fillColorLabel.BackColor = Color.FromArgb(64, 64, 64);
            fillColorLabel.ForeColor = Color.DarkGray;
            penColorLabel.BackColor = Color.Transparent;
            penColorLabel.ForeColor = Color.Black;
        }

        private void CanvasPanel_MouseMove(object sender, MouseEventArgs e)
        {
            Canvas_MouseMove(sender, new(e.Button, e.Clicks, e.Location.X - canvas.Location.X, e.Location.Y - canvas.Location.Y, e.Delta));
        }

        private void CanvasPanel_MouseUp(object sender, MouseEventArgs e)
        {
            Canvas_MouseUp(sender, new(e.Button, e.Clicks, e.Location.X - canvas.Location.X, e.Location.Y - canvas.Location.Y, e.Delta));
        }
    }
}