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
            this.regelingListBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regelingListBox.FormattingEnabled = true;
            this.regelingListBox.ItemHeight = 17;
            this.regelingListBox.Location = new System.Drawing.Point(6, 33);
            this.regelingListBox.Name = "regelingListBox";
            this.regelingListBox.Size = new System.Drawing.Size(733, 276);
            this.regelingListBox.TabIndex = 1;
            // 
            // geselecteerdeDieButton
            // 
            this.geselecteerdeDieButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.geselecteerdeDieButton.Location = new System.Drawing.Point(6, 325);
            this.geselecteerdeDieButton.Name = "geselecteerdeDieButton";
            this.geselecteerdeDieButton.Size = new System.Drawing.Size(733, 23);
            this.geselecteerdeDieButton.TabIndex = 2;
            this.geselecteerdeDieButton.Text = "Geselecteerde Dienst Aanpassen";
            this.geselecteerdeDieButton.UseVisualStyleBackColor = true;
            this.geselecteerdeDieButton.Click += new System.EventHandler(this.geselecteerdeDieButton_Click);
            // 
            // selectedDiestVerwijderenButton
            // 
            this.selectedDiestVerwijderenButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedDiestVerwijderenButton.Location = new System.Drawing.Point(6, 354);
            this.selectedDiestVerwijderenButton.Name = "selectedDiestVerwijderenButton";
            this.selectedDiestVerwijderenButton.Size = new System.Drawing.Size(733, 23);
            this.selectedDiestVerwijderenButton.TabIndex = 3;
            this.selectedDiestVerwijderenButton.Text = "Geselecteerde Deinst Verwijderen";
            this.selectedDiestVerwijderenButton.UseVisualStyleBackColor = true;
            this.selectedDiestVerwijderenButton.Click += new System.EventHandler(this.selectedDiestVerwijderenButton_Click);
            // 
            // dienstToevoegenButton
            // 
            this.dienstToevoegenButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dienstToevoegenButton.Location = new System.Drawing.Point(6, 383);
            this.dienstToevoegenButton.Name = "dienstToevoegenButton";
            this.dienstToevoegenButton.Size = new System.Drawing.Size(733, 23);
            this.dienstToevoegenButton.TabIndex = 4;
            this.dienstToevoegenButton.Text = "Dienst Toevoegen";
            this.dienstToevoegenButton.UseVisualStyleBackColor = true;
            this.dienstToevoegenButton.Click += new System.EventHandler(this.dienstToevoegenButton_Click);
            // 
            // terugButton
            // 
            this.terugButton.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.terugButton.Location = new System.Drawing.Point(12, 61);
            this.terugButton.Name = "terugButton";
            this.terugButton.Size = new System.Drawing.Size(116, 23);
            this.terugButton.TabIndex = 5;
            this.terugButton.Text = "Uitloggen";
            this.terugButton.UseVisualStyleBackColor = true;
            this.terugButton.Click += new System.EventHandler(this.terugButton_Click);
            // 
            // sorteerGemeenteComboBox
            // 
            this.sorteerGemeenteComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sorteerGemeenteComboBox.FormattingEnabled = true;
            this.sorteerGemeenteComboBox.Items.AddRange(new object[] {
            "Poperinge",
            "TEST",
            "Wervik",
            "Menen",
            "Wevelgem",
            "Bissegem",
            "Kortrijk"});
            this.sorteerGemeenteComboBox.Location = new System.Drawing.Point(618, 6);
            this.sorteerGemeenteComboBox.Name = "sorteerGemeenteComboBox";
            this.sorteerGemeenteComboBox.Size = new System.Drawing.Size(121, 21);
            this.sorteerGemeenteComboBox.TabIndex = 6;
            this.sorteerGemeenteComboBox.Text = "Poperinge";
            this.sorteerGemeenteComboBox.SelectedIndexChanged += new System.EventHandler(this.sorteerGemeenteComboBox_SelectedIndexChanged);
            // 
            // weekdienstCheckBox
            // 
            this.weekdienstCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.weekdienstCheckBox.AutoSize = true;
            this.weekdienstCheckBox.Location = new System.Drawing.Point(512, 8);
            this.weekdienstCheckBox.Name = "weekdienstCheckBox";
            this.weekdienstCheckBox.Size = new System.Drawing.Size(83, 17);
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
            this.dienstEnGebruikTabControl.Location = new System.Drawing.Point(12, 90);
            this.dienstEnGebruikTabControl.Name = "dienstEnGebruikTabControl";
            this.dienstEnGebruikTabControl.SelectedIndex = 0;
            this.dienstEnGebruikTabControl.Size = new System.Drawing.Size(753, 437);
            this.dienstEnGebruikTabControl.TabIndex = 8;
            // 
            // dienstenTabPage
            // 
            this.dienstenTabPage.Controls.Add(this.regelingListBox);
            this.dienstenTabPage.Controls.Add(this.weekdienstCheckBox);
            this.dienstenTabPage.Controls.Add(this.geselecteerdeDieButton);
            this.dienstenTabPage.Controls.Add(this.sorteerGemeenteComboBox);
            this.dienstenTabPage.Controls.Add(this.selectedDiestVerwijderenButton);
            this.dienstenTabPage.Controls.Add(this.dienstToevoegenButton);
            this.dienstenTabPage.Location = new System.Drawing.Point(4, 22);
            this.dienstenTabPage.Name = "dienstenTabPage";
            this.dienstenTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dienstenTabPage.Size = new System.Drawing.Size(745, 411);
            this.dienstenTabPage.TabIndex = 0;
            this.dienstenTabPage.Text = "Diensten";
            this.dienstenTabPage.UseVisualStyleBackColor = true;
            // 
            // gebruikersTabPage
            // 
            this.gebruikersTabPage.Controls.Add(this.gebruikerToevoegenButton);
            this.gebruikersTabPage.Controls.Add(this.gebruikerVerwijderenButton);
            this.gebruikersTabPage.Controls.Add(this.gebruikerAanpassenButton);
            this.gebruikersTabPage.Controls.Add(this.gebruikersListBox);
            this.gebruikersTabPage.Location = new System.Drawing.Point(4, 22);
            this.gebruikersTabPage.Name = "gebruikersTabPage";
            this.gebruikersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.gebruikersTabPage.Size = new System.Drawing.Size(745, 376);
            this.gebruikersTabPage.TabIndex = 1;
            this.gebruikersTabPage.Text = "Gebruikers";
            this.gebruikersTabPage.UseVisualStyleBackColor = true;
            // 
            // gebruikerToevoegenButton
            // 
            this.gebruikerToevoegenButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gebruikerToevoegenButton.Location = new System.Drawing.Point(6, 289);
            this.gebruikerToevoegenButton.Name = "gebruikerToevoegenButton";
            this.gebruikerToevoegenButton.Size = new System.Drawing.Size(733, 23);
            this.gebruikerToevoegenButton.TabIndex = 7;
            this.gebruikerToevoegenButton.Text = "Gebruiker Toevoegen";
            this.gebruikerToevoegenButton.UseVisualStyleBackColor = true;
            this.gebruikerToevoegenButton.Click += new System.EventHandler(this.gebruikerToevoegenButton_Click);
            // 
            // gebruikerVerwijderenButton
            // 
            this.gebruikerVerwijderenButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gebruikerVerwijderenButton.Location = new System.Drawing.Point(6, 347);
            this.gebruikerVerwijderenButton.Name = "gebruikerVerwijderenButton";
            this.gebruikerVerwijderenButton.Size = new System.Drawing.Size(733, 23);
            this.gebruikerVerwijderenButton.TabIndex = 6;
            this.gebruikerVerwijderenButton.Text = "Geselecteerde Gebruiker Verwijderen";
            this.gebruikerVerwijderenButton.UseVisualStyleBackColor = true;
            this.gebruikerVerwijderenButton.Click += new System.EventHandler(this.gebruikerVerwijderenButton_Click);
            // 
            // gebruikerAanpassenButton
            // 
            this.gebruikerAanpassenButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gebruikerAanpassenButton.Location = new System.Drawing.Point(6, 318);
            this.gebruikerAanpassenButton.Name = "gebruikerAanpassenButton";
            this.gebruikerAanpassenButton.Size = new System.Drawing.Size(733, 23);
            this.gebruikerAanpassenButton.TabIndex = 5;
            this.gebruikerAanpassenButton.Text = "Geslecteerd Gebruiker Aanpassen";
            this.gebruikerAanpassenButton.UseVisualStyleBackColor = true;
            this.gebruikerAanpassenButton.Click += new System.EventHandler(this.gebruikerAanpassenButton_Click);
            // 
            // gebruikersListBox
            // 
            this.gebruikersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gebruikersListBox.FormattingEnabled = true;
            this.gebruikersListBox.Location = new System.Drawing.Point(6, 6);
            this.gebruikersListBox.Name = "gebruikersListBox";
            this.gebruikersListBox.Size = new System.Drawing.Size(733, 277);
            this.gebruikersListBox.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exporterenAlsCSVToolStripMenuItem});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 538);
            this.Controls.Add(this.dienstEnGebruikTabControl);
            this.Controls.Add(this.terugButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(791, 493);
            this.Name = "AanpassenDienstenForm";
            this.Text = "AanpassenDiensten";
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
        private System.Windows.Forms.ComboBox sorteerGemeenteComboBox;
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
    }
}