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
        }
        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseLeftButtonDown = true;
            }
        }
        private void canvas_MouseUp(object sender, MouseEventArgs e)
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

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap tempBitmap = new(bitmap);
            Graphics tempGraphics = Graphics.FromImage(tempBitmap);
            currentFigure.PreDraw(tempGraphics, pen, e.Location);
            canvas.Image = tempBitmap;
            canvas.Refresh();
            tempGraphics.Dispose();
            tempBitmap.Dispose();

        }
        private void colorButton_SetPenColor(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
        }

        private void penSizeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = penSizeTrackBar.Value;
        }

        private void clearCanvasButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            currentFigure.CancelDrawing();
            canvas.Image = bitmap;
        }
    }
}