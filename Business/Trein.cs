using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Trein
    {
        private String _naam;
        private int _vertrekTijdMinuten;
        private int _vertrekTijdUur;
        private int _aankomstTijdMinuten;
        private int _aankomstTijdUur;
        private int _vertrekSpoor;
        private bool _weekdienst;
        private int _ID;
        private String _bestemming;

        public Trein(String naam, int vertrekTijdMinuten, int vertrekTijdUur, int aankomstTijdMinuten, int aankomstTijdUur, int vertrekSpoor, bool weekdienst, int ID, String bestemming)
        {
            _naam = naam;
            _vertrekTijdMinuten = vertrekTijdMinuten;
            _vertrekTijdUur = vertrekTijdUur;
            _aankomstTijdMinuten = aankomstTijdMinuten;
            _aankomstTijdUur = aankomstTijdUur;
            _vertrekSpoor = vertrekSpoor;
            _weekdienst = weekdienst;
            _ID = ID;
            _bestemming = bestemming;
        }

        public String Naam
        {
            get { return _naam; }
            set { _naam = value; } 
        }
         
        public int VertrekTijdMinuten
        {
            get { return _vertrekTijdMinuten; }
            set { _vertrekTijdMinuten = value; }
        }

        public int VertrekTijdUur
        {
            get { return _vertrekTijdUur; }
            set { _vertrekTijdUur = value; }
        }

        public int AankomstTijdMinuten
        {
            get { return _aankomstTijdMinuten; }
            set { _aankomstTijdMinuten = value; }
        }

        public int AankomstTijdUur
        {
            get { return _aankomstTijdUur; }
            set { _aankomstTijdUur = value; }
        }

        public int VertrekSpoor
        {
            get { return _vertrekSpoor; }
            set { _vertrekSpoor = value; }
        }

        public bool Weekdienst
        {
            get { return _weekdienst; }
            set { _weekdienst = value; }
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public String Bestemming
        {
            get { return _bestemming; }
            set { _bestemming = value; }
        }

        public override String ToString()
        {
            return "Naam: " + Naam + "\t Bestemming: " + Bestemming  + "\t Vertrektijd: " + VertrekTijdUur + ":" + VertrekTijdMinuten + "\t Aankomsttijd: " + AankomstTijdUur + ":" + AankomstTijdMinuten + "\t VertrekSpoor: " + VertrekSpoor;
        }
    }




} 
