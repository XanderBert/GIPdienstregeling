namespace Dienstregeling
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.gebruikersnaamTextBox = new System.Windows.Forms.TextBox();
            this.wachtwoordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.gaTerugButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gebruikersnaamTextBox
            // 
            this.gebruikersnaamTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gebruikersnaamTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.gebruikersnaamTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gebruikersnaamTextBox.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gebruikersnaamTextBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gebruikersnaamTextBox.Location = new System.Drawing.Point(137, 12);
            this.gebruikersnaamTextBox.Name = "gebruikersnaamTextBox";
            this.gebruikersnaamTextBox.Size = new System.Drawing.Size(176, 22);
            this.gebruikersnaamTextBox.TabIndex = 1;
            // 
            // wachtwoordTextBox
            // 
            this.wachtwoordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wachtwoordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.wachtwoordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wachtwoordTextBox.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wachtwoordTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.wachtwoordTextBox.Location = new System.Drawing.Point(137, 44);
            this.wachtwoordTextBox.Name = "wachtwoordTextBox";
            this.wachtwoordTextBox.Size = new System.Drawing.Size(176, 22);
            this.wachtwoordTextBox.TabIndex = 2;
            this.wachtwoordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gebruikersnaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wachtwoord";
            // 
            // loginButton
            // 
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Image = global::Dienstregeling.Properties.Resources.ArrowIconWhite_Small;
            this.loginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginButton.Location = new System.Drawing.Point(0, 90);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(325, 35);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // gaTerugButton
            // 
            this.gaTerugButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gaTerugButton.FlatAppearance.BorderSize = 0;
            this.gaTerugButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gaTerugButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaTerugButton.Image = global::Dienstregeling.Properties.Resources.ArrowIconWhite_Small;
            this.gaTerugButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gaTerugButton.Location = new System.Drawing.Point(0, 147);
            this.gaTerugButton.Name = "gaTerugButton";
            this.gaTerugButton.Size = new System.Drawing.Size(325, 35);
            this.gaTerugButton.TabIndex = 7;
            this.gaTerugButton.Text = "Ga Terug";
            this.gaTerugButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gaTerugButton.UseVisualStyleBackColor = true;
            this.gaTerugButton.Click += new System.EventHandler(this.gaTerugButton_Click_1);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(325, 198);
            this.Controls.Add(this.gaTerugButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wachtwoordTextBox);
            this.Controls.Add(this.gebruikersnaamTextBox);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(341, 237);
            this.Name = "LoginForm";
            this.Text = "NMBS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox gebruikersnaamTextBox;
        private System.Windows.Forms.TextBox wachtwoordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button gaTerugButton;
    }
}

