using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using DataAccess;

namespace Dienstregeling
{
    public partial class Welkom : Form
    {
        private List<String> _bestemmingen;
        private DienstregelingDA _dienstregelingDA;

        public Welkom()
        {
            InitializeComponent();
            _dienstregelingDA = new DienstregelingDA();
            _bestemmingen = new List<String>(_dienstregelingDA.ReadBestemmingen());
            BestemmingComboBoxVullen();
        }

        private void gaLoginButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Show();
        }

        private void gaDienstregelingButton_Click(object sender, EventArgs e)
        {
            int uur = Convert.ToInt32(uurNumericUpDown.Value);
            bool weekdienst = weekdienstCheckBox.Checked;
            String bestemming = BestemmingComboBox.Text;
            DienstregelingForm dienstregeling = new DienstregelingForm(uur, weekdienst,bestemming);
            this.Hide();
            dienstregeling.ShowDialog();
            this.Show();
        }

        // laat de tekst van weekdienst aanpassens // word opgeropen in constructor
        private void weekdienstCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (weekdienstCheckBox.Checked) { weekLabel.Text = "Ja"; } else { weekLabel.Text = "Nee"; }
        }

        private void BestemmingComboBoxVullen()
        {
            BestemmingComboBox.Items.Clear();
            foreach (String bestemming in _bestemmingen) { BestemmingComboBox.Items.Add(bestemming); }
        }
    }
}
