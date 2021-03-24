using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Business;
using System.Data;

namespace DataAccess
{
    public class LoginDA
    {
        private String _connString;
        private MySqlConnection _mySqlConnection;

        public LoginDA()
        {
            _connString = "server=LocalHost;user id=root;database=dienstregeling";
            _mySqlConnection = new MySqlConnection(_connString);
        }


        public List<Gebruiker> ReadTable()
        {
            List<Gebruiker> gebruikers = new List<Gebruiker>();

            String sql = "SELECT * FROM tbllogin ORDER BY  BeheerderID;";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            _mySqlConnection.Open();
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read() == true)
            {
                Gebruiker gebruiker = new Gebruiker((int)mySqlDataReader["BeheerderID"],
                    mySqlDataReader["Gebruikersnaam"].ToString(),
                    mySqlDataReader["Wachtwoord"].ToString());
                gebruikers.Add(gebruiker);
            }
            _mySqlConnection.Close();
            return gebruikers;
        }

        public void DeleteRecord(int id)
        {
            String sql = "DELETE FROM tbllogin WHERE (BeheerderID = @ID); ";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);
            mySqlCommand.Parameters.AddWithValue("@ID", id);
            _mySqlConnection.Open();
            mySqlCommand.ExecuteNonQuery();
            _mySqlConnection.Close();
        }

        public void CreateRecord(Gebruiker gebruiker)
        {
            String sql = "INSERT INTO `dienstregeling`.`tbllogin` (`BeheerderID`, `Gebruikersnaam`, `Wachtwoord`) VALUES(@ID, @Gebruikersnaam, @Wachtwoord);";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);
            mySqlCommand.Parameters.AddWithValue("@ID", gebruiker.ID);
            mySqlCommand.Parameters.AddWithValue("@Gebruikersnaam", gebruiker.Gebruikersnaam);
            mySqlCommand.Parameters.AddWithValue("@Wachtwoord", gebruiker.Wachtwoord);

            _mySqlConnection.Open();
            mySqlCommand.ExecuteNonQuery();
            _mySqlConnection.Close();
        }

        public void UpdateRecord(Gebruiker gebruiker)
        {
            String sql = "update tbllogin set Gebruikersnaam = @Gebruikersnaam," +
                "Wachtwoord = @Wachtwoord" +
                " where BeheerderID = @ID;";

            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            mySqlCommand.Parameters.AddWithValue("@Gebruikersnaam", gebruiker.Gebruikersnaam);
            mySqlCommand.Parameters.AddWithValue("@Wachtwoord", gebruiker.Wachtwoord);
            mySqlCommand.Parameters.AddWithValue("@ID", gebruiker.ID);

            _mySqlConnection.Open();
            mySqlCommand.ExecuteNonQuery();
            _mySqlConnection.Close();
        }

        // De controle van gebruikersnaam en wachtwoord. Het id van de gebruiker word dan gereturned.
        public int LoginControle(String Gebruikernaam, String Wachtwoord)
        {
            int id = 0;
            _mySqlConnection.Open();

            // zoekt in de database naar data waar de opgegeven gebruikersnaam en wachtwoord juist is en telt het aantal die overeenkomen
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT COUNT(*) FROM tbllogin WHERE Gebruikersnaam='" + Gebruikernaam + "' AND Wachtwoord='" + Wachtwoord + "'", _connString);
            

            //het aanmaken van een table om dan de data te controleren
            DataTable dt = new DataTable();  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                // het id van de gegeven gebruiker opslaan
                MySqlDataAdapter sdi = new MySqlDataAdapter("SELECT BeheerderID FROM tbllogin WHERE Gebruikersnaam='" + Gebruikernaam + "' AND Wachtwoord='" + Wachtwoord + "'", _connString);
                DataTable dtt = new DataTable();
                sdi.Fill(dtt);
                id = Convert.ToInt32(dtt.Rows[0][0]);
            }

            _mySqlConnection.Close();
            return id;
        }

        public bool IsGebruikersnaamVrij(String Gebruikersnaam)
        {
            bool isVrij = false;

            String sql = "SELECT COUNT(*) FROM tbllogin WHERE Gebruikersnaam = @Gebruikersnaam ";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);
            mySqlCommand.Parameters.AddWithValue("@Gebruikersnaam", Gebruikersnaam);

            _mySqlConnection.Open();
            int aantal = Convert.ToInt32(mySqlCommand.ExecuteScalar());
            _mySqlConnection.Close();

            if (aantal == 0) { isVrij = true; }

            return isVrij;
        }
    }
}
