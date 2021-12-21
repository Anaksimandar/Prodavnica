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
    public partial class Racun_baza_form : Form
    {
        DataTable tabela_racun;
        DataTable sortirana_tabela;
        DataRow sortiran_red;

        public Racun_baza_form()
        {
            InitializeComponent();
            
            tabela_racun = Racun.vrati_tabelu_racun();
            sortirana_tabela = tabela_racun.Copy();
            sortiran_red = sortirana_tabela.NewRow();

        }

        private void racun_baza_form_Load(object sender, EventArgs e)
        {
            DateTime min =  DateTime.Now;
            DateTime max = DateTime.Now.AddYears(-10);
            foreach (DataRow red in tabela_racun.Rows)
            {
                DateTime datum = DateTime.Parse(red["Vreme_izdavanja"].ToString());
                if (datum < min)
                {
                    min = datum;
                }
                if(datum > max)
                {
                    max = datum;
                }
            }

            dtpPocetniDatum.MinDate = min;
            dtpPocetniDatum.Value = min;
            dtpKrajnjiDatum.MaxDate = max;
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            
            sortirana_tabela.Clear();
            foreach(DataRow red in Racun.vrati_tabelu_racun().Rows)
            {
                sortiran_red = sortirana_tabela.NewRow();
                DateTime datum = DateTime.Parse(red["Vreme_izdavanja"].ToString());
                if(datum > dtpPocetniDatum.Value.AddMinutes(-1) && datum < dtpKrajnjiDatum.Value.AddMinutes(+1))
                {

                    sortiran_red["Id_racun"] = red["Id_racun"];
                    sortiran_red["Ukupna_cena"] = red["Ukupna_cena"];
                    sortiran_red["Vreme_izdavanja"] = red["Vreme_izdavanja"];
                    sortirana_tabela.Rows.Add(sortiran_red);

                }
            }
            
            dataGridView1.DataSource = sortirana_tabela;
        }
    }
}
