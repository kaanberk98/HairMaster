using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairMasterDemo
{
    public class VW2DAL
    {

        SqlConnection _connection = new SqlConnection(@"server = (localdb)\mssqllocaldb; initial catalog = HAIRMASTER; integrated security = true");
        private void ConnectionControl()
        {

            if (_connection.State == ConnectionState.Closed)
            {

                _connection.Open();

            }

        }


        internal List<VW2> GetAll()
        {

            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from VW2", _connection);
            SqlDataReader reader = command.ExecuteReader();

            List<VW2> vW2s = new List<VW2>();

            while (reader.Read())
            {
                VW2 vw2 = new VW2
                {
                    RandevuID = reader["RandevuID"].ToString(),
                    MusteriID = reader["MusteriID"].ToString(),
                    KuaforID = reader["KuaforID"].ToString(),
                    ToplamFiyat = Convert.ToDecimal(reader["ToplamFiyat"]),


                };

                vW2s.Add(vw2);

            }

            reader.Close();
            _connection.Close();
            return vW2s;


        }
    }
}
