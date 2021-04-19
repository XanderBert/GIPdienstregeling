using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using Business;

namespace Dienstregeling
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {   
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String gebruikersnaam = gebruikersnaamTextBox.Text;

            //ingegeven wachtwoord encrypteren om zo te testen met het wachtwoord in de database.
            //zo moet je het wachtwoord in de database niet decrypten
            String salt = SecurityHelper.GenerateSalt(gebruikersnaam);
            String wachtwoord = SecurityHelper.ConvertToEncrypt(wachtwoordTextBox.Text, salt, 10101, 70);

            LoginDA login = new LoginDA();
            int loginID = login.LoginControle(gebruikersnaam, wachtwoord);
            if ( loginID != 0)
            {
                AanpassenDienstenForm aanpassen = new AanpassenDienstenForm(loginID);
                this.Hide();
                aanpassen.StartPosition = FormStartPosition.Manual;
                aanpassen.Location = this.Location;
                aanpassen.Size = this.Size;
                aanpassen.ShowDialog();

                gebruikersnaamTextBox.Text = "";
                wachtwoordTextBox.Text = "";

                this.Show();
            }
            else { MessageBox.Show("Geen heldige login.");}
        }

        private void gaTerugButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
