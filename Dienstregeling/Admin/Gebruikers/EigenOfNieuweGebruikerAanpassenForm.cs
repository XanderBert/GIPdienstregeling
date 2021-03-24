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
    public partial class EigenOfNieuweGebruikerAanpassenForm : Form
    {
        private Gebruiker _gebruiker;
        LoginDA _loginDA;
        ErrorProvider _error;

        public EigenOfNieuweGebruikerAanpassenForm(Gebruiker gebruiker)
        {
            InitializeComponent();
            _gebruiker = gebruiker;
            _loginDA = new LoginDA();
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

        private bool IsGebruikerLeeg(String gebruiker)
        {
            bool isGebruikerLeeg = false;

            if (gebruiker == String.Empty || gebruiker.Equals("") || gebruiker == "")
            {
                isGebruikerLeeg = true;
            }

            return isGebruikerLeeg;
        }

        private void opslaanButton_Click_1(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                _gebruiker.Gebruikersnaam = gebruikersnaamTextBox.Text;
                _gebruiker.Wachtwoord = wachtwoordTextBox.Text;
                this.Close();
            }
        }

        private void gebruikersnaamTextBox_Validating(object sender, CancelEventArgs e)
        {
            bool heeftGebruikersnaamNietVeranderd = _gebruiker.Gebruikersnaam.Equals(gebruikersnaamTextBox.Text);

            if (!heeftGebruikersnaamNietVeranderd || IsGebruikerLeeg(gebruikersnaamTextBox.Text))
            {
                if (!IsGebruikerVrij() || IsGebruikerLeeg(gebruikersnaamTextBox.Text))
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
            if (!IsWachtwoordLangGenoeg())
            {
                e.Cancel = true;
                wachtwoordTextBox.Select(0, wachtwoordTextBox.Text.Length);
                _error.SetError(wachtwoordTextBox, "Het wachtwoord moet langer zijn dan 7 tekens.");
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
