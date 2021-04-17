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
            this.textLabel.Location = new System.Drawing.Point(149, 9);
            this.textLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(442, 24);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "Weet je zeker dat je dienst x wilt verwijderen ?";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // jaButton
            // 
            this.jaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jaButton.Location = new System.Drawing.Point(13, 52);
            this.jaButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jaButton.Name = "jaButton";
            this.jaButton.Size = new System.Drawing.Size(172, 30);
            this.jaButton.TabIndex = 1;
            this.jaButton.Text = "Ja";
            this.jaButton.UseVisualStyleBackColor = true;
            this.jaButton.Click += new System.EventHandler(this.jaButton_Click);
            // 
            // neeButton
            // 
            this.neeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.neeButton.Location = new System.Drawing.Point(545, 52);
            this.neeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.neeButton.Name = "neeButton";
            this.neeButton.Size = new System.Drawing.Size(196, 30);
            this.neeButton.TabIndex = 2;
            this.neeButton.Text = "Nee";
            this.neeButton.UseVisualStyleBackColor = true;
            this.neeButton.Click += new System.EventHandler(this.neeButton_Click);
            // 
            // GeselecteerdeDienstVerwijderenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(754, 118);
            this.Controls.Add(this.neeButton);
            this.Controls.Add(this.jaButton);
            this.Controls.Add(this.textLabel);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(770, 157);
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