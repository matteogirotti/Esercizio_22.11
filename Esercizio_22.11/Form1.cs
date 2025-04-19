using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio_22._11
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcolaDifferenza_Click(object sender, EventArgs e)
        {
            DateTime data1 = dateTimePicker1.Value;
            DateTime data2 = dateTimePicker2.Value;
            int differenzaGiorni = (data2 - data1).Days;
            lblRisultatoDifferenza.Text = $"Differenza di {differenzaGiorni} giorni";
        }

        private void btnSomma_Click(object sender, EventArgs e)
        {
            int giorni;
            if(int.TryParse(txtGiorni.Text, out giorni))
            {
                DateTime nuovaData = dateTimePickerSomma.Value.AddDays(giorni);
                lblRisultatoSomma.Text = $"Nuova data: {nuovaData.ToShortDateString()}";
            }
            else
            {
                MessageBox.Show("Inserisci un numero di giorni valido");
            }
        }

        private void btnSottrazione_Click(object sender, EventArgs e)
        {
            int giorni;
            if (int.TryParse(txtGiorni.Text, out giorni))
            {
                DateTime nuovaData = dateTimePickerSomma.Value.AddDays(-giorni);
                lblRisultatoSomma.Text = $"Nuova data: {nuovaData.ToShortDateString()}";
            }
            else
            {
                MessageBox.Show("Inserisci un numero di giorni valido");
            }
        }
    }
}
