using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uputstvo_App_Sample_by_DanijelXDA
{
    public partial class glavniProzor : Form
    {
        public glavniProzor()
        {
            InitializeComponent();
        }

        private void potvrdiBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(oglas.Text))
            {
                MessageBox.Show(("Попуните сва поља!"), "Обавештење", MessageBoxButtons.OK);
            }
            else
            {
                string str = "http://www.google.com/search?q=oglasi+";
                string unos = oglas.Text;
                unos = unos.Replace(' ', '+');
                str += unos;

                Uri u = new Uri(str);

                pretraga.Navigate(u);
            }
        }

        private void izlazBtn_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show(("Да ли желите да напустите програм?"), "Излаз из програма", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }
    }
}
