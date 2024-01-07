using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using Entities.Concrete;
using DataAccessLayer.Abstract;

namespace DataAccessLayer.Concrete
{
    public class UyelerDal : IUyelerDal
    {
        private string server = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Ders\\Görsel Programlama\\Görsel Finale\\Uyeler.accdb;";

        public void Add(Uyeler uyeler)
        {
            using (OleDbConnection connection = new OleDbConnection(server))
            {
                connection.Open();

                string check = "SELECT COUNT(*) FROM Uyeler";
                OleDbCommand cmd = new OleDbCommand(check, connection);
                int count = (int)cmd.ExecuteScalar();

                if (count == 0)
                    uyeler.uye_id = 1;

                string query = "INSERT INTO Uyeler (uye_name, uye_surname, uye_tc, uye_country, uye_bloodtype, uye_active) VALUES (@uyename, @uyesurname, @uyetc, @uyecountry, @uyebloodtype, @uyeactive)";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@uyename", uyeler.uye_name);
                    command.Parameters.AddWithValue("@uyesurname", uyeler.uye_surname);
                    command.Parameters.AddWithValue("@uyetc", uyeler.uye_tc);
                    command.Parameters.AddWithValue("@uyecountry", uyeler.uye_country);
                    command.Parameters.AddWithValue("@uyebloodtype", uyeler.uye_bloodtype);
                    command.Parameters.AddWithValue("@uyeactive", uyeler.uye_active);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int uye_id)
        {
            throw new NotImplementedException();
        }

        public List<Uyeler> GetAll()
        {
            using (OleDbConnection connection = new OleDbConnection(server))
            {
                connection.Open();
                string query = "Select * from Uyeler";
                List<Uyeler> uyelistesi = new List<Uyeler>();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    OleDbDataReader getir = command.ExecuteReader();
                    while (getir.Read())
                    {
                        Uyeler uye = new Uyeler();
                        uye.uye_id = int.Parse(getir[0].ToString());
                        uye.uye_name = getir[1].ToString();
                        uye.uye_surname = getir[2].ToString();
                        uye.uye_tc = getir[3].ToString();
                        uye.uye_country = getir[4].ToString();
                        uye.uye_bloodtype = getir[5].ToString();
                        uye.uye_active = bool.Parse( getir[6].ToString());
                        uyelistesi.Add(uye);
                    }
                    return uyelistesi;
                }
            }
        }

        public List<Uyeler> GetAllByCountry(string country)
        {
            using (OleDbConnection connection = new OleDbConnection(server))
            {
                connection.Open();
                string query = "Select * FROM Uyeler WHERE uye_country = @country";
                List<Uyeler> uyelistesi = new List<Uyeler>();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@country", country);
                    OleDbDataReader getir = command.ExecuteReader();
                    while (getir.Read())
                    {
                        /*string ad = getir.GetString(1);
                        string soyad = getir.GetString(2);
                        string tc = getir.GetString(3);
                        string countrys = getir.GetString(4);
                        string blood = getir.GetString(5);

                        Uyeler uye = new Uyeler
                        {
                            uye_name= ad,
                            uye_surname = soyad,
                            uye_tc = tc,
                            uye_country= countrys,
                            uye_bloodtype= blood
                        };
                        */
                        Uyeler uye = new Uyeler();
                        uye.uye_id = int.Parse(getir[0].ToString());
                        uye.uye_name = getir[1].ToString();
                        uye.uye_surname = getir[2].ToString();
                        uye.uye_tc = getir[3].ToString();
                        uye.uye_country = getir[4].ToString();
                        uye.uye_bloodtype = getir[5].ToString();
                        uye.uye_active = bool.Parse(getir[6].ToString());
                        uyelistesi.Add(uye);
                    }
                    return uyelistesi;
                }
            }
        }

        public List<Uyeler> GetAllByBlood(string blood)
        {
            using (OleDbConnection connection = new OleDbConnection(server))
            {
                connection.Open();
                string query = "Select * FROM Uyeler WHERE uye_bloodtype = @blood";
                List<Uyeler> uyelistesi = new List<Uyeler>();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@blood", blood);
                    OleDbDataReader getir = command.ExecuteReader();
                    while (getir.Read())
                    {
                        Uyeler uye = new Uyeler();
                        uye.uye_id = int.Parse(getir[0].ToString());
                        uye.uye_name = getir[1].ToString();
                        uye.uye_surname = getir[2].ToString();
                        uye.uye_tc = getir[3].ToString();
                        uye.uye_country = getir[4].ToString();
                        uye.uye_bloodtype = getir[5].ToString();
                        uye.uye_active = bool.Parse(getir[6].ToString());
                        uyelistesi.Add(uye);
                    }
                    return uyelistesi;
                }
            }
        }

        public List<Uyeler> GetAllByActive(bool active)
        {
            using (OleDbConnection connection = new OleDbConnection(server))
            {
                connection.Open();
                string query = "Select * FROM Uyeler WHERE uye_active = @active";
                List<Uyeler> uyelistesi = new List<Uyeler>();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@active", active);
                    OleDbDataReader getir = command.ExecuteReader();
                    while (getir.Read())
                    {
                        Uyeler uye = new Uyeler();
                        uye.uye_id = int.Parse(getir[0].ToString());
                        uye.uye_name = getir[1].ToString();
                        uye.uye_surname = getir[2].ToString();
                        uye.uye_tc = getir[3].ToString();
                        uye.uye_country = getir[4].ToString();
                        uye.uye_bloodtype = getir[5].ToString();
                        uye.uye_active = bool.Parse(getir[6].ToString());
                        uyelistesi.Add(uye);
                    }
                    return uyelistesi;
                }
            }
        }

        public void Update(Uyeler uyeler)
        {
            throw new NotImplementedException();
        }
    }
}
