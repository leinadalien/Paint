using Paint.Domain.FigureImporter;
using Paint.Domain.FigureKeeper;
using Paint.Domain.FigureSerializer;
using Paint.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    public class Paint
    {
        private delegate void Drawer(Graphics graphics);
        public Image Image { get; private set; }
        private FlowLayoutPanel figuresPanel;
        private FigureCreator creator;
        List<FigureCreator> creators;
        private bool isMouseLeftButtonDown = false;
        private Point mouseCanvasPosition;
        private Bitmap bitmap;
        private Bitmap tempBitmap;
        private Graphics graphics;
        private Color fillColor = Color.Transparent;
        private Color strokeColor = Color.Black;
        private int strokeWidth = 10;
        private bool isPenPaletteOpen = true;
        private bool isCanvasEmpty = true;
        private IFigure currentFigure;
        private FigureKeeper figureKeeper;
        public Paint(Size imageSize, FlowLayoutPanel figuresPanel)
        {
            this.figuresPanel = figuresPanel;
            creator = new LineCreator();
            bitmap = new(imageSize.Width, imageSize.Height);
            graphics = Graphics.FromImage(bitmap);
            figureKeeper = new(graphics);
            creators = new();
            LoadStandartFigures();
            currentFigure = creator.Create(fillColor, strokeColor, strokeWidth);
            Image = bitmap;
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
        private void RefreshFigures()//figuresFlowLayoutPanel.Width - 30
        {
            figuresPanel.Controls.Clear();
            Button currentButton = new();
            foreach (var creator in creators)
            {
                Button button = new()
                {
                    FlatStyle = FlatStyle.Flat,
                    Width = figuresPanel.Width - 30,
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
                figuresPanel.Controls.Add(button);
            }
            Button importButton = new()
            {
                FlatStyle = FlatStyle.Flat,
                Width = figuresPanel.Width - 30,
                Height = 30,
                Margin = new(0, 5, 0, 5),
                BackColor = Color.FromArgb(96, 96, 96),
                Text = "Import",
            };
            importButton.Click += (sender, e) => Import();
            figuresPanel.Controls.Add(importButton);
        }
        public void Import()
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
        private void CurrentFigureUpdate()
        {
            currentFigure.FillColor = fillColor;
            currentFigure.StrokeColor = strokeColor;
            currentFigure.StrokeWidth = strokeWidth;
        }
        public void MouseDown(object sender, MouseEventArgs e)
        {
            if (!currentFigure.IsDrawing)
            {
                tempBitmap = new(bitmap);
            }
            if (e.Button == MouseButtons.Left)
            {
                isMouseLeftButtonDown = true;
            }
        }
        public void MouseUp(object sender, MouseEventArgs e)
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
                    Image = bitmap;
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
                    Image = bitmap;
                }

            }
            if (!currentFigure.IsDrawing)
            {
                tempBitmap.Dispose();
            }
        }
        public void MouseMove(object sender, MouseEventArgs e)
        {
            mouseCanvasPosition = e.Location;
            Drawer tempDrawer;
            if (currentFigure.IsDrawing)
            {
                tempDrawer = (tempGraphics) => { currentFigure.PreDraw(tempGraphics, e.Location); };
                DrawOnTheTemp(tempDrawer);
            } else if (isMouseLeftButtonDown)
            {
                tempDrawer = (tempGraphics) => { currentFigure.DrawTarget(tempGraphics, e.Location); };
                DrawOnTheTemp(tempDrawer);
            }
            
        }
        private void DrawOnTheTemp(Drawer tempDrawer)
        {
            Graphics tempGraphics = Graphics.FromImage(tempBitmap);
            tempGraphics.Clear(Color.White);
            tempGraphics.DrawImage(bitmap, new Point(0,0));
            tempDrawer.Invoke(tempGraphics);
            Image = tempBitmap;
            tempGraphics.Dispose();
        }
        public void ChoosePenPalette()
        {
            isPenPaletteOpen = true;
        }
        public void ChooseFillPalette()
        {
            isPenPaletteOpen = false;
        }
        public void ColorButton_SetColor(object sender, EventArgs e)
        {
            Color choosenColor = ((Button)sender).BackColor;
            if (isPenPaletteOpen)
            {
                strokeColor = choosenColor;
            }
            else
            {
                fillColor = choosenColor;
            }
            CurrentFigureUpdate();
            DrawOnTheTemp((tempGraphics) => { currentFigure.PreDraw(tempGraphics, mouseCanvasPosition); });
        }
        public void ChangePenSize(int value)
        {
            strokeWidth = value;
            currentFigure.StrokeWidth = value;
            CurrentFigureUpdate();
            DrawOnTheTemp((tempGraphics) => { currentFigure.PreDraw(tempGraphics, mouseCanvasPosition); });
        }
        public void Clear()
        {
            if (!isCanvasEmpty)
            {
                figureKeeper.MakeReserve();
                currentFigure.CancelDrawing();
                graphics.Clear(Color.White);
                Image = bitmap;
                isCanvasEmpty = true;
            }
        }
        public void Undo()
        {
            figureKeeper.Undo();
            tempBitmap = new(bitmap);
            DrawOnTheTemp((tempGraphics) => { currentFigure.PreDraw(tempGraphics, mouseCanvasPosition); });
            tempBitmap.Dispose();
            Image = bitmap;
        }
        public void Redo()
        {
            figureKeeper.Redo();
            tempBitmap = new(bitmap);
            DrawOnTheTemp((tempGraphics) => { currentFigure.PreDraw(tempGraphics, mouseCanvasPosition); });
            tempBitmap.Dispose();
            Image = bitmap;
        }
        public void Save()
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
        public void Load()
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
                    isCanvasEmpty = false;
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
