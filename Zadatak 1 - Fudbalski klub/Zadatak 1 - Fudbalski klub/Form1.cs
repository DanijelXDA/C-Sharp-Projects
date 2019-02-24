using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static Zadatak_1___Fudbalski_klub.Fudbaler;

namespace Zadatak_1___Fudbalski_klub
{
    public partial class Form1 : Form
    {
        private List<Fudbaler> fudbaleri = new List<Fudbaler>();
        BindingSource bs = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            bs.DataSource = fudbaleri;
            dataGridView1.DataSource = bs;
        }

        private void Osvezi()
        {
            bs.ResetBindings(false);
        }
        void OcistiPolja()
        {
            tbBrDresa.Clear();
            tbIme.Clear();
            tbPrezime.Clear();
        }

        private void dugmeDodaj(object sender, EventArgs e)
        {
        }

        bool DaLiJeSvePopunjeno()
        {
            errorLabel.Text = "";
            if (tbBrDresa.Text.Equals(""))
            {
                errorLabel.Text += "Broj dresa fudbalera nije unet.";
            }
            else if (!tbBrDresa.Text.All(char.IsDigit))
            {
                errorLabel.Text += "Broj dresa fudbalera nije pravilno unet.";
            }

            if (tbIme.Text.Equals(""))
            {
                errorLabel.Text += "Ime nije uneto. ";
            }
            if (tbPrezime.Text.Equals(""))
            {
                errorLabel.Text += "Prezime nije uneto. ";
            }
            

            if (pozicijaComboBox.SelectedIndex == -1)
            {
                errorLabel.Text += "Niste odabrali poziciju igrača. ";
            }
          
            if (errorLabel.Text.Equals(""))
                return true;
            else
                return false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            if (DaLiJeSvePopunjeno())
            {
                int brDresa = int.Parse(tbBrDresa.Text);
                string ime = tbIme.Text;
                string prezime = tbPrezime.Text;
                DateTime dt = datumPicker.Value;

                PozicijaFudbalera pozicija = (PozicijaFudbalera)Enum.Parse(typeof(PozicijaFudbalera), pozicijaComboBox.SelectedItem.ToString());

                Fudbaler f = new Fudbaler(brDresa, ime, prezime, dt, pozicija);
                fudbaleri.Add(f);
                Osvezi();
                OcistiPolja();
            }
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dataGridView1.SelectedRows;

            if (rows.Count > 0)
            {
                int indeks = rows[0].Index;
                fudbaleri.RemoveAt(indeks);
                Osvezi();
            }
        }
    }
}
