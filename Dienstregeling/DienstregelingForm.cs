﻿using System;
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
    public partial class DienstregelingForm : Form
    {
        private List<Trein> _treins;
        private DienstregelingDA _dienstregelingDA;
        private int _uur;
        private bool _weekdienst;
        private String _bestemming;


        public DienstregelingForm(int uur, bool weekdienst,String bestemming)
        {
            InitializeComponent();
            _dienstregelingDA = new DienstregelingDA();
            _treins = new List<Trein>();
            _weekdienst = weekdienst;
            _uur = uur;
            _bestemming = bestemming;
            _treins = _dienstregelingDA.Soorteer(_uur.ToString(),_weekdienst,_bestemming);
            ListBoxVernieuwen();
        }

        private void ListBoxVernieuwen()
        {
            regelingListBox.DataSource = null;
            regelingListBox.DataSource = _treins;
        }

        private void toonDienstForm_Click(object sender, EventArgs e)
        {
            Trein trein = (Trein)regelingListBox.SelectedItem;
            if (trein != null)
            {
                GeselecteerdeDienstBekijkenForm geselecteerdeDienstBekijkenForm = new GeselecteerdeDienstBekijkenForm(trein);
                this.Hide();
                geselecteerdeDienstBekijkenForm.ShowDialog();
                this.Show();
            }
            
        }

        private void sluitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
