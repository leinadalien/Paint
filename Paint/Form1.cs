using Paint.Domain;
using Paint.Domain.Figures;

namespace Paint
{
    public partial class PaintForm : Form
    {
        private bool isMouseLeftButtonDown = false;
        private Bitmap bitmap;
        private Graphics graphics;
        private Pen pen;
        bool isPenPaletteOpen = true;
        private SolidBrush brush;
        private Size penSize;
        private IFigure currentFigure;
        public PaintForm()
        {
            InitializeComponent();
            bitmap = new(canvas.Width, canvas.Height);
            graphics = Graphics.FromImage(bitmap);
            brush = new SolidBrush(Color.Transparent);
            pen = new(Color.Black, penSizeTrackBar.Value);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
            currentFigure = Factory.CreateFigure(FigureType.Line);
            LoadStandartFigures();
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
                    currentFigure = Factory.CreateFigure(figureType);
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
                currentFigure.Draw(graphics, pen, brush);
            }
            if (e.Button == MouseButtons.Right)
            {
                currentFigure.EndDrawing(graphics, pen, brush);
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
            currentFigure.PreDraw(tempGraphics, pen, brush, e.Location);
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
                pen.Color = choosenColor;
            } else
            {
                brush.Color = choosenColor;
            }
        }

        private void PenSizeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = penSizeTrackBar.Value;
        }

        private void ClearCanvasButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            currentFigure.CancelDrawing();
            canvas.Image = bitmap;
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            ClearCanvasButton_Click(sender, e);

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