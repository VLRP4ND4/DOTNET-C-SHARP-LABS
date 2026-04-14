using System;
using System.Windows.Forms;

namespace LAB_7
{
    public partial class FormMain : Form
    {
        private FormInfo teachersForm;
        private FormInfo studentsForm;

        public FormMain()
        {
            InitializeComponent();
            IsMdiContainer = true;
            InitializeTrayMenu();

            if (this.Icon != null)
                notifyIcon1.Icon = this.Icon;
        }

        private void InitializeTrayMenu()
        {
            notifyIcon1.Visible = false;
            notifyIcon1.Text = "LAB 7. UNIVERSITY";
            notifyIcon1.Icon = this.Icon;
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
        }

        private void ShowFromTray()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;

            foreach (Form child in this.MdiChildren)
            {
                child.Show();
            }

            this.Activate();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            ShowFromTray();
        }

        private void OpenSingleChild(ref FormInfo form, string title, string text)
        {
            if (form == null || form.IsDisposed)
            {
                form = new FormInfo(title, text);
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                form.Activate();
            }
        }

        private void сведенияОПреподавателяхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSingleChild(
                ref teachersForm,
                "Сведения о преподавателях",
                "Преподаватели:\r\n1. Иванов И.И.\r\n2. Петров П.П.\r\n3. Сидорова А.А."
            );
        }

        private void сведенияОСтудентахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSingleChild(
                ref studentsForm,
                "Сведения о студентах",
                "Студенты:\r\n1. Алексеев А.А.\r\n2. Борисов Б.Б.\r\n3. Васильева В.В.\r\n 4. Алексеева Ю.А.\r\n 5. Гоголев В.Г.\r\n 6. Иванова В.А."
            );
        }

        private void свернутьВТрейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Hide();
            }

            this.Hide();
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
    }
}
