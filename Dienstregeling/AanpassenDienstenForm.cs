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
    public partial class AanpassenDienstenForm : Form
    {
        private List<Trein> _treins;
        private DienstregelingDA _dienstregelingDA;
        private List<Gebruiker> _gebruikers;
        private LoginDA _loginDA;
        private int _loginID;
        private List<String> _bestemmingen;

        public AanpassenDienstenForm(int loginID)
        {
            InitializeComponent();
            _loginID = loginID;
            //Diensten
            _dienstregelingDA = new DienstregelingDA();
            _treins = new List<Trein>();
            _bestemmingen = new List<String>(_dienstregelingDA.ReadBestemmingen());
            BestemmingComboBoxVullen();
            _treins = _dienstregelingDA.Soorteer("0",weekdienstCheckBox.Checked , sorteerGemeenteComboBox.Text);
            //Gebruikers
            _loginDA = new LoginDA();
            _gebruikers = new List<Gebruiker>();
            _gebruikers = _loginDA.ReadTable();

            ListBoxVernieuwen();
        }

        // Functies omtrend Diensten
        private void geselecteerdeDieButton_Click(object sender, EventArgs e)
        {
            Trein selected = (Trein)regelingListBox.SelectedItem;
            GeselecteerdeDienstWijzigenForm dienstWijzigen = new GeselecteerdeDienstWijzigenForm(selected, _bestemmingen);
            dienstWijzigen.ShowDialog();
            ListBoxVernieuwen();
            _dienstregelingDA.UpdateRecord(selected);
        }

        private void selectedDiestVerwijderenButton_Click(object sender, EventArgs e)
        {
            GeselecteerdeDienstVerwijderenForm verwijderenForm = new GeselecteerdeDienstVerwijderenForm((Trein)regelingListBox.SelectedItem);
            verwijderenForm.ShowDialog();
            _treins = _dienstregelingDA.ReadTable();
            ListBoxVernieuwen();
        }

        private void dienstToevoegenButton_Click(object sender, EventArgs e)
        {
            Trein nieuweTrein = new Trein("", 0, 0, 0, 0, 0, true, 0, "Poperinge");
            GeselecteerdeDienstWijzigenForm nieuweDienst = new GeselecteerdeDienstWijzigenForm(nieuweTrein, _bestemmingen);
            nieuweDienst.ShowDialog();
            _dienstregelingDA.CreateRecord(nieuweTrein);
            _treins = _dienstregelingDA.ReadTable();
            ListBoxVernieuwen();
        }

        private void sorteerGemeenteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String naam = sorteerGemeenteComboBox.Text;
            bool weekdienst = weekdienstCheckBox.Checked;
            _treins = _dienstregelingDA.Soorteer("0", weekdienst, naam);
            ListBoxVernieuwen();
        }
            // oproepen van combobox status changed om ook te sorteeren wanneer te checkbox veranderd
        private void weekdienstCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            sorteerGemeenteComboBox_SelectedIndexChanged(sender, e);
        }

        private void BestemmingComboBoxVullen()
        {
            sorteerGemeenteComboBox.Items.Clear();
            foreach (String bestemming in _bestemmingen) { sorteerGemeenteComboBox.Items.Add(bestemming); }
        }

        //verniewen van listbox
        private void ListBoxVernieuwen()
        {
            regelingListBox.DataSource = null;
            regelingListBox.DataSource = _treins;
            gebruikersListBox.DataSource = null;
            gebruikersListBox.DataSource = _gebruikers;
        }

        private void terugButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Functies omtrend Gebruikers
        private void gebruikerToevoegenButton_Click(object sender, EventArgs e)
        {
            Gebruiker nieuweGebruiker = new Gebruiker(0, "", "");
            GeselecteerdeGebruikerWijzigenForm gebruikerWijzigenForm = new GeselecteerdeGebruikerWijzigenForm(nieuweGebruiker, true, false);
            gebruikerWijzigenForm.ShowDialog();
            _loginDA.CreateRecord(nieuweGebruiker);
            _gebruikers = _loginDA.ReadTable();
            ListBoxVernieuwen();
        }

        private void gebruikerAanpassenButton_Click(object sender, EventArgs e)
        {
            Gebruiker selected = (Gebruiker)gebruikersListBox.SelectedItem;
            bool zelfdeGebruiker = false;
            if (selected.ID == _loginID) { zelfdeGebruiker = true; }
            GeselecteerdeGebruikerWijzigenForm gebruikerWijzigenForm = new GeselecteerdeGebruikerWijzigenForm(selected, false, zelfdeGebruiker);
            gebruikerWijzigenForm.ShowDialog();
            _loginDA.UpdateRecord(selected);
            _gebruikers = _loginDA.ReadTable();
            ListBoxVernieuwen();
        }

        private void gebruikerVerwijderenButton_Click(object sender, EventArgs e)
        {
            Gebruiker selected = (Gebruiker)gebruikersListBox.SelectedItem;
            if (selected.ID == _loginID) { MessageBox.Show("Je kan jezelf niet verwijderen"); } else { _loginDA.DeleteRecord(selected.ID); }
            _gebruikers = _loginDA.ReadTable();
            ListBoxVernieuwen();
        }

        private void exporterenAlsCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV(*.CSV)|*.CSV";

            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
            {
                List<String> csv = _dienstregelingDA.ReturnCSV();
                System.IO.File.WriteAllLines(sfd.FileName, csv);
            }
        }
    }
}
