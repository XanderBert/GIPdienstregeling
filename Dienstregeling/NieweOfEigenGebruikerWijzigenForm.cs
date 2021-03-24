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
    public partial class GeselecteerdeGebruikerWijzigenForm : Form
    {
        private Gebruiker _gebruiker;
        LoginDA _loginDA;
        ErrorProvider _error;

        public GeselecteerdeGebruikerWijzigenForm(Gebruiker gebruiker)
        {
            _gebruiker = gebruiker;

            _loginDA = new LoginDA();
            InitializeComponent();
            gebruikersnaamTextBox.Text = _gebruiker.Gebruikersnaam;
            _error = new ErrorProvider();
        }

        private bool IsWachtwoordGelijk()
        {
            return wachtwoordTextBox.Text.Equals(repeatWachtwoordTextBox.Text);
        }

        private bool IsWachtwoordLangGenoeg()
        {
            bool isLang = false;
            if (wachtwoordTextBox.Text.Length >= 8) { isLang = true; }
            return isLang;
        }

        private bool IsGebruikerVrij()
        {
            return _loginDA.IsGebruikersnaamVrij(gebruikersnaamTextBox.Text);
        }

        private void opslaanButton_Click(object sender, EventArgs e)
        {
            

                if (ValidateChildren())
                {
                    _gebruiker.Gebruikersnaam = gebruikersnaamTextBox.Text;
                    _gebruiker.Wachtwoord = wachtwoordTextBox.Text;
                    this.Close();
                }
          
                CancelEventArgs nieuw = new CancelEventArgs();
                gebruikersnaamTextBox_Validating(sender, nieuw);
                _gebruiker.Gebruikersnaam = gebruikersnaamTextBox.Text;
                this.Close();
            

        }

        private void gebruikersnaamTextBox_Validating(object sender, CancelEventArgs e)
        {
            bool heeftGebruikersnaamNietVeranderd = _gebruiker.Gebruikersnaam.Equals(gebruikersnaamTextBox.Text);

            if (!heeftGebruikersnaamNietVeranderd)
            {
                if (!IsGebruikerVrij() || gebruikersnaamTextBox.Text.Equals(""))
                {
                    e.Cancel = true;
                    gebruikersnaamTextBox.Select(0, gebruikersnaamTextBox.Text.Length);
                    _error.SetError(gebruikersnaamTextBox, "De gebruikersnaam is in gebruik of het veld is leeg.");
                }
            }
        }

        private void gebruikersnaamTextBox_Validated(object sender, EventArgs e)
        {
            _error.SetError(gebruikersnaamTextBox, "");
        }

        private void wachtwoordTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!IsWachtwoordLangGenoeg() )
            {
                e.Cancel = true;
                wachtwoordTextBox.Select(0, wachtwoordTextBox.Text.Length);
                _error.SetError(wachtwoordTextBox, "Het wachtwoord is niet lang genoeg .");
            }
        }

        private void wachtwoordTextBox_Validated(object sender, EventArgs e)
        {
            _error.SetError(wachtwoordTextBox, "");
        }

        private void repeatWachtwoordTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!IsWachtwoordGelijk())
            {
                e.Cancel = true;
                repeatWachtwoordTextBox.Select(0, repeatWachtwoordTextBox.Text.Length);
                _error.SetError(repeatWachtwoordTextBox, "De wachtwoorden komen niet overreen.");
            }
        }

        private void repeatWachtwoordTextBox_Validated(object sender, EventArgs e)
        {
            _error.SetError(repeatWachtwoordTextBox, "");
        }
    }
}
