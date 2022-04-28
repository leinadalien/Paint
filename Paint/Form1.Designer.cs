﻿namespace Paint
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
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearCanvasButton = new System.Windows.Forms.Button();
            this.standarFiguresPanel = new System.Windows.Forms.Panel();
            this.StandartFiguresLabel = new System.Windows.Forms.Label();
            this.penSizePanel = new System.Windows.Forms.Panel();
            this.maxPenSizeLabel = new System.Windows.Forms.Label();
            this.minPenSizeLabel = new System.Windows.Forms.Label();
            this.penSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.penSizeLabel = new System.Windows.Forms.Label();
            this.palettePanel = new System.Windows.Forms.FlowLayoutPanel();
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
            this.AddColor = new System.Windows.Forms.Button();
            this.canvasPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.toolsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.standarFiguresPanel.SuspendLayout();
            this.penSizePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penSizeTrackBar)).BeginInit();
            this.palettePanel.SuspendLayout();
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
            this.canvasPanel.Size = new System.Drawing.Size(1042, 673);
            this.canvasPanel.TabIndex = 0;
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(20, 20);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1002, 633);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // toolsPanel
            // 
            this.toolsPanel.BackColor = System.Drawing.Color.DimGray;
            this.toolsPanel.Controls.Add(this.panel1);
            this.toolsPanel.Controls.Add(this.standarFiguresPanel);
            this.toolsPanel.Controls.Add(this.penSizePanel);
            this.toolsPanel.Controls.Add(this.palettePanel);
            this.toolsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolsPanel.Location = new System.Drawing.Point(1042, 0);
            this.toolsPanel.Margin = new System.Windows.Forms.Padding(5);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Padding = new System.Windows.Forms.Padding(5);
            this.toolsPanel.Size = new System.Drawing.Size(220, 673);
            this.toolsPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clearCanvasButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 353);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 125);
            this.panel1.TabIndex = 4;
            // 
            // clearCanvasButton
            // 
            this.clearCanvasButton.BackColor = System.Drawing.Color.DarkGray;
            this.clearCanvasButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearCanvasButton.Location = new System.Drawing.Point(0, 0);
            this.clearCanvasButton.Name = "clearCanvasButton";
            this.clearCanvasButton.Size = new System.Drawing.Size(210, 125);
            this.clearCanvasButton.TabIndex = 0;
            this.clearCanvasButton.Text = "Clear";
            this.clearCanvasButton.UseVisualStyleBackColor = false;
            this.clearCanvasButton.Click += new System.EventHandler(this.clearCanvasButton_Click);
            // 
            // standarFiguresPanel
            // 
            this.standarFiguresPanel.BackColor = System.Drawing.Color.Transparent;
            this.standarFiguresPanel.Controls.Add(this.StandartFiguresLabel);
            this.standarFiguresPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.standarFiguresPanel.Location = new System.Drawing.Point(5, 228);
            this.standarFiguresPanel.Margin = new System.Windows.Forms.Padding(5);
            this.standarFiguresPanel.Name = "standarFiguresPanel";
            this.standarFiguresPanel.Padding = new System.Windows.Forms.Padding(5);
            this.standarFiguresPanel.Size = new System.Drawing.Size(210, 125);
            this.standarFiguresPanel.TabIndex = 1;
            // 
            // StandartFiguresLabel
            // 
            this.StandartFiguresLabel.BackColor = System.Drawing.Color.Gray;
            this.StandartFiguresLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StandartFiguresLabel.Location = new System.Drawing.Point(5, 5);
            this.StandartFiguresLabel.Margin = new System.Windows.Forms.Padding(5);
            this.StandartFiguresLabel.Name = "StandartFiguresLabel";
            this.StandartFiguresLabel.Size = new System.Drawing.Size(200, 25);
            this.StandartFiguresLabel.TabIndex = 0;
            this.StandartFiguresLabel.Text = "Standart figures";
            this.StandartFiguresLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // penSizePanel
            // 
            this.penSizePanel.AutoSize = true;
            this.penSizePanel.BackColor = System.Drawing.Color.Transparent;
            this.penSizePanel.Controls.Add(this.maxPenSizeLabel);
            this.penSizePanel.Controls.Add(this.minPenSizeLabel);
            this.penSizePanel.Controls.Add(this.penSizeTrackBar);
            this.penSizePanel.Controls.Add(this.penSizeLabel);
            this.penSizePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.penSizePanel.Location = new System.Drawing.Point(5, 130);
            this.penSizePanel.Margin = new System.Windows.Forms.Padding(5);
            this.penSizePanel.Name = "penSizePanel";
            this.penSizePanel.Padding = new System.Windows.Forms.Padding(5);
            this.penSizePanel.Size = new System.Drawing.Size(210, 98);
            this.penSizePanel.TabIndex = 2;
            // 
            // maxPenSizeLabel
            // 
            this.maxPenSizeLabel.Location = new System.Drawing.Point(175, 63);
            this.maxPenSizeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.maxPenSizeLabel.Name = "maxPenSizeLabel";
            this.maxPenSizeLabel.Size = new System.Drawing.Size(30, 30);
            this.maxPenSizeLabel.TabIndex = 3;
            this.maxPenSizeLabel.Text = "50";
            this.maxPenSizeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // minPenSizeLabel
            // 
            this.minPenSizeLabel.Location = new System.Drawing.Point(5, 63);
            this.minPenSizeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.minPenSizeLabel.Name = "minPenSizeLabel";
            this.minPenSizeLabel.Size = new System.Drawing.Size(30, 30);
            this.minPenSizeLabel.TabIndex = 2;
            this.minPenSizeLabel.Text = "1";
            this.minPenSizeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // penSizeTrackBar
            // 
            this.penSizeTrackBar.BackColor = System.Drawing.Color.DimGray;
            this.penSizeTrackBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.penSizeTrackBar.Location = new System.Drawing.Point(5, 30);
            this.penSizeTrackBar.Margin = new System.Windows.Forms.Padding(5);
            this.penSizeTrackBar.Maximum = 50;
            this.penSizeTrackBar.Minimum = 1;
            this.penSizeTrackBar.Name = "penSizeTrackBar";
            this.penSizeTrackBar.Size = new System.Drawing.Size(200, 56);
            this.penSizeTrackBar.TabIndex = 1;
            this.penSizeTrackBar.Value = 10;
            this.penSizeTrackBar.ValueChanged += new System.EventHandler(this.penSizeTrackBar_ValueChanged);
            // 
            // penSizeLabel
            // 
            this.penSizeLabel.BackColor = System.Drawing.Color.Gray;
            this.penSizeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.penSizeLabel.Location = new System.Drawing.Point(5, 5);
            this.penSizeLabel.Margin = new System.Windows.Forms.Padding(5);
            this.penSizeLabel.Name = "penSizeLabel";
            this.penSizeLabel.Size = new System.Drawing.Size(200, 25);
            this.penSizeLabel.TabIndex = 0;
            this.penSizeLabel.Text = "Pen size";
            this.penSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // palettePanel
            // 
            this.palettePanel.BackColor = System.Drawing.Color.Transparent;
            this.palettePanel.Controls.Add(this.colorButton1);
            this.palettePanel.Controls.Add(this.colorButton2);
            this.palettePanel.Controls.Add(this.colorButton3);
            this.palettePanel.Controls.Add(this.colorButton4);
            this.palettePanel.Controls.Add(this.colorButton5);
            this.palettePanel.Controls.Add(this.colorButton6);
            this.palettePanel.Controls.Add(this.colorButton7);
            this.palettePanel.Controls.Add(this.colorButton8);
            this.palettePanel.Controls.Add(this.colorButton9);
            this.palettePanel.Controls.Add(this.colorButton10);
            this.palettePanel.Controls.Add(this.AddColor);
            this.palettePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.palettePanel.Location = new System.Drawing.Point(5, 5);
            this.palettePanel.Margin = new System.Windows.Forms.Padding(5);
            this.palettePanel.Name = "palettePanel";
            this.palettePanel.Padding = new System.Windows.Forms.Padding(5);
            this.palettePanel.Size = new System.Drawing.Size(210, 125);
            this.palettePanel.TabIndex = 3;
            // 
            // colorButton1
            // 
            this.colorButton1.BackColor = System.Drawing.Color.Red;
            this.colorButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton1.Location = new System.Drawing.Point(10, 10);
            this.colorButton1.Margin = new System.Windows.Forms.Padding(5);
            this.colorButton1.Name = "colorButton1";
            this.colorButton1.Size = new System.Drawing.Size(30, 30);
            this.colorButton1.TabIndex = 0;
            this.colorButton1.UseVisualStyleBackColor = false;
            this.colorButton1.Click += new System.EventHandler(this.colorButton_SetPenColor);
            // 
            // colorButton2
            // 
            this.colorButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colorButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton2.Location = new System.Drawing.Point(50, 10);
            this.colorButton2.Margin = new System.Windows.Forms.Padding(5);
            this.colorButton2.Name = "colorButton2";
            this.colorButton2.Size = new System.Drawing.Size(30, 30);
            this.colorButton2.TabIndex = 1;
            this.colorButton2.UseVisualStyleBackColor = false;
            this.colorButton2.Click += new System.EventHandler(this.colorButton_SetPenColor);
            // 
            // colorButton3
            // 
            this.colorButton3.BackColor = System.Drawing.Color.Yellow;
            this.colorButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton3.Location = new System.Drawing.Point(90, 10);
            this.colorButton3.Margin = new System.Windows.Forms.Padding(5);
            this.colorButton3.Name = "colorButton3";
            this.colorButton3.Size = new System.Drawing.Size(30, 30);
            this.colorButton3.TabIndex = 2;
            this.colorButton3.UseVisualStyleBackColor = false;
            this.colorButton3.Click += new System.EventHandler(this.colorButton_SetPenColor);
            // 
            // colorButton4
            // 
            this.colorButton4.BackColor = System.Drawing.Color.Lime;
            this.colorButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton4.Location = new System.Drawing.Point(130, 10);
            this.colorButton4.Margin = new System.Windows.Forms.Padding(5);
            this.colorButton4.Name = "colorButton4";
            this.colorButton4.Size = new System.Drawing.Size(30, 30);
            this.colorButton4.TabIndex = 3;
            this.colorButton4.UseVisualStyleBackColor = false;
            this.colorButton4.Click += new System.EventHandler(this.colorButton_SetPenColor);
            // 
            // colorButton5
            // 
            this.colorButton5.BackColor = System.Drawing.Color.Cyan;
            this.colorButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton5.Location = new System.Drawing.Point(170, 10);
            this.colorButton5.Margin = new System.Windows.Forms.Padding(5);
            this.colorButton5.Name = "colorButton5";
            this.colorButton5.Size = new System.Drawing.Size(30, 30);
            this.colorButton5.TabIndex = 4;
            this.colorButton5.UseVisualStyleBackColor = false;
            this.colorButton5.Click += new System.EventHandler(this.colorButton_SetPenColor);
            // 
            // colorButton6
            // 
            this.colorButton6.BackColor = System.Drawing.Color.Blue;
            this.colorButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton6.Location = new System.Drawing.Point(10, 50);
            this.colorButton6.Margin = new System.Windows.Forms.Padding(5);
            this.colorButton6.Name = "colorButton6";
            this.colorButton6.Size = new System.Drawing.Size(30, 30);
            this.colorButton6.TabIndex = 5;
            this.colorButton6.UseVisualStyleBackColor = false;
            this.colorButton6.Click += new System.EventHandler(this.colorButton_SetPenColor);
            // 
            // colorButton7
            // 
            this.colorButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colorButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton7.Location = new System.Drawing.Point(50, 50);
            this.colorButton7.Margin = new System.Windows.Forms.Padding(5);
            this.colorButton7.Name = "colorButton7";
            this.colorButton7.Size = new System.Drawing.Size(30, 30);
            this.colorButton7.TabIndex = 6;
            this.colorButton7.UseVisualStyleBackColor = false;
            this.colorButton7.Click += new System.EventHandler(this.colorButton_SetPenColor);
            // 
            // colorButton8
            // 
            this.colorButton8.BackColor = System.Drawing.Color.White;
            this.colorButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton8.Location = new System.Drawing.Point(90, 50);
            this.colorButton8.Margin = new System.Windows.Forms.Padding(5);
            this.colorButton8.Name = "colorButton8";
            this.colorButton8.Size = new System.Drawing.Size(30, 30);
            this.colorButton8.TabIndex = 7;
            this.colorButton8.UseVisualStyleBackColor = false;
            this.colorButton8.Click += new System.EventHandler(this.colorButton_SetPenColor);
            // 
            // colorButton9
            // 
            this.colorButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.colorButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton9.Location = new System.Drawing.Point(130, 50);
            this.colorButton9.Margin = new System.Windows.Forms.Padding(5);
            this.colorButton9.Name = "colorButton9";
            this.colorButton9.Size = new System.Drawing.Size(30, 30);
            this.colorButton9.TabIndex = 8;
            this.colorButton9.UseVisualStyleBackColor = false;
            this.colorButton9.Click += new System.EventHandler(this.colorButton_SetPenColor);
            // 
            // colorButton10
            // 
            this.colorButton10.BackColor = System.Drawing.Color.Black;
            this.colorButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton10.Location = new System.Drawing.Point(170, 50);
            this.colorButton10.Margin = new System.Windows.Forms.Padding(5);
            this.colorButton10.Name = "colorButton10";
            this.colorButton10.Size = new System.Drawing.Size(30, 30);
            this.colorButton10.TabIndex = 9;
            this.colorButton10.UseVisualStyleBackColor = false;
            this.colorButton10.Click += new System.EventHandler(this.colorButton_SetPenColor);
            // 
            // AddColor
            // 
            this.AddColor.BackColor = System.Drawing.Color.DarkGray;
            this.AddColor.Location = new System.Drawing.Point(10, 90);
            this.AddColor.Margin = new System.Windows.Forms.Padding(5);
            this.AddColor.Name = "AddColor";
            this.AddColor.Size = new System.Drawing.Size(190, 30);
            this.AddColor.TabIndex = 10;
            this.AddColor.Text = "Another color";
            this.AddColor.UseVisualStyleBackColor = false;
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
            this.toolsPanel.ResumeLayout(false);
            this.toolsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.standarFiguresPanel.ResumeLayout(false);
            this.penSizePanel.ResumeLayout(false);
            this.penSizePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penSizeTrackBar)).EndInit();
            this.palettePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel canvasPanel;
        private PictureBox canvas;
        private Panel toolsPanel;
        private Button AddColor;
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
        private Panel standarFiguresPanel;
        private Label StandartFiguresLabel;
        private Panel penSizePanel;
        private TrackBar penSizeTrackBar;
        private Label penSizeLabel;
        private FlowLayoutPanel palettePanel;
        private Panel panel1;
        private Button clearCanvasButton;
        private Label maxPenSizeLabel;
        private Label minPenSizeLabel;
    }
}