using Paint.Domain;
using Paint.Domain.Figures;

namespace Paint
{
    public partial class PaintForm : Form
    {
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
            currentFigure = Factory.CreateFigure(FigureType.BrokenLine);
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentFigure.MakePoint(e.Location);
            }
            if (e.Button == MouseButtons.Right)
            {
                currentFigure.EndDrawing();
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                currentFigure.Draw(graphics, pen, e.Location);
            }
            canvas.Image = bitmap;

        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            using (Bitmap tempBitmap = new(bitmap))
            {
                Graphics tempGraphics = Graphics.FromImage(tempBitmap);
                currentFigure.PreDraw(tempGraphics, pen, e.Location);
                canvas.Image = tempBitmap;
                canvas.Refresh();
                tempGraphics.Dispose();
            }
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
            canvas.Image = bitmap;
        }
    }
}