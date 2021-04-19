namespace Dienstregeling
{
    partial class GeselecteerdeDienstWijzigenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeselecteerdeDienstWijzigenForm));
            this.label1 = new System.Windows.Forms.Label();
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.opslaanButton = new System.Windows.Forms.Button();
            this.weekdienstCheckBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.vertrekDateTime = new System.Windows.Forms.DateTimePicker();
            this.aankomstDateTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.bestemmingComboBox = new System.Windows.Forms.ComboBox();
            this.verNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.verNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trein Naam";
            // 
            // naamTextBox
            // 
            this.naamTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.naamTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.naamTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.naamTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.naamTextBox.Location = new System.Drawing.Point(196, 8);
            this.naamTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(203, 25);
            this.naamTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vertrek Tijd";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vertrek Spoor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 188);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "WeekDienst";
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
            this.opslaanButton.Location = new System.Drawing.Point(0, 247);
            this.opslaanButton.Margin = new System.Windows.Forms.Padding(4);
            this.opslaanButton.Name = "opslaanButton";
            this.opslaanButton.Size = new System.Drawing.Size(428, 30);
            this.opslaanButton.TabIndex = 16;
            this.opslaanButton.Text = "Opslaan";
            this.opslaanButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.opslaanButton.UseVisualStyleBackColor = false;
            this.opslaanButton.Click += new System.EventHandler(this.opslaanButton_Click);
            // 
            // weekdienstCheckBox
            // 
            this.weekdienstCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.weekdienstCheckBox.AutoSize = true;
            this.weekdienstCheckBox.Location = new System.Drawing.Point(196, 188);
            this.weekdienstCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.weekdienstCheckBox.Name = "weekdienstCheckBox";
            this.weekdienstCheckBox.Size = new System.Drawing.Size(15, 14);
            this.weekdienstCheckBox.TabIndex = 17;
            this.weekdienstCheckBox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 47);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Bestemming";
            // 
            // vertrekDateTime
            // 
            this.vertrekDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vertrekDateTime.CustomFormat = "HH:mm";
            this.vertrekDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.vertrekDateTime.Location = new System.Drawing.Point(196, 77);
            this.vertrekDateTime.Margin = new System.Windows.Forms.Padding(4);
            this.vertrekDateTime.Name = "vertrekDateTime";
            this.vertrekDateTime.ShowUpDown = true;
            this.vertrekDateTime.Size = new System.Drawing.Size(77, 25);
            this.vertrekDateTime.TabIndex = 21;
            // 
            // aankomstDateTime
            // 
            this.aankomstDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aankomstDateTime.CustomFormat = "HH:mm";
            this.aankomstDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.aankomstDateTime.Location = new System.Drawing.Point(196, 111);
            this.aankomstDateTime.Margin = new System.Windows.Forms.Padding(4);
            this.aankomstDateTime.Name = "aankomstDateTime";
            this.aankomstDateTime.ShowUpDown = true;
            this.aankomstDateTime.Size = new System.Drawing.Size(77, 25);
            this.aankomstDateTime.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Aankomst Tijd";
            // 
            // bestemmingComboBox
            // 
            this.bestemmingComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bestemmingComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.bestemmingComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.bestemmingComboBox.FormattingEnabled = true;
            this.bestemmingComboBox.Items.AddRange(new object[] {
            "Poperinge",
            "Komen",
            "Wervik",
            "Menen",
            "Wevelgem",
            "Bissegem",
            "Kortrijk"});
            this.bestemmingComboBox.Location = new System.Drawing.Point(196, 42);
            this.bestemmingComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.bestemmingComboBox.Name = "bestemmingComboBox";
            this.bestemmingComboBox.Size = new System.Drawing.Size(203, 25);
            this.bestemmingComboBox.TabIndex = 24;
            this.bestemmingComboBox.Text = "Poperinge";
            // 
            // verNumericUpDown
            // 
            this.verNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.verNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.verNumericUpDown.ForeColor = System.Drawing.SystemColors.Window;
            this.verNumericUpDown.Location = new System.Drawing.Point(196, 145);
            this.verNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.verNumericUpDown.Name = "verNumericUpDown";
            this.verNumericUpDown.Size = new System.Drawing.Size(55, 25);
            this.verNumericUpDown.TabIndex = 25;
            // 
            // GeselecteerdeDienstWijzigenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(431, 290);
            this.Controls.Add(this.verNumericUpDown);
            this.Controls.Add(this.bestemmingComboBox);
            this.Controls.Add(this.aankomstDateTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vertrekDateTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.weekdienstCheckBox);
            this.Controls.Add(this.opslaanButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.naamTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(447, 329);
            this.Name = "GeselecteerdeDienstWijzigenForm";
            this.Text = "NMBS";
            ((System.ComponentModel.ISupportInitialize)(this.verNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox naamTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button opslaanButton;
        private System.Windows.Forms.CheckBox weekdienstCheckBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker vertrekDateTime;
        private System.Windows.Forms.DateTimePicker aankomstDateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox bestemmingComboBox;
        private System.Windows.Forms.NumericUpDown verNumericUpDown;
    }
}