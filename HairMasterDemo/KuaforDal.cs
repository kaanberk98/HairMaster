using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairMasterDemo
{
    public class KuaforDal
    {

        SqlConnection _connection = new SqlConnection(@"server = (localdb)\mssqllocaldb; initial catalog = HAIRMASTER; integrated security = true");
        private void ConnectionControl()
        {

            if (_connection.State == ConnectionState.Closed)
            {

                _connection.Open();

            }

        }


        public List<Kuafor> GetAll()
        {

            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from Kuafor", _connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Kuafor> kuafors = new List<Kuafor>();

            while (reader.Read())
            {
                Kuafor kuafor = new Kuafor {

                    KuaforID = reader["KuaforID"].ToString(),
                    Isim = reader["Isim"].ToString(),
                    IkinciIsim = reader["IkinciIsim"].ToString(),
                    SoyIsim = reader["SoyIsim"].ToString(),
                    TelNo = reader["TelNo"].ToString(),
                    Adres = reader["Adres"].ToString(),
                    IsletmeGiris = reader["IsletmeGiris"].ToString(),
                    IsletmeCikis = reader["IsletmeCikis"].ToString(),
                    Email = reader["Email"].ToString(),
                    DogumTarihi = reader["DogumTarihi"].ToString(),




                };

                kuafors.Add(kuafor);

            }

            reader.Close();
            _connection.Close();
            return kuafors;
            
        }



        public DataTable GetAll2()
        {

            
            if (_connection.State == ConnectionState.Closed)
            {

                _connection.Open();

            }

            SqlCommand command = new SqlCommand("Exac SP_KuaforRead", _connection);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;

        }


        public void Ekle(Kuafor kuafor)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Kuafor values(@kuaforID,@ısim,@ikinciIsim,@soyIsim,@telNo,@adres,@isletmeGiris,@isletmeCikis,@email,@dogumTarihi)", _connection);
            command.Parameters.AddWithValue("@kuaforID", kuafor.KuaforID);
            command.Parameters.AddWithValue("@ısim", kuafor.Isim);
            command.Parameters.AddWithValue("@ikinciIsim", kuafor.IkinciIsim);
            command.Parameters.AddWithValue("@soyIsim", kuafor.SoyIsim);
            command.Parameters.AddWithValue("@telNo", kuafor.TelNo);
            command.Parameters.AddWithValue("@adres", kuafor.Adres);
            command.Parameters.AddWithValue("@isletmeGiris", kuafor.IsletmeGiris);
            command.Parameters.AddWithValue("@isletmeCikis", kuafor.IsletmeCikis);
            command.Parameters.AddWithValue("@email", kuafor.Email);
            command.Parameters.AddWithValue("@dogumTarihi", kuafor.DogumTarihi);

            command.ExecuteNonQuery();
            _connection.Close();

        }

        /*
        public void SP_Add(Kuafor kuafor)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Exec SP_KuaforAdd @kuaforID,@ısim,@ikinciIsim,@soyIsim,@telNo,@adres,@isletmeGiris,@isletmeCikis,@email,@dogumTarihi", _connection);
            command.Parameters.AddWithValue("@kuaforID", kuafor.KuaforID);
            command.Parameters.AddWithValue("@ısim", kuafor.Isim);
            command.Parameters.AddWithValue("@ikinciIsim", kuafor.IkinciIsim);
            command.Parameters.AddWithValue("@soyIsim", kuafor.SoyIsim);
            command.Parameters.AddWithValue("@telNo", kuafor.TelNo);
            command.Parameters.AddWithValue("@adres", kuafor.Adres);
            command.Parameters.AddWithValue("@isletmeGiris", kuafor.IsletmeGiris);
            command.Parameters.AddWithValue("@isletmeCikis", kuafor.IsletmeCikis);
            command.Parameters.AddWithValue("@email", kuafor.Email);
            command.Parameters.AddWithValue("@dogumTarihi", kuafor.DogumTarihi);

            command.ExecuteNonQuery();
            _connection.Close();

        }
        */

        public void Guncelle(Kuafor kuafor)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Kuafor set Isim=@isim,IkinciIsim=@ikinciIsim,SoyIsim=@soyIsim,TelNo=@telNo,Adres=@adres,IsletmeGiris=@isletmeGiris,IsletmeCikis=@isletmeCikis,Email=@email,DogumTarihi=@dogumTarihi where KuaforID=@kuaforID", _connection);
            command.Parameters.AddWithValue("@kuaforID", kuafor.KuaforID);
            command.Parameters.AddWithValue("@isim", kuafor.Isim);
            command.Parameters.AddWithValue("@ikinciIsim", kuafor.IkinciIsim);
            command.Parameters.AddWithValue("@soyIsim", kuafor.SoyIsim);
            command.Parameters.AddWithValue("@telNo", kuafor.TelNo);
            command.Parameters.AddWithValue("@adres", kuafor.Adres);
            command.Parameters.AddWithValue("@isletmeGiris", kuafor.IsletmeGiris);
            command.Parameters.AddWithValue("@isletmeCikis", kuafor.IsletmeCikis);
            command.Parameters.AddWithValue("@email", kuafor.Email);
            command.Parameters.AddWithValue("@dogumTarihi", kuafor.DogumTarihi);

            command.ExecuteNonQuery();
            _connection.Close();

        }

        /*
        public void SP_Update(Kuafor kuafor)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Exec SP_KuaforUpdate @isim,@ikinciIsim,@soyIsim,@telNo,@adres,@isletmeGiris,@isletmeCikis,@email,@dogumTarihi,@kuaforID", _connection);
            command.Parameters.AddWithValue("@kuaforID", kuafor.KuaforID);
            command.Parameters.AddWithValue("@isim", kuafor.Isim);
            command.Parameters.AddWithValue("@ikinciIsim", kuafor.IkinciIsim);
            command.Parameters.AddWithValue("@soyIsim", kuafor.SoyIsim);
            command.Parameters.AddWithValue("@telNo", kuafor.TelNo);
            command.Parameters.AddWithValue("@adres", kuafor.Adres);
            command.Parameters.AddWithValue("@isletmeGiris", kuafor.IsletmeGiris);
            command.Parameters.AddWithValue("@isletmeCikis", kuafor.IsletmeCikis);
            command.Parameters.AddWithValue("@email", kuafor.Email);
            command.Parameters.AddWithValue("@dogumTarihi", kuafor.DogumTarihi);

            command.ExecuteNonQuery();
            _connection.Close();

        }
        */

        public void Sil(string KuaforID)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Kuafor where KuaforID=@kuaforID", _connection);
            command.Parameters.AddWithValue("@kuaforID", KuaforID);


            command.ExecuteNonQuery();
            _connection.Close();




        }

        /*
        public void SP_Delete(string KuaforID)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Exec SP_KuaforDelete @kuaforID", _connection);
            command.Parameters.AddWithValue("@kuaforID", KuaforID);


            command.ExecuteNonQuery();
            _connection.Close();




        }
        */
    }
}
