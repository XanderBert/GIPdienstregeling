namespace Dienstregeling
{
    partial class GeselecteerdeDienstVerwijderenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeselecteerdeDienstVerwijderenForm));
            this.textLabel = new System.Windows.Forms.Label();
            this.jaButton = new System.Windows.Forms.Button();
            this.neeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.textLabel.Location = new System.Drawing.Point(12, 23);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(442, 24);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "Weet je zeker dat je dienst x wilt verwijderen ?";
            // 
            // jaButton
            // 
            this.jaButton.Location = new System.Drawing.Point(16, 62);
            this.jaButton.Name = "jaButton";
            this.jaButton.Size = new System.Drawing.Size(207, 23);
            this.jaButton.TabIndex = 1;
            this.jaButton.Text = "Ja";
            this.jaButton.UseVisualStyleBackColor = true;
            this.jaButton.Click += new System.EventHandler(this.jaButton_Click);
            // 
            // neeButton
            // 
            this.neeButton.Location = new System.Drawing.Point(229, 62);
            this.neeButton.Name = "neeButton";
            this.neeButton.Size = new System.Drawing.Size(225, 23);
            this.neeButton.TabIndex = 2;
            this.neeButton.Text = "Nee";
            this.neeButton.UseVisualStyleBackColor = true;
            this.neeButton.Click += new System.EventHandler(this.neeButton_Click);
            // 
            // GeselecteerdeDienstVerwijderenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 112);
            this.Controls.Add(this.neeButton);
            this.Controls.Add(this.jaButton);
            this.Controls.Add(this.textLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeselecteerdeDienstVerwijderenForm";
            this.Text = "NMBS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Button jaButton;
        private System.Windows.Forms.Button neeButton;
    }
}