using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB_6
{
    public partial class FormGallery : Form
    {
        private Artist currentArtist;
        private FormMain mainForm;
        private int currentImageIndex = 0;

        public FormGallery(Artist artist, FormMain formMain)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            mainForm = formMain;

            currentArtist = artist;
            mainForm = formMain;

            if (currentArtist == null)
            {
                MessageBox.Show("Автор не передан в галерею.");
                Close();
                return;
            }

            label1.Text = currentArtist.Name;
            richTextBox1.Text = currentArtist.Bio;

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            ShowCurrentImage();

            this.FormClosed += WinFormClosed;
        }

        private void ShowCurrentImage()
        {
            if (currentArtist.ImagePaths == null || currentArtist.ImagePaths.Count == 0)
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }

                button1.Enabled = false;
                button2.Enabled = false;
                return;
            }

            if (currentImageIndex < 0)
                currentImageIndex = 0;

            if (currentImageIndex >= currentArtist.ImagePaths.Count)
                currentImageIndex = currentArtist.ImagePaths.Count - 1;

            string imagePath = currentArtist.ImagePaths[currentImageIndex];
            label2.Text = Path.GetFileNameWithoutExtension(imagePath);

            try
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }

                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    pictureBox1.Image = Image.FromStream(fs);
                }
            }
            catch
            {
                MessageBox.Show("Не удалось загрузить изображение:\n" + imagePath);
            }

            button1.Enabled = currentImageIndex > 0;
            button2.Enabled = currentImageIndex < currentArtist.ImagePaths.Count - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentArtist.ImagePaths == null || currentArtist.ImagePaths.Count == 0)
                return;

            if (currentImageIndex > 0)
            {
                currentImageIndex--;
                ShowCurrentImage();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentArtist.ImagePaths == null || currentArtist.ImagePaths.Count == 0)
                return;

            if (currentImageIndex < currentArtist.ImagePaths.Count - 1)
            {
                currentImageIndex++;
                ShowCurrentImage();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void WinFormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainForm != null && !mainForm.Visible)
                Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
