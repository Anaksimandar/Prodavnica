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
    public partial class Proizvod_Form : Form
    {
        DataTable tabela_proizvod;
        public Proizvod_Form()
        {
            InitializeComponent();
            
        }

        private void btnPrikaziProizvode_Click(object sender, EventArgs e)
        {
            tabela_proizvod = Proizvod.tabela_proizvod();
            if(tabela_proizvod != null)
            {
                dataGridView1.DataSource = tabela_proizvod;
                dataGridView1.Columns["ID_PROIZVODA"].DisplayIndex = 0;
            }
        }

        private void Proizvod_Form_Load(object sender, EventArgs e)
        {
            var tabela = Kategorija.tabela_kategorija();
            foreach (DataRow red in tabela.Rows)
            {
                cbKategorija.Items.Add(red["Naziv_kategorije"]);
            }
        }

        private void btnDodajProizvod_Click(object sender, EventArgs e)
        {
            bool provera_id_proizvod = false;
            bool provera_naziv = false;
            bool provera_cena = false;
            bool provera_kolicina = false;
            bool provera_id_kategorija = false;
            int cena;
            int kolicina;
            int id_kategorije = 0;
            int id_proizvod;
            if (string.IsNullOrEmpty(tbNaziv.Text))
            {
                provera_naziv = false;
                MessageBox.Show("Unesite naziv proizvoda");
            }
            else
            {
                provera_naziv = true;
            }
            provera_id_proizvod = Int32.TryParse(tbIdProizvoda.Text, out id_proizvod);
            provera_cena = Int32.TryParse(tbCena.Text, out cena);
            provera_kolicina = Int32.TryParse(tbKolicina.Text, out kolicina);
            if (!provera_id_proizvod)
            {
                MessageBox.Show("Unesite pozitivnan broj za kolicinu");

            }
            else
            {
                if(id_proizvod > 0)
                {

                    foreach (DataRow red in Proizvod.tabela_proizvod().Rows)
                    {
                        if ((int)red["ID_PROIZVODA"] == id_proizvod)
                        {
                            provera_id_proizvod = false;
                            MessageBox.Show("Neispravan ID.");
                            break;
                        }
                        else
                        {
                            provera_id_proizvod = true;

                        }
                    }
                }
                else
                {
                    provera_id_proizvod = false;
                    MessageBox.Show("ID ne moze biti negativan broj ili 0");
                }
            }
            if (!provera_kolicina)
            {
                MessageBox.Show("Unesite pozitivnan broj za kolicinu");
            }
            else
            {
                if(provera_kolicina && kolicina < 0)
            {
                    provera_kolicina = false;
                    MessageBox.Show("Kolicina ne moze biti iskazana negativnim brojem.");
                }
                else
                {
                    provera_kolicina = true;
                }
            }
            if (!provera_cena)
            {
                
                MessageBox.Show("Unesite pozitivnan broj za cenu");
            }
            else
            {
                if (provera_cena && cena <= 0)
                {
                    provera_cena = false;
                    MessageBox.Show("Cena ne moze biti iskazana negativnim brojem");
                }
                else
                {
                    provera_cena = true;
                }
            }
            
            
            if (cbKategorija.SelectedIndex != -1)
            {
                provera_id_kategorija = true;
                foreach(DataRow red in Kategorija.tabela_kategorija().Rows)
                {
                    if(red["Naziv_kategorije"].ToString() == cbKategorija.SelectedItem.ToString())
                    {
                        id_kategorije = (int)red["ID_Kategorija"];
                        break;
                    }
                }
            }
            else
            {
                provera_id_kategorija = false;
                MessageBox.Show("Izaberite željenu kategoriju");
            }
            if(provera_naziv && provera_cena && provera_id_kategorija && provera_kolicina && provera_id_proizvod)
            {
                Proizvod novi_prozivod = new Proizvod(id_proizvod, id_kategorije, tbNaziv.Text, cena, kolicina);
                int broj_redova = Proizvod.dodaj_proizvod(novi_prozivod);
                MessageBox.Show("Broj izmenjenih redova: " + broj_redova);

            }
            

        }

        private void btnSacuvajIzmene_Click(object sender, EventArgs e)
        {
            int broj_izmenjenih = Proizvod.sacuvaj_izmene(tabela_proizvod);
            MessageBox.Show("Broj izmenjenih redova je: " + broj_izmenjenih);

            
        }
    }
}
