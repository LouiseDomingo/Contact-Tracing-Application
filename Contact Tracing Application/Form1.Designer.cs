
namespace Contact_Tracing_Application
{
    partial class contactTracingForm
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
            this.forNickname = new System.Windows.Forms.Label();
            this.nicknameInput = new System.Windows.Forms.TextBox();
            this.usualSymptoms = new System.Windows.Forms.CheckedListBox();
            this.unusualSymptoms = new System.Windows.Forms.CheckedListBox();
            this.questionForSymptoms = new System.Windows.Forms.Label();
            this.forUsualSymptoms = new System.Windows.Forms.Label();
            this.forUnusualSymptoms = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.ageInput = new System.Windows.Forms.MaskedTextBox();
            this.forContactNo = new System.Windows.Forms.Label();
            this.contactNoInput = new System.Windows.Forms.MaskedTextBox();
            this.forTemp = new System.Windows.Forms.Label();
            this.temperatureInput = new System.Windows.Forms.MaskedTextBox();
            this.dataAccessBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomingLabel
            // 
            this.welcomingLabel.AutoSize = true;
            this.welcomingLabel.BackColor = System.Drawing.Color.Peru;
            this.welcomingLabel.Font = new System.Drawing.Font("Tekton Pro", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.welcomingLabel.Location = new System.Drawing.Point(126, 20);
            this.welcomingLabel.Name = "welcomingLabel";
            this.welcomingLabel.Size = new System.Drawing.Size(333, 35);
            this.welcomingLabel.TabIndex = 0;
            this.welcomingLabel.Text = "Welcome to LA\'s Coffee Shop!\r\n";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.messageLabel.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageLabel.Location = new System.Drawing.Point(120, 60);
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
            this.forName.BackColor = System.Drawing.Color.Transparent;
            this.forName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.forName.Location = new System.Drawing.Point(120, 125);
            this.forName.Name = "forName";
            this.forName.Size = new System.Drawing.Size(47, 15);
            this.forName.TabIndex = 2;
            this.forName.Text = "Name :";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(173, 122);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(221, 23);
            this.nameInput.TabIndex = 3;
            this.nameInput.Text = "This field is optional.";
            this.nameInput.Click += new System.EventHandler(this.nameInput_Click);
            // 
            // nameInputGuide
            // 
            this.nameInputGuide.AutoSize = true;
            this.nameInputGuide.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameInputGuide.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameInputGuide.Location = new System.Drawing.Point(184, 148);
            this.nameInputGuide.Name = "nameInputGuide";
            this.nameInputGuide.Size = new System.Drawing.Size(200, 14);
            this.nameInputGuide.TabIndex = 4;
            this.nameInputGuide.Text = "(Last Name, First Name, Middle Initial)";
            // 
            // forAge
            // 
            this.forAge.AutoSize = true;
            this.forAge.BackColor = System.Drawing.Color.Transparent;
            this.forAge.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.forAge.Location = new System.Drawing.Point(120, 240);
            this.forAge.Name = "forAge";
            this.forAge.Size = new System.Drawing.Size(38, 15);
            this.forAge.TabIndex = 5;
            this.forAge.Text = "Age : ";
            // 
            // forAddress
            // 
            this.forAddress.AutoSize = true;
            this.forAddress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.forAddress.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.forAddress.Location = new System.Drawing.Point(120, 300);
            this.forAddress.Name = "forAddress";
            this.forAddress.Size = new System.Drawing.Size(61, 15);
            this.forAddress.TabIndex = 6;
            this.forAddress.Text = "Address : ";
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(187, 297);
            this.addressInput.Multiline = true;
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(205, 58);
            this.addressInput.TabIndex = 7;
            this.addressInput.Text = "Required";
            this.addressInput.Click += new System.EventHandler(this.addressInput_Click);
            // 
            // forNickname
            // 
            this.forNickname.AutoSize = true;
            this.forNickname.BackColor = System.Drawing.Color.Transparent;
            this.forNickname.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.forNickname.Location = new System.Drawing.Point(120, 180);
            this.forNickname.Name = "forNickname";
            this.forNickname.Size = new System.Drawing.Size(68, 15);
            this.forNickname.TabIndex = 9;
            this.forNickname.Text = "Nickname :";
            // 
            // nicknameInput
            // 
            this.nicknameInput.Location = new System.Drawing.Point(194, 177);
            this.nicknameInput.Name = "nicknameInput";
            this.nicknameInput.Size = new System.Drawing.Size(146, 23);
            this.nicknameInput.TabIndex = 10;
            this.nicknameInput.Text = "Required";
            this.nicknameInput.Click += new System.EventHandler(this.nicknameInput_Click);
            // 
            // usualSymptoms
            // 
            this.usualSymptoms.CheckOnClick = true;
            this.usualSymptoms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usualSymptoms.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usualSymptoms.FormattingEnabled = true;
            this.usualSymptoms.Items.AddRange(new object[] {
            "Fever (Lagnat)",
            "Dry Cough (Tuyong ubo)",
            "Sore Throat (Namamagang lalamunan)",
            "Shortness of Breath (Hirap sa paghinga)",
            "Loss of Smell and Taste (Pagkawala ng pang-amoy at panglasa)"});
            this.usualSymptoms.Location = new System.Drawing.Point(120, 555);
            this.usualSymptoms.Name = "usualSymptoms";
            this.usualSymptoms.Size = new System.Drawing.Size(373, 89);
            this.usualSymptoms.TabIndex = 11;
            // 
            // unusualSymptoms
            // 
            this.unusualSymptoms.CheckOnClick = true;
            this.unusualSymptoms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unusualSymptoms.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unusualSymptoms.FormattingEnabled = true;
            this.unusualSymptoms.Items.AddRange(new object[] {
            "Fatigue (Pagkapagod)",
            "Body Ache (Pananakit ng katawan)",
            "Headache (Pananakit ng ulo)",
            "Runny Nose (Sipon)",
            "Diarrhea (Pagdudumi)"});
            this.unusualSymptoms.Location = new System.Drawing.Point(120, 680);
            this.unusualSymptoms.Name = "unusualSymptoms";
            this.unusualSymptoms.Size = new System.Drawing.Size(212, 89);
            this.unusualSymptoms.TabIndex = 12;
            // 
            // questionForSymptoms
            // 
            this.questionForSymptoms.AutoSize = true;
            this.questionForSymptoms.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.questionForSymptoms.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.questionForSymptoms.Location = new System.Drawing.Point(91, 510);
            this.questionForSymptoms.Name = "questionForSymptoms";
            this.questionForSymptoms.Size = new System.Drawing.Size(130, 15);
            this.questionForSymptoms.TabIndex = 13;
            this.questionForSymptoms.Text = "Are you experiencing :";
            // 
            // forUsualSymptoms
            // 
            this.forUsualSymptoms.AutoSize = true;
            this.forUsualSymptoms.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.forUsualSymptoms.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.forUsualSymptoms.Location = new System.Drawing.Point(120, 535);
            this.forUsualSymptoms.Name = "forUsualSymptoms";
            this.forUsualSymptoms.Size = new System.Drawing.Size(142, 14);
            this.forUsualSymptoms.TabIndex = 14;
            this.forUsualSymptoms.Text = "Most Common Symptoms";
            // 
            // forUnusualSymptoms
            // 
            this.forUnusualSymptoms.AutoSize = true;
            this.forUnusualSymptoms.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.forUnusualSymptoms.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.forUnusualSymptoms.Location = new System.Drawing.Point(120, 660);
            this.forUnusualSymptoms.Name = "forUnusualSymptoms";
            this.forUnusualSymptoms.Size = new System.Drawing.Size(171, 14);
            this.forUnusualSymptoms.TabIndex = 15;
            this.forUnusualSymptoms.Text = "Some Patients may also have :";
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitBtn.Location = new System.Drawing.Point(218, 800);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(102, 27);
            this.submitBtn.TabIndex = 16;
            this.submitBtn.Text = "SUBMIT";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // ageInput
            // 
            this.ageInput.Location = new System.Drawing.Point(164, 237);
            this.ageInput.Mask = "00";
            this.ageInput.Name = "ageInput";
            this.ageInput.PromptChar = '-';
            this.ageInput.RejectInputOnFirstFailure = true;
            this.ageInput.Size = new System.Drawing.Size(100, 23);
            this.ageInput.TabIndex = 19;
            // 
            // forContactNo
            // 
            this.forContactNo.AutoSize = true;
            this.forContactNo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.forContactNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.forContactNo.Location = new System.Drawing.Point(120, 390);
            this.forContactNo.Name = "forContactNo";
            this.forContactNo.Size = new System.Drawing.Size(105, 15);
            this.forContactNo.TabIndex = 20;
            this.forContactNo.Text = "Contact Number :";
            // 
            // contactNoInput
            // 
            this.contactNoInput.Location = new System.Drawing.Point(231, 387);
            this.contactNoInput.Mask = "00000000000";
            this.contactNoInput.Name = "contactNoInput";
            this.contactNoInput.PromptChar = '-';
            this.contactNoInput.RejectInputOnFirstFailure = true;
            this.contactNoInput.Size = new System.Drawing.Size(100, 23);
            this.contactNoInput.TabIndex = 21;
            // 
            // forTemp
            // 
            this.forTemp.AutoSize = true;
            this.forTemp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.forTemp.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.forTemp.Location = new System.Drawing.Point(120, 450);
            this.forTemp.Name = "forTemp";
            this.forTemp.Size = new System.Drawing.Size(86, 15);
            this.forTemp.TabIndex = 8;
            this.forTemp.Text = "Temperature :";
            // 
            // temperatureInput
            // 
            this.temperatureInput.Location = new System.Drawing.Point(212, 447);
            this.temperatureInput.Mask = "00.00";
            this.temperatureInput.Name = "temperatureInput";
            this.temperatureInput.PromptChar = '-';
            this.temperatureInput.RejectInputOnFirstFailure = true;
            this.temperatureInput.Size = new System.Drawing.Size(100, 23);
            this.temperatureInput.TabIndex = 23;
            // 
            // dataAccessBtn
            // 
            this.dataAccessBtn.BackColor = System.Drawing.Color.Transparent;
            this.dataAccessBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataAccessBtn.Location = new System.Drawing.Point(12, 824);
            this.dataAccessBtn.Name = "dataAccessBtn";
            this.dataAccessBtn.Size = new System.Drawing.Size(153, 58);
            this.dataAccessBtn.TabIndex = 24;
            this.dataAccessBtn.Text = "DO NOT OPEN!\r\nFor authorized personnel only! \r\n";
            this.dataAccessBtn.UseVisualStyleBackColor = false;
            this.dataAccessBtn.Click += new System.EventHandler(this.dataAccessBtn_Click);
            // 
            // contactTracingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.BackgroundImage = global::Contact_Tracing_Application.Properties.Resources.tryer;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(664, 436);
            this.Controls.Add(this.dataAccessBtn);
            this.Controls.Add(this.temperatureInput);
            this.Controls.Add(this.contactNoInput);
            this.Controls.Add(this.forContactNo);
            this.Controls.Add(this.ageInput);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.forUnusualSymptoms);
            this.Controls.Add(this.forUsualSymptoms);
            this.Controls.Add(this.questionForSymptoms);
            this.Controls.Add(this.unusualSymptoms);
            this.Controls.Add(this.usualSymptoms);
            this.Controls.Add(this.nicknameInput);
            this.Controls.Add(this.forNickname);
            this.Controls.Add(this.forTemp);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(this.forAddress);
            this.Controls.Add(this.forAge);
            this.Controls.Add(this.nameInputGuide);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.forName);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.welcomingLabel);
            this.DoubleBuffered = true;
            this.Name = "contactTracingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LA\'s Contact Tracing Form";
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
        private System.Windows.Forms.Label forNickname;
        private System.Windows.Forms.TextBox nicknameInput;
        private System.Windows.Forms.CheckedListBox usualSymptoms;
        private System.Windows.Forms.CheckedListBox unusualSymptoms;
        private System.Windows.Forms.Label questionForSymptoms;
        private System.Windows.Forms.Label forUsualSymptoms;
        private System.Windows.Forms.Label forUnusualSymptoms;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.MaskedTextBox ageInput;
        private System.Windows.Forms.Label forContactNo;
        private System.Windows.Forms.MaskedTextBox contactNoInput;
        private System.Windows.Forms.Label forTemp;
        private System.Windows.Forms.MaskedTextBox temperatureInput;
        private System.Windows.Forms.Button dataAccessBtn;
    }
}

