using System.Windows.Forms;

namespace ShortURL_DesktopClient
{
    public partial class FormAddURL : Form
    {
        public string URL { get => this.textBoxURL.Text; }
        public string Code { get => this.textBoxCode.Text; }

        public FormAddURL()
        {
            InitializeComponent();
        }
    }
}
