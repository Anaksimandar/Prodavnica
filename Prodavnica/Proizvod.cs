using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica
{
    public class Proizvod
    {
        int id_proizvoda;
        int id_kategorje;
        string naziv_proizvoda;
        int cena_proizvoda;
        int kolicina_proizvoda;
        public static List<Proizvod> lista_proizvoda = new List<Proizvod>();

        public Proizvod()
        {

        }
        public Proizvod(int id_proizvoda, int id_kategorje, string naziv_proizvoda, int cena_proizvoda, int kolicina_proizvoda)
        {
            this.id_proizvoda = id_proizvoda;
            this.id_kategorje = id_kategorje;
            this.naziv_proizvoda = naziv_proizvoda;
            this.cena_proizvoda = cena_proizvoda;
            this.kolicina_proizvoda = kolicina_proizvoda;
        }
        public string proizvod_info()
        {
            return naziv_proizvoda +" "+ cena_proizvoda + " RSD" + " kolicina:" + kolicina_proizvoda;
        }
        public static  DataTable tabela_proizvod()
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM PROIZVOD", @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\acode\OneDrive\Desktop\Aleksandar\Druga_godina\TVP\Prodavnica_TVP2\baza1.mdb");

            DataTable ds = new DataTable();
            adapter.Fill(ds);
            return ds;

        }
        public static void ucitaj_proizvode_iz_baze()
        {
            lista_proizvoda.Clear();
            DataTable tabela_proizvoda = tabela_proizvod();
            foreach(DataRow red in tabela_proizvoda.Rows)
            {
                lista_proizvoda.Add(new Proizvod(int.Parse(red["ID_PROIZVODA"].ToString()), int.Parse(red["ID_KATEGORIJA"].ToString()), red["NAZIV_PROIZVODA"].ToString(), int.Parse(red["CENA_PROIZVODA"].ToString()), int.Parse(red["KOLICINA_PROIZVODA"].ToString())));
                
            }
        }
        public static int dodaj_proizvod(Proizvod novi_proizvod)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM PROIZVOD", @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\acode\OneDrive\Desktop\Aleksandar\Druga_godina\TVP\Prodavnica_TVP2\baza1.mdb");
            int broj_izmena = 0;
            OleDbCommandBuilder komanda = new OleDbCommandBuilder(adapter);
            adapter.InsertCommand = komanda.GetInsertCommand();
            DataTable stara_tabela = Proizvod.tabela_proizvod();
            DataRow red_novi_proizvod = stara_tabela.NewRow();
            red_novi_proizvod["ID_PROIZVODA"] = novi_proizvod.id_proizvoda;
            red_novi_proizvod["NAZIV_PROIZVODA"] = novi_proizvod.naziv_proizvoda;
            red_novi_proizvod["CENA_PROIZVODA"] =novi_proizvod.cena_proizvoda;
            red_novi_proizvod["KOLICINA_PROIZVODA"] =novi_proizvod.kolicina_proizvoda;
            red_novi_proizvod["ID_KATEGORIJA"] = novi_proizvod.id_kategorje;
            stara_tabela.Rows.Add(red_novi_proizvod);
            
            try
            {
                return broj_izmena = adapter.Update(stara_tabela);
            }
            catch (Exception e)
            {
                
                return broj_izmena;
            }

        }
        public static bool ukloni_proizvod_kolicina(Proizvod izabran_proizvod)
        {
            
            bool izmenjena_tabela = false;
            //Selektovani proizvod treba pronaci u tabeli i smanjiti kolicinu za 1
            DataTable tabela_proizvod = Proizvod.tabela_proizvod();
            foreach (DataRow red in tabela_proizvod.Rows)
            {
                if (red["NAZIV_PROIZVODA"].ToString() == izabran_proizvod.naziv_proizvoda)
                {
                    if(int.Parse(red["KOLICINA_PROIZVODA"].ToString()) != 0)
                    {
                        red["KOLICINA_PROIZVODA"] = int.Parse(red["KOLICINA_PROIZVODA"].ToString()) -1;
                        izmenjena_tabela = true;
                    }
                }
                
            }
            sacuvaj_izmene(tabela_proizvod);
            return izmenjena_tabela;
        }
        public static bool dodaj_proizvod_kolicina(Proizvod izabran_proizvod)
        {

            bool izmenjena_tabela = false;
            //Selektovani proizvod treba pronaci u tabeli i smanjiti kolicinu za 1
            DataTable tabela_proizvod = Proizvod.tabela_proizvod();
            foreach (DataRow red in tabela_proizvod.Rows)
            {
                if (red["NAZIV_PROIZVODA"].ToString() == izabran_proizvod.naziv_proizvoda)
                {
                    if (int.Parse(red["KOLICINA_PROIZVODA"].ToString()) != 0)
                    {
                        red["KOLICINA_PROIZVODA"] = int.Parse(red["KOLICINA_PROIZVODA"].ToString()) +1;
                        izmenjena_tabela = true;
                    }
                }

            }
            sacuvaj_izmene(tabela_proizvod);
            return izmenjena_tabela;
        }

        public static int sacuvaj_izmene(DataTable azurirana_tabela)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM PROIZVOD", @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\acode\OneDrive\Desktop\Aleksandar\Druga_godina\TVP\Prodavnica_TVP2\baza1.mdb");
            int broj_izmena = 0;
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();
            try
            {
                return broj_izmena = adapter.Update(azurirana_tabela);
            }catch(Exception e)
            {
                return broj_izmena;
            }

        }
        public int get_id_proizvoda()
        {
            return this.id_proizvoda;
        }
        public int get_id_kategorije()
        {
            return this.id_kategorje;
        }
        public string get_naziv_proizvoda()
        {
            return this.naziv_proizvoda;
        }
        public int get_cena_proizvoda()
        {
            return this.cena_proizvoda;
        }
        public int get_kolicina_proizvoda()
        {
            return this.kolicina_proizvoda;
        }
        public void set_id_prozivoda(int novi_id)
        {
            this.id_proizvoda = novi_id;
        }
        public void set_id_kategorija(int novi_id)
        {
            this.id_kategorje = novi_id;
        }
        public void set_naziv(string novi_naziv)
        {
            this.naziv_proizvoda = novi_naziv;
        }
        public void set_cena(int nova_cena)
        {
            this.cena_proizvoda = nova_cena;
        }
        public void set_kolicina(int nova_kolicina)
        {
            this.kolicina_proizvoda =nova_kolicina;
        }

    }
        
    
}
