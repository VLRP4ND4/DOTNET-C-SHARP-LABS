namespace LAB_12
{
    partial class PhotoEditorForm
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
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.buttonThreshold = new System.Windows.Forms.Button();
            this.buttonBrightness = new System.Windows.Forms.Button();
            this.buttonContrast = new System.Windows.Forms.Button();
            this.buttonBlur = new System.Windows.Forms.Button();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.trackBarContrast = new System.Windows.Forms.TrackBar();
            this.trackBarBlur = new System.Windows.Forms.TrackBar();
            this.trackBarThreshold = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сброситьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelBrightnessValue = new System.Windows.Forms.Label();
            this.labelContrastValue = new System.Windows.Forms.Label();
            this.labelSharpenValue = new System.Windows.Forms.Label();
            this.labelThresholdValue = new System.Windows.Forms.Label();
            this.numericWidth = new System.Windows.Forms.NumericUpDown();
            this.labelW = new System.Windows.Forms.Label();
            this.labelH = new System.Windows.Forms.Label();
            this.numericHeight = new System.Windows.Forms.NumericUpDown();
            this.labelBlurValue = new System.Windows.Forms.Label();
            this.trackBarSharpen = new System.Windows.Forms.TrackBar();
            this.buttonSharpen = new System.Windows.Forms.Button();
            this.buttonResize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSharpen)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOriginal.Location = new System.Drawing.Point(12, 27);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(600, 400);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOriginal.TabIndex = 0;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxResult.Location = new System.Drawing.Point(664, 27);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(600, 400);
            this.pictureBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxResult.TabIndex = 1;
            this.pictureBoxResult.TabStop = false;
            // 
            // buttonThreshold
            // 
            this.buttonThreshold.Location = new System.Drawing.Point(58, 702);
            this.buttonThreshold.Name = "buttonThreshold";
            this.buttonThreshold.Size = new System.Drawing.Size(202, 46);
            this.buttonThreshold.TabIndex = 3;
            this.buttonThreshold.Text = "Бинаризация";
            this.buttonThreshold.UseVisualStyleBackColor = true;
            // 
            // buttonBrightness
            // 
            this.buttonBrightness.Location = new System.Drawing.Point(58, 442);
            this.buttonBrightness.Name = "buttonBrightness";
            this.buttonBrightness.Size = new System.Drawing.Size(202, 46);
            this.buttonBrightness.TabIndex = 4;
            this.buttonBrightness.Text = "Яркость";
            this.buttonBrightness.UseVisualStyleBackColor = true;
            // 
            // buttonContrast
            // 
            this.buttonContrast.Location = new System.Drawing.Point(58, 494);
            this.buttonContrast.Name = "buttonContrast";
            this.buttonContrast.Size = new System.Drawing.Size(202, 46);
            this.buttonContrast.TabIndex = 5;
            this.buttonContrast.Text = "Контраст";
            this.buttonContrast.UseVisualStyleBackColor = true;
            // 
            // buttonBlur
            // 
            this.buttonBlur.Location = new System.Drawing.Point(58, 650);
            this.buttonBlur.Name = "buttonBlur";
            this.buttonBlur.Size = new System.Drawing.Size(202, 46);
            this.buttonBlur.TabIndex = 7;
            this.buttonBlur.Text = "Сглаживание";
            this.buttonBlur.UseVisualStyleBackColor = true;
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.Location = new System.Drawing.Point(266, 452);
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(817, 45);
            this.trackBarBrightness.TabIndex = 9;
            // 
            // trackBarContrast
            // 
            this.trackBarContrast.Location = new System.Drawing.Point(266, 503);
            this.trackBarContrast.Name = "trackBarContrast";
            this.trackBarContrast.Size = new System.Drawing.Size(817, 45);
            this.trackBarContrast.TabIndex = 10;
            // 
            // trackBarBlur
            // 
            this.trackBarBlur.Location = new System.Drawing.Point(266, 660);
            this.trackBarBlur.Name = "trackBarBlur";
            this.trackBarBlur.Size = new System.Drawing.Size(817, 45);
            this.trackBarBlur.TabIndex = 12;
            // 
            // trackBarThreshold
            // 
            this.trackBarThreshold.Location = new System.Drawing.Point(266, 711);
            this.trackBarThreshold.Name = "trackBarThreshold";
            this.trackBarThreshold.Size = new System.Drawing.Size(817, 45);
            this.trackBarThreshold.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сброситьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузиттToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сброситьToolStripMenuItem
            // 
            this.сброситьToolStripMenuItem.Name = "сброситьToolStripMenuItem";
            this.сброситьToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.сброситьToolStripMenuItem.Text = "Сбросить";
            // 
            // labelBrightnessValue
            // 
            this.labelBrightnessValue.AutoSize = true;
            this.labelBrightnessValue.Location = new System.Drawing.Point(1089, 452);
            this.labelBrightnessValue.Name = "labelBrightnessValue";
            this.labelBrightnessValue.Size = new System.Drawing.Size(66, 13);
            this.labelBrightnessValue.TabIndex = 15;
            this.labelBrightnessValue.Text = "значение: 0";
            this.labelBrightnessValue.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelContrastValue
            // 
            this.labelContrastValue.AutoSize = true;
            this.labelContrastValue.Location = new System.Drawing.Point(1089, 503);
            this.labelContrastValue.Name = "labelContrastValue";
            this.labelContrastValue.Size = new System.Drawing.Size(66, 13);
            this.labelContrastValue.TabIndex = 16;
            this.labelContrastValue.Text = "значение: 0";
            // 
            // labelSharpenValue
            // 
            this.labelSharpenValue.AutoSize = true;
            this.labelSharpenValue.Location = new System.Drawing.Point(1089, 608);
            this.labelSharpenValue.Name = "labelSharpenValue";
            this.labelSharpenValue.Size = new System.Drawing.Size(66, 13);
            this.labelSharpenValue.TabIndex = 17;
            this.labelSharpenValue.Text = "значение: 0";
            // 
            // labelThresholdValue
            // 
            this.labelThresholdValue.AutoSize = true;
            this.labelThresholdValue.Location = new System.Drawing.Point(1089, 711);
            this.labelThresholdValue.Name = "labelThresholdValue";
            this.labelThresholdValue.Size = new System.Drawing.Size(66, 13);
            this.labelThresholdValue.TabIndex = 18;
            this.labelThresholdValue.Text = "значение: 0";
            // 
            // numericWidth
            // 
            this.numericWidth.Location = new System.Drawing.Point(266, 561);
            this.numericWidth.Name = "numericWidth";
            this.numericWidth.Size = new System.Drawing.Size(344, 20);
            this.numericWidth.TabIndex = 20;
            // 
            // labelW
            // 
            this.labelW.AutoSize = true;
            this.labelW.Location = new System.Drawing.Point(614, 563);
            this.labelW.Name = "labelW";
            this.labelW.Size = new System.Drawing.Size(45, 13);
            this.labelW.TabIndex = 21;
            this.labelW.Text = "ширина";
            this.labelW.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Location = new System.Drawing.Point(1040, 563);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(44, 13);
            this.labelH.TabIndex = 23;
            this.labelH.Text = "высота";
            this.labelH.Click += new System.EventHandler(this.label7_Click);
            // 
            // numericHeight
            // 
            this.numericHeight.Location = new System.Drawing.Point(690, 561);
            this.numericHeight.Name = "numericHeight";
            this.numericHeight.Size = new System.Drawing.Size(344, 20);
            this.numericHeight.TabIndex = 22;
            this.numericHeight.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // labelBlurValue
            // 
            this.labelBlurValue.AutoSize = true;
            this.labelBlurValue.Location = new System.Drawing.Point(1089, 660);
            this.labelBlurValue.Name = "labelBlurValue";
            this.labelBlurValue.Size = new System.Drawing.Size(66, 13);
            this.labelBlurValue.TabIndex = 26;
            this.labelBlurValue.Text = "значение: 0";
            // 
            // trackBarSharpen
            // 
            this.trackBarSharpen.Location = new System.Drawing.Point(266, 608);
            this.trackBarSharpen.Name = "trackBarSharpen";
            this.trackBarSharpen.Size = new System.Drawing.Size(817, 45);
            this.trackBarSharpen.TabIndex = 25;
            // 
            // buttonSharpen
            // 
            this.buttonSharpen.Location = new System.Drawing.Point(58, 598);
            this.buttonSharpen.Name = "buttonSharpen";
            this.buttonSharpen.Size = new System.Drawing.Size(202, 46);
            this.buttonSharpen.TabIndex = 24;
            this.buttonSharpen.Text = "Резкость";
            this.buttonSharpen.UseVisualStyleBackColor = true;
            // 
            // buttonResize
            // 
            this.buttonResize.Location = new System.Drawing.Point(58, 546);
            this.buttonResize.Name = "buttonResize";
            this.buttonResize.Size = new System.Drawing.Size(202, 46);
            this.buttonResize.TabIndex = 27;
            this.buttonResize.Text = "Изменить размер";
            this.buttonResize.UseVisualStyleBackColor = true;
            // 
            // PhotoEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.buttonResize);
            this.Controls.Add(this.labelBlurValue);
            this.Controls.Add(this.trackBarSharpen);
            this.Controls.Add(this.buttonSharpen);
            this.Controls.Add(this.labelH);
            this.Controls.Add(this.numericHeight);
            this.Controls.Add(this.labelW);
            this.Controls.Add(this.numericWidth);
            this.Controls.Add(this.labelThresholdValue);
            this.Controls.Add(this.labelSharpenValue);
            this.Controls.Add(this.labelContrastValue);
            this.Controls.Add(this.labelBrightnessValue);
            this.Controls.Add(this.trackBarThreshold);
            this.Controls.Add(this.trackBarBlur);
            this.Controls.Add(this.trackBarContrast);
            this.Controls.Add(this.trackBarBrightness);
            this.Controls.Add(this.buttonBlur);
            this.Controls.Add(this.buttonContrast);
            this.Controls.Add(this.buttonBrightness);
            this.Controls.Add(this.buttonThreshold);
            this.Controls.Add(this.pictureBoxResult);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PhotoEditorForm";
            this.Text = "PhotoEditorForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSharpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Button buttonThreshold;
        private System.Windows.Forms.Button buttonBrightness;
        private System.Windows.Forms.Button buttonContrast;
        private System.Windows.Forms.Button buttonBlur;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.TrackBar trackBarContrast;
        private System.Windows.Forms.TrackBar trackBarBlur;
        private System.Windows.Forms.TrackBar trackBarThreshold;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сброситьToolStripMenuItem;
        private System.Windows.Forms.Label labelBrightnessValue;
        private System.Windows.Forms.Label labelContrastValue;
        private System.Windows.Forms.Label labelSharpenValue;
        private System.Windows.Forms.Label labelThresholdValue;
        private System.Windows.Forms.NumericUpDown numericWidth;
        private System.Windows.Forms.Label labelW;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.NumericUpDown numericHeight;
        private System.Windows.Forms.Label labelBlurValue;
        private System.Windows.Forms.TrackBar trackBarSharpen;
        private System.Windows.Forms.Button buttonSharpen;
        private System.Windows.Forms.Button buttonResize;
    }
}