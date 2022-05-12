namespace Paint
{
    partial class PaintForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.palettePanel = new System.Windows.Forms.Panel();
            this.switchColorPanel = new System.Windows.Forms.Panel();
            this.fillColorLabel = new System.Windows.Forms.Label();
            this.penColorLabel = new System.Windows.Forms.Label();
            this.paletteFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.colorButton1 = new System.Windows.Forms.Button();
            this.colorButton2 = new System.Windows.Forms.Button();
            this.colorButton3 = new System.Windows.Forms.Button();
            this.colorButton4 = new System.Windows.Forms.Button();
            this.colorButton5 = new System.Windows.Forms.Button();
            this.colorButton6 = new System.Windows.Forms.Button();
            this.colorButton7 = new System.Windows.Forms.Button();
            this.colorButton8 = new System.Windows.Forms.Button();
            this.colorButton9 = new System.Windows.Forms.Button();
            this.colorButton10 = new System.Windows.Forms.Button();
            this.paletteLabel = new System.Windows.Forms.Label();
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.figuresPanel = new System.Windows.Forms.Panel();
            this.figuresFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.figuresLabel = new System.Windows.Forms.Label();
            this.undoRedoPanel = new System.Windows.Forms.Panel();
            this.RedoButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.penSizePanel = new System.Windows.Forms.Panel();
            this.minPenSizeLabel = new System.Windows.Forms.Label();
            this.maxPenSizeLabel = new System.Windows.Forms.Label();
            this.penSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.penSizeLabel = new System.Windows.Forms.Label();
            this.clearCanvasPanel = new System.Windows.Forms.Panel();
            this.clearCanvasButton = new System.Windows.Forms.Button();
            this.projectPanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.importFiguresDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.canvasPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.palettePanel.SuspendLayout();
            this.switchColorPanel.SuspendLayout();
            this.paletteFlowLayoutPanel.SuspendLayout();
            this.toolsPanel.SuspendLayout();
            this.figuresPanel.SuspendLayout();
            this.undoRedoPanel.SuspendLayout();
            this.penSizePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penSizeTrackBar)).BeginInit();
            this.clearCanvasPanel.SuspendLayout();
            this.projectPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvasPanel
            // 
            this.canvasPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.canvasPanel.Controls.Add(this.canvas);
            this.canvasPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.canvasPanel.Location = new System.Drawing.Point(0, 0);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Padding = new System.Windows.Forms.Padding(20);
            this.canvasPanel.Size = new System.Drawing.Size(1032, 673);
            this.canvasPanel.TabIndex = 0;
            this.canvasPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CanvasPanel_MouseMove);
            this.canvasPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CanvasPanel_MouseUp);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(20, 20);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(992, 633);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // palettePanel
            // 
            this.palettePanel.BackColor = System.Drawing.Color.Transparent;
            this.palettePanel.Controls.Add(this.switchColorPanel);
            this.palettePanel.Controls.Add(this.paletteFlowLayoutPanel);
            this.palettePanel.Controls.Add(this.paletteLabel);
            this.palettePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.palettePanel.Location = new System.Drawing.Point(5, 65);
            this.palettePanel.Margin = new System.Windows.Forms.Padding(5);
            this.palettePanel.Name = "palettePanel";
            this.palettePanel.Padding = new System.Windows.Forms.Padding(5);
            this.palettePanel.Size = new System.Drawing.Size(220, 168);
            this.palettePanel.TabIndex = 1;
            // 
            // switchColorPanel
            // 
            this.switchColorPanel.Controls.Add(this.fillColorLabel);
            this.switchColorPanel.Controls.Add(this.penColorLabel);
            this.switchColorPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.switchColorPanel.Location = new System.Drawing.Point(5, 118);
            this.switchColorPanel.Name = "switchColorPanel";
            this.switchColorPanel.Size = new System.Drawing.Size(210, 45);
            this.switchColorPanel.TabIndex = 5;
            // 
            // fillColorLabel
            // 
            this.fillColorLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fillColorLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.fillColorLabel.ForeColor = System.Drawing.Color.Black;
            this.fillColorLabel.Location = new System.Drawing.Point(105, 0);
            this.fillColorLabel.Margin = new System.Windows.Forms.Padding(5);
            this.fillColorLabel.Name = "fillColorLabel";
            this.fillColorLabel.Size = new System.Drawing.Size(105, 45);
            this.fillColorLabel.TabIndex = 1;
            this.fillColorLabel.Text = "Fill";
            this.fillColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fillColorLabel.Click += new System.EventHandler(this.FillColorLabel_Click);
            // 
            // penColorLabel
            // 
            this.penColorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.penColorLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.penColorLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.penColorLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.penColorLabel.Location = new System.Drawing.Point(0, 0);
            this.penColorLabel.Margin = new System.Windows.Forms.Padding(5);
            this.penColorLabel.Name = "penColorLabel";
            this.penColorLabel.Size = new System.Drawing.Size(105, 45);
            this.penColorLabel.TabIndex = 0;
            this.penColorLabel.Text = "Pen";
            this.penColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.penColorLabel.Click += new System.EventHandler(this.PenColorLabel_Click);
            // 
            // paletteFlowLayoutPanel
            // 
            this.paletteFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.paletteFlowLayoutPanel.Controls.Add(this.colorButton1);
            this.paletteFlowLayoutPanel.Controls.Add(this.colorButton2);
            this.paletteFlowLayoutPanel.Controls.Add(this.colorButton3);
            this.paletteFlowLayoutPanel.Controls.Add(this.colorButton4);
            this.paletteFlowLayoutPanel.Controls.Add(this.colorButton5);
            this.paletteFlowLayoutPanel.Controls.Add(this.colorButton6);
            this.paletteFlowLayoutPanel.Controls.Add(this.colorButton7);
            this.paletteFlowLayoutPanel.Controls.Add(this.colorButton8);
            this.paletteFlowLayoutPanel.Controls.Add(this.colorButton9);
            this.paletteFlowLayoutPanel.Controls.Add(this.colorButton10);
            this.paletteFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paletteFlowLayoutPanel.Location = new System.Drawing.Point(5, 30);
            this.paletteFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(5);
            this.paletteFlowLayoutPanel.Name = "paletteFlowLayoutPanel";
            this.paletteFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.paletteFlowLayoutPanel.Size = new System.Drawing.Size(210, 133);
            this.paletteFlowLayoutPanel.TabIndex = 3;
            // 
            // colorButton1
            // 
            this.colorButton1.BackColor = System.Drawing.Color.Red;
            this.colorButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton1.Location = new System.Drawing.Point(10, 10);
            this.colorButton1.Margin = new System.Windows.Forms.Padding(5);
            this.colorButton1.Name = "colorButton1";
            this.colorButton1.Size = new System.Drawing.Size(30, 30);
            this.colorButton1.TabIndex = 0;
            this.colorButton1.UseVisualStyleBackColor = false;
            this.colorButton1.Click += new System.EventHandler(this.ColorButton_SetColor);
            // 
            // colorButton2
            // 
            this.colorButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colorButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton2.Location = new System.Drawing.Point(50, 10);
            this.colorButton2.Margin = new System.Windows.Forms.Padding(5);
            this.colorButton2.Name = "colorButton2";
            this.colorButton2.Size = new System.Drawing.Size(30, 30);
            this.colorButton2.TabIndex = 1;
            this.colorButton2.UseVisualStyleBackColor = false;
            this.colorButton2.Click += new System.EventHandler(this.ColorButton_SetColor);
            // 
            // colorButton3
            // 
            this.colorButton3.BackColor = System.Drawing.Color.Yellow;
            this.colorButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton3.Location = new System.Drawing.Point(90, 10);
            this.colorButton3.Margin = new System.Windows.Forms.Padding(5);
            this.colorButton3.Name = "colorButton3";
            this.colorButton3.Size = new System.Drawing.Size(30, 30);
            this.colorButton3.TabIndex = 2;
            this.colorButton3.UseVisualStyleBackColor = false;
            this.colorButton3.Click += new System.EventHandler(this.ColorButton_SetColor);
            // 
            // colorButton4
            // 
            this.colorButton4.BackColor = System.Drawing.Color.Lime;
            this.colorButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton4.Location = new System.Drawing.Point(130, 10);
            this.colorButton4.Margin = new System.Windows.Forms.Padding(5);
            this.colorButton4.Name = "colorButton4";
            this.colorButton4.Size = new System.Drawing.Size(30, 30);
            this.colorButton4.TabIndex = 3;
            this.colorButton4.UseVisualStyleBackColor = false;
            this.colorButton4.Click += new System.EventHandler(this.ColorButton_SetColor);
            // 
            // colorButton5
            // 
            this.colorButton5.BackColor = System.Drawing.Color.Cyan;
            this.colorButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton5.Location = new System.Drawing.Point(170, 10);
            this.colorButton5.Margin = new System.Windows.Forms.Padding(5);
            this.colorButton5.Name = "colorButton5";
            this.colorButton5.Size = new System.Drawing.Size(30, 30);
            this.colorButton5.TabIndex = 4;
            this.colorButton5.UseVisualStyleBackColor = false;
            this.colorButton5.Click += new System.EventHandler(this.ColorButton_SetColor);
            // 
            // colorButton6
            // 
            this.colorButton6.BackColor = System.Drawing.Color.Blue;
            this.colorButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton6.Location = new System.Drawing.Point(10, 50);
            this.colorButton6.Margin = new System.Windows.Forms.Padding(5);
            this.colorButton6.Name = "colorButton6";
            this.colorButton6.Size = new System.Drawing.Size(30, 30);
            this.colorButton6.TabIndex = 5;
            this.colorButton6.UseVisualStyleBackColor = false;
            this.colorButton6.Click += new System.EventHandler(this.ColorButton_SetColor);
            // 
            // colorButton7
            // 
            this.colorButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colorButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton7.Location = new System.Drawing.Point(50, 50);
            this.colorButton7.Margin = new System.Windows.Forms.Padding(5);
            this.colorButton7.Name = "colorButton7";
            this.colorButton7.Size = new System.Drawing.Size(30, 30);
            this.colorButton7.TabIndex = 6;
            this.colorButton7.UseVisualStyleBackColor = false;
            this.colorButton7.Click += new System.EventHandler(this.ColorButton_SetColor);
            // 
            // colorButton8
            // 
            this.colorButton8.BackColor = System.Drawing.Color.White;
            this.colorButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton8.Location = new System.Drawing.Point(90, 50);
            this.colorButton8.Margin = new System.Windows.Forms.Padding(5);
            this.colorButton8.Name = "colorButton8";
            this.colorButton8.Size = new System.Drawing.Size(30, 30);
            this.colorButton8.TabIndex = 7;
            this.colorButton8.UseVisualStyleBackColor = false;
            this.colorButton8.Click += new System.EventHandler(this.ColorButton_SetColor);
            // 
            // colorButton9
            // 
            this.colorButton9.BackColor = System.Drawing.Color.Black;
            this.colorButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton9.Location = new System.Drawing.Point(130, 50);
            this.colorButton9.Margin = new System.Windows.Forms.Padding(5);
            this.colorButton9.Name = "colorButton9";
            this.colorButton9.Size = new System.Drawing.Size(30, 30);
            this.colorButton9.TabIndex = 8;
            this.colorButton9.UseVisualStyleBackColor = false;
            this.colorButton9.Click += new System.EventHandler(this.ColorButton_SetColor);
            // 
            // colorButton10
            // 
            this.colorButton10.BackColor = System.Drawing.Color.Transparent;
            this.colorButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton10.Location = new System.Drawing.Point(170, 50);
            this.colorButton10.Margin = new System.Windows.Forms.Padding(5);
            this.colorButton10.Name = "colorButton10";
            this.colorButton10.Size = new System.Drawing.Size(30, 30);
            this.colorButton10.TabIndex = 9;
            this.colorButton10.UseVisualStyleBackColor = false;
            this.colorButton10.Click += new System.EventHandler(this.ColorButton_SetColor);
            // 
            // paletteLabel
            // 
            this.paletteLabel.BackColor = System.Drawing.Color.Gray;
            this.paletteLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.paletteLabel.Location = new System.Drawing.Point(5, 5);
            this.paletteLabel.Margin = new System.Windows.Forms.Padding(5);
            this.paletteLabel.Name = "paletteLabel";
            this.paletteLabel.Size = new System.Drawing.Size(210, 25);
            this.paletteLabel.TabIndex = 4;
            this.paletteLabel.Text = "Color palette";
            this.paletteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolsPanel
            // 
            this.toolsPanel.BackColor = System.Drawing.Color.DimGray;
            this.toolsPanel.Controls.Add(this.figuresPanel);
            this.toolsPanel.Controls.Add(this.undoRedoPanel);
            this.toolsPanel.Controls.Add(this.penSizePanel);
            this.toolsPanel.Controls.Add(this.palettePanel);
            this.toolsPanel.Controls.Add(this.clearCanvasPanel);
            this.toolsPanel.Controls.Add(this.projectPanel);
            this.toolsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolsPanel.Location = new System.Drawing.Point(1032, 0);
            this.toolsPanel.Margin = new System.Windows.Forms.Padding(5);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Padding = new System.Windows.Forms.Padding(5);
            this.toolsPanel.Size = new System.Drawing.Size(230, 673);
            this.toolsPanel.TabIndex = 4;
            // 
            // figuresPanel
            // 
            this.figuresPanel.BackColor = System.Drawing.Color.Transparent;
            this.figuresPanel.Controls.Add(this.figuresFlowLayoutPanel);
            this.figuresPanel.Controls.Add(this.figuresLabel);
            this.figuresPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figuresPanel.Location = new System.Drawing.Point(5, 324);
            this.figuresPanel.Margin = new System.Windows.Forms.Padding(5);
            this.figuresPanel.Name = "figuresPanel";
            this.figuresPanel.Padding = new System.Windows.Forms.Padding(5);
            this.figuresPanel.Size = new System.Drawing.Size(220, 204);
            this.figuresPanel.TabIndex = 1;
            // 
            // figuresFlowLayoutPanel
            // 
            this.figuresFlowLayoutPanel.AutoScroll = true;
            this.figuresFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.figuresFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figuresFlowLayoutPanel.Location = new System.Drawing.Point(5, 30);
            this.figuresFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.figuresFlowLayoutPanel.Name = "figuresFlowLayoutPanel";
            this.figuresFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.figuresFlowLayoutPanel.Size = new System.Drawing.Size(210, 169);
            this.figuresFlowLayoutPanel.TabIndex = 5;
            // 
            // figuresLabel
            // 
            this.figuresLabel.BackColor = System.Drawing.Color.Gray;
            this.figuresLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.figuresLabel.Location = new System.Drawing.Point(5, 5);
            this.figuresLabel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.figuresLabel.Name = "figuresLabel";
            this.figuresLabel.Size = new System.Drawing.Size(210, 25);
            this.figuresLabel.TabIndex = 0;
            this.figuresLabel.Text = "Figures";
            this.figuresLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // undoRedoPanel
            // 
            this.undoRedoPanel.Controls.Add(this.RedoButton);
            this.undoRedoPanel.Controls.Add(this.undoButton);
            this.undoRedoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.undoRedoPanel.Location = new System.Drawing.Point(5, 528);
            this.undoRedoPanel.Margin = new System.Windows.Forms.Padding(5);
            this.undoRedoPanel.Name = "undoRedoPanel";
            this.undoRedoPanel.Padding = new System.Windows.Forms.Padding(5);
            this.undoRedoPanel.Size = new System.Drawing.Size(220, 60);
            this.undoRedoPanel.TabIndex = 5;
            // 
            // RedoButton
            // 
            this.RedoButton.BackColor = System.Drawing.Color.DarkGray;
            this.RedoButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.RedoButton.Location = new System.Drawing.Point(110, 5);
            this.RedoButton.Margin = new System.Windows.Forms.Padding(5);
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(105, 50);
            this.RedoButton.TabIndex = 1;
            this.RedoButton.Text = "Redo";
            this.RedoButton.UseVisualStyleBackColor = false;
            this.RedoButton.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.BackColor = System.Drawing.Color.DarkGray;
            this.undoButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.undoButton.Location = new System.Drawing.Point(5, 5);
            this.undoButton.Margin = new System.Windows.Forms.Padding(5);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(105, 50);
            this.undoButton.TabIndex = 0;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = false;
            this.undoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // penSizePanel
            // 
            this.penSizePanel.AutoSize = true;
            this.penSizePanel.BackColor = System.Drawing.Color.Transparent;
            this.penSizePanel.Controls.Add(this.minPenSizeLabel);
            this.penSizePanel.Controls.Add(this.maxPenSizeLabel);
            this.penSizePanel.Controls.Add(this.penSizeTrackBar);
            this.penSizePanel.Controls.Add(this.penSizeLabel);
            this.penSizePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.penSizePanel.Location = new System.Drawing.Point(5, 233);
            this.penSizePanel.Margin = new System.Windows.Forms.Padding(5);
            this.penSizePanel.Name = "penSizePanel";
            this.penSizePanel.Padding = new System.Windows.Forms.Padding(5);
            this.penSizePanel.Size = new System.Drawing.Size(220, 91);
            this.penSizePanel.TabIndex = 2;
            // 
            // minPenSizeLabel
            // 
            this.minPenSizeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minPenSizeLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.minPenSizeLabel.Location = new System.Drawing.Point(5, 66);
            this.minPenSizeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.minPenSizeLabel.Name = "minPenSizeLabel";
            this.minPenSizeLabel.Size = new System.Drawing.Size(30, 20);
            this.minPenSizeLabel.TabIndex = 2;
            this.minPenSizeLabel.Text = "1";
            this.minPenSizeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // maxPenSizeLabel
            // 
            this.maxPenSizeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maxPenSizeLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.maxPenSizeLabel.Location = new System.Drawing.Point(175, 66);
            this.maxPenSizeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.maxPenSizeLabel.Name = "maxPenSizeLabel";
            this.maxPenSizeLabel.Size = new System.Drawing.Size(30, 20);
            this.maxPenSizeLabel.TabIndex = 3;
            this.maxPenSizeLabel.Text = "50";
            this.maxPenSizeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // penSizeTrackBar
            // 
            this.penSizeTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.penSizeTrackBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.penSizeTrackBar.Location = new System.Drawing.Point(5, 30);
            this.penSizeTrackBar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.penSizeTrackBar.Maximum = 50;
            this.penSizeTrackBar.Minimum = 1;
            this.penSizeTrackBar.Name = "penSizeTrackBar";
            this.penSizeTrackBar.Size = new System.Drawing.Size(210, 56);
            this.penSizeTrackBar.TabIndex = 1;
            this.penSizeTrackBar.Value = 10;
            this.penSizeTrackBar.ValueChanged += new System.EventHandler(this.PenSizeTrackBar_ValueChanged);
            // 
            // penSizeLabel
            // 
            this.penSizeLabel.BackColor = System.Drawing.Color.Gray;
            this.penSizeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.penSizeLabel.Location = new System.Drawing.Point(5, 5);
            this.penSizeLabel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.penSizeLabel.Name = "penSizeLabel";
            this.penSizeLabel.Size = new System.Drawing.Size(210, 25);
            this.penSizeLabel.TabIndex = 0;
            this.penSizeLabel.Text = "Pen size";
            this.penSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearCanvasPanel
            // 
            this.clearCanvasPanel.Controls.Add(this.clearCanvasButton);
            this.clearCanvasPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clearCanvasPanel.Location = new System.Drawing.Point(5, 588);
            this.clearCanvasPanel.Margin = new System.Windows.Forms.Padding(5);
            this.clearCanvasPanel.Name = "clearCanvasPanel";
            this.clearCanvasPanel.Padding = new System.Windows.Forms.Padding(5);
            this.clearCanvasPanel.Size = new System.Drawing.Size(220, 80);
            this.clearCanvasPanel.TabIndex = 5;
            // 
            // clearCanvasButton
            // 
            this.clearCanvasButton.BackColor = System.Drawing.Color.DarkGray;
            this.clearCanvasButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearCanvasButton.Location = new System.Drawing.Point(5, 5);
            this.clearCanvasButton.Margin = new System.Windows.Forms.Padding(5);
            this.clearCanvasButton.Name = "clearCanvasButton";
            this.clearCanvasButton.Size = new System.Drawing.Size(210, 70);
            this.clearCanvasButton.TabIndex = 0;
            this.clearCanvasButton.Text = "Clear";
            this.clearCanvasButton.UseVisualStyleBackColor = false;
            this.clearCanvasButton.Click += new System.EventHandler(this.ClearCanvasButton_Click);
            // 
            // projectPanel
            // 
            this.projectPanel.Controls.Add(this.saveButton);
            this.projectPanel.Controls.Add(this.loadButton);
            this.projectPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.projectPanel.Location = new System.Drawing.Point(5, 5);
            this.projectPanel.Margin = new System.Windows.Forms.Padding(5);
            this.projectPanel.Name = "projectPanel";
            this.projectPanel.Padding = new System.Windows.Forms.Padding(5);
            this.projectPanel.Size = new System.Drawing.Size(220, 60);
            this.projectPanel.TabIndex = 6;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DarkGray;
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveButton.Location = new System.Drawing.Point(110, 5);
            this.saveButton.Margin = new System.Windows.Forms.Padding(5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(105, 50);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.DarkGray;
            this.loadButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.loadButton.Location = new System.Drawing.Point(5, 5);
            this.loadButton.Margin = new System.Windows.Forms.Padding(5);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(105, 50);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // importFiguresDialog
            // 
            this.importFiguresDialog.Filter = "(*.dll)|*.dll";
            this.importFiguresDialog.Title = "Import figure";
            // 
            // saveDialog
            // 
            this.saveDialog.CheckPathExists = false;
            this.saveDialog.DefaultExt = "*.jpg";
            this.saveDialog.Filter = "(*.json)|*.json";
            this.saveDialog.Title = "Save drawing";
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.toolsPanel);
            this.Controls.Add(this.canvasPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PaintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.canvasPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.palettePanel.ResumeLayout(false);
            this.switchColorPanel.ResumeLayout(false);
            this.paletteFlowLayoutPanel.ResumeLayout(false);
            this.toolsPanel.ResumeLayout(false);
            this.toolsPanel.PerformLayout();
            this.figuresPanel.ResumeLayout(false);
            this.undoRedoPanel.ResumeLayout(false);
            this.penSizePanel.ResumeLayout(false);
            this.penSizePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penSizeTrackBar)).EndInit();
            this.clearCanvasPanel.ResumeLayout(false);
            this.projectPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel canvasPanel;
        private PictureBox canvas;
        private Panel toolsPanel;
        private Button colorButton10;
        private Button colorButton9;
        private Button colorButton8;
        private Button colorButton7;
        private Button colorButton6;
        private Button colorButton5;
        private Button colorButton4;
        private Button colorButton3;
        private Button colorButton2;
        private Button colorButton1;
        private Panel figuresPanel;
        private Label figuresLabel;
        private Panel penSizePanel;
        private TrackBar penSizeTrackBar;
        private Label penSizeLabel;
        private FlowLayoutPanel paletteFlowLayoutPanel;
        private Panel clearCanvasPanel;
        private Button clearCanvasButton;
        private Label maxPenSizeLabel;
        private Label minPenSizeLabel;
        private FlowLayoutPanel figuresFlowLayoutPanel;
        private Label paletteLabel;
        private Panel palettePanel;
        private Panel undoRedoPanel;
        private Button RedoButton;
        private Button undoButton;
        private Panel switchColorPanel;
        private Label fillColorLabel;
        private Label penColorLabel;
        private OpenFileDialog importFiguresDialog;
        private Panel projectPanel;
        private Button saveButton;
        private Button loadButton;
        private SaveFileDialog saveDialog;
    }
}