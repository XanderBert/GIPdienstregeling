using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Business;

namespace DataAccess
{
   public  class DienstregelingDA
    {
        private String _connString;
        private MySqlConnection _mySqlConnection;

        public DienstregelingDA()
        {
            _connString = "server=LocalHost;user id=root;database=dienstregeling";
            _mySqlConnection = new MySqlConnection(_connString);
        }

        public List<Trein> ReadTable() 
        {
            String sql = "SELECT * FROM tbldienstregeling ORDER BY  VertrekTijdUur;";
            return SorteerHulp(sql);
        }

        public List<String> ReadBestemmingen()
        {
            String sql = "SELECT DISTINCT Bestemming FROM tbldienstregeling;";

            List<String> bestemmingen = new List<String>();
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            _mySqlConnection.Open();
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read() == true)
            {
                String bestemming = mySqlDataReader["Bestemming"].ToString();
                bestemmingen.Add(bestemming);
            }
            _mySqlConnection.Close();
            return bestemmingen;
        }

        public void DeleteRecord(int id)
        {
            String sql = "DELETE FROM tbldienstregeling WHERE (DienstID = @ID); ";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);
            mySqlCommand.Parameters.AddWithValue("@ID", id);
            _mySqlConnection.Open();
            mySqlCommand.ExecuteNonQuery();
            _mySqlConnection.Close();

        }

        public void UpdateRecord(Trein trein)
        {
            String sql = "update tbldienstregeling set VertrekTijdMinuten = @verMinuten," +
                "VertrekTijdUur = @verUur," +
                "AankomstTijdMinuten = @aanMinuten," +
                "AankomstTijdUur = @aanUur," +
                "VertrekSpoor = @verSpoor," +
                "Weekdienst = @weekdienst," +
                "TreinCode = @treinCode," +
                "Bestemming = @bestemming" + 
                " where DienstID = @ID;";

            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            mySqlCommand.Parameters.AddWithValue("@verMinuten", trein.VertrekTijdMinuten);
            mySqlCommand.Parameters.AddWithValue("@verUur", trein.VertrekTijdUur);
            mySqlCommand.Parameters.AddWithValue("@aanMinuten", trein.AankomstTijdMinuten);
            mySqlCommand.Parameters.AddWithValue("@aanUur", trein.AankomstTijdUur);
            mySqlCommand.Parameters.AddWithValue("@verSpoor", trein.VertrekSpoor);
            mySqlCommand.Parameters.AddWithValue("@weekdienst", trein.Weekdienst);
            mySqlCommand.Parameters.AddWithValue("@treinCode", trein.Naam);
            mySqlCommand.Parameters.AddWithValue("@bestemming", trein.Bestemming);
            mySqlCommand.Parameters.AddWithValue("@ID", trein.ID);

            _mySqlConnection.Open();
            mySqlCommand.ExecuteNonQuery();
            _mySqlConnection.Close();
        }

        public void CreateRecord(Trein trein)
        {
            String sql = "INSERT INTO `dienstregeling`.`tbldienstregeling` (`DienstID`, `VertrekTijdMinuten`, `VertrekTijdUur`, `AankomstTijdMinuten`, `AankomstTijdUur`, `VertrekSpoor`, `Weekdienst`, `TreinCode`, `Bestemming`) " +
                "VALUES (@ID, @verMinuten, @verUur, @aanMinuten, @aanUur, @verSpoor, @weekdienst,  @treinCode, @bestemming);";

            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            mySqlCommand.Parameters.AddWithValue("@verMinuten", trein.VertrekTijdMinuten);
            mySqlCommand.Parameters.AddWithValue("@verUur", trein.VertrekTijdUur);
            mySqlCommand.Parameters.AddWithValue("@aanMinuten", trein.AankomstTijdMinuten);
            mySqlCommand.Parameters.AddWithValue("@aanUur", trein.AankomstTijdUur);
            mySqlCommand.Parameters.AddWithValue("@verSpoor", trein.VertrekSpoor);
            mySqlCommand.Parameters.AddWithValue("@weekdienst", trein.Weekdienst);
            mySqlCommand.Parameters.AddWithValue("@treinCode", trein.Naam);
            mySqlCommand.Parameters.AddWithValue("@bestemming", trein.Bestemming);
            mySqlCommand.Parameters.AddWithValue("@ID", trein.ID);

            _mySqlConnection.Open();
            mySqlCommand.ExecuteNonQuery();
            _mySqlConnection.Close();
        }

        public List<Trein> Soorteer(String uur,bool Weekdienst,String bestemming)
        {
            String sql = "SELECT * FROM tbldienstregeling WHERE VertrekTijdUur >=" + uur + "&& Weekdienst = " + Weekdienst + "&& Bestemming = '"+ bestemming + "' ORDER BY VertrekTijdUur;";
            return SorteerHulp(sql);
        }
        
        // dit is een hulp om veel herhalende code te vermijden
        // hier word de list gemaakt, gevuld met treinen, return van die list
        public List<Trein> SorteerHulp(String Command)
        {
            List<Trein> treins = new List<Trein>();
            MySqlCommand mySqlCommand = new MySqlCommand(Command, _mySqlConnection);

            _mySqlConnection.Open();
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read() == true)
            {
                Trein trein = new Trein(mySqlDataReader["TreinCode"].ToString(),
                   (int)(mySqlDataReader["VertrekTijdMinuten"]),
                   (int)(mySqlDataReader["VertrekTijdUur"]),
                   (int)(mySqlDataReader["AankomstTijdMinuten"]),
                   (int)(mySqlDataReader["AankomstTijdUur"]),
                   (int)(mySqlDataReader["VertrekSpoor"]),
                   (bool)(mySqlDataReader.GetBoolean("Weekdienst")),
                   (int)(mySqlDataReader["DienstID"]),
                   mySqlDataReader["Bestemming"].ToString());

                treins.Add(trein);
            }
            _mySqlConnection.Close();
            return treins;
        }


        public List<String> ReturnCSV()
        {
            String sql = "SELECT * FROM tbldienstregeling ORDER BY  DienstID;";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);
            List<String> csv = new List<String>();
            String headerLine = "";

            _mySqlConnection.Open();
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            // kolomen maken en kolom namen opvullen.
            if (mySqlDataReader.Read())
            {
                String[] columns = new String[mySqlDataReader.FieldCount];
                for (int i = 0; i < mySqlDataReader.FieldCount; i++)
                {
                    columns[i] = mySqlDataReader.GetName(i);
                }
                headerLine = String.Join(",", columns);
                csv.Add(headerLine);  
            }

            // data opvullen
            while (mySqlDataReader.Read())
            {
                object[] values = new object[mySqlDataReader.FieldCount];
                mySqlDataReader.GetValues(values);
                csv.Add(String.Join(",", values));
            }
            _mySqlConnection.Close();
            return csv;
        }
    }
}
