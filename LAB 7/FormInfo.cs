using System;
using System.Windows.Forms;

namespace LAB_7
{
    public partial class FormInfo : Form
    {
        public FormInfo(string title, string content)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(0, 0);

            Text = title;
            labelInfo.Text = content;
        }

        public void SetInfo(string title, string content)
        {
            Text = title;
            labelInfo.Text = content;
        }
    }
}
