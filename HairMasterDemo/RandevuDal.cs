using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairMasterDemo
{
    public class RandevuDal
    {

        SqlConnection _connection = new SqlConnection(@"server = (localdb)\mssqllocaldb; initial catalog = HAIRMASTER; integrated security = true");
        private void ConnectionControl()
        {

            if (_connection.State == ConnectionState.Closed)
            {

                _connection.Open();

            }

        }

        public List<Randevu> GetAll()
        {

            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from Randevu", _connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Randevu> randevus = new List<Randevu>();

            while (reader.Read())
            {
                Randevu randevu = new Randevu
                {
                    RandevuID = reader["RandevuID"].ToString(),
                    RandevuTarihSaat = reader["RandevuTarihSaat"].ToString(),
                    ToplamFiyat = Convert.ToDecimal(reader["ToplamFiyat"]),
                    HizmetSuresi = Convert.ToInt32(reader["HizmetSuresi"]),
                    MusteriID = reader["MusteriID"].ToString(),
                    KuaforID = reader["KuaforID"].ToString(),

                };
                randevus.Add(randevu);

            }
            reader.Close();
            _connection.Close();
            return randevus;

        }


        public DataTable GetAll2()
        {

            if (_connection.State == ConnectionState.Closed)
            {

                _connection.Open();

            }

            SqlCommand command = new SqlCommand("Select * from Randevu", _connection);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;



        }

        public void Ekle(Randevu randevu)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Randevu values(@randevuID,@randevuTarihSaat,@toplamFiyat,@hizmetSuresi,@musteriID,@kuaforID)", _connection);
            command.Parameters.AddWithValue("@randevuID", randevu.RandevuID);
            command.Parameters.AddWithValue("@randevuTarihSaat", randevu.RandevuTarihSaat);
            command.Parameters.AddWithValue("@toplamFiyat", randevu.ToplamFiyat);
            command.Parameters.AddWithValue("@hizmetSuresi", randevu.HizmetSuresi);
            command.Parameters.AddWithValue("@musteriID", randevu.MusteriID);
            command.Parameters.AddWithValue("@kuaforID", randevu.KuaforID);

            command.ExecuteNonQuery();
            _connection.Close();




        }

        /*
        public void SP_Add(Randevu randevu)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Exec SP_RandevuAdd @randevuID,@randevuTarihSaat,@toplamFiyat,@hizmetSuresi,@musteriID,@kuaforID", _connection);
            command.Parameters.AddWithValue("@randevuID", randevu.RandevuID);
            command.Parameters.AddWithValue("@randevuTarihSaat", randevu.RandevuTarihSaat);
            command.Parameters.AddWithValue("@toplamFiyat", randevu.ToplamFiyat);
            command.Parameters.AddWithValue("@hizmetSuresi", randevu.HizmetSuresi);
            command.Parameters.AddWithValue("@musteriID", randevu.MusteriID);
            command.Parameters.AddWithValue("@kuaforID", randevu.KuaforID);

            command.ExecuteNonQuery();
            _connection.Close();




        }
        */
        public void Guncelle(Randevu randevu)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Randevu set RandevuTarihSaat=@randevuTarihSaat,ToplamFiyat=@toplamFiyat,HizmetSuresi=@hizmetSuresi,MusteriID=@musteriID,KuaforID=@kuaforID where RandevuID=@randevuID", _connection);
            command.Parameters.AddWithValue("@randevuID", randevu.RandevuID);
            command.Parameters.AddWithValue("@randevuTarihSaat", randevu.RandevuTarihSaat);
            command.Parameters.AddWithValue("@toplamFiyat", randevu.ToplamFiyat);
            command.Parameters.AddWithValue("@hizmetSuresi", randevu.HizmetSuresi);
            command.Parameters.AddWithValue("@musteriID", randevu.MusteriID);
            command.Parameters.AddWithValue("@kuaforID", randevu.KuaforID);

            command.ExecuteNonQuery();
            _connection.Close();




        }

        /*
        public void Sp_Update(Randevu randevu)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Exec SP_RandevuUpdate @randevuTarihSaat,@toplamFiyat,@hizmetSuresi,@musteriID,@kuaforID,@randevuID", _connection);
            command.Parameters.AddWithValue("@randevuID", randevu.RandevuID);
            command.Parameters.AddWithValue("@randevuTarihSaat", randevu.RandevuTarihSaat);
            command.Parameters.AddWithValue("@toplamFiyat", randevu.ToplamFiyat);
            command.Parameters.AddWithValue("@hizmetSuresi", randevu.HizmetSuresi);
            command.Parameters.AddWithValue("@musteriID", randevu.MusteriID);
            command.Parameters.AddWithValue("@kuaforID", randevu.KuaforID);

            command.ExecuteNonQuery();
            _connection.Close();




        }
        */

        public void Sil(string RandevuID)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Randevu where RandevuID=@randevuID", _connection);
            command.Parameters.AddWithValue("@randevuID", RandevuID);


            command.ExecuteNonQuery();
            _connection.Close();




        }

        /*
        public void SP_Delete(int RandevuID)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Exec SP_RandevuDelete @randevuID", _connection);
            command.Parameters.AddWithValue("@randevuID", RandevuID);


            command.ExecuteNonQuery();
            _connection.Close();




        }

        */
    }
}
