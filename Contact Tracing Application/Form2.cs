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
            
            StreamReader dataFile;
            dataFile = File.OpenText(visitationDate + ".txt");
            while (!dataFile.EndOfStream)
            {
                listViewer.Items.Add(dataFile.ReadLine());
            }
            
            
        }
    }
}
