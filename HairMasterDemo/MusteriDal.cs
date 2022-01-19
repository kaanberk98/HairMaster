using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairMasterDemo
{
    public class MusteriDal
    {


        SqlConnection _connection = new SqlConnection(@"server = (localdb)\mssqllocaldb; initial catalog = HAIRMASTER; integrated security = true");

        private void ConnectionControl()
        {

            if (_connection.State == ConnectionState.Closed)
            {

                _connection.Open();

            }

        }

        public  List<Musteri> GetAll()
        {

            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from Musteri",_connection);

            List<Musteri> musteris = new List<Musteri>();

            while (reader.Read())
            {
                Musteri musteri = new Musteri {

                    MusteriID = reader["MusteriID"].ToString(),
                    Isim = reader["Isim"].ToString(),
                    IkinciIsim = reader["IkinciIsim"].ToString(),
                    SoyIsim = reader["SoyIsim"].ToString(),
                    TelNo = reader["TelNo"].ToString(),
                    Adres = reader["Adres"].ToString(),
                    Email = reader["Email"].ToString(),
                    DogumTarihi = reader["DogumTarihi"].ToString(),
                };

                musteris.Add(musteri);



            }

            reader.Close();
            _connection.Close();
            return musteris;


        }



        public DataTable GetAll2()
        {

           

            if (_connection.State == ConnectionState.Closed)
            {

                _connection.Open();


            }

            SqlCommand command = new SqlCommand("Select * from Musteri", _connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;




        }


        public void Ekle(Musteri musteri)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Musteri values(@musteriID,@ısim,@ikinciIsim,@soyIsim,@telNo,@adres,@email,@dogumTarihi)", _connection);
            command.Parameters.AddWithValue("@musteriID", musteri.MusteriID);
            command.Parameters.AddWithValue("@ısim", musteri.Isim);
            command.Parameters.AddWithValue("@ikinciIsim", musteri.IkinciIsim);
            command.Parameters.AddWithValue("@soyIsim", musteri.SoyIsim);
            command.Parameters.AddWithValue("@telNo", musteri.TelNo);
            command.Parameters.AddWithValue("@adres", musteri.Adres);
            command.Parameters.AddWithValue("@email", musteri.Email);
            command.Parameters.AddWithValue("@dogumTarihi", musteri.DogumTarihi);

            command.ExecuteNonQuery();
            _connection.Close();




        }


        /*
        public void SP_Add(Musteri musteri)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Exec SP_MusteriAdd @musteriID,@ısim,@ikinciIsim,@soyIsim,@telNo,@adres,@email,@dogumTarihi", _connection);
            command.Parameters.AddWithValue("@musteriID", musteri.MusteriID);
            command.Parameters.AddWithValue("@ısim", musteri.Isim);
            command.Parameters.AddWithValue("@ikinciIsim", musteri.IkinciIsim);
            command.Parameters.AddWithValue("@soyIsim", musteri.SoyIsim);
            command.Parameters.AddWithValue("@telNo", musteri.TelNo);
            command.Parameters.AddWithValue("@adres", musteri.Adres);
            command.Parameters.AddWithValue("@email", musteri.Email);
            command.Parameters.AddWithValue("@dogumTarihi", musteri.DogumTarihi);

            command.ExecuteNonQuery();
            _connection.Close();




        }
        */

        public void Guncelle(Musteri musteri)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Musteri set Isim=@ısim,IkinciIsim=@ikinciIsim,SoyIsim=@soyIsim,TelNo=@telNo,Adres=@adres,Email=@email,DogumTarihi=@dogumTarihi where MusteriID=@musteriID", _connection);
            command.Parameters.AddWithValue("@musteriID", musteri.MusteriID);
            command.Parameters.AddWithValue("@ısim", musteri.Isim);
            command.Parameters.AddWithValue("@ikinciIsim", musteri.IkinciIsim);
            command.Parameters.AddWithValue("@soyIsim", musteri.SoyIsim);
            command.Parameters.AddWithValue("@telNo", musteri.TelNo);
            command.Parameters.AddWithValue("@adres", musteri.Adres);
            command.Parameters.AddWithValue("@email", musteri.Email);
            command.Parameters.AddWithValue("@dogumTarihi", musteri.DogumTarihi);

            command.ExecuteNonQuery();
            _connection.Close();




        }

        /*
        public void SP_Update(Musteri musteri)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Exec SP_MusteriUpdate @ısim,@ikinciIsim,@soyIsim,@telNo,@adres,@email,@dogumTarihi,@musteriID", _connection);
            command.Parameters.AddWithValue("@musteriID", musteri.MusteriID);
            command.Parameters.AddWithValue("@ısim", musteri.Isim);
            command.Parameters.AddWithValue("@ikinciIsim", musteri.IkinciIsim);
            command.Parameters.AddWithValue("@soyIsim", musteri.SoyIsim);
            command.Parameters.AddWithValue("@telNo", musteri.TelNo);
            command.Parameters.AddWithValue("@adres", musteri.Adres);
            command.Parameters.AddWithValue("@email", musteri.Email);
            command.Parameters.AddWithValue("@dogumTarihi", musteri.DogumTarihi);

            command.ExecuteNonQuery();
            _connection.Close();




        }
        */

        public void Sil(string MusteriID)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Musteri where MusteriID=@musteriID", _connection);
            command.Parameters.AddWithValue("@musteriID", MusteriID);
            

            command.ExecuteNonQuery();
            _connection.Close();




        }

        /*
        public void SP_Delete(string MusteriID)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Exec SP_MusteriDelete @musteriID", _connection);
            command.Parameters.AddWithValue("@musteriID", MusteriID);


            command.ExecuteNonQuery();
            _connection.Close();




        }
        */
    }
}
