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
    public partial class GeselecteerdeDienstWijzigenForm : Form
    {
        private Trein _trein;
        private List<String> _bestemmingen;

        public GeselecteerdeDienstWijzigenForm(Trein trein, List<String> bestemmingen)
        {
            InitializeComponent();
            _trein = trein;
            _bestemmingen = bestemmingen;
            BestemmingComboBoxVullen();
            naamTextBox.Text = trein.Naam.ToString();
            verNumericUpDown.Value = trein.VertrekSpoor;
            weekdienstCheckBox.Checked = trein.Weekdienst;
            bestemmingComboBox.Text = trein.Bestemming;


            // vertrektijd tonen
            TimeSpan vertrektijd = new TimeSpan(trein.VertrekTijdUur, trein.VertrekTijdMinuten, 0);
            vertrekDateTime.Value = DateTime.Now.Date;
            vertrekDateTime.Value += vertrektijd;

            // Aankomsttijd tonen
            TimeSpan aankomsttijd = new TimeSpan(trein.AankomstTijdUur, trein.AankomstTijdMinuten, 0);
            aankomstDateTime.Value = DateTime.Now.Date;
            aankomstDateTime.Value += aankomsttijd;
        }


        //bestemmingen opvullen
        private void BestemmingComboBoxVullen()
        {
            bestemmingComboBox.Items.Clear();
            foreach (String bestemming in _bestemmingen) { bestemmingComboBox.Items.Add(bestemming); }
        }

        //kijkt of het een geldige bestemming is.
        private bool BestemmingControle()
        {
            bool aanwezig = false;
            foreach (String bestemming in _bestemmingen)
            {
                if (bestemmingComboBox.Text == bestemming){ aanwezig = true; }
            }
            return aanwezig;
        }


        // kijkt of de aankomsttijd niet eerder is of de vertrektijd.
        private bool TijdControle()
        {
            bool tijdIsJuist = false;
            if (vertrekDateTime.Value < aankomstDateTime.Value) { tijdIsJuist = true; }
            return tijdIsJuist;
        }

        private void opslaanButton_Click(object sender, EventArgs e)
        {
            if (BestemmingControle() && TijdControle() && (naamTextBox.Text != ""))
            {
                _trein.Naam = naamTextBox.Text;
                _trein.VertrekTijdUur = Convert.ToInt32(vertrekDateTime.Value.Hour);
                _trein.VertrekTijdMinuten = Convert.ToInt32(vertrekDateTime.Value.Minute);
                _trein.AankomstTijdUur = Convert.ToInt32(aankomstDateTime.Value.Hour);
                _trein.AankomstTijdMinuten = Convert.ToInt32(aankomstDateTime.Value.Minute);
                _trein.VertrekSpoor = Convert.ToInt32(verNumericUpDown.Value);
                _trein.Weekdienst = weekdienstCheckBox.Checked;
                _trein.Bestemming = bestemmingComboBox.Text;
                this.Close();
            }
            else { MessageBox.Show("Een of meerdere voorwaarden zijn ongeldig!"); }
        }
    }
}
