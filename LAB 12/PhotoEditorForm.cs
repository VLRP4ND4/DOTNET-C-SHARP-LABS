using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Accord.Imaging.Filters;

namespace LAB_12
{
    public partial class PhotoEditorForm : Form
    {
        private Bitmap originalImage;
        private Bitmap currentImage;

        public PhotoEditorForm()
        {
            InitializeComponent();

            ConfigureControls();
            SubscribeEvents();
        }

        private void ConfigureControls()
        {
            Text = "Редактор изображений";

            pictureBoxOriginal.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxResult.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBoxOriginal.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxResult.BorderStyle = BorderStyle.FixedSingle;

            trackBarBrightness.Minimum = -255;
            trackBarBrightness.Maximum = 255;
            trackBarBrightness.Value = 0;
            trackBarBrightness.TickFrequency = 25;

            trackBarContrast.Minimum = -100;
            trackBarContrast.Maximum = 100;
            trackBarContrast.Value = 0;
            trackBarContrast.TickFrequency = 10;

            trackBarSharpen.Minimum = 0;
            trackBarSharpen.Maximum = 10;
            trackBarSharpen.Value = 0;
            trackBarSharpen.TickFrequency = 1;

            trackBarBlur.Minimum = 0;
            trackBarBlur.Maximum = 100;
            trackBarBlur.Value = 0;
            trackBarBlur.TickFrequency = 10;

            trackBarThreshold.Minimum = -255;
            trackBarThreshold.Maximum = 255;
            trackBarThreshold.Value = 0;
            trackBarThreshold.TickFrequency = 25;

            numericWidth.Minimum = 1;
            numericWidth.Maximum = 5000;

            numericHeight.Minimum = 1;
            numericHeight.Maximum = 5000;

            UpdateLabels();
        }

        private void SubscribeEvents()
        {
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            сброситьToolStripMenuItem.Click += сброситьToolStripMenuItem_Click;

            trackBarBrightness.Scroll += ControlValueChanged;
            trackBarContrast.Scroll += ControlValueChanged;
            trackBarSharpen.Scroll += ControlValueChanged;
            trackBarBlur.Scroll += ControlValueChanged;
            trackBarThreshold.Scroll += ControlValueChanged;

            numericWidth.ValueChanged += ControlValueChanged;
            numericHeight.ValueChanged += ControlValueChanged;
        }

        private void ControlValueChanged(object sender, EventArgs e)
        {
            UpdateLabels();
            ApplyFilters();
        }

        private void UpdateLabels()
        {
            labelBrightnessValue.Text = "значение: " + trackBarBrightness.Value;
            labelContrastValue.Text = "значение: " + trackBarContrast.Value;
            labelSharpenValue.Text = "значение: " + trackBarSharpen.Value;

            double blurValue = trackBarBlur.Value / 10.0;
            labelBlurValue.Text = "значение: " + blurValue.ToString("0.0");

            labelThresholdValue.Text = "значение: " + trackBarThreshold.Value;
        }

        private void ApplyFilters()
        {
            if (originalImage == null)
                return;

            Bitmap image = new Bitmap(originalImage);

            int width = (int)numericWidth.Value;
            int height = (int)numericHeight.Value;

            if (width > 0 && height > 0 &&
                (width != image.Width || height != image.Height))
            {
                ResizeBilinear resizeFilter = new ResizeBilinear(width, height);
                Bitmap resizedImage = resizeFilter.Apply(image);

                image.Dispose();
                image = resizedImage;
            }

            if (trackBarBrightness.Value != 0)
            {
                BrightnessCorrection brightnessFilter =
                    new BrightnessCorrection(trackBarBrightness.Value);

                Bitmap temp = brightnessFilter.Apply(image);
                image.Dispose();
                image = temp;
            }

            if (trackBarContrast.Value != 0)
            {
                ContrastCorrection contrastFilter =
                    new ContrastCorrection(trackBarContrast.Value);

                Bitmap temp = contrastFilter.Apply(image);
                image.Dispose();
                image = temp;
            }

            if (trackBarSharpen.Value > 0)
            {
                int strength = trackBarSharpen.Value;

                int[,] kernel =
                {
                    { -1, -1, -1 },
                    { -1, strength + 4, -1 },
                    { -1, -1, -1 }
                };

                Convolution sharpenFilter = new Convolution(kernel);

                Bitmap temp = sharpenFilter.Apply(image);
                image.Dispose();
                image = temp;
            }

            if (trackBarBlur.Value > 0)
            {
                double sigma = trackBarBlur.Value / 10.0;
                int kernelSize = 7;

                GaussianBlur blurFilter = new GaussianBlur(sigma, kernelSize);

                Bitmap temp = blurFilter.Apply(image);
                image.Dispose();
                image = temp;
            }

            if (trackBarThreshold.Value != 0)
            {
                Grayscale grayscaleFilter = new Grayscale(0.2125, 0.7154, 0.0721);
                Bitmap grayImage = grayscaleFilter.Apply(image);
                image.Dispose();

                int thresholdValue;

                if (trackBarThreshold.Value > 0)
                {
                    // Ползунок вправо: чем больше значение, тем больше белого
                    thresholdValue = 255 - trackBarThreshold.Value;
                }
                else
                {
                    // Ползунок влево: чем больше отклонение влево, тем больше чёрного
                    thresholdValue = Math.Abs(trackBarThreshold.Value);
                }

                Threshold thresholdFilter = new Threshold(thresholdValue);
                Bitmap binaryImage = thresholdFilter.Apply(grayImage);
                grayImage.Dispose();

                image = binaryImage;
            }

            if (currentImage != null)
            {
                currentImage.Dispose();
            }

            currentImage = image;
            pictureBoxResult.Image = currentImage;
        }

        private Bitmap ConvertTo24bpp(Bitmap source)
        {
            Bitmap result = new Bitmap(source.Width, source.Height, PixelFormat.Format24bppRgb);

            using (Graphics graphics = Graphics.FromImage(result))
            {
                graphics.DrawImage(source, 0, 0, source.Width, source.Height);
            }

            return result;
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (Bitmap loadedImage = new Bitmap(dialog.FileName))
                {
                    originalImage = ConvertTo24bpp(loadedImage);
                }

                pictureBoxOriginal.Image = originalImage;

                numericWidth.Value = originalImage.Width;
                numericHeight.Value = originalImage.Height;

                ApplyFilters();
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentImage == null)
            {
                MessageBox.Show("Нет изображения для сохранения.");
                return;
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JPEG|*.jpg|PNG|*.png|BMP|*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ImageFormat format = ImageFormat.Jpeg;

                if (dialog.FilterIndex == 2)
                    format = ImageFormat.Png;
                else if (dialog.FilterIndex == 3)
                    format = ImageFormat.Bmp;

                currentImage.Save(dialog.FileName, format);
            }
        }

        private void сброситьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Сначала загрузите изображение.");
                return;
            }

            trackBarBrightness.Value = 0;
            trackBarContrast.Value = 0;
            trackBarSharpen.Value = 0;
            trackBarBlur.Value = 0;
            trackBarThreshold.Value = 0;

            numericWidth.Value = originalImage.Width;
            numericHeight.Value = originalImage.Height;

            UpdateLabels();
            ApplyFilters();
        }
    }
}