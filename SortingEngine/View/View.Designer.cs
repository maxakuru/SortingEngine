namespace SortingEngine
{
    partial class View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.exitBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.sortingMethod = new System.Windows.Forms.ComboBox();
            this.arraySizeBar = new System.Windows.Forms.TrackBar();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.arraySize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.arraySizeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(619, 442);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(396, 442);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 1;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(300, 442);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(75, 23);
            this.sortBtn.TabIndex = 2;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            // 
            // sortingMethod
            // 
            this.sortingMethod.FormattingEnabled = true;
            this.sortingMethod.Items.AddRange(new object[] {
            "Selection Sort",
            "Merge Sort"});
            this.sortingMethod.Location = new System.Drawing.Point(112, 442);
            this.sortingMethod.Name = "sortingMethod";
            this.sortingMethod.Size = new System.Drawing.Size(165, 21);
            this.sortingMethod.TabIndex = 3;
            // 
            // arraySizeBar
            // 
            this.arraySizeBar.LargeChange = 2;
            this.arraySizeBar.Location = new System.Drawing.Point(87, 380);
            this.arraySizeBar.Maximum = 128;
            this.arraySizeBar.Minimum = 32;
            this.arraySizeBar.Name = "arraySizeBar";
            this.arraySizeBar.Size = new System.Drawing.Size(555, 45);
            this.arraySizeBar.TabIndex = 4;
            this.arraySizeBar.TickFrequency = 4;
            this.arraySizeBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.arraySizeBar.Value = 32;
            // 
            // canvas
            // 
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Location = new System.Drawing.Point(12, 33);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(682, 320);
            this.canvas.TabIndex = 5;
            this.canvas.TabStop = false;
            // 
            // arraySize
            // 
            this.arraySize.Location = new System.Drawing.Point(648, 392);
            this.arraySize.Name = "arraySize";
            this.arraySize.Size = new System.Drawing.Size(46, 20);
            this.arraySize.TabIndex = 6;
            this.arraySize.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Array Size :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sorting Method :";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 485);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arraySize);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.arraySizeBar);
            this.Controls.Add(this.sortingMethod);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.exitBtn);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "View";
            this.Text = "Sort Engine";
            ((System.ComponentModel.ISupportInitialize)(this.arraySizeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.ComboBox sortingMethod;
        private System.Windows.Forms.TrackBar arraySizeBar;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.TextBox arraySize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

