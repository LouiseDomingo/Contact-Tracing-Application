
namespace Contact_Tracing_Application
{
    partial class directoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.headerLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.goBtn = new System.Windows.Forms.Button();
            this.listViewer = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(180, 85);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 23);
            this.datePicker.TabIndex = 0;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.headerLabel.Font = new System.Drawing.Font("Tekton Pro", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(60, 20);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(487, 35);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "LA\'s Coffee Shop Contact Tracing Directory";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.Location = new System.Drawing.Point(125, 90);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(40, 15);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Date :";
            // 
            // goBtn
            // 
            this.goBtn.BackColor = System.Drawing.SystemColors.Control;
            this.goBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.goBtn.Location = new System.Drawing.Point(400, 86);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(75, 23);
            this.goBtn.TabIndex = 3;
            this.goBtn.Text = "GO";
            this.goBtn.UseVisualStyleBackColor = false;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // listViewer
            // 
            this.listViewer.FormattingEnabled = true;
            this.listViewer.ItemHeight = 15;
            this.listViewer.Location = new System.Drawing.Point(125, 125);
            this.listViewer.Name = "listViewer";
            this.listViewer.Size = new System.Drawing.Size(350, 259);
            this.listViewer.TabIndex = 5;
            // 
            // directoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_Application.Properties.Resources.tryer;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.listViewer);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.datePicker);
            this.Name = "directoryForm";
            this.Text = "LA\'s Coffee Shop Directory Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.ListBox listViewer;
    }
}