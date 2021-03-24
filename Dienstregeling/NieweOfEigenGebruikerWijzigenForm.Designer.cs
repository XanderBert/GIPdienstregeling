namespace Dienstregeling
{
    partial class GeselecteerdeGebruikerWijzigenForm
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
            this.gebruikersnaamTextBox = new System.Windows.Forms.TextBox();
            this.opslaanButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.wachtwooordLabel = new System.Windows.Forms.Label();
            this.repeatWachtwoordLabel = new System.Windows.Forms.Label();
            this.wachtwoordTextBox = new System.Windows.Forms.TextBox();
            this.repeatWachtwoordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gebruikersnaamTextBox
            // 
            this.gebruikersnaamTextBox.Location = new System.Drawing.Point(184, 6);
            this.gebruikersnaamTextBox.Name = "gebruikersnaamTextBox";
            this.gebruikersnaamTextBox.Size = new System.Drawing.Size(201, 20);
            this.gebruikersnaamTextBox.TabIndex = 0;
            this.gebruikersnaamTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.gebruikersnaamTextBox_Validating);
            this.gebruikersnaamTextBox.Validated += new System.EventHandler(this.gebruikersnaamTextBox_Validated);
            // 
            // opslaanButton
            // 
            this.opslaanButton.Location = new System.Drawing.Point(15, 122);
            this.opslaanButton.Name = "opslaanButton";
            this.opslaanButton.Size = new System.Drawing.Size(370, 23);
            this.opslaanButton.TabIndex = 3;
            this.opslaanButton.Text = "Opslaan";
            this.opslaanButton.UseVisualStyleBackColor = true;
            this.opslaanButton.Click += new System.EventHandler(this.opslaanButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gebruikersnaam";
            // 
            // wachtwooordLabel
            // 
            this.wachtwooordLabel.AutoSize = true;
            this.wachtwooordLabel.Location = new System.Drawing.Point(12, 39);
            this.wachtwooordLabel.Name = "wachtwooordLabel";
            this.wachtwooordLabel.Size = new System.Drawing.Size(68, 13);
            this.wachtwooordLabel.TabIndex = 4;
            this.wachtwooordLabel.Text = "Wachtwoord";
            // 
            // repeatWachtwoordLabel
            // 
            this.repeatWachtwoordLabel.AutoSize = true;
            this.repeatWachtwoordLabel.Location = new System.Drawing.Point(12, 66);
            this.repeatWachtwoordLabel.Name = "repeatWachtwoordLabel";
            this.repeatWachtwoordLabel.Size = new System.Drawing.Size(105, 13);
            this.repeatWachtwoordLabel.TabIndex = 5;
            this.repeatWachtwoordLabel.Text = "Herhaal wachtwoord";
            // 
            // wachtwoordTextBox
            // 
            this.wachtwoordTextBox.Location = new System.Drawing.Point(184, 32);
            this.wachtwoordTextBox.Name = "wachtwoordTextBox";
            this.wachtwoordTextBox.Size = new System.Drawing.Size(201, 20);
            this.wachtwoordTextBox.TabIndex = 1;
            this.wachtwoordTextBox.UseSystemPasswordChar = true;
            this.wachtwoordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.wachtwoordTextBox_Validating);
            this.wachtwoordTextBox.Validated += new System.EventHandler(this.wachtwoordTextBox_Validated);
            // 
            // repeatWachtwoordTextBox
            // 
            this.repeatWachtwoordTextBox.Location = new System.Drawing.Point(184, 58);
            this.repeatWachtwoordTextBox.Name = "repeatWachtwoordTextBox";
            this.repeatWachtwoordTextBox.Size = new System.Drawing.Size(201, 20);
            this.repeatWachtwoordTextBox.TabIndex = 2;
            this.repeatWachtwoordTextBox.UseSystemPasswordChar = true;
            this.repeatWachtwoordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.repeatWachtwoordTextBox_Validating);
            this.repeatWachtwoordTextBox.Validated += new System.EventHandler(this.repeatWachtwoordTextBox_Validated);
            // 
            // GeselecteerdeGebruikerWijzigenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 152);
            this.Controls.Add(this.repeatWachtwoordTextBox);
            this.Controls.Add(this.wachtwoordTextBox);
            this.Controls.Add(this.repeatWachtwoordLabel);
            this.Controls.Add(this.wachtwooordLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opslaanButton);
            this.Controls.Add(this.gebruikersnaamTextBox);
            this.Name = "GeselecteerdeGebruikerWijzigenForm";
            this.Text = "GeselecteerdeGebruikerWijzigenForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gebruikersnaamTextBox;
        private System.Windows.Forms.Button opslaanButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label wachtwooordLabel;
        private System.Windows.Forms.Label repeatWachtwoordLabel;
        private System.Windows.Forms.TextBox wachtwoordTextBox;
        private System.Windows.Forms.TextBox repeatWachtwoordTextBox;
    }
}