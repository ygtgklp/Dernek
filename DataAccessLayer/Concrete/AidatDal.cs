using DataAccessLayer.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class AidatDal : IAidatDal
    {
        private string server = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Ders\\Görsel Programlama\\Görsel Finale\\Uyeler.accdb;";

        public List<Aidat> GetAll()
        {
            using (OleDbConnection connection = new OleDbConnection(server))
            {
                connection.Open();
                string query = "Select * from Aidat";
                List<Aidat> aidatlistesi = new List<Aidat>();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    OleDbDataReader getir = command.ExecuteReader();
                    while (getir.Read())
                    {
                        Aidat aidat = new Aidat();
                        aidat.aidat_id = int.Parse(getir[0].ToString());
                        aidat.aidat_month = getir[1].ToString();
                        aidat.aidat_price = getir[2].ToString();
                        aidatlistesi.Add(aidat);
                    }
                    return aidatlistesi;
                }
            }
        }

        public void Update(Aidat aidat)
        {
            throw new NotImplementedException();
        }
    }
}
