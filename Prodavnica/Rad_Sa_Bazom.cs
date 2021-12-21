using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prodavnica
{
    
    public partial class Rad_Sa_Bazom : Form
    {
        Racun_baza_form racun_forma;
        Proizvod_Form proizvod_forma;
        public Rad_Sa_Bazom()
        {
            InitializeComponent();
            racun_forma = new Racun_baza_form();
            proizvod_forma = new Proizvod_Form();
        }

        private void btnProizvod_Click(object sender, EventArgs e)
        {
            if (proizvod_forma.IsDisposed)
            {
                proizvod_forma = new Proizvod_Form();
            }
            proizvod_forma.Show();
        }

        private void btnRacun_Click(object sender, EventArgs e)
        {
            if (racun_forma.IsDisposed)
            {
                racun_forma = new Racun_baza_form();
            }
            racun_forma.Show();
        }
    }
}
