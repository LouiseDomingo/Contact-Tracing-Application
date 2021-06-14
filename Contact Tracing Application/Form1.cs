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
            if (ageInput.Text == "" || contactNoInput.Text == "" || temperatureInput.Text == "")
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
               StreamWriter contactTracingFile;
                string visitationDate = DateTime.Now.ToLongDateString();
                contactTracingFile = File.AppendText(visitationDate + ".txt");
                contactTracingFile.WriteLine("\nName : " + nameInput.Text);
                contactTracingFile.WriteLine("Nickname : " + nicknameInput.Text);
                contactTracingFile.WriteLine("Age : " + ageInput.Text);
                contactTracingFile.WriteLine("Address : " + addressInput.Text);
                contactTracingFile.WriteLine("Contact Number : " + contactNoInput.Text);
                contactTracingFile.WriteLine("Temperature : " + temperatureInput.Text);
                
                string firstSymp = string.Empty;
                if (usualSymptoms.CheckedItems.Count != 0)
                { 
                    for(byte x = 0; x < usualSymptoms.CheckedItems.Count; x++)
                    {
                        firstSymp = firstSymp + usualSymptoms.CheckedItems[x].ToString() + " , ";
                    }
                }
                contactTracingFile.WriteLine("Usual Symptoms : " + firstSymp);

                string secondSymp = string.Empty;
                if (unusualSymptoms.CheckedItems.Count != 0)
                {
                    for (byte x = 0; x < unusualSymptoms.CheckedItems.Count; x++)
                    {
                        secondSymp = secondSymp + unusualSymptoms.CheckedItems[x].ToString() + " , ";
                    }
                }
                contactTracingFile.WriteLine("Unusual Symptoms : " + secondSymp);

                contactTracingFile.WriteLine("\n==============================");
                contactTracingFile.Close();

                MessageBox.Show("Accepted! Thank you and\nWelcome to our coffee shop!");
                Close();

            }
        }
    }
}
