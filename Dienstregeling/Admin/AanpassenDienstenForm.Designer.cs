namespace Dienstregeling
{
    partial class AanpassenDienstenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AanpassenDienstenForm));
            this.regelingListBox = new System.Windows.Forms.ListBox();
            this.geselecteerdeDieButton = new System.Windows.Forms.Button();
            this.selectedDiestVerwijderenButton = new System.Windows.Forms.Button();
            this.dienstToevoegenButton = new System.Windows.Forms.Button();
            this.terugButton = new System.Windows.Forms.Button();
            this.sorteerGemeenteComboBox = new System.Windows.Forms.ComboBox();
            this.weekdienstCheckBox = new System.Windows.Forms.CheckBox();
            this.dienstEnGebruikTabControl = new System.Windows.Forms.TabControl();
            this.dienstenTabPage = new System.Windows.Forms.TabPage();
            this.gebruikersTabPage = new System.Windows.Forms.TabPage();
            this.gebruikerToevoegenButton = new System.Windows.Forms.Button();
            this.gebruikerVerwijderenButton = new System.Windows.Forms.Button();
            this.gebruikerAanpassenButton = new System.Windows.Forms.Button();
            this.gebruikersListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterenAlsCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dienstEnGebruikTabControl.SuspendLayout();
            this.dienstenTabPage.SuspendLayout();
            this.gebruikersTabPage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // regelingListBox
            // 
            this.regelingListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regelingListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.regelingListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regelingListBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regelingListBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.regelingListBox.FormattingEnabled = true;
            this.regelingListBox.ItemHeight = 17;
            this.regelingListBox.Location = new System.Drawing.Point(4, 39);
            this.regelingListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.regelingListBox.Name = "regelingListBox";
            this.regelingListBox.Size = new System.Drawing.Size(1013, 325);
            this.regelingListBox.TabIndex = 1;
            // 
            // geselecteerdeDieButton
            // 
            this.geselecteerdeDieButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.geselecteerdeDieButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.geselecteerdeDieButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geselecteerdeDieButton.Image = global::Dienstregeling.Properties.Resources.ArrowIconWhite_Small;
            this.geselecteerdeDieButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.geselecteerdeDieButton.Location = new System.Drawing.Point(3, 400);
            this.geselecteerdeDieButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.geselecteerdeDieButton.Name = "geselecteerdeDieButton";
            this.geselecteerdeDieButton.Size = new System.Drawing.Size(1014, 38);
            this.geselecteerdeDieButton.TabIndex = 2;
            this.geselecteerdeDieButton.Text = "Geselecteerde Dienst Aanpassen";
            this.geselecteerdeDieButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.geselecteerdeDieButton.UseVisualStyleBackColor = false;
            this.geselecteerdeDieButton.Click += new System.EventHandler(this.geselecteerdeDieButton_Click);
            // 
            // selectedDiestVerwijderenButton
            // 
            this.selectedDiestVerwijderenButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedDiestVerwijderenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.selectedDiestVerwijderenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectedDiestVerwijderenButton.Image = global::Dienstregeling.Properties.Resources.ArrowIconWhite_Small;
            this.selectedDiestVerwijderenButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selectedDiestVerwijderenButton.Location = new System.Drawing.Point(3, 446);
            this.selectedDiestVerwijderenButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectedDiestVerwijderenButton.Name = "selectedDiestVerwijderenButton";
            this.selectedDiestVerwijderenButton.Size = new System.Drawing.Size(1014, 38);
            this.selectedDiestVerwijderenButton.TabIndex = 3;
            this.selectedDiestVerwijderenButton.Text = "Geselecteerde Deinst Verwijderen";
            this.selectedDiestVerwijderenButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectedDiestVerwijderenButton.UseVisualStyleBackColor = false;
            this.selectedDiestVerwijderenButton.Click += new System.EventHandler(this.selectedDiestVerwijderenButton_Click);
            // 
            // dienstToevoegenButton
            // 
            this.dienstToevoegenButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dienstToevoegenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.dienstToevoegenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dienstToevoegenButton.Image = global::Dienstregeling.Properties.Resources.ArrowIconWhite_Small;
            this.dienstToevoegenButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dienstToevoegenButton.Location = new System.Drawing.Point(3, 492);
            this.dienstToevoegenButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dienstToevoegenButton.Name = "dienstToevoegenButton";
            this.dienstToevoegenButton.Size = new System.Drawing.Size(1014, 38);
            this.dienstToevoegenButton.TabIndex = 4;
            this.dienstToevoegenButton.Text = "Dienst Toevoegen";
            this.dienstToevoegenButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dienstToevoegenButton.UseVisualStyleBackColor = false;
            this.dienstToevoegenButton.Click += new System.EventHandler(this.dienstToevoegenButton_Click);
            // 
            // terugButton
            // 
            this.terugButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.terugButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.terugButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.terugButton.Image = global::Dienstregeling.Properties.Resources.ArrowIconWhite_Small;
            this.terugButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.terugButton.Location = new System.Drawing.Point(7, 640);
            this.terugButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.terugButton.Name = "terugButton";
            this.terugButton.Size = new System.Drawing.Size(1017, 38);
            this.terugButton.TabIndex = 5;
            this.terugButton.Text = "Uitloggen";
            this.terugButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.terugButton.UseVisualStyleBackColor = false;
            this.terugButton.Click += new System.EventHandler(this.terugButton_Click);
            // 
            // sorteerGemeenteComboBox
            // 
            this.sorteerGemeenteComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sorteerGemeenteComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sorteerGemeenteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sorteerGemeenteComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.sorteerGemeenteComboBox.Items.AddRange(new object[] {
            "Poperinge",
            "TEST",
            "Wervik",
            "Menen",
            "Wevelgem",
            "Bissegem",
            "Kortrijk"});
            this.sorteerGemeenteComboBox.Location = new System.Drawing.Point(857, 4);
            this.sorteerGemeenteComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sorteerGemeenteComboBox.Name = "sorteerGemeenteComboBox";
            this.sorteerGemeenteComboBox.Size = new System.Drawing.Size(160, 25);
            this.sorteerGemeenteComboBox.TabIndex = 6;
            this.sorteerGemeenteComboBox.SelectedIndexChanged += new System.EventHandler(this.sorteerGemeenteComboBox_SelectedIndexChanged);
            // 
            // weekdienstCheckBox
            // 
            this.weekdienstCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.weekdienstCheckBox.AutoSize = true;
            this.weekdienstCheckBox.Location = new System.Drawing.Point(728, 6);
            this.weekdienstCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.weekdienstCheckBox.Name = "weekdienstCheckBox";
            this.weekdienstCheckBox.Size = new System.Drawing.Size(99, 21);
            this.weekdienstCheckBox.TabIndex = 7;
            this.weekdienstCheckBox.Text = "Weekdienst";
            this.weekdienstCheckBox.UseVisualStyleBackColor = true;
            this.weekdienstCheckBox.CheckedChanged += new System.EventHandler(this.weekdienstCheckBox_CheckedChanged);
            // 
            // dienstEnGebruikTabControl
            // 
            this.dienstEnGebruikTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dienstEnGebruikTabControl.Controls.Add(this.dienstenTabPage);
            this.dienstEnGebruikTabControl.Controls.Add(this.gebruikersTabPage);
            this.dienstEnGebruikTabControl.Location = new System.Drawing.Point(0, 29);
            this.dienstEnGebruikTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dienstEnGebruikTabControl.Name = "dienstEnGebruikTabControl";
            this.dienstEnGebruikTabControl.SelectedIndex = 0;
            this.dienstEnGebruikTabControl.Size = new System.Drawing.Size(1033, 578);
            this.dienstEnGebruikTabControl.TabIndex = 8;
            // 
            // dienstenTabPage
            // 
            this.dienstenTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.dienstenTabPage.Controls.Add(this.regelingListBox);
            this.dienstenTabPage.Controls.Add(this.weekdienstCheckBox);
            this.dienstenTabPage.Controls.Add(this.geselecteerdeDieButton);
            this.dienstenTabPage.Controls.Add(this.sorteerGemeenteComboBox);
            this.dienstenTabPage.Controls.Add(this.selectedDiestVerwijderenButton);
            this.dienstenTabPage.Controls.Add(this.dienstToevoegenButton);
            this.dienstenTabPage.Location = new System.Drawing.Point(4, 26);
            this.dienstenTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dienstenTabPage.Name = "dienstenTabPage";
            this.dienstenTabPage.Size = new System.Drawing.Size(1025, 548);
            this.dienstenTabPage.TabIndex = 0;
            this.dienstenTabPage.Text = "Diensten";
            // 
            // gebruikersTabPage
            // 
            this.gebruikersTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.gebruikersTabPage.Controls.Add(this.gebruikerToevoegenButton);
            this.gebruikersTabPage.Controls.Add(this.gebruikerVerwijderenButton);
            this.gebruikersTabPage.Controls.Add(this.gebruikerAanpassenButton);
            this.gebruikersTabPage.Controls.Add(this.gebruikersListBox);
            this.gebruikersTabPage.Location = new System.Drawing.Point(4, 26);
            this.gebruikersTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gebruikersTabPage.Name = "gebruikersTabPage";
            this.gebruikersTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gebruikersTabPage.Size = new System.Drawing.Size(1025, 539);
            this.gebruikersTabPage.TabIndex = 1;
            this.gebruikersTabPage.Text = "Gebruikers";
            // 
            // gebruikerToevoegenButton
            // 
            this.gebruikerToevoegenButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gebruikerToevoegenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.gebruikerToevoegenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gebruikerToevoegenButton.Image = global::Dienstregeling.Properties.Resources.ArrowIconWhite_Small;
            this.gebruikerToevoegenButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gebruikerToevoegenButton.Location = new System.Drawing.Point(8, 400);
            this.gebruikerToevoegenButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gebruikerToevoegenButton.Name = "gebruikerToevoegenButton";
            this.gebruikerToevoegenButton.Size = new System.Drawing.Size(1006, 38);
            this.gebruikerToevoegenButton.TabIndex = 7;
            this.gebruikerToevoegenButton.Text = "Gebruiker Toevoegen";
            this.gebruikerToevoegenButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gebruikerToevoegenButton.UseVisualStyleBackColor = false;
            this.gebruikerToevoegenButton.Click += new System.EventHandler(this.gebruikerToevoegenButton_Click);
            // 
            // gebruikerVerwijderenButton
            // 
            this.gebruikerVerwijderenButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gebruikerVerwijderenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.gebruikerVerwijderenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gebruikerVerwijderenButton.Image = global::Dienstregeling.Properties.Resources.ArrowIconWhite_Small;
            this.gebruikerVerwijderenButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gebruikerVerwijderenButton.Location = new System.Drawing.Point(8, 492);
            this.gebruikerVerwijderenButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gebruikerVerwijderenButton.Name = "gebruikerVerwijderenButton";
            this.gebruikerVerwijderenButton.Size = new System.Drawing.Size(1006, 38);
            this.gebruikerVerwijderenButton.TabIndex = 6;
            this.gebruikerVerwijderenButton.Text = "Geselecteerde Gebruiker Verwijderen";
            this.gebruikerVerwijderenButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gebruikerVerwijderenButton.UseVisualStyleBackColor = false;
            this.gebruikerVerwijderenButton.Click += new System.EventHandler(this.gebruikerVerwijderenButton_Click);
            // 
            // gebruikerAanpassenButton
            // 
            this.gebruikerAanpassenButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gebruikerAanpassenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.gebruikerAanpassenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gebruikerAanpassenButton.Image = global::Dienstregeling.Properties.Resources.ArrowIconWhite_Small;
            this.gebruikerAanpassenButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gebruikerAanpassenButton.Location = new System.Drawing.Point(8, 446);
            this.gebruikerAanpassenButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gebruikerAanpassenButton.Name = "gebruikerAanpassenButton";
            this.gebruikerAanpassenButton.Size = new System.Drawing.Size(1006, 38);
            this.gebruikerAanpassenButton.TabIndex = 5;
            this.gebruikerAanpassenButton.Text = "Geslecteerd Gebruiker Aanpassen";
            this.gebruikerAanpassenButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gebruikerAanpassenButton.UseVisualStyleBackColor = false;
            this.gebruikerAanpassenButton.Click += new System.EventHandler(this.gebruikerAanpassenButton_Click);
            // 
            // gebruikersListBox
            // 
            this.gebruikersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gebruikersListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.gebruikersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gebruikersListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.gebruikersListBox.FormattingEnabled = true;
            this.gebruikersListBox.ItemHeight = 17;
            this.gebruikersListBox.Location = new System.Drawing.Point(4, 8);
            this.gebruikersListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gebruikersListBox.Name = "gebruikersListBox";
            this.gebruikersListBox.Size = new System.Drawing.Size(1010, 376);
            this.gebruikersListBox.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1033, 25);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exporterenAlsCSVToolStripMenuItem});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.bestandToolStripMenuItem.Text = "Bestand";
            // 
            // exporterenAlsCSVToolStripMenuItem
            // 
            this.exporterenAlsCSVToolStripMenuItem.Name = "exporterenAlsCSVToolStripMenuItem";
            this.exporterenAlsCSVToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.exporterenAlsCSVToolStripMenuItem.Text = "Diensten exporteren als CSV";
            this.exporterenAlsCSVToolStripMenuItem.Click += new System.EventHandler(this.exporterenAlsCSVToolStripMenuItem_Click);
            // 
            // AanpassenDienstenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1033, 691);
            this.Controls.Add(this.dienstEnGebruikTabControl);
            this.Controls.Add(this.terugButton);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1049, 633);
            this.Name = "AanpassenDienstenForm";
            this.Text = "NMBS";
            this.dienstEnGebruikTabControl.ResumeLayout(false);
            this.dienstenTabPage.ResumeLayout(false);
            this.dienstenTabPage.PerformLayout();
            this.gebruikersTabPage.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox regelingListBox;
        private System.Windows.Forms.Button geselecteerdeDieButton;
        private System.Windows.Forms.Button selectedDiestVerwijderenButton;
        private System.Windows.Forms.Button dienstToevoegenButton;
        private System.Windows.Forms.Button terugButton;
        private System.Windows.Forms.CheckBox weekdienstCheckBox;
        private System.Windows.Forms.TabControl dienstEnGebruikTabControl;
        private System.Windows.Forms.TabPage dienstenTabPage;
        private System.Windows.Forms.TabPage gebruikersTabPage;
        private System.Windows.Forms.Button gebruikerToevoegenButton;
        private System.Windows.Forms.Button gebruikerVerwijderenButton;
        private System.Windows.Forms.Button gebruikerAanpassenButton;
        private System.Windows.Forms.ListBox gebruikersListBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporterenAlsCSVToolStripMenuItem;
        private System.Windows.Forms.ComboBox sorteerGemeenteComboBox;
    }
}