using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairMasterDemo
{
    public class VW1DAL
    {

        SqlConnection _connection = new SqlConnection(@"server = (localdb)\mssqllocaldb; initial catalog = HAIRMASTER; integrated security = true");
        private void ConnectionControl()
        {

            if (_connection.State == ConnectionState.Closed)
            {

                _connection.Open();

            }

        }


        public List<VW1> GetAll()
        {

            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from VW1", _connection);
            SqlDataReader reader = command.ExecuteReader();

            List<VW1> vW1s = new List<VW1>();

            while (reader.Read())
            {
                VW1 vw1 = new VW1
                {
                    RandevuID = reader["RandevuID"].ToString(),
                    MusteriID = reader["MusteriID"].ToString(),
                    KuaforID = reader["KuaforID"].ToString(),
                    RandevuTarihSaat = reader["RandevuTarihSaat"].ToString(),


                };

               vW1s.Add(vw1);

            }

            reader.Close();
            _connection.Close();
            return vW1s;

        }
    }
}
