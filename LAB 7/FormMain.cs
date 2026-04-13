using System;
using System.Drawing;
using System.Windows.Forms;

namespace LAB_7
{
    public partial class FormMain : Form
    {
        private FormInfo infoForm;

        public FormMain()
        {
            InitializeComponent();
            IsMdiContainer = true;
            InitializeTrayMenu();
        }

        private void InitializeTrayMenu()
        {
            notifyIcon1.Visible = false;
            notifyIcon1.Text = "LAB 7. UNIVERSITY";
            notifyIcon1.Icon = this.Icon;
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.DoubleClick += notifyIcon1_DoubleClick;
        }

        private void ShowFromTray()
        {
            Show();
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            Activate();
        }

        private void OpenSingleChild(string title, string text)
        {
            if (infoForm != null && !infoForm.IsDisposed)
            {
                infoForm.SetInfo(title, text);
                infoForm.Location = new Point(0, 0);
                infoForm.Activate();
                return;
            }

            infoForm = new FormInfo(title, text);
            infoForm.MdiParent = this;
            infoForm.Show();
            infoForm.Location = new Point(0, 0);
        }

        private void сведенияОПреподавателяхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSingleChild(
                "Сведения о преподавателях",
                "Преподаватели:\r\n 1. Иванов И.И.\r\n 2. Петров П.П.\r\n 3. Сидорова А.А.\r\n 4. Слепцов А.В."
            );
        }

        private void сведенияОСтудентахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSingleChild(
                "Сведения о студентах",
                "Студенты:\r\n 1. Алексеев А.А.\r\n 2. Борисов Б.Б.\r\n 3. Васильева В.В.\r\n 4. Гоголев В.Г.\r\n 5. Иванова В.А.\r\n 6. Лапкин И.С.\r\n 7. Буйский Л.С.\r\n 8. Смирнов Э.З"
            );
        }

        private void свернутьВТрейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            ShowInTaskbar = false;
            notifyIcon1.Visible = true;
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            else
                MessageBox.Show("Нечего закрывать.");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            Application.Exit();
        }

        private void развернутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFromTray();
        }

        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            ShowFromTray();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            ShowFromTray();
        }
    }
}
