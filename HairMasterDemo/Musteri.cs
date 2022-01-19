using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairMasterDemo
{
    public class Musteri
    {
      
       public string  MusteriID { get; set; }
       public string Isim { get; set; }
       public string IkinciIsim { get; set; }
       public string SoyIsim { get; set; }
       public string TelNo { get; set; }
       public string Adres { get; set; }
       public string Email { get; set; }
       public string DogumTarihi { get; set; }
    }
}
