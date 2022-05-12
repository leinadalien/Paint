using Paint.Domain.FigureKeeper;
using Paint.Domain.FigureImporter;
using Paint.Domain.FigureSerializer;
using Paint.Figures;

namespace Paint
{
    public partial class PaintForm : Form
    {
        private delegate void Drawer(Graphics graphics);
        private FigureCreator creator;
        List<FigureCreator> creators;
        private bool isMouseLeftButtonDown = false;
        private Point mouseCanvasPosition;
        private Bitmap bitmap;
        private Graphics graphics;
        private Color fillColor = Color.Transparent;
        private Color strokeColor = Color.Black;
        private int strokeWidth = 10;
        private bool isPenPaletteOpen = true;
        private bool isCanvasEmpty = true;
        private IFigure currentFigure;
        private FigureKeeper figureKeeper;
        public PaintForm()
        {
            creator = new LineCreator();
            InitializeComponent();
            bitmap = new(canvas.Width, canvas.Height);
            graphics = Graphics.FromImage(bitmap);
            figureKeeper = new(graphics);
            creators = new();
            LoadStandartFigures();
            currentFigure = creator.Create(fillColor, strokeColor, strokeWidth);
            canvas.Image = bitmap;
        }
        private void CurrentFigureUpdate()
        {
            currentFigure.FillColor = fillColor;
            currentFigure.StrokeColor = strokeColor;
            currentFigure.StrokeWidth = strokeWidth;
        }
        private void RefreshFigures()
        {
            Button currentButton = new();
            figuresFlowLayoutPanel.Controls.Clear();
            foreach (var creator in creators)
            {
                Button button = new()
                {
                    FlatStyle = FlatStyle.Flat,
                    Width = figuresFlowLayoutPanel.Width - 30,
                    Height = 30,
                    Margin = new(0, 5, 0, 0),
                    BackColor = Color.DarkGray,
                    Text = creator.FigureType
                };
                if (creator.FigureType == this.creator.FigureType)
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
                figuresFlowLayoutPanel.Controls.Add(button);
            }
            Button importButton = new()
            {
                FlatStyle = FlatStyle.Flat,
                Width = figuresFlowLayoutPanel.Width - 30,
                Height = 30,
                Margin = new(0, 5, 0, 5),
                BackColor = Color.FromArgb(96, 96, 96),
                Text = "Import",
            };
            importButton.Click += (sender, e) => ImportButton_Click(importButton, e);
            figuresFlowLayoutPanel.Controls.Add(importButton);
        }
        private void LoadStandartFigures()
        {
            creators.Add(new LineCreator());
            creators.Add(new RectangleCreator());
            creators.Add(new EllipseCreator());
            creators.Add(new BrokenLineCreator());
            creators.Add(new PolygonCreator());
            RefreshFigures();
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
            mouseCanvasPosition = e.Location;
            Drawer tempDrawer;
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
        private void DrawOnTheTemp(Drawer tempDrawer)
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
            DrawOnTheTemp((tempGraphics) => { currentFigure.PreDraw(tempGraphics, mouseCanvasPosition); });
        }
        private void PenSizeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            strokeWidth = penSizeTrackBar.Value;
            currentFigure.StrokeWidth = penSizeTrackBar.Value;
            CurrentFigureUpdate();
            DrawOnTheTemp((tempGraphics) => { currentFigure.PreDraw(tempGraphics, mouseCanvasPosition);});
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
            DrawOnTheTemp((tempGraphics) => { currentFigure.PreDraw(tempGraphics, mouseCanvasPosition); });
        }
        private void RedoButton_Click(object sender, EventArgs e)
        {
            figureKeeper.Redo();
            canvas.Image = bitmap;
            DrawOnTheTemp((tempGraphics) => { currentFigure.PreDraw(tempGraphics, mouseCanvasPosition); });
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

        private void ImportButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog importFiguresDialog = new()
            {
                Title = "Import figures",
                Filter = "(*.dll) | *.dll",
            };
            if (importFiguresDialog.ShowDialog() == DialogResult.OK)
            {
                CreatorImporter importer = new();
                if (importer.ImportFromDll(importFiguresDialog.FileName) == ImportResult.OK)
                {
                    foreach (var creator in importer.ImportedCreators)
                    {
                        creators.Add(creator);
                    }
                    RefreshFigures();
                }
                else
                {
                    MessageBox.Show("Error!", "Import");
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFiguresDialog = new()
            {
                Title = "Save drawing",
                Filter = "(*.json)|*.json",
            };
            if (saveFiguresDialog.ShowDialog() == DialogResult.OK)
            {
                FigureSerializer.SerializeToJson(figureKeeper.GetDrawedFigures(), saveFiguresDialog.FileName);
            }
            else
            {
                MessageBox.Show("Error", "Save");
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadFiguresDialog = new()
            {
                Title = "Load drawing",
                Filter = "(*.json)|*.json",
            };
            if (loadFiguresDialog.ShowDialog() == DialogResult.OK)
            {
                FigureSerializer figureSerializer = new();
                if (figureSerializer.DeserializeFromJson(loadFiguresDialog.FileName) == Result.OK)
                {
                    figureKeeper.Clear();
                    foreach (IFigure figure in figureSerializer.DeserializedFigures)
                    {
                        figureKeeper.AddFigure(figure);
                    }
                    figureKeeper.DrawCurrentFigures();
                }
                else
                {
                    MessageBox.Show("Plugins are not found", "Load");
                }
            }
            else
            {
                MessageBox.Show("Error", "Load");
            }
        }
    }
}