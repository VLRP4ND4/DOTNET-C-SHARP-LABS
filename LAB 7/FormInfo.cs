using System;
using System.Windows.Forms;

namespace LAB_7
{
    public partial class FormInfo : Form
    {
        public FormInfo(string title, string content)
        {
            InitializeComponent();

            ControlBox = false;
            MinimizeBox = false;
            MaximizeBox = false;

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
