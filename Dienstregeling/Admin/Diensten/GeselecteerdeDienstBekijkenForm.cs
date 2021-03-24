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

namespace Dienstregeling
{
    public partial class GeselecteerdeDienstBekijkenForm : Form
    {
        private Trein _trein;

        public GeselecteerdeDienstBekijkenForm(Trein trein)
        {
            InitializeComponent();
            _trein = trein;
            naamTextBox.Text = trein.Naam.ToString();
            verTijdUurTextBox.Text = trein.VertrekTijdUur.ToString() + ":" + trein.VertrekTijdMinuten.ToString();
            aanTijdUurTextBox.Text = trein.AankomstTijdUur.ToString() + ":" + trein.AankomstTijdMinuten.ToString();
            verSpoorTextBox.Text = trein.VertrekSpoor.ToString();
            weekdienstCheckBox.Checked = trein.Weekdienst;
            bestemmingTextBox.Text = trein.Bestemming;
            weekdienstLabel.Text = WeekdienstTekst();
        }

        private void sluitenButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private String WeekdienstTekst()
        {
            String value;
            if (weekdienstCheckBox.Checked) { value = "Ja"; } else { value = "Nee"; }
            return value;
        }
    }
}
