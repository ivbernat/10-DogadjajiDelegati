using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vsite.CSharp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            buttonDelete.Enabled = textBox.Text.Length > 0;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // TODO: Dodati metodu za obradu događaja (event handler) koji će onemogućiti tipku buttonDelete ako nema upisanog teksta u kontroli textBox, odnosno omogućiti kada je neki tekst upisan.


        // TODO: Dodati metodu za obradu događaja koji će na pritisak tipke buttonDelete obrisati sadržaj kontrole textBox.


        // TODO: Dodati metodu za obradu događaja koji će na pritisak tipke buttonClose zatvoriti formu.
    }
}
