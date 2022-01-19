using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairMasterDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        MusteriDal _musteriDal = new MusteriDal();
        private void LoadMusteri()
        {

            dgwMusteri.DataSource = _musteriDal.GetAll();


        }

        KuaforDal _kuaforDal = new KuaforDal();
        private void LoadKuafor()
        {


            dgwKuafor.DataSource = _kuaforDal.GetAll();


        }

        RandevuDal _randevuDal = new RandevuDal();
        private void LoadRandevu()
        {

            dgwRandevu.DataSource = _randevuDal.GetAll();


        }

        VW1DAL _vW1DAL = new VW1DAL();
        private void LoadVW1()
        {



            dgwVW1.DataSource = _vW1DAL.GetAll();


        }

        VW2DAL _vW2DAL = new VW2DAL();
        private void LoadVW2()
        {



            dgwVW2.DataSource = _vW2DAL.GetAll();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadKuafor();
            LoadMusteri();
            LoadRandevu();
            LoadVW1();
            LoadVW2();
        }

/// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnEkle_Click(object sender, EventArgs e)
        {

            _musteriDal.Ekle(new Musteri { 
            
                MusteriID = tbxMusteriID.Text,
                Isim = tbxIsim.Text,
                IkinciIsim = tbxIkinciIsim.Text,
                SoyIsim = tbxSoyIsim.Text,
                TelNo = tbxTelNo.Text,
                Adres = tbxAdres.Text,
                Email = tbxEmail.Text,
                DogumTarihi = tbxDogumTarihi.Text,
            
            });

            LoadMusteri();
            MessageBox.Show("Musteri Eklendi !");


          /*  _musteriDal.SP_Add(new Musteri
            {

                MusteriID = tbxMusteriID.Text,
                Isim = tbxIsim.Text,
                IkinciIsim = tbxIkinciIsim.Text,
                SoyIsim = tbxSoyIsim.Text,
                TelNo = tbxTelNo.Text,
                Adres = tbxAdres.Text,
                Email = tbxEmail.Text,
                DogumTarihi = tbxDogumTarihi.Text,

            });

            LoadMusteri();
            MessageBox.Show("Musteri Eklendi !");
            */
        }

       

        private void dgwMusteri_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tbxIsimUpdate.Text= dgwMusteri.CurrentRow.Cells[1].Value.ToString();
            tbxIkinciIsimUpdate.Text = dgwMusteri.CurrentRow.Cells[2].Value.ToString();
            tbxSoyIsimUpdate.Text = dgwMusteri.CurrentRow.Cells[3].Value.ToString();
            tbxTelNoUpdate.Text = dgwMusteri.CurrentRow.Cells[4].Value.ToString();
            tbxAdresUpdate.Text = dgwMusteri.CurrentRow.Cells[5].Value.ToString();
            tbxEmailUpdate.Text = dgwMusteri.CurrentRow.Cells[6].Value.ToString();
            tbxDogumTarihiUpdate.Text = dgwMusteri.CurrentRow.Cells[7].Value.ToString();
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            Musteri musteri = new Musteri()
            {
                MusteriID = dgwMusteri.CurrentRow.Cells[0].Value.ToString(),
                Isim = tbxIsimUpdate.Text,
                IkinciIsim = tbxIkinciIsimUpdate.Text,
                SoyIsim = tbxSoyIsimUpdate.Text,
                TelNo = tbxTelNoUpdate.Text,
                Adres = tbxAdresUpdate.Text,
                Email = tbxEmailUpdate.Text,
                DogumTarihi = tbxDogumTarihiUpdate.Text,
            };
            _musteriDal.Guncelle(musteri);
            //_musteriDal.SP_Update(musteri);
            LoadMusteri();
            MessageBox.Show("Guncellendi!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            String musteriID = dgwMusteri.CurrentRow.Cells[0].Value.ToString();
            _musteriDal.Sil(musteriID);
            //_musteriDal.SP_Delete(musteriID);
            LoadMusteri();
            MessageBox.Show("Silindi!");
        }

/// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnEkle2_Click(object sender, EventArgs e)
        {
            _kuaforDal.Ekle(new Kuafor
            {

                KuaforID = tbxKuaforID.Text,
                Isim = tbxKuaforIsim.Text,
                IkinciIsim = tbxKuaforIkinciIsim.Text,
                SoyIsim = tbxKuaforSoyIsim.Text,
                TelNo = tbxKuaforTelNo.Text,
                Adres = tbxKuaforAdres.Text,
                IsletmeGiris = tbxIsletmeGiris.Text,
                IsletmeCikis = tbxIsletmeCikis.Text, 
                Email = tbxKuaforEmail.Text,
                DogumTarihi = tbxKuaforDogumTarihi.Text,

            });

            LoadKuafor();
            MessageBox.Show("Kuafor Eklendi !");

           /* _kuaforDal.SP_Add(new Kuafor
            {

                KuaforID = tbxKuaforID.Text,
                Isim = tbxKuaforIsim.Text,
                IkinciIsim = tbxKuaforIkinciIsim.Text,
                SoyIsim = tbxKuaforSoyIsim.Text,
                TelNo = tbxKuaforTelNo.Text,
                Adres = tbxKuaforAdres.Text,
                IsletmeGiris = tbxIsletmeGiris.Text,
                IsletmeCikis = tbxIsletmeCikis.Text,
                Email = tbxKuaforEmail.Text,
                DogumTarihi = tbxKuaforDogumTarihi.Text,

            });

            LoadKuafor();
            MessageBox.Show("Kuafor Eklendi !");
            */
        }

        private void dgwKuafor_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tbxKuaforIsimUpdate.Text = dgwKuafor.CurrentRow.Cells[1].Value.ToString();
            tbxKuaforIkinciIsimUpdate.Text = dgwKuafor.CurrentRow.Cells[2].Value.ToString();
            tbxKuaforSoyIsimUpdate.Text = dgwKuafor.CurrentRow.Cells[3].Value.ToString();
            tbxKuaforTelNoUpdate.Text = dgwKuafor.CurrentRow.Cells[4].Value.ToString();
            tbxKuaforAdresUpdate.Text = dgwKuafor.CurrentRow.Cells[5].Value.ToString();
            tbxIsletmeGirisUpdate.Text = dgwKuafor.CurrentRow.Cells[6].Value.ToString();
            tbxIsletmeCikisUpdate.Text = dgwKuafor.CurrentRow.Cells[7].Value.ToString();
            tbxKuaforEmailUpdate.Text = dgwKuafor.CurrentRow.Cells[8].Value.ToString();
            tbxKuaforDogumTarihiUpdate.Text = dgwKuafor.CurrentRow.Cells[9].Value.ToString();




        }

        private void btnGuncelle2_Click(object sender, EventArgs e)
        {

            Kuafor kuafor = new Kuafor {

                KuaforID = dgwKuafor.CurrentRow.Cells[0].Value.ToString(),
                Isim = tbxKuaforIsimUpdate.Text,
                IkinciIsim = tbxKuaforIkinciIsimUpdate.Text,
                SoyIsim = tbxKuaforSoyIsimUpdate.Text,
                TelNo = tbxKuaforTelNoUpdate.Text,
                Adres = tbxKuaforAdresUpdate.Text,
                IsletmeGiris = tbxIsletmeGirisUpdate.Text,
                IsletmeCikis = tbxIsletmeCikisUpdate.Text,
                Email = tbxKuaforEmailUpdate.Text,
                DogumTarihi = tbxKuaforDogumTarihiUpdate.Text,

            };
            _kuaforDal.Guncelle(kuafor);
            //_musteriDal.SP_Update(kuafor);
            LoadKuafor();
            MessageBox.Show("Guncellendi!");

        }

        private void btnSil2_Click(object sender, EventArgs e)
        {

            String kuaforID = dgwKuafor.CurrentRow.Cells[0].Value.ToString();
            _kuaforDal.Sil(kuaforID);
            //_musteriDal.SP_Delete(kuaforID);
            LoadKuafor();
            MessageBox.Show("Silindi!");


        }



        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnEkle3_Click(object sender, EventArgs e)
        {

            _randevuDal.Ekle(new Randevu
            {

                RandevuID = tbxRandevuID.Text,
                RandevuTarihSaat = tbxRandevuTarihSaat.Text,
                ToplamFiyat = Convert.ToDecimal(tbxToplamFiyat.Text),
                HizmetSuresi = Convert.ToInt32(tbxHizmetSuresi.Text),
                MusteriID = tbxMusteriIDFK.Text,
                KuaforID = tbxKuaforIDFK.Text,


            }) ;

            LoadRandevu();
            MessageBox.Show("Randevu Eklendi !");

            /* _randevuDal.SP_Add(new Randevu
            {

                RandevuID = Convert.ToInt32(tbxRandevuID.Text),
                RandevuTarihSaat = tbxRandevuTarihSaat.Text,
                ToplamFiyat = Convert.ToDecimal(tbxToplamFiyat.Text),
                HizmetSuresi = Convert.ToInt32(tbxHizmetSuresi.Text),
                MusteriID = tbxMusteriIDFK.Text,
                KuaforID = tbxKuaforIDFK.Text,


            });

            LoadRandevu();
            MessageBox.Show("Randevu Eklendi !");
            */
        }

        private void dgwRandevu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tbxRandevuTarihSaatUpdate.Text = dgwRandevu.CurrentRow.Cells[1].Value.ToString();
            tbxToplamFiyatUpdate.Text = dgwRandevu.CurrentRow.Cells[2].Value.ToString();
            tbxHizmetSuresiUpdate.Text = dgwRandevu.CurrentRow.Cells[3].Value.ToString();




        }

        private void btnGuncelle3_Click(object sender, EventArgs e)
        {

           Randevu randevu = new Randevu
            {

                RandevuID = dgwRandevu.CurrentRow.Cells[0].Value.ToString(),
                RandevuTarihSaat = tbxRandevuTarihSaatUpdate.Text,
                ToplamFiyat = Convert.ToDecimal(tbxToplamFiyatUpdate.Text),
                HizmetSuresi = Convert.ToInt32(tbxHizmetSuresiUpdate.Text),
                MusteriID = dgwRandevu.CurrentRow.Cells[4].Value.ToString(),
                KuaforID = dgwRandevu.CurrentRow.Cells[5].Value.ToString(),

        };
            _randevuDal.Guncelle(randevu);
            //_musteriDal.SP_Update(randevu);
            LoadRandevu();
            MessageBox.Show("Guncellendi!");


        }

        private void btnSil3_Click(object sender, EventArgs e)
        {

            string randevuID = dgwRandevu.CurrentRow.Cells[0].Value.ToString();
            _randevuDal.Sil(randevuID);
            //_musteriDal.SP_Delete(randevuID);
            LoadRandevu();
            MessageBox.Show("Silindi!");

        }
    }
}

