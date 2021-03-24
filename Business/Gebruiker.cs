using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Gebruiker
    {
        private int _ID;
        private String _gebruikersnaam;
        private String _wachtwoord;

        public Gebruiker(int ID, String gebruikersnaam, String wachtwoord)
        {
            _ID = ID;
            _gebruikersnaam = gebruikersnaam;
            _wachtwoord = wachtwoord;
        }

        public String Gebruikersnaam
        {
            get { return _gebruikersnaam; }
            set { _gebruikersnaam = value; }
        }

        public String Wachtwoord
        {
            get { return _wachtwoord; }
            set { _wachtwoord = value; }
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public override String ToString()
        {
            return Gebruikersnaam ;
        }

    }
}
