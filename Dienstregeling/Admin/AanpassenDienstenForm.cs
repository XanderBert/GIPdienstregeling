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

            this.regelingListBox.MouseDoubleClick += new MouseEventHandler(regelingListBox_MouseDoubleclick);
            this.gebruikersListBox.MouseDoubleClick += new MouseEventHandler(gebruikerListBox_MouseDoubleclick);
            ListBoxVernieuwen();
        }

        // Functies omtrend Diensten

        private void regelingListBox_MouseDoubleclick(object sender, MouseEventArgs e)
        {
            int index = this.regelingListBox.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                Trein trein = (Trein)regelingListBox.SelectedItem;
                ToonTrein(trein);
            }
        }

        private void ToonTrein(Trein trein)
        {
            if (trein != null)
            {
                GeselecteerdeDienstWijzigenForm dienstWijzigen = new GeselecteerdeDienstWijzigenForm(trein, _bestemmingen);
                this.Hide();

                dienstWijzigen.StartPosition = FormStartPosition.Manual;
                dienstWijzigen.Location = this.Location;
                dienstWijzigen.Size = this.Size;
                dienstWijzigen.ShowDialog();

                this.Show();
            }
        }
        
        private void geselecteerdeDieButton_Click(object sender, EventArgs e)
        {
            Trein selected = (Trein)regelingListBox.SelectedItem;
            ToonTrein(selected);
            ListBoxVernieuwen();
            _dienstregelingDA.UpdateRecord(selected);
        }

        private void selectedDiestVerwijderenButton_Click(object sender, EventArgs e)
        {
            GeselecteerdeDienstVerwijderenForm verwijderenForm = new GeselecteerdeDienstVerwijderenForm((Trein)regelingListBox.SelectedItem);
            verwijderenForm.ShowDialog();
            _treins = _dienstregelingDA.Soorteer("0", weekdienstCheckBox.Checked, sorteerGemeenteComboBox.Text);
            ListBoxVernieuwen();
        }

        private void dienstToevoegenButton_Click(object sender, EventArgs e)
        {
            Trein nieuweTrein = new Trein("", 0, 0, 0, 0, 0, true, 0, "Poperinge");
            GeselecteerdeDienstWijzigenForm nieuweDienst = new GeselecteerdeDienstWijzigenForm(nieuweTrein, _bestemmingen);
            nieuweDienst.ShowDialog();
            _dienstregelingDA.CreateRecord(nieuweTrein);
            _treins = _dienstregelingDA.Soorteer("0", weekdienstCheckBox.Checked, sorteerGemeenteComboBox.Text);
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
            sorteerGemeenteComboBox.Text = _bestemmingen[0];
        }

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

        // Functies omtrend Gebruikers

        
        private void gebruikerListBox_MouseDoubleclick(object sender, MouseEventArgs e)
        {
            int index = this.gebruikersListBox.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                Gebruiker gebruiker = (Gebruiker)gebruikersListBox.SelectedItem;
                ToonGebruiker(gebruiker);
            }
        }

        private void ToonGebruiker(Gebruiker gebruiker)
        {
            if (gebruiker != null)
            {
               // Gebruiker selected = (Gebruiker)gebruikersListBox.SelectedItem;
                this.Hide();
                if (IsZelfdeGebruiker(gebruiker.ID))
                {
                    EigenOfNieuweGebruikerAanpassenForm aanpassenForm = new EigenOfNieuweGebruikerAanpassenForm(gebruiker);
                    aanpassenForm.StartPosition = FormStartPosition.Manual;
                    aanpassenForm.Location = this.Location;
                    aanpassenForm.Size = this.Size;
                    aanpassenForm.ShowDialog();
                }
                else
                {
                    GeselecteerdeGebruikerWijzigenForm aanpassenForm = new GeselecteerdeGebruikerWijzigenForm(gebruiker);
                    aanpassenForm.StartPosition = FormStartPosition.Manual;
                    aanpassenForm.Location = this.Location;
                    aanpassenForm.Size = this.Size;
                    aanpassenForm.ShowDialog();
                }
                this.Show();
            }
        }

        private void gebruikerToevoegenButton_Click(object sender, EventArgs e)
        {
            Gebruiker nieuweGebruiker = new Gebruiker(0, "", "");
            EigenOfNieuweGebruikerAanpassenForm aanpassenForm = new EigenOfNieuweGebruikerAanpassenForm(nieuweGebruiker);
            aanpassenForm.StartPosition = FormStartPosition.Manual;
            aanpassenForm.Location = this.Location;
            aanpassenForm.Size = this.Size;
            this.Hide();
            aanpassenForm.ShowDialog();
            this.Show();
            _loginDA.CreateRecord(nieuweGebruiker);
            _gebruikers = _loginDA.ReadTable();
            ListBoxVernieuwen();
        }

        private void gebruikerAanpassenButton_Click(object sender, EventArgs e)
        {
            Gebruiker selected = (Gebruiker)gebruikersListBox.SelectedItem;
            ToonGebruiker(selected);

            _loginDA.UpdateRecord(selected);
            _gebruikers = _loginDA.ReadTable();
            ListBoxVernieuwen();
        }

        private void gebruikerVerwijderenButton_Click(object sender, EventArgs e)
        {
            Gebruiker selected = (Gebruiker)gebruikersListBox.SelectedItem;

            DialogResult dialogResult = MessageBox.Show("Ben je zeker dat je gebruiker "+selected.Gebruikersnaam + " wil verwijderen?" , "Gebruiker Verwijderen", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (IsZelfdeGebruiker(selected.ID)) { MessageBox.Show("Je kan jezelf niet verwijderen"); } else { _loginDA.DeleteRecord(selected.ID); }
                _gebruikers = _loginDA.ReadTable();
                ListBoxVernieuwen();
            }
        }

        private bool IsZelfdeGebruiker(int id)
        {
            bool zelfdeGebruiker = false;
            if (id == _loginID)
            {
                zelfdeGebruiker = true;
            }
            return zelfdeGebruiker;
        }
    }
}
