using System;
using System.IO;
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
            if (nameInput.Text == "This field is optional.")
            {
                ageInput.Text = string.Empty;
            }
        }

        private void nicknameInput_Click(object sender, EventArgs e)
        {
            if (nicknameInput.Text == "Required")
            {
                nicknameInput.Text = string.Empty;
            }
        }

        private void addressInput_Click(object sender, EventArgs e)
        {
            if (addressInput.Text == "Required")
            {
                addressInput.Text = string.Empty;
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (ageInput.Text == "" || contactNoInput.Text == "")
            {
                MessageBox.Show("Incomplete fields!");
            }    
            else if (Convert.ToInt32(ageInput.Text) < 18)
            {
                MessageBox.Show("Minors are not allowed!");
            }
            else if (Convert.ToInt32(ageInput.Text) > 65)
            {
                MessageBox.Show("Above 65 years old  are not allowed!");
            }
            else if (nicknameInput.Text == "Required" || nicknameInput.Text == "" ||
                addressInput.Text == "Required" || addressInput.Text == "")
            {
                MessageBox.Show("Incomplete fields!");
            }
            else
            {
                Close();
            }
        }
    }
}
