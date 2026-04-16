using System.Windows.Forms;

namespace LAB_7
{
    public partial class FormInfo : Form
    {
        public FormInfo(string title, string content)
        {
            InitializeComponent();

            Text = title;
            labelInfo.Text = content;

            FormBorderStyle = FormBorderStyle.Sizable;
            ControlBox = true;
            MinimizeBox = false;
            MaximizeBox = false;
        }
    }
}