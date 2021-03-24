namespace Dienstregeling
{
    partial class EigenOfNieuweGebruikerAanpassenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EigenOfNieuweGebruikerAanpassenForm));
            this.repeatWachtwoordTextBox = new System.Windows.Forms.TextBox();
            this.wachtwoordTextBox = new System.Windows.Forms.TextBox();
            this.repeatWachtwoordLabel = new System.Windows.Forms.Label();
            this.wachtwooordLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.opslaanButton = new System.Windows.Forms.Button();
            this.gebruikersnaamTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // repeatWachtwoordTextBox
            // 
            this.repeatWachtwoordTextBox.Location = new System.Drawing.Point(199, 68);
            this.repeatWachtwoordTextBox.Name = "repeatWachtwoordTextBox";
            this.repeatWachtwoordTextBox.Size = new System.Drawing.Size(201, 20);
            this.repeatWachtwoordTextBox.TabIndex = 8;
            this.repeatWachtwoordTextBox.UseSystemPasswordChar = true;
            this.repeatWachtwoordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.repeatWachtwoordTextBox_Validating);
            this.repeatWachtwoordTextBox.Validated += new System.EventHandler(this.repeatWachtwoordTextBox_Validated);
            // 
            // wachtwoordTextBox
            // 
            this.wachtwoordTextBox.Location = new System.Drawing.Point(199, 42);
            this.wachtwoordTextBox.Name = "wachtwoordTextBox";
            this.wachtwoordTextBox.Size = new System.Drawing.Size(201, 20);
            this.wachtwoordTextBox.TabIndex = 7;
            this.wachtwoordTextBox.UseSystemPasswordChar = true;
            this.wachtwoordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.wachtwoordTextBox_Validating);
            this.wachtwoordTextBox.Validated += new System.EventHandler(this.wachtwoordTextBox_Validated);
            // 
            // repeatWachtwoordLabel
            // 
            this.repeatWachtwoordLabel.AutoSize = true;
            this.repeatWachtwoordLabel.Location = new System.Drawing.Point(27, 76);
            this.repeatWachtwoordLabel.Name = "repeatWachtwoordLabel";
            this.repeatWachtwoordLabel.Size = new System.Drawing.Size(105, 13);
            this.repeatWachtwoordLabel.TabIndex = 12;
            this.repeatWachtwoordLabel.Text = "Herhaal wachtwoord";
            // 
            // wachtwooordLabel
            // 
            this.wachtwooordLabel.AutoSize = true;
            this.wachtwooordLabel.Location = new System.Drawing.Point(27, 49);
            this.wachtwooordLabel.Name = "wachtwooordLabel";
            this.wachtwooordLabel.Size = new System.Drawing.Size(68, 13);
            this.wachtwooordLabel.TabIndex = 11;
            this.wachtwooordLabel.Text = "Wachtwoord";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gebruikersnaam";
            // 
            // opslaanButton
            // 
            this.opslaanButton.Location = new System.Drawing.Point(30, 132);
            this.opslaanButton.Name = "opslaanButton";
            this.opslaanButton.Size = new System.Drawing.Size(370, 23);
            this.opslaanButton.TabIndex = 10;
            this.opslaanButton.Text = "Opslaan";
            this.opslaanButton.UseVisualStyleBackColor = true;
            this.opslaanButton.Click += new System.EventHandler(this.opslaanButton_Click_1);
            // 
            // gebruikersnaamTextBox
            // 
            this.gebruikersnaamTextBox.Location = new System.Drawing.Point(199, 16);
            this.gebruikersnaamTextBox.Name = "gebruikersnaamTextBox";
            this.gebruikersnaamTextBox.Size = new System.Drawing.Size(201, 20);
            this.gebruikersnaamTextBox.TabIndex = 6;
            this.gebruikersnaamTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.gebruikersnaamTextBox_Validating);
            this.gebruikersnaamTextBox.Validated += new System.EventHandler(this.gebruikersnaamTextBox_Validated);
            // 
            // EigenOfNieuweGebruikerAanpassenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 193);
            this.Controls.Add(this.repeatWachtwoordTextBox);
            this.Controls.Add(this.wachtwoordTextBox);
            this.Controls.Add(this.repeatWachtwoordLabel);
            this.Controls.Add(this.wachtwooordLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opslaanButton);
            this.Controls.Add(this.gebruikersnaamTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EigenOfNieuweGebruikerAanpassenForm";
            this.Text = "NMBS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox repeatWachtwoordTextBox;
        private System.Windows.Forms.TextBox wachtwoordTextBox;
        private System.Windows.Forms.Label repeatWachtwoordLabel;
        private System.Windows.Forms.Label wachtwooordLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button opslaanButton;
        private System.Windows.Forms.TextBox gebruikersnaamTextBox;
    }
}