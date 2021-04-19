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
        
        //kijkt of de wachtwoorden overreen komen
        private bool IsWachtwoordGelijk()
        {
            return wachtwoordTextBox.Text.Equals(repeatWachtwoordTextBox.Text);
        }

        // kijkt of het wachtwoord wel langer of gelijk aan 6 tekens is.
        private bool IsWachtwoordLangGenoeg()
        {
            bool isLang = false;
            if (wachtwoordTextBox.Text.Length >= 6) { isLang = true; }
            return isLang;
        }

        //kijkt of de gebruikersnaam al niet in gebruik is.
        private bool IsGebruikerVrij()
        {
            return _loginDA.IsGebruikersnaamVrij(gebruikersnaamTextBox.Text);
        }

        //kijkt of de gebruikersnaam niet leeg is.
        private bool IsGebruikerLeeg(String gebruiker)
        {
            bool isGebruikerLeeg = false;

            if (gebruiker == String.Empty || gebruiker.Equals("") || gebruiker == "")
            {
                isGebruikerLeeg = true;
            }

            return isGebruikerLeeg;
        }

        // kijkt of dat de gegevens aan alle voorwaarden voldoen en slaat het dan op.
        private void opslaanButton_Click_1(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                _gebruiker.Gebruikersnaam = gebruikersnaamTextBox.Text;

                //wachtwoord encrypteren.
                string salt = SecurityHelper.GenerateSalt(gebruikersnaamTextBox.Text);
                _gebruiker.Wachtwoord = SecurityHelper.ConvertToEncrypt(wachtwoordTextBox.Text, salt, 10101, 70);

                this.Close();
            }
        }

        //roept alle controles op.
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

        // error legen
        private void gebruikersnaamTextBox_Validated(object sender, EventArgs e)
        {
            _error.SetError(gebruikersnaamTextBox, "");
        }

        // geeft error als wachtwoord niet lang genoeg is.
        private void wachtwoordTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!IsWachtwoordLangGenoeg())
            {
                e.Cancel = true;
                wachtwoordTextBox.Select(0, wachtwoordTextBox.Text.Length);
                _error.SetError(wachtwoordTextBox, "Het wachtwoord moet langer zijn dan 7 tekens.");
            }
        }

        // error legen
        private void wachtwoordTextBox_Validated(object sender, EventArgs e)
        {
            _error.SetError(wachtwoordTextBox, "");
        }

        //geeft error als de wachtwoorden niet overreen komen
        private void repeatWachtwoordTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!IsWachtwoordGelijk())
            {
                e.Cancel = true;
                repeatWachtwoordTextBox.Select(0, repeatWachtwoordTextBox.Text.Length);
                _error.SetError(repeatWachtwoordTextBox, "De wachtwoorden komen niet overreen.");
            }
        }

        // error legen
        private void repeatWachtwoordTextBox_Validated(object sender, EventArgs e)
        {
            _error.SetError(repeatWachtwoordTextBox, "");
        }
    }
    
}
