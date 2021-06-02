
namespace Contact_Tracing_Application
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcomingLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.forName = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.nameInputGuide = new System.Windows.Forms.Label();
            this.forAge = new System.Windows.Forms.Label();
            this.forAddress = new System.Windows.Forms.Label();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.forTemp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomingLabel
            // 
            this.welcomingLabel.AutoSize = true;
            this.welcomingLabel.Font = new System.Drawing.Font("Tekton Pro", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.welcomingLabel.Location = new System.Drawing.Point(53, 19);
            this.welcomingLabel.Name = "welcomingLabel";
            this.welcomingLabel.Size = new System.Drawing.Size(333, 35);
            this.welcomingLabel.TabIndex = 0;
            this.welcomingLabel.Text = "Welcome to LA\'s Coffee Shop!\r\n";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageLabel.Location = new System.Drawing.Point(49, 55);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(343, 28);
            this.messageLabel.TabIndex = 1;
            this.messageLabel.Text = "For safety purposes, please fill out this contact tracing form honestly\r\nbefore e" +
    "ntering the shop. Thank you!\r\n";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // forName
            // 
            this.forName.AutoSize = true;
            this.forName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.forName.Location = new System.Drawing.Point(49, 120);
            this.forName.Name = "forName";
            this.forName.Size = new System.Drawing.Size(44, 15);
            this.forName.TabIndex = 2;
            this.forName.Text = "Name :";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(99, 117);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(221, 23);
            this.nameInput.TabIndex = 3;
            // 
            // nameInputGuide
            // 
            this.nameInputGuide.AutoSize = true;
            this.nameInputGuide.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameInputGuide.Location = new System.Drawing.Point(108, 143);
            this.nameInputGuide.Name = "nameInputGuide";
            this.nameInputGuide.Size = new System.Drawing.Size(200, 14);
            this.nameInputGuide.TabIndex = 4;
            this.nameInputGuide.Text = "(Last Name, First Name, Middle Initial)";
            // 
            // forAge
            // 
            this.forAge.AutoSize = true;
            this.forAge.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.forAge.Location = new System.Drawing.Point(49, 180);
            this.forAge.Name = "forAge";
            this.forAge.Size = new System.Drawing.Size(35, 15);
            this.forAge.TabIndex = 5;
            this.forAge.Text = "Age : ";
            // 
            // forAddress
            // 
            this.forAddress.AutoSize = true;
            this.forAddress.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.forAddress.Location = new System.Drawing.Point(49, 240);
            this.forAddress.Name = "forAddress";
            this.forAddress.Size = new System.Drawing.Size(60, 15);
            this.forAddress.TabIndex = 6;
            this.forAddress.Text = "Address : ";
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(115, 237);
            this.addressInput.Multiline = true;
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(205, 58);
            this.addressInput.TabIndex = 7;
            // 
            // forTemp
            // 
            this.forTemp.AutoSize = true;
            this.forTemp.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.forTemp.Location = new System.Drawing.Point(49, 350);
            this.forTemp.Name = "forTemp";
            this.forTemp.Size = new System.Drawing.Size(81, 15);
            this.forTemp.TabIndex = 8;
            this.forTemp.Text = "Temperature :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.forTemp);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(this.forAddress);
            this.Controls.Add(this.forAge);
            this.Controls.Add(this.nameInputGuide);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.forName);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.welcomingLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomingLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label forName;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label nameInputGuide;
        private System.Windows.Forms.Label forAge;
        private System.Windows.Forms.Label forAddress;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.Label forTemp;
    }
}

