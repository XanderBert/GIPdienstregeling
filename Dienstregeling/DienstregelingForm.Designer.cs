namespace Dienstregeling
{
    partial class DienstregelingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DienstregelingForm));
            this.regelingListBox = new System.Windows.Forms.ListBox();
            this.toonDienstForm = new System.Windows.Forms.Button();
            this.sluitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // regelingListBox
            // 
            this.regelingListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regelingListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.regelingListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.regelingListBox.FormattingEnabled = true;
            this.regelingListBox.ItemHeight = 17;
            this.regelingListBox.Location = new System.Drawing.Point(13, 13);
            this.regelingListBox.Margin = new System.Windows.Forms.Padding(4);
            this.regelingListBox.Name = "regelingListBox";
            this.regelingListBox.Size = new System.Drawing.Size(746, 225);
            this.regelingListBox.TabIndex = 0;
            // 
            // toonDienstForm
            // 
            this.toonDienstForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toonDienstForm.FlatAppearance.BorderSize = 0;
            this.toonDienstForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toonDienstForm.Image = global::Dienstregeling.Properties.Resources.ArrowIconWhite_Small;
            this.toonDienstForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toonDienstForm.Location = new System.Drawing.Point(13, 261);
            this.toonDienstForm.Margin = new System.Windows.Forms.Padding(4);
            this.toonDienstForm.Name = "toonDienstForm";
            this.toonDienstForm.Size = new System.Drawing.Size(746, 30);
            this.toonDienstForm.TabIndex = 1;
            this.toonDienstForm.Text = "Toon Geselecteerde Dienst";
            this.toonDienstForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toonDienstForm.UseVisualStyleBackColor = true;
            this.toonDienstForm.Click += new System.EventHandler(this.toonDienstForm_Click);
            // 
            // sluitButton
            // 
            this.sluitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sluitButton.FlatAppearance.BorderSize = 0;
            this.sluitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sluitButton.Image = global::Dienstregeling.Properties.Resources.ArrowIconWhite_Small;
            this.sluitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sluitButton.Location = new System.Drawing.Point(13, 299);
            this.sluitButton.Margin = new System.Windows.Forms.Padding(4);
            this.sluitButton.Name = "sluitButton";
            this.sluitButton.Size = new System.Drawing.Size(746, 30);
            this.sluitButton.TabIndex = 2;
            this.sluitButton.Text = "Terug";
            this.sluitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sluitButton.UseVisualStyleBackColor = true;
            this.sluitButton.Click += new System.EventHandler(this.sluitButton_Click);
            // 
            // DienstregelingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(772, 344);
            this.Controls.Add(this.sluitButton);
            this.Controls.Add(this.toonDienstForm);
            this.Controls.Add(this.regelingListBox);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(788, 383);
            this.Name = "DienstregelingForm";
            this.Text = "Dienstregeling";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox regelingListBox;
        private System.Windows.Forms.Button toonDienstForm;
        private System.Windows.Forms.Button sluitButton;
    }
}