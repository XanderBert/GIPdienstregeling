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
            this.gaDienstregelingButton = new System.Windows.Forms.Button();
            this.gaLoginButton = new System.Windows.Forms.Button();
            this.weekdienstCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BestemmingComboBox = new System.Windows.Forms.ComboBox();
            this.weekLabel = new System.Windows.Forms.Label();
            this.vertrekDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // gaDienstregelingButton
            // 
            resources.ApplyResources(this.gaDienstregelingButton, "gaDienstregelingButton");
            this.gaDienstregelingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.gaDienstregelingButton.FlatAppearance.BorderSize = 0;
            this.gaDienstregelingButton.Image = global::Dienstregeling.Properties.Resources.ArrowIconWhite_Small;
            this.gaDienstregelingButton.Name = "gaDienstregelingButton";
            this.gaDienstregelingButton.UseVisualStyleBackColor = false;
            this.gaDienstregelingButton.Click += new System.EventHandler(this.gaDienstregelingButton_Click);
            // 
            // gaLoginButton
            // 
            resources.ApplyResources(this.gaLoginButton, "gaLoginButton");
            this.gaLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.gaLoginButton.FlatAppearance.BorderSize = 0;
            this.gaLoginButton.Image = global::Dienstregeling.Properties.Resources.ArrowIconWhite_Small;
            this.gaLoginButton.Name = "gaLoginButton";
            this.gaLoginButton.UseVisualStyleBackColor = false;
            this.gaLoginButton.Click += new System.EventHandler(this.gaLoginButton_Click);
            // 
            // weekdienstCheckBox
            // 
            resources.ApplyResources(this.weekdienstCheckBox, "weekdienstCheckBox");
            this.weekdienstCheckBox.Checked = true;
            this.weekdienstCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.weekdienstCheckBox.Name = "weekdienstCheckBox";
            this.weekdienstCheckBox.UseVisualStyleBackColor = true;
            this.weekdienstCheckBox.CheckedChanged += new System.EventHandler(this.weekdienstCheckBox_CheckedChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // BestemmingComboBox
            // 
            this.BestemmingComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
            resources.ApplyResources(this.BestemmingComboBox, "BestemmingComboBox");
            this.BestemmingComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("BestemmingComboBox.AutoCompleteCustomSource"),
            resources.GetString("BestemmingComboBox.AutoCompleteCustomSource1"),
            resources.GetString("BestemmingComboBox.AutoCompleteCustomSource2"),
            resources.GetString("BestemmingComboBox.AutoCompleteCustomSource3"),
            resources.GetString("BestemmingComboBox.AutoCompleteCustomSource4"),
            resources.GetString("BestemmingComboBox.AutoCompleteCustomSource5"),
            resources.GetString("BestemmingComboBox.AutoCompleteCustomSource6")});
            this.BestemmingComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.BestemmingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BestemmingComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.BestemmingComboBox.FormattingEnabled = true;
            this.BestemmingComboBox.Items.AddRange(new object[] {
            resources.GetString("BestemmingComboBox.Items"),
            resources.GetString("BestemmingComboBox.Items1"),
            resources.GetString("BestemmingComboBox.Items2"),
            resources.GetString("BestemmingComboBox.Items3"),
            resources.GetString("BestemmingComboBox.Items4"),
            resources.GetString("BestemmingComboBox.Items5"),
            resources.GetString("BestemmingComboBox.Items6")});
            this.BestemmingComboBox.Name = "BestemmingComboBox";
            // 
            // weekLabel
            // 
            resources.ApplyResources(this.weekLabel, "weekLabel");
            this.weekLabel.Name = "weekLabel";
            // 
            // vertrekDateTime
            // 
            resources.ApplyResources(this.vertrekDateTime, "vertrekDateTime");
            this.vertrekDateTime.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.vertrekDateTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.vertrekDateTime.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.vertrekDateTime.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.vertrekDateTime.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.vertrekDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.vertrekDateTime.Name = "vertrekDateTime";
            this.vertrekDateTime.ShowUpDown = true;
            // 
            // Welkom
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.vertrekDateTime);
            this.Controls.Add(this.weekLabel);
            this.Controls.Add(this.BestemmingComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weekdienstCheckBox);
            this.Controls.Add(this.gaLoginButton);
            this.Controls.Add(this.gaDienstregelingButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Welkom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button gaDienstregelingButton;
        private System.Windows.Forms.Button gaLoginButton;
        private System.Windows.Forms.CheckBox weekdienstCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BestemmingComboBox;
        private System.Windows.Forms.Label weekLabel;
        private System.Windows.Forms.DateTimePicker vertrekDateTime;
    }
}