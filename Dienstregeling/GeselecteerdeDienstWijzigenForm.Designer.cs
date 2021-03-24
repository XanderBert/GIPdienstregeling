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
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trein Naam";
            // 
            // naamTextBox
            // 
            this.naamTextBox.Location = new System.Drawing.Point(147, 6);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(153, 20);
            this.naamTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vertrek Tijd";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vertrek Spoor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "WeekDienst";
            // 
            // opslaanButton
            // 
            this.opslaanButton.Location = new System.Drawing.Point(26, 176);
            this.opslaanButton.Name = "opslaanButton";
            this.opslaanButton.Size = new System.Drawing.Size(274, 23);
            this.opslaanButton.TabIndex = 16;
            this.opslaanButton.Text = "Opslaan";
            this.opslaanButton.UseVisualStyleBackColor = true;
            this.opslaanButton.Click += new System.EventHandler(this.opslaanButton_Click);
            // 
            // weekdienstCheckBox
            // 
            this.weekdienstCheckBox.AutoSize = true;
            this.weekdienstCheckBox.Location = new System.Drawing.Point(147, 144);
            this.weekdienstCheckBox.Name = "weekdienstCheckBox";
            this.weekdienstCheckBox.Size = new System.Drawing.Size(15, 14);
            this.weekdienstCheckBox.TabIndex = 17;
            this.weekdienstCheckBox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Bestemming";
            // 
            // vertrekDateTime
            // 
            this.vertrekDateTime.CustomFormat = "HH:mm";
            this.vertrekDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.vertrekDateTime.Location = new System.Drawing.Point(147, 59);
            this.vertrekDateTime.Name = "vertrekDateTime";
            this.vertrekDateTime.ShowUpDown = true;
            this.vertrekDateTime.Size = new System.Drawing.Size(59, 20);
            this.vertrekDateTime.TabIndex = 21;
            // 
            // aankomstDateTime
            // 
            this.aankomstDateTime.CustomFormat = "HH:mm";
            this.aankomstDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.aankomstDateTime.Location = new System.Drawing.Point(147, 85);
            this.aankomstDateTime.Name = "aankomstDateTime";
            this.aankomstDateTime.ShowUpDown = true;
            this.aankomstDateTime.Size = new System.Drawing.Size(59, 20);
            this.aankomstDateTime.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Aankomst Tijd";
            // 
            // bestemmingComboBox
            // 
            this.bestemmingComboBox.FormattingEnabled = true;
            this.bestemmingComboBox.Items.AddRange(new object[] {
            "Poperinge",
            "Komen",
            "Wervik",
            "Menen",
            "Wevelgem",
            "Bissegem",
            "Kortrijk"});
            this.bestemmingComboBox.Location = new System.Drawing.Point(147, 32);
            this.bestemmingComboBox.Name = "bestemmingComboBox";
            this.bestemmingComboBox.Size = new System.Drawing.Size(153, 21);
            this.bestemmingComboBox.TabIndex = 24;
            this.bestemmingComboBox.Text = "Poperinge";
            // 
            // verNumericUpDown
            // 
            this.verNumericUpDown.Location = new System.Drawing.Point(147, 111);
            this.verNumericUpDown.Name = "verNumericUpDown";
            this.verNumericUpDown.Size = new System.Drawing.Size(41, 20);
            this.verNumericUpDown.TabIndex = 25;
            // 
            // GeselecteerdeDienstWijzigenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 222);
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
            this.Name = "GeselecteerdeDienstWijzigenForm";
            this.Text = "Dienst";
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