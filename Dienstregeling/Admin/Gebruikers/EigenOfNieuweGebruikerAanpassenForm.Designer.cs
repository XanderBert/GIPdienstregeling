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
            this.repeatWachtwoordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.repeatWachtwoordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.repeatWachtwoordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.repeatWachtwoordTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.repeatWachtwoordTextBox.Location = new System.Drawing.Point(311, 89);
            this.repeatWachtwoordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.repeatWachtwoordTextBox.Name = "repeatWachtwoordTextBox";
            this.repeatWachtwoordTextBox.Size = new System.Drawing.Size(267, 25);
            this.repeatWachtwoordTextBox.TabIndex = 8;
            this.repeatWachtwoordTextBox.UseSystemPasswordChar = true;
            this.repeatWachtwoordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.repeatWachtwoordTextBox_Validating);
            this.repeatWachtwoordTextBox.Validated += new System.EventHandler(this.repeatWachtwoordTextBox_Validated);
            // 
            // wachtwoordTextBox
            // 
            this.wachtwoordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wachtwoordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.wachtwoordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wachtwoordTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.wachtwoordTextBox.Location = new System.Drawing.Point(311, 55);
            this.wachtwoordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wachtwoordTextBox.Name = "wachtwoordTextBox";
            this.wachtwoordTextBox.Size = new System.Drawing.Size(267, 25);
            this.wachtwoordTextBox.TabIndex = 7;
            this.wachtwoordTextBox.UseSystemPasswordChar = true;
            this.wachtwoordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.wachtwoordTextBox_Validating);
            this.wachtwoordTextBox.Validated += new System.EventHandler(this.wachtwoordTextBox_Validated);
            // 
            // repeatWachtwoordLabel
            // 
            this.repeatWachtwoordLabel.AutoSize = true;
            this.repeatWachtwoordLabel.Location = new System.Drawing.Point(12, 99);
            this.repeatWachtwoordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.repeatWachtwoordLabel.Name = "repeatWachtwoordLabel";
            this.repeatWachtwoordLabel.Size = new System.Drawing.Size(135, 17);
            this.repeatWachtwoordLabel.TabIndex = 12;
            this.repeatWachtwoordLabel.Text = "Herhaal wachtwoord";
            // 
            // wachtwooordLabel
            // 
            this.wachtwooordLabel.AutoSize = true;
            this.wachtwooordLabel.Location = new System.Drawing.Point(12, 64);
            this.wachtwooordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wachtwooordLabel.Name = "wachtwooordLabel";
            this.wachtwooordLabel.Size = new System.Drawing.Size(86, 17);
            this.wachtwooordLabel.TabIndex = 11;
            this.wachtwooordLabel.Text = "Wachtwoord";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gebruikersnaam";
            // 
            // opslaanButton
            // 
            this.opslaanButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opslaanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.opslaanButton.FlatAppearance.BorderSize = 0;
            this.opslaanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opslaanButton.Image = global::Dienstregeling.Properties.Resources.ArrowIconWhite_Small;
            this.opslaanButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.opslaanButton.Location = new System.Drawing.Point(2, 125);
            this.opslaanButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.opslaanButton.Name = "opslaanButton";
            this.opslaanButton.Size = new System.Drawing.Size(581, 30);
            this.opslaanButton.TabIndex = 10;
            this.opslaanButton.Text = "Opslaan";
            this.opslaanButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.opslaanButton.UseVisualStyleBackColor = false;
            this.opslaanButton.Click += new System.EventHandler(this.opslaanButton_Click_1);
            // 
            // gebruikersnaamTextBox
            // 
            this.gebruikersnaamTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gebruikersnaamTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.gebruikersnaamTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gebruikersnaamTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.gebruikersnaamTextBox.Location = new System.Drawing.Point(311, 21);
            this.gebruikersnaamTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gebruikersnaamTextBox.Name = "gebruikersnaamTextBox";
            this.gebruikersnaamTextBox.Size = new System.Drawing.Size(267, 25);
            this.gebruikersnaamTextBox.TabIndex = 6;
            this.gebruikersnaamTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.gebruikersnaamTextBox_Validating);
            this.gebruikersnaamTextBox.Validated += new System.EventHandler(this.gebruikersnaamTextBox_Validated);
            // 
            // EigenOfNieuweGebruikerAanpassenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(585, 161);
            this.Controls.Add(this.repeatWachtwoordTextBox);
            this.Controls.Add(this.wachtwoordTextBox);
            this.Controls.Add(this.repeatWachtwoordLabel);
            this.Controls.Add(this.wachtwooordLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opslaanButton);
            this.Controls.Add(this.gebruikersnaamTextBox);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(601, 200);
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