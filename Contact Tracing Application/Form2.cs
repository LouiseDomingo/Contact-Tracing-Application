using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_Application
{
    public partial class directoryForm : Form
    {
        public static directoryForm contactTracing;

        public directoryForm()
        {
            InitializeComponent();
            contactTracing = this;
        }


        private void goBtn_Click(object sender, EventArgs e)
        {
            string visitationDate = datePicker.Value.ToLongDateString();
            
            try
            {
                StreamReader dataFile;
                dataFile = File.OpenText(visitationDate + ".txt");
                while (!dataFile.EndOfStream)
                {
                    listViewer.Items.Add(dataFile.ReadLine());
                    goBtn.Enabled = false;
                }
            }
            
            catch (Exception)
            {
                listViewer.Items.Add("No available data for " + visitationDate);
            }

        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            goBtn.Enabled = true;
            listViewer.Items.Clear();
        }
    }
}
