using System;
using System.Windows.Forms;

namespace Contact_Tracing_Application
{
    public partial class contactTracingForm : Form
    {
        public contactTracingForm()
        {
            InitializeComponent();
        }


        private void nameInput_Click(object sender, EventArgs e)
        {
            nameInput.Text = string.Empty;
        }

        private void nicknameInput_Click(object sender, EventArgs e)
        {
            nameInput.Text = string.Empty;
        }

        private void ageInput_Click(object sender, EventArgs e)
        {
            nameInput.Text = string.Empty;
        }

        private void addressInput_Click(object sender, EventArgs e)
        {
            nameInput.Text = string.Empty;
        }

        private void temperatureInput_Click(object sender, EventArgs e)
        {
            nameInput.Text = string.Empty;
        }

    }
}
