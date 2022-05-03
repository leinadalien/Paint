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
        private Size penSize;
        private IFigure currentFigure;
        public PaintForm()
        {
            InitializeComponent();
            bitmap = new(canvas.Width, canvas.Height);
            graphics = Graphics.FromImage(bitmap);
            pen = new(Color.Black, penSizeTrackBar.Value);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
            currentFigure = Factory.CreateFigure(FigureType.Line);
            LoadStandartFigures();
        }
        private void LoadStandartFigures()
        {
            standartFiguresFlowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            standartFiguresFlowLayoutPanel.AutoScroll = true;
            standartFiguresFlowLayoutPanel.Margin = new(5, 5, 5, 5);
            standartFiguresFlowLayoutPanel.Padding = new(5, 5, 5, 5);
            standartFiguresFlowLayoutPanel.Controls.Clear();
            foreach(FigureType figureType in Enum.GetValues(typeof(FigureType)))
            {
                Button button = new();
                button.FlatStyle = FlatStyle.Flat;
                button.Width = standartFiguresFlowLayoutPanel.Width - 40;
                button.Height = 30;
                button.BackColor = Color.DarkGray;
                button.Text = figureType.ToString();
                standartFiguresFlowLayoutPanel.Controls.Add(button);
                button.Click += (sender, EventArgs) => currentFigure = Factory.CreateFigure(figureType);
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
                currentFigure.Draw(graphics, pen, e.Location);
            }
            if (e.Button == MouseButtons.Right)
            {
                currentFigure.CancelDrawing();
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
            currentFigure.PreDraw(tempGraphics, pen, e.Location);
            canvas.Image = tempBitmap;
            canvas.Refresh();
            tempGraphics.Dispose();
            tempBitmap.Dispose();

        }
        private void ColorButton_SetPenColor(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
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
    }
}