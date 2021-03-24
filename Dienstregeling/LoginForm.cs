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
            String wachtwoord = wachtwoordTextBox.Text;
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
            else { MessageBox.Show("Geen heldige login."); }
        }

        private void gaTerugButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
