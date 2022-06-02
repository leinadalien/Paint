using Paint.Domain.FigureKeeper;
using Paint.Domain.FigureImporter;
using Paint.Domain.FigureSerializer;
using Paint.Figures;

namespace Paint
{
    public partial class PaintForm : Form
    {
        private Paint paint;
        public PaintForm()
        {
            InitializeComponent();
            paint = new(canvas.Size, figuresFlowLayoutPanel);
        }
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            paint.MouseDown(sender, e);
            canvas.Image = paint.Image;
        }
        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            paint.MouseUp(sender, e);
            canvas.Image = paint.Image;
        }
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            paint.MouseMove(sender, e);
            canvas.Image = paint.Image;
        }
        private void ColorButton_SetColor(object sender, EventArgs e)
        {
            paint.ColorButton_SetColor(sender, e);
        }
        private void PenSizeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            paint.ChangePenSize(penSizeTrackBar.Value);
        }
        private void ClearCanvasButton_Click(object sender, EventArgs e)
        {
            paint.Clear();
            canvas.Image = paint.Image;
        }
        private void UndoButton_Click(object sender, EventArgs e)
        {
            paint.Undo();
            canvas.Image = paint.Image;
        }
        private void RedoButton_Click(object sender, EventArgs e)
        {
            paint.Redo();
            canvas.Image = paint.Image;
        }
        private void PenColorLabel_Click(object sender, EventArgs e)
        {
            paint.ChoosePenPalette();
            penColorLabel.BackColor = Color.FromArgb(64, 64, 64);
            penColorLabel.ForeColor = Color.DarkGray;
            fillColorLabel.BackColor = Color.Transparent;
            fillColorLabel.ForeColor = Color.Black;
        }
        private void FillColorLabel_Click(object sender, EventArgs e)
        {
            paint.ChooseFillPalette();
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

        private void ImportButton_Click(object sender, EventArgs e)
        {
            paint.Import();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            paint.Save();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            paint.Load();
            canvas.Image = paint.Image;
        }
    }
}