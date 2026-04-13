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

            labelAuthor.Text = currentArtist.Name;
            authorText.Text = currentArtist.Bio;

            galleryPicture.SizeMode = PictureBoxSizeMode.Zoom;
            ShowCurrentImage();

            this.FormClosed += WinFormClosed;
        }

        private void ShowCurrentImage()
        {
            if (currentArtist.ImagePaths == null || currentArtist.ImagePaths.Count == 0)
            {
                if (galleryPicture.Image != null)
                {
                    galleryPicture.Image.Dispose();
                    galleryPicture.Image = null;
                }

                buttonBack.Enabled = false;
                buttonNext.Enabled = false;
                return;
            }

            if (currentImageIndex < 0)
                currentImageIndex = 0;

            if (currentImageIndex >= currentArtist.ImagePaths.Count)
                currentImageIndex = currentArtist.ImagePaths.Count - 1;

            string imagePath = currentArtist.ImagePaths[currentImageIndex];
            labelName.Text = Path.GetFileNameWithoutExtension(imagePath);

            try
            {
                if (galleryPicture.Image != null)
                {
                    galleryPicture.Image.Dispose();
                    galleryPicture.Image = null;
                }

                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    galleryPicture.Image = Image.FromStream(fs);
                }
            }
            catch
            {
                MessageBox.Show("Не удалось загрузить изображение:\n" + imagePath);
            }

            buttonBack.Enabled = currentImageIndex > 0;
            buttonNext.Enabled = currentImageIndex < currentArtist.ImagePaths.Count - 1;
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
    }
}
