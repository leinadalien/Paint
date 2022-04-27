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
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.colorPickerPanel = new System.Windows.Forms.Panel();
            this.canvasPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.toolsPanel.SuspendLayout();
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
            this.canvasPanel.Size = new System.Drawing.Size(1000, 673);
            this.canvasPanel.TabIndex = 0;
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(20, 20);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(960, 633);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            // 
            // toolsPanel
            // 
            this.toolsPanel.BackColor = System.Drawing.Color.Gray;
            this.toolsPanel.Controls.Add(this.colorPickerPanel);
            this.toolsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolsPanel.Location = new System.Drawing.Point(1000, 0);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(262, 673);
            this.toolsPanel.TabIndex = 1;
            // 
            // colorPickerPanel
            // 
            this.colorPickerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorPickerPanel.Location = new System.Drawing.Point(0, 0);
            this.colorPickerPanel.Name = "colorPickerPanel";
            this.colorPickerPanel.Size = new System.Drawing.Size(262, 125);
            this.colorPickerPanel.TabIndex = 0;
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
            this.Text = "Form1";
            this.canvasPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.toolsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel canvasPanel;
        private PictureBox canvas;
        private Panel toolsPanel;
        private Panel colorPickerPanel;
    }
}