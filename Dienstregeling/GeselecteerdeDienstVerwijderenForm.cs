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
    public partial class GeselecteerdeDienstVerwijderenForm : Form
    {
        private int _treinID;

        public GeselecteerdeDienstVerwijderenForm(Trein trein)
        {
            InitializeComponent();
            _treinID = trein.ID;
            textLabel.Text = "Weet je zeker dat je dienst " + trein.Naam + " wilt verwijderen ?";
            
        }

        private void jaButton_Click(object sender, EventArgs e)
        {
            DienstregelingDA dienstregeling = new DienstregelingDA();
            dienstregeling.DeleteRecord(_treinID);
            this.Close();
        }

        private void neeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
