namespace TTS
{
    partial class TTS
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
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.rbArabic = new System.Windows.Forms.RadioButton();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.lblPitch = new System.Windows.Forms.Label();
            this.nudPitch = new System.Windows.Forms.NumericUpDown();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.nudSpeed = new System.Windows.Forms.NumericUpDown();
            this.rtxtText = new System.Windows.Forms.RichTextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.lblFileLocation = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnFilePath = new System.Windows.Forms.Button();
            this.btnGenMp3 = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnGenAndLstn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(12, 67);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(65, 16);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "File Name";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(97, 66);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(232, 20);
            this.txtFileName.TabIndex = 1;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.Location = new System.Drawing.Point(12, 107);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(63, 16);
            this.lblLanguage.TabIndex = 2;
            this.lblLanguage.Text = "Language";
            // 
            // rbArabic
            // 
            this.rbArabic.AutoSize = true;
            this.rbArabic.Checked = true;
            this.rbArabic.Location = new System.Drawing.Point(97, 107);
            this.rbArabic.Name = "rbArabic";
            this.rbArabic.Size = new System.Drawing.Size(55, 17);
            this.rbArabic.TabIndex = 3;
            this.rbArabic.TabStop = true;
            this.rbArabic.Text = "Arabic";
            this.rbArabic.UseVisualStyleBackColor = true;
            // 
            // rbEnglish
            // 
            this.rbEnglish.AutoSize = true;
            this.rbEnglish.Location = new System.Drawing.Point(158, 106);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(58, 17);
            this.rbEnglish.TabIndex = 4;
            this.rbEnglish.Text = "English";
            this.rbEnglish.UseVisualStyleBackColor = true;
            // 
            // lblPitch
            // 
            this.lblPitch.AutoSize = true;
            this.lblPitch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPitch.Location = new System.Drawing.Point(12, 145);
            this.lblPitch.Name = "lblPitch";
            this.lblPitch.Size = new System.Drawing.Size(35, 16);
            this.lblPitch.TabIndex = 5;
            this.lblPitch.Text = "Pitch";
            // 
            // nudPitch
            // 
            this.nudPitch.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudPitch.Location = new System.Drawing.Point(97, 145);
            this.nudPitch.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.nudPitch.Minimum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.nudPitch.Name = "nudPitch";
            this.nudPitch.ReadOnly = true;
            this.nudPitch.Size = new System.Drawing.Size(119, 20);
            this.nudPitch.TabIndex = 7;
            this.nudPitch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPitch.Value = new decimal(new int[] {
            25000,
            0,
            0,
            0});
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(12, 182);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(44, 16);
            this.lblSpeed.TabIndex = 8;
            this.lblSpeed.Text = "Speed";
            // 
            // nudSpeed
            // 
            this.nudSpeed.DecimalPlaces = 1;
            this.nudSpeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudSpeed.Location = new System.Drawing.Point(97, 182);
            this.nudSpeed.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.ReadOnly = true;
            this.nudSpeed.Size = new System.Drawing.Size(119, 20);
            this.nudSpeed.TabIndex = 9;
            this.nudSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSpeed.Value = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            // 
            // rtxtText
            // 
            this.rtxtText.Location = new System.Drawing.Point(97, 12);
            this.rtxtText.Name = "rtxtText";
            this.rtxtText.Size = new System.Drawing.Size(233, 45);
            this.rtxtText.TabIndex = 10;
            this.rtxtText.Text = "";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(12, 29);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(33, 16);
            this.lblText.TabIndex = 11;
            this.lblText.Text = "Text";
            // 
            // lblFileLocation
            // 
            this.lblFileLocation.AutoSize = true;
            this.lblFileLocation.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileLocation.Location = new System.Drawing.Point(12, 222);
            this.lblFileLocation.Name = "lblFileLocation";
            this.lblFileLocation.Size = new System.Drawing.Size(79, 16);
            this.lblFileLocation.TabIndex = 12;
            this.lblFileLocation.Text = "File Location";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(97, 218);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(219, 20);
            this.txtFilePath.TabIndex = 13;
            // 
            // btnFilePath
            // 
            this.btnFilePath.Location = new System.Drawing.Point(322, 212);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(40, 31);
            this.btnFilePath.TabIndex = 14;
            this.btnFilePath.Text = "Path";
            this.btnFilePath.UseVisualStyleBackColor = true;
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // btnGenMp3
            // 
            this.btnGenMp3.Location = new System.Drawing.Point(28, 257);
            this.btnGenMp3.Name = "btnGenMp3";
            this.btnGenMp3.Size = new System.Drawing.Size(124, 38);
            this.btnGenMp3.TabIndex = 15;
            this.btnGenMp3.Text = "Generate MP3 File";
            this.btnGenMp3.UseVisualStyleBackColor = true;
            this.btnGenMp3.Click += new System.EventHandler(this.btnGenMp3_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMessage.Location = new System.Drawing.Point(0, 298);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(374, 26);
            this.lblMessage.TabIndex = 16;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGenAndLstn
            // 
            this.btnGenAndLstn.Location = new System.Drawing.Point(177, 257);
            this.btnGenAndLstn.Name = "btnGenAndLstn";
            this.btnGenAndLstn.Size = new System.Drawing.Size(153, 38);
            this.btnGenAndLstn.TabIndex = 17;
            this.btnGenAndLstn.Text = "Generate and Listen MP3";
            this.btnGenAndLstn.UseVisualStyleBackColor = true;
            this.btnGenAndLstn.Click += new System.EventHandler(this.btnGenAndLstn_Click);
            // 
            // TTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 324);
            this.Controls.Add(this.btnGenAndLstn);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnGenMp3);
            this.Controls.Add(this.btnFilePath);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.lblFileLocation);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.rtxtText);
            this.Controls.Add(this.nudSpeed);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.nudPitch);
            this.Controls.Add(this.lblPitch);
            this.Controls.Add(this.rbEnglish);
            this.Controls.Add(this.rbArabic);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblFileName);
            this.Name = "TTS";
            this.Text = "Text To Speech";
            this.Load += new System.EventHandler(this.TTS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.RadioButton rbArabic;
        private System.Windows.Forms.RadioButton rbEnglish;
        private System.Windows.Forms.Label lblPitch;
        private System.Windows.Forms.NumericUpDown nudPitch;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.NumericUpDown nudSpeed;
        private System.Windows.Forms.RichTextBox rtxtText;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblFileLocation;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnFilePath;
        private System.Windows.Forms.Button btnGenMp3;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnGenAndLstn;
    }
}

