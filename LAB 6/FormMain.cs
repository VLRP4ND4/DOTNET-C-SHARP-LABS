using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_6
{
    public partial class FormMain : Form
    {
        private List<Artist> artists = new List<Artist>();

        public FormMain()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadArtists();

            comboBoxChooseAuthor.DataSource = null;
            comboBoxChooseAuthor.DataSource = artists;

            this.FormClosed += WinFormClosed;
        }

        private void LoadArtists()
        {
            artists.Clear();

            string authorsPath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\Authors"));

            if (!Directory.Exists(authorsPath))
            {
                MessageBox.Show("Папка Authors не найдена: " + authorsPath);
                return;
            }

            string[] artistDirectories = Directory.GetDirectories(authorsPath);

            foreach (string artistDir in artistDirectories)
            {
                string artistName = Path.GetFileName(artistDir);

                string descriptionPath = Path.Combine(artistDir, "text.txt");
                string bio = File.Exists(descriptionPath)
                    ? File.ReadAllText(descriptionPath)
                    : "Описание отсутствует.";

                string imgDir = Path.Combine(artistDir, "img");
                List<string> imagePaths = new List<string>();

                if (Directory.Exists(imgDir))
                {
                    string[] allowedExtensions =
                    {
                        ".jpg", ".jpeg", ".png", ".bmp", ".gif", ".tiff", ".webp"
                    };

                    imagePaths = Directory.GetFiles(imgDir)
                        .Where(file => allowedExtensions.Contains(
                            Path.GetExtension(file).ToLower()))
                        .ToList();
                }

                artists.Add(new Artist(artistName, bio, imagePaths));
            }
        }

        private void WinFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxChooseAuthor.SelectedItem == null)
            {
                MessageBox.Show("Выберите автора.");
                return;
            }

            Artist selectedArtist = comboBoxChooseAuthor.SelectedItem as Artist;

            if (selectedArtist == null)
            {
                MessageBox.Show("Автор не выбран.");
                return;
            }

            FormGallery gallery = new FormGallery(selectedArtist, this);
            gallery.Show();
            this.Hide();
        }
    }
}
