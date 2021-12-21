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
    public partial class Rad_Sa_Racunom : Form
    {
        Racun_forma racun_forma;
        int trenutni_id_kategorija;
        Proizvod izabran_proizvod;
        DataTable filtrirana_tabela;
        DataTable proizvodi_tabela;
        DataTable tabela_kategorija;
        public Rad_Sa_Racunom()
        {
            InitializeComponent();
            izabran_proizvod = new Proizvod();
            racun_forma = new Racun_forma();
            tabela_kategorija = Kategorija.tabela_kategorija();
            trenutni_id_kategorija = -1;
            filtrirana_tabela = new DataTable();
            proizvodi_tabela = Proizvod.tabela_proizvod();
        }
        public void osvezi_tabelu_proizvod()
        {
            
            lbProizvodi.Items.Clear();

            foreach(Proizvod p in Proizvod.lista_proizvoda)
            {
                lbProizvodi.Items.Add(p.proizvod_info());
            }
        }
        private void Rad_Sa_Racunom_Load(object sender, EventArgs e)
        {
            Proizvod.ucitaj_proizvode_iz_baze();
            if (racun_forma.IsDisposed)
            {
                racun_forma = new Racun_forma();
            }
            racun_forma.Show();
            filtrirana_tabela = Proizvod.tabela_proizvod().Copy();
            foreach (DataRow red in Kategorija.tabela_kategorija().Rows)
            {
                cbKategorija.Items.Add(red["Naziv_kategorije"]);
            }

        }
       
        private void btnProizvodKategorija_Click(object sender, EventArgs e)
        {
            lbProizvodi.Items.Clear();
            foreach (DataRow red in Proizvod.tabela_proizvod().Rows)
            {
                if ((int)red["ID_KATEGORIJA"] == trenutni_id_kategorija)
                {
                    
                    lbProizvodi.Items.Add(red["NAZIV_PROIZVODA"].ToString() + " " + int.Parse(red["CENA_PROIZVODA"].ToString()) + " RSD" + " kolicina:" + int.Parse(red["KOLICINA_PROIZVODA"].ToString()));
                }
            }

        }

        private void btnProizvodNaziv_Click(object sender, EventArgs e)
        {
            lbProizvodi.Items.Clear();
            
            if(tbNazivProizvoda.Text.Trim().Length != 0)
            {
                filtrirana_tabela.Clear();
                DataRow[] redovi = proizvodi_tabela.Select("NAZIV_PROIZVODA LIKE'" + tbNazivProizvoda.Text + "%'");
                foreach(DataRow red in redovi)
                {
                   DataRow formatiran_red = filtrirana_tabela.NewRow();
                    for(int i = 0; i < red.Table.Columns.Count; i++)
                    {
                        formatiran_red[i] = red[i];
                    }
                    filtrirana_tabela.Rows.Add(formatiran_red);
                }
                if(filtrirana_tabela.Rows.Count != 0)
                {
                    foreach (DataRow red in filtrirana_tabela.Rows)
                    {
                        lbProizvodi.Items.Add(red["NAZIV_PROIZVODA"].ToString() + " " + int.Parse(red["CENA_PROIZVODA"].ToString()) + " RSD" + " kolicina:" + int.Parse(red["KOLICINA_PROIZVODA"].ToString()));
                    }
                }
                else
                {
                    MessageBox.Show("Ne postoji proizvod koji odgovara unetom tekstu");
                }
            }
            else
            {
                foreach (DataRow red in Proizvod.tabela_proizvod().Rows)
                {
                    lbProizvodi.Items.Add(red["NAZIV_PROIZVODA"].ToString() + " " + int.Parse(red["CENA_PROIZVODA"].ToString()) + " RSD" + " kolicina:" + int.Parse(red["KOLICINA_PROIZVODA"].ToString()));
                }
            }
        }

       

        private void btnDodajnaRacun_Click(object sender, EventArgs e)
        {
            if (lbProizvodi.SelectedIndex != -1)
            {
                
                if (Proizvod.ukloni_proizvod_kolicina(izabran_proizvod))
                {
                    lbProizvodi.Items.Clear();
                    foreach (DataRow red in Proizvod.tabela_proizvod().Rows)
                    {
                        
                        if ((int)red["ID_KATEGORIJA"] == izabran_proizvod.get_id_kategorije())
                        {
                            lbProizvodi.Items.Add(red["NAZIV_PROIZVODA"].ToString() + " " + int.Parse(red["CENA_PROIZVODA"].ToString()) + " RSD" + " kolicina:" + int.Parse(red["KOLICINA_PROIZVODA"].ToString()));
                        }
                        
                    }
                    racun_forma.dodaj_proizvod(izabran_proizvod);
                }
                else
                {
                    MessageBox.Show("Na stanju trenutno vise nema dostupnih proizvoda");
                }
            }
            else
            {
                MessageBox.Show("Izaberite proizvod koji želite da dodate");
            }
            Proizvod.ucitaj_proizvode_iz_baze();
            
        }

        private void cbKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKategorija.SelectedIndex != -1)
            {
                foreach (DataRow red in Kategorija.tabela_kategorija().Rows)
                {
                    if (red["Naziv_kategorije"].ToString() == cbKategorija.SelectedItem.ToString())
                    {
                        trenutni_id_kategorija = (int)red["ID_Kategorija"];
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Izaberite zeljenu kategoriju");
            }
        }
        private void lbProizvodi_MouseClick(object sender, MouseEventArgs e)
        {
            if(lbProizvodi.SelectedItem != null) {
                foreach (Proizvod p in Proizvod.lista_proizvoda)
                {                    
                    if (p.proizvod_info() == lbProizvodi.SelectedItem.ToString())
                    {
                        izabran_proizvod = p;
                        break;

                    }
                }
            }
            else
            {
                MessageBox.Show("Izaberite željeni proizvod");
            }
        }
       
        

        
    }
}
