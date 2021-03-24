namespace Dienstregeling
{
    partial class Welkom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welkom));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uurNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gaDienstregelingButton = new System.Windows.Forms.Button();
            this.gaLoginButton = new System.Windows.Forms.Button();
            this.weekdienstCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BestemmingComboBox = new System.Windows.Forms.ComboBox();
            this.weekLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uurNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vertrek Uur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bestemming";
            // 
            // uurNumericUpDown
            // 
            this.uurNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uurNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.uurNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uurNumericUpDown.ForeColor = System.Drawing.SystemColors.Window;
            this.uurNumericUpDown.Location = new System.Drawing.Point(240, 53);
            this.uurNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.uurNumericUpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.uurNumericUpDown.MaximumSize = new System.Drawing.Size(300, 0);
            this.uurNumericUpDown.Name = "uurNumericUpDown";
            this.uurNumericUpDown.Size = new System.Drawing.Size(192, 21);
            this.uurNumericUpDown.TabIndex = 4;
            this.uurNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gaDienstregelingButton
            // 
            this.gaDienstregelingButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gaDienstregelingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.gaDienstregelingButton.FlatAppearance.BorderSize = 0;
            this.gaDienstregelingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gaDienstregelingButton.Image = global::Dienstregeling.Properties.Resources.ArrowIconWhite_Small;
            this.gaDienstregelingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gaDienstregelingButton.Location = new System.Drawing.Point(-1, 190);
            this.gaDienstregelingButton.Margin = new System.Windows.Forms.Padding(4);
            this.gaDienstregelingButton.Name = "gaDienstregelingButton";
            this.gaDienstregelingButton.Size = new System.Drawing.Size(449, 46);
            this.gaDienstregelingButton.TabIndex = 6;
            this.gaDienstregelingButton.Text = "Ga naar de Dienstregeling";
            this.gaDienstregelingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gaDienstregelingButton.UseVisualStyleBackColor = false;
            this.gaDienstregelingButton.Click += new System.EventHandler(this.gaDienstregelingButton_Click);
            // 
            // gaLoginButton
            // 
            this.gaLoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gaLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.gaLoginButton.FlatAppearance.BorderSize = 0;
            this.gaLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gaLoginButton.Image = global::Dienstregeling.Properties.Resources.ArrowIconWhite_Small;
            this.gaLoginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gaLoginButton.Location = new System.Drawing.Point(-1, 244);
            this.gaLoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.gaLoginButton.Name = "gaLoginButton";
            this.gaLoginButton.Size = new System.Drawing.Size(449, 46);
            this.gaLoginButton.TabIndex = 7;
            this.gaLoginButton.Text = "Ga Naar Login";
            this.gaLoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gaLoginButton.UseVisualStyleBackColor = false;
            this.gaLoginButton.Click += new System.EventHandler(this.gaLoginButton_Click);
            // 
            // weekdienstCheckBox
            // 
            this.weekdienstCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.weekdienstCheckBox.AutoSize = true;
            this.weekdienstCheckBox.Checked = true;
            this.weekdienstCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.weekdienstCheckBox.Location = new System.Drawing.Point(265, 138);
            this.weekdienstCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.weekdienstCheckBox.Name = "weekdienstCheckBox";
            this.weekdienstCheckBox.Size = new System.Drawing.Size(15, 14);
            this.weekdienstCheckBox.TabIndex = 8;
            this.weekdienstCheckBox.UseVisualStyleBackColor = true;
            this.weekdienstCheckBox.CheckedChanged += new System.EventHandler(this.weekdienstCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Is de reis in de week?";
            // 
            // BestemmingComboBox
            // 
            this.BestemmingComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
            this.BestemmingComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BestemmingComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "kakakakakakakak",
            "Komen",
            "Wervik",
            "Menen",
            "Wevelgem",
            "Bissegem",
            "Kortrijk"});
            this.BestemmingComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.BestemmingComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BestemmingComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.BestemmingComboBox.FormattingEnabled = true;
            this.BestemmingComboBox.Items.AddRange(new object[] {
            "TESTTEST",
            "TESATSTET",
            "Wervik",
            "Menen",
            "Wevelgem",
            "Bissegem",
            "Kortrijk"});
            this.BestemmingComboBox.Location = new System.Drawing.Point(240, 92);
            this.BestemmingComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.BestemmingComboBox.Name = "BestemmingComboBox";
            this.BestemmingComboBox.Size = new System.Drawing.Size(192, 25);
            this.BestemmingComboBox.TabIndex = 11;
            this.BestemmingComboBox.Text = "Poperinge";
            // 
            // weekLabel
            // 
            this.weekLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.weekLabel.AutoSize = true;
            this.weekLabel.Location = new System.Drawing.Point(237, 134);
            this.weekLabel.Name = "weekLabel";
            this.weekLabel.Size = new System.Drawing.Size(21, 17);
            this.weekLabel.TabIndex = 13;
            this.weekLabel.Text = "Ja";
            // 
            // Welkom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(447, 303);
            this.Controls.Add(this.weekLabel);
            this.Controls.Add(this.BestemmingComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weekdienstCheckBox);
            this.Controls.Add(this.gaLoginButton);
            this.Controls.Add(this.gaDienstregelingButton);
            this.Controls.Add(this.uurNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(463, 342);
            this.Name = "Welkom";
            this.Text = "NMBS";
            ((System.ComponentModel.ISupportInitialize)(this.uurNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown uurNumericUpDown;
        private System.Windows.Forms.Button gaDienstregelingButton;
        private System.Windows.Forms.Button gaLoginButton;
        private System.Windows.Forms.CheckBox weekdienstCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BestemmingComboBox;
        private System.Windows.Forms.Label weekLabel;
    }
}