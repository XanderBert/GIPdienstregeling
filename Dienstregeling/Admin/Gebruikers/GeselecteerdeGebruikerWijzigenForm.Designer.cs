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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeselecteerdeGebruikerWijzigenForm));
            this.gebruikersnaamTextBox = new System.Windows.Forms.TextBox();
            this.opslaanButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gebruikersnaamTextBox
            // 
            this.gebruikersnaamTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gebruikersnaamTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.gebruikersnaamTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gebruikersnaamTextBox.Location = new System.Drawing.Point(261, 10);
            this.gebruikersnaamTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.gebruikersnaamTextBox.Name = "gebruikersnaamTextBox";
            this.gebruikersnaamTextBox.Size = new System.Drawing.Size(267, 25);
            this.gebruikersnaamTextBox.TabIndex = 0;
            this.gebruikersnaamTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.gebruikersnaamTextBox_Validating);
            this.gebruikersnaamTextBox.Validated += new System.EventHandler(this.gebruikersnaamTextBox_Validated);
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
            this.opslaanButton.Location = new System.Drawing.Point(1, 54);
            this.opslaanButton.Margin = new System.Windows.Forms.Padding(4);
            this.opslaanButton.Name = "opslaanButton";
            this.opslaanButton.Size = new System.Drawing.Size(539, 30);
            this.opslaanButton.TabIndex = 3;
            this.opslaanButton.Text = "Opslaan";
            this.opslaanButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.opslaanButton.UseVisualStyleBackColor = false;
            this.opslaanButton.Click += new System.EventHandler(this.opslaanButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gebruikersnaam";
            // 
            // GeselecteerdeGebruikerWijzigenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(541, 89);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opslaanButton);
            this.Controls.Add(this.gebruikersnaamTextBox);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(557, 128);
            this.Name = "GeselecteerdeGebruikerWijzigenForm";
            this.Text = "NMBS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gebruikersnaamTextBox;
        private System.Windows.Forms.Button opslaanButton;
        private System.Windows.Forms.Label label1;
    }
}