using Paint.Domain;
using Paint.Domain.Figures;
namespace Paint
{
    public partial class PaintForm : Form
    {
        private bool isMouseLeftButtonDown = false;
        private Bitmap bitmap;
        private Graphics graphics;
        private Color fillColor = Color.Transparent;
        private Color strokeColor = Color.Black;
        private int strokeWidth = 10;
        private Pen pen;
        bool isPenPaletteOpen = true;
        private Size penSize;
        private IFigure currentFigure;
        private FigureKeeper.FigureKeeper figureKeeper;
        public PaintForm()
        {
            InitializeComponent();
            bitmap = new(canvas.Width, canvas.Height);
            graphics = Graphics.FromImage(bitmap);
            pen = new(Color.Black, penSizeTrackBar.Value);
            currentFigure = Factory.CreateFigure(fillColor, strokeColor, strokeWidth, FigureType.Line);
            figureKeeper = new(graphics);
            LoadStandartFigures();
        }
        private void CurrentFigureUpdate()
        {
            currentFigure.CancelDrawing();
            currentFigure.FillColor = fillColor;
            currentFigure.StrokeColor = strokeColor;
            currentFigure.StrokeWidth = strokeWidth;
        }
        private void PenUpdate()
        {
            pen.Color = strokeColor;
            pen.Width = strokeWidth;
        }
        private void LoadStandartFigures()
        {
            Button currentButton = new();
            standartFiguresFlowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            standartFiguresFlowLayoutPanel.AutoScroll = true;
            standartFiguresFlowLayoutPanel.Margin = new(5, 5, 5, 5);
            standartFiguresFlowLayoutPanel.Padding = new(5, 5, 5, 5);
            standartFiguresFlowLayoutPanel.Controls.Clear();
            foreach (FigureType figureType in Enum.GetValues(typeof(FigureType)))
            {
                Button button = new();
                button.FlatStyle = FlatStyle.Flat;
                button.Width = standartFiguresFlowLayoutPanel.ClientSize.Width - 40;
                button.Height = 30;
                button.Margin = new(5, 5, 5, 5);
                button.BackColor = Color.DarkGray;
                button.Text = figureType.ToString();
                if (figureType == currentFigure.Type)
                {
                    currentButton = button;
                    button.BackColor = Color.LightGray;
                }
                button.Click += (sender, EventArgs) =>
                {
                    currentButton.BackColor = Color.DarkGray;
                    currentButton = button;
                    button.BackColor = Color.LightGray;
                    currentFigure = Factory.CreateFigure(fillColor, strokeColor, strokeWidth, figureType);
                };
                standartFiguresFlowLayoutPanel.Controls.Add(button);
            }
        }
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseLeftButtonDown = true;
                penSize = new((int)pen.Width, (int)pen.Width);
            }
        }
        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseLeftButtonDown = false;
                currentFigure.AddPoint(e.Location);
                currentFigure.Draw(graphics);
                if (!currentFigure.IsDrawing)
                {
                    figureKeeper.AddFigure(currentFigure);
                    currentFigure = Factory.CreateFigure(fillColor, strokeColor, strokeWidth, currentFigure.Type);
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                currentFigure.EndDrawing(graphics);
                if (!currentFigure.DrawingCanceled)
                {
                    figureKeeper.AddFigure(currentFigure);
                    currentFigure = Factory.CreateFigure(fillColor, strokeColor, strokeWidth, currentFigure.Type);
                }
                
            }
            canvas.Image = bitmap;
        }
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap tempBitmap = new(bitmap);
            Graphics tempGraphics = Graphics.FromImage(tempBitmap);
            if (isMouseLeftButtonDown)
            {
                tempGraphics.FillEllipse(pen.Brush, new(Point.Subtract(e.Location, penSize / 2), penSize));
            }
            currentFigure.PreDraw(tempGraphics, e.Location);
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
            PenUpdate();
            CurrentFigureUpdate();
        }
        private void PenSizeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            strokeWidth = penSizeTrackBar.Value;
            currentFigure.StrokeWidth = penSizeTrackBar.Value;
            PenUpdate();
            CurrentFigureUpdate();
        }
        private void ClearCanvasButton_Click(object sender, EventArgs e)
        {
            figureKeeper.ClearCanvas();
            currentFigure.CancelDrawing();
            graphics.Clear(Color.White);
            canvas.Image = bitmap;
        }
        private void UndoButton_Click(object sender, EventArgs e)
        {
            if (currentFigure.IsDrawing)
            {
                currentFigure.CancelDrawing();
            }
            figureKeeper.Undo();
            canvas.Image = bitmap;
        }
        private void RedoButton_Click(object sender, EventArgs e)
        {
            if (currentFigure.IsDrawing)
            {
                currentFigure.CancelDrawing();
            }
            figureKeeper.Redo();
            canvas.Image = bitmap;
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
    }
}