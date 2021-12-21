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
    public partial class Racun_forma : Form
    {
        Prodavnica ds;
        ProdavnicaTableAdapters.RacunTableAdapter racun_adapter;
        Rad_Sa_Racunom rad_sa_racunom_form;
        Proizvod izabran_proizvod;
        List<Proizvod> proizvodi_na_racunu = new List<Proizvod>();
        public Racun_forma()
        {
            InitializeComponent();
            ds = new Prodavnica();
            racun_adapter = new ProdavnicaTableAdapters.RacunTableAdapter();
            izabran_proizvod = new Proizvod();
        }

        public void dodaj_proizvod(Proizvod novi_proizvod)
        {
            bool postoji_proizvod = false;
            lbProizvodinaRacunu.Items.Clear();
            if (proizvodi_na_racunu.Count == 0)
            {
                novi_proizvod.set_kolicina(1);
                proizvodi_na_racunu.Add(novi_proizvod);
            }
            else
            {
                foreach (Proizvod p in proizvodi_na_racunu.ToArray())
                {
                    if (p.get_naziv_proizvoda() == novi_proizvod.get_naziv_proizvoda())
                    {
                        int trenutna_kolicina = p.get_kolicina_proizvoda() + 1;
                        p.set_kolicina(trenutna_kolicina);
                        postoji_proizvod = true;
                        break;

                    }

                }
                if (!postoji_proizvod)
                {

                    novi_proizvod.set_kolicina(1);
                    proizvodi_na_racunu.Add(novi_proizvod);


                }

            }
            lblUkupno.Text = stanje_na_racunu(proizvodi_na_racunu).ToString();
            //rad_sa_racunom_form.osvezi_tabelu_proizvod();
            foreach (Proizvod p in proizvodi_na_racunu)
            {
                lbProizvodinaRacunu.Items.Add(p.proizvod_info());
            }

        }
        private int stanje_na_racunu(List<Proizvod> proizvodi)
        {
            int ukupno = 0;
            foreach (Proizvod p in proizvodi)
            {
                ukupno += p.get_cena_proizvoda() * p.get_kolicina_proizvoda();
            }
            return ukupno;
        }
        private void Racun_forma_Load(object sender, EventArgs e)
        {

        }


        private void ukloni_proizvod(Proizvod novi_proizvod)
        {
            proizvodi_na_racunu.Remove(novi_proizvod);
        }
        //private static DateTime dan_mesec_godina(DateTime datum)
        //{
        //    return 1;
        //}
        //public  static DateTime cas_minut(DateTime datum)
        //{

        //}
        

        private void btnUkloni_Click(object sender, EventArgs e)
        {

            if (lbProizvodinaRacunu.SelectedIndex != -1)
            {
                lbProizvodinaRacunu.Items.Clear();
                if (izabran_proizvod.get_kolicina_proizvoda() == 1)
                {
                    Proizvod.dodaj_proizvod_kolicina(izabran_proizvod);
                    proizvodi_na_racunu.Remove(izabran_proizvod);
                }
                if (izabran_proizvod.get_kolicina_proizvoda() >= 2)
                {
                    int trenutna_kolicina = izabran_proizvod.get_kolicina_proizvoda() - 1;
                    izabran_proizvod.set_kolicina(trenutna_kolicina);
                    Proizvod.dodaj_proizvod_kolicina(izabran_proizvod);
                }
                foreach (Proizvod proizvod in proizvodi_na_racunu)
                {
                    lbProizvodinaRacunu.Items.Add(proizvod.proizvod_info());
                }
                lblUkupno.Text = stanje_na_racunu(proizvodi_na_racunu).ToString();

            }
            else
            {
                MessageBox.Show("Izaberite proizvod koji želite da uklonite");
            }


        }

        private void lbProizvodinaRacunu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbProizvodinaRacunu.SelectedIndex != -1)
            {
                foreach (Proizvod p in proizvodi_na_racunu)
                {
                    if (p.proizvod_info() == lbProizvodinaRacunu.SelectedItem.ToString())
                    {
                        izabran_proizvod = p;
                        break;
                    }
                }
            }

        }

        private void lbProizvodinaRacunu_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            Prodavnica.RacunRow racun_red = ds.Racun.NewRacunRow();
            if (lblUkupno.Text == "0"|| proizvodi_na_racunu.Count ==0|| lbProizvodinaRacunu.Items.Count == 0)
            {
                MessageBox.Show("Na racunu nema proizvoda");
                return;
            }

            int cena = 0;
            bool konverzija = int.TryParse(lblUkupno.Text, out cena);
            Racun novi_racun = new Racun();
            novi_racun.id_racun = 1;
            novi_racun.ukupna_cena = cena;
            novi_racun.vreme_izdavanja = DateTime.Now;
            int broj_izmena = Racun.azuriraj_tabelu_racun(novi_racun);
            MessageBox.Show("Racun je uspesno upisan");
            proizvodi_na_racunu.Clear();
            lbProizvodinaRacunu.Items.Clear();
            lblUkupno.Text = "0";
        }
    }
}
