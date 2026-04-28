using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace LAB_11
{
    public partial class PaintForm : Form
    {
        private Bitmap canvas;
        private Graphics graphics;
        private Random random = new Random();

        private enum DrawMode
        {
            None,
            Circle,
            ConcentricCircles,
            CircleSequence
        }

        private DrawMode currentMode = DrawMode.None;

        private Point? firstPoint = null;

        public PaintForm()
        {
            InitializeComponent();

            InitCanvas();

            pictureBox1.MouseClick += pictureBox1_MouseClick;
        }

        private void InitCanvas()
        {
            canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(canvas);
            graphics.Clear(Color.White);
            pictureBox1.Image = canvas;
        }

        private Color GetRandomColor()
        {
            return Color.FromArgb(
                random.Next(256),
                random.Next(256),
                random.Next(256)
            );
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            pictureBox1.Refresh();

            currentMode = DrawMode.None;
            firstPoint = null;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            openDialog.Filter = "Изображения|*.bmp;*.jpg;*.jpeg;*.png|Все файлы|*.*";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                Image loadedImage = Image.FromFile(openDialog.FileName);

                canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                graphics = Graphics.FromImage(canvas);
                graphics.Clear(Color.White);

                graphics.DrawImage(loadedImage, 0, 0, pictureBox1.Width, pictureBox1.Height);

                pictureBox1.Image = canvas;
                pictureBox1.Refresh();

                loadedImage.Dispose();
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
            saveDialog.Title = "Сохранить изображение";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string extension = System.IO.Path.GetExtension(saveDialog.FileName).ToLower();

                if (extension == ".jpg" || extension == ".jpeg")
                {
                    canvas.Save(saveDialog.FileName, ImageFormat.Jpeg);
                }
                else if (extension == ".bmp")
                {
                    canvas.Save(saveDialog.FileName, ImageFormat.Bmp);
                }
                else
                {
                    canvas.Save(saveDialog.FileName, ImageFormat.Png);
                }
            }
        }

        private void кругToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentMode = DrawMode.Circle;
            firstPoint = null;
        }

        private void концентрическиеОкружностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentMode = DrawMode.ConcentricCircles;
            firstPoint = null;
        }

        private void последовательностьКруговToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentMode = DrawMode.CircleSequence;
            firstPoint = null;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentMode == DrawMode.Circle)
            {
                DrawRandomCircle(e.Location);
            }
            else if (currentMode == DrawMode.ConcentricCircles)
            {
                DrawConcentricCircles(e.Location);
            }
            else if (currentMode == DrawMode.CircleSequence)
            {
                if (firstPoint == null)
                {
                    firstPoint = e.Location;
                    MessageBox.Show("Выберите вторую точку отрезка.");
                }
                else
                {
                    DrawCircleSequence(firstPoint.Value, e.Location);
                    firstPoint = null;
                }
            }

            pictureBox1.Refresh();
        }

        private void DrawRandomCircle(Point center)
        {
            int radius = random.Next(20, 100);
            Color color = GetRandomColor();

            using (SolidBrush brush = new SolidBrush(color))
            {
                graphics.FillEllipse(
                    brush,
                    center.X - radius,
                    center.Y - radius,
                    radius * 2,
                    radius * 2
                );
            }
        }

        private void DrawConcentricCircles(Point center)
        {
            int count = random.Next(3, 8);
            int step = random.Next(15, 35);

            Color color = GetRandomColor();

            using (Pen pen = new Pen(color, 2))
            {
                for (int i = 1; i <= count; i++)
                {
                    int radius = i * step;

                    graphics.DrawEllipse(
                        pen,
                        center.X - radius,
                        center.Y - radius,
                        radius * 2,
                        radius * 2
                    );
                }
            }
        }

        private void DrawCircleSequence(Point start, Point end)
        {
            int count = random.Next(5, 12);
            int radius = random.Next(50, 90);
            int radiusStep = random.Next(3, 8);

            for (int i = 0; i < count; i++)
            {
                double t = count == 1 ? 0 : (double)i / (count - 1);

                int x = (int)(start.X + (end.X - start.X) * t);
                int y = (int)(start.Y + (end.Y - start.Y) * t);

                int currentRadius = radius - i * radiusStep;

                if (currentRadius < 5)
                {
                    currentRadius = 5;
                }

                using (SolidBrush brush = new SolidBrush(GetRandomColor()))
                {
                    graphics.FillEllipse(
                        brush,
                        x - currentRadius,
                        y - currentRadius,
                        currentRadius * 2,
                        currentRadius * 2
                    );
                }
            }
        }

        private void PaintForm_Resize(object sender, EventArgs e)
        {
            if (pictureBox1.Width <= 0 || pictureBox1.Height <= 0)
            {
                return;
            }

            Bitmap newCanvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            using (Graphics g = Graphics.FromImage(newCanvas))
            {
                g.Clear(Color.White);

                if (canvas != null)
                {
                    g.DrawImage(canvas, 0, 0);
                }
            }

            canvas = newCanvas;
            graphics = Graphics.FromImage(canvas);
            pictureBox1.Image = canvas;
        }
    }
}