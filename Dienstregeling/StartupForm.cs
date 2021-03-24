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

            login.StartPosition = FormStartPosition.Manual;
            login.Location = this.Location;
            login.Size = this.Size;
            login.ShowDialog();

            this.Show();
        }

        private void gaDienstregelingButton_Click(object sender, EventArgs e)
        {
            int uur = Convert.ToInt32(vertrekDateTime.Value.Hour);
            bool weekdienst = weekdienstCheckBox.Checked;
            String bestemming = BestemmingComboBox.Text;
            DienstregelingForm dienstregeling = new DienstregelingForm(uur, weekdienst,bestemming);

            this.Hide();

            dienstregeling.StartPosition = FormStartPosition.Manual;
            dienstregeling.Location = this.Location;
            dienstregeling.Size = this.Size;
            dienstregeling.ShowDialog();

            this.Show();
        }

        // laat de tekst van weekdienst aanpassen
        private void weekdienstCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (weekdienstCheckBox.Checked) { weekLabel.Text = "Ja"; } else { weekLabel.Text = "Nee"; }
        }

        // zorgt ook dat het eerste element standaard actief staat.
        private void BestemmingComboBoxVullen()
        {
            BestemmingComboBox.Items.Clear();
            foreach (String bestemming in _bestemmingen) { BestemmingComboBox.Items.Add(bestemming); }
            BestemmingComboBox.Text = _bestemmingen[0];
        }
    }
}
