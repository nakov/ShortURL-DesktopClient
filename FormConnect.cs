﻿using System.Windows.Forms;

namespace ShortURL_DesktopClient
{
    public partial class FormConnect : Form
    {
        public string ApiUrl { get => this.textBoxApiUrl.Text; }

        public FormConnect()
        {
            InitializeComponent();
        }

        private void FormConnect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
