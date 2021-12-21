using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica
{
    class Kategorija
    {
        public int id_kategorije;
        public string naziv_kategorije;
        public static List<Kategorija> lista_kategorija = new List<Kategorija>();
        public Kategorija()
        {

        }
        public Kategorija(int id_kategorije, string naziv_kategorije)
        {
            this.id_kategorije = id_kategorije;
            this.naziv_kategorije = naziv_kategorije;
        }
        public static DataTable tabela_kategorija()
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM KATEGORIJA", @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\acode\OneDrive\Desktop\Aleksandar\Druga_godina\TVP\Prodavnica_TVP2\baza1.mdb");
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            return tabela;
        }

    }
}
