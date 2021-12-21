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
    public partial class Form1 : Form
    {
        Rad_Sa_Racunom rad_sa_racunom;
        Rad_Sa_Bazom baza;
        public Form1()
        {
            InitializeComponent();
            rad_sa_racunom = new Rad_Sa_Racunom();
            baza = new Rad_Sa_Bazom();
        }

        private void btnRadSaBazom_Click(object sender, EventArgs e)
        {
            if (baza.IsDisposed)
            {
                baza = new Rad_Sa_Bazom();
            }
            baza.Show();
        }

        private void btnRadSaRacunom_Click(object sender, EventArgs e)
        {
            if (rad_sa_racunom.IsDisposed)
            {
                rad_sa_racunom = new Rad_Sa_Racunom();
            }
            rad_sa_racunom.Show();
        }

        
    }
}
