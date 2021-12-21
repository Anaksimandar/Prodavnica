using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica
{
    class Racun
    {
        public int id_racun { get; set; }
        public int ukupna_cena { get; set; }
        public DateTime vreme_izdavanja { get; set; }
        public static DataTable vrati_tabelu_racun()
        {
            DataTable tabela = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM RACUN", @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\acode\OneDrive\Desktop\Aleksandar\Druga_godina\TVP\Prodavnica_TVP2\baza1.mdb");
            adapter.Fill(tabela);
            return tabela;
        }
        public static int azuriraj_tabelu_racun(Racun r)
        {
            DataTable tabela_racun = vrati_tabelu_racun();
            DataRow red = tabela_racun.NewRow();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM RACUN", @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\acode\OneDrive\Desktop\Aleksandar\Druga_godina\TVP\Prodavnica_TVP2\baza1.mdb");
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();
            adapter.InsertCommand = builder.GetInsertCommand();
            red["Ukupna_cena"] = r.ukupna_cena;
            red["Vreme_izdavanja"] = r.vreme_izdavanja;
            tabela_racun.Rows.Add(red);
            return adapter.Update(tabela_racun);
        }
    }
    
}
