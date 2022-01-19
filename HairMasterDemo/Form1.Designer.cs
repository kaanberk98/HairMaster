namespace HairMasterDemo
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwMusteri = new System.Windows.Forms.DataGridView();
            this.lblMusteriID = new System.Windows.Forms.Label();
            this.tbxMusteriID = new System.Windows.Forms.TextBox();
            this.lblIsim = new System.Windows.Forms.Label();
            this.tbxIsim = new System.Windows.Forms.TextBox();
            this.lblIkinciIsim = new System.Windows.Forms.Label();
            this.tbxIkinciIsim = new System.Windows.Forms.TextBox();
            this.lblSoyIsim = new System.Windows.Forms.Label();
            this.tbxSoyIsim = new System.Windows.Forms.TextBox();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.tbxTelNo = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.tbxAdres = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.gbxEkle = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.tbxDogumTarihi = new System.Windows.Forms.TextBox();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.gbxGuncelle = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.tbxDogumTarihiUpdate = new System.Windows.Forms.TextBox();
            this.lblDogumTarihiUpdate = new System.Windows.Forms.Label();
            this.tbxIkinciIsimUpdate = new System.Windows.Forms.TextBox();
            this.tbxEmailUpdate = new System.Windows.Forms.TextBox();
            this.lblEmailUpdate = new System.Windows.Forms.Label();
            this.tbxAdresUpdate = new System.Windows.Forms.TextBox();
            this.lblIsimUpdate = new System.Windows.Forms.Label();
            this.lblAdresUpdate = new System.Windows.Forms.Label();
            this.tbxIsimUpdate = new System.Windows.Forms.TextBox();
            this.tbxTelNoUpdate = new System.Windows.Forms.TextBox();
            this.lblIkinciIsimUpdate = new System.Windows.Forms.Label();
            this.lblTelNoUpdate = new System.Windows.Forms.Label();
            this.lblSoyIsimUpdate = new System.Windows.Forms.Label();
            this.tbxSoyIsimUpdate = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgwKuafor = new System.Windows.Forms.DataGridView();
            this.gbxEkle2 = new System.Windows.Forms.GroupBox();
            this.tbxKuaforDogumTarihi = new System.Windows.Forms.TextBox();
            this.lblKuaforDogumTarihi = new System.Windows.Forms.Label();
            this.tbxKuaforEmail = new System.Windows.Forms.TextBox();
            this.lblKuaforEmail = new System.Windows.Forms.Label();
            this.btnEkle2 = new System.Windows.Forms.Button();
            this.tbxIsletmeCikis = new System.Windows.Forms.TextBox();
            this.lblIsletmeCikis = new System.Windows.Forms.Label();
            this.tbxKuaforIkinciIsim = new System.Windows.Forms.TextBox();
            this.tbxIsletmeGiris = new System.Windows.Forms.TextBox();
            this.lblKuaforID = new System.Windows.Forms.Label();
            this.lblIsletmeGiris = new System.Windows.Forms.Label();
            this.tbxKuaforID = new System.Windows.Forms.TextBox();
            this.tbxKuaforAdres = new System.Windows.Forms.TextBox();
            this.lblKuaforIsim = new System.Windows.Forms.Label();
            this.lblKuaforAdres = new System.Windows.Forms.Label();
            this.tbxKuaforIsim = new System.Windows.Forms.TextBox();
            this.tbxKuaforTelNo = new System.Windows.Forms.TextBox();
            this.lblKuaforIkinciIsim = new System.Windows.Forms.Label();
            this.lblKuaforTelNo = new System.Windows.Forms.Label();
            this.lblKuaforSoyIsim = new System.Windows.Forms.Label();
            this.tbxKuaforSoyIsim = new System.Windows.Forms.TextBox();
            this.gbxGuncelle2 = new System.Windows.Forms.GroupBox();
            this.tbxKuaforDogumTarihiUpdate = new System.Windows.Forms.TextBox();
            this.lblKuaforDogumTarihiUpdate = new System.Windows.Forms.Label();
            this.tbxKuaforEmailUpdate = new System.Windows.Forms.TextBox();
            this.lblKuaforEmailUpdate = new System.Windows.Forms.Label();
            this.btnGuncelle2 = new System.Windows.Forms.Button();
            this.tbxIsletmeCikisUpdate = new System.Windows.Forms.TextBox();
            this.lblIsletmeCikisUpdate = new System.Windows.Forms.Label();
            this.tbxKuaforIkinciIsimUpdate = new System.Windows.Forms.TextBox();
            this.tbxIsletmeGirisUpdate = new System.Windows.Forms.TextBox();
            this.lblIsletmeGirisUpdate = new System.Windows.Forms.Label();
            this.tbxKuaforAdresUpdate = new System.Windows.Forms.TextBox();
            this.lblKuaforIsimUpdate = new System.Windows.Forms.Label();
            this.lblKuaforAdresUpdate = new System.Windows.Forms.Label();
            this.tbxKuaforIsimUpdate = new System.Windows.Forms.TextBox();
            this.tbxKuaforTelNoUpdate = new System.Windows.Forms.TextBox();
            this.lblKuaforIkinciIsimUpdate = new System.Windows.Forms.Label();
            this.lblKuaforTelNoUpdate = new System.Windows.Forms.Label();
            this.lblKuaforSoyIsimUpdate = new System.Windows.Forms.Label();
            this.tbxKuaforSoyIsimUpdate = new System.Windows.Forms.TextBox();
            this.btnSil2 = new System.Windows.Forms.Button();
            this.dgwRandevu = new System.Windows.Forms.DataGridView();
            this.lblRandevuID = new System.Windows.Forms.Label();
            this.tbxRandevuID = new System.Windows.Forms.TextBox();
            this.tbxRandevuTarihSaat = new System.Windows.Forms.TextBox();
            this.lblRandevuTarihSaat = new System.Windows.Forms.Label();
            this.tbxToplamFiyat = new System.Windows.Forms.TextBox();
            this.lblToplamFiyat = new System.Windows.Forms.Label();
            this.tbxHizmetSuresi = new System.Windows.Forms.TextBox();
            this.lblHizmetSuresi = new System.Windows.Forms.Label();
            this.tbxMusteriIDFK = new System.Windows.Forms.TextBox();
            this.lblMusteriIDFK = new System.Windows.Forms.Label();
            this.tbxKuaforIDFK = new System.Windows.Forms.TextBox();
            this.lblKuaforIDFK = new System.Windows.Forms.Label();
            this.gbxEkle3 = new System.Windows.Forms.GroupBox();
            this.btnEkle3 = new System.Windows.Forms.Button();
            this.gbxGuncelle3 = new System.Windows.Forms.GroupBox();
            this.btnGuncelle3 = new System.Windows.Forms.Button();
            this.lblRandevuTarihSaatUpdate = new System.Windows.Forms.Label();
            this.tbxRandevuTarihSaatUpdate = new System.Windows.Forms.TextBox();
            this.tbxToplamFiyatUpdate = new System.Windows.Forms.TextBox();
            this.lblToplamFiyatUpdate = new System.Windows.Forms.Label();
            this.lblHizmetSuresiUpdate = new System.Windows.Forms.Label();
            this.tbxHizmetSuresiUpdate = new System.Windows.Forms.TextBox();
            this.btnSil3 = new System.Windows.Forms.Button();
            this.dgwVW1 = new System.Windows.Forms.DataGridView();
            this.dgwVW2 = new System.Windows.Forms.DataGridView();
            this.VIEW1 = new System.Windows.Forms.Label();
            this.VIEW2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteri)).BeginInit();
            this.gbxEkle.SuspendLayout();
            this.gbxGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKuafor)).BeginInit();
            this.gbxEkle2.SuspendLayout();
            this.gbxGuncelle2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRandevu)).BeginInit();
            this.gbxEkle3.SuspendLayout();
            this.gbxGuncelle3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVW1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVW2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwMusteri
            // 
            this.dgwMusteri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMusteri.Location = new System.Drawing.Point(36, 34);
            this.dgwMusteri.Name = "dgwMusteri";
            this.dgwMusteri.Size = new System.Drawing.Size(727, 180);
            this.dgwMusteri.TabIndex = 0;
            this.dgwMusteri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMusteri_CellClick);
            // 
            // lblMusteriID
            // 
            this.lblMusteriID.AutoSize = true;
            this.lblMusteriID.Location = new System.Drawing.Point(13, 27);
            this.lblMusteriID.Name = "lblMusteriID";
            this.lblMusteriID.Size = new System.Drawing.Size(52, 13);
            this.lblMusteriID.TabIndex = 1;
            this.lblMusteriID.Text = "MusteriID";
            // 
            // tbxMusteriID
            // 
            this.tbxMusteriID.Location = new System.Drawing.Point(71, 27);
            this.tbxMusteriID.Name = "tbxMusteriID";
            this.tbxMusteriID.Size = new System.Drawing.Size(100, 20);
            this.tbxMusteriID.TabIndex = 2;
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(13, 61);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(25, 13);
            this.lblIsim.TabIndex = 3;
            this.lblIsim.Text = "Isim";
            // 
            // tbxIsim
            // 
            this.tbxIsim.Location = new System.Drawing.Point(71, 61);
            this.tbxIsim.Name = "tbxIsim";
            this.tbxIsim.Size = new System.Drawing.Size(100, 20);
            this.tbxIsim.TabIndex = 4;
            // 
            // lblIkinciIsim
            // 
            this.lblIkinciIsim.AutoSize = true;
            this.lblIkinciIsim.Location = new System.Drawing.Point(13, 93);
            this.lblIkinciIsim.Name = "lblIkinciIsim";
            this.lblIkinciIsim.Size = new System.Drawing.Size(50, 13);
            this.lblIkinciIsim.TabIndex = 5;
            this.lblIkinciIsim.Text = "IkinciIsim";
            // 
            // tbxIkinciIsim
            // 
            this.tbxIkinciIsim.Location = new System.Drawing.Point(71, 93);
            this.tbxIkinciIsim.Name = "tbxIkinciIsim";
            this.tbxIkinciIsim.Size = new System.Drawing.Size(100, 20);
            this.tbxIkinciIsim.TabIndex = 6;
            // 
            // lblSoyIsim
            // 
            this.lblSoyIsim.AutoSize = true;
            this.lblSoyIsim.Location = new System.Drawing.Point(13, 124);
            this.lblSoyIsim.Name = "lblSoyIsim";
            this.lblSoyIsim.Size = new System.Drawing.Size(43, 13);
            this.lblSoyIsim.TabIndex = 7;
            this.lblSoyIsim.Text = "SoyIsim";
            // 
            // tbxSoyIsim
            // 
            this.tbxSoyIsim.Location = new System.Drawing.Point(71, 121);
            this.tbxSoyIsim.Name = "tbxSoyIsim";
            this.tbxSoyIsim.Size = new System.Drawing.Size(100, 20);
            this.tbxSoyIsim.TabIndex = 8;
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Location = new System.Drawing.Point(13, 150);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(36, 13);
            this.lblTelNo.TabIndex = 9;
            this.lblTelNo.Text = "TelNo";
            // 
            // tbxTelNo
            // 
            this.tbxTelNo.Location = new System.Drawing.Point(71, 147);
            this.tbxTelNo.Name = "tbxTelNo";
            this.tbxTelNo.Size = new System.Drawing.Size(100, 20);
            this.tbxTelNo.TabIndex = 10;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(180, 27);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(34, 13);
            this.lblAdres.TabIndex = 11;
            this.lblAdres.Text = "Adres";
            // 
            // tbxAdres
            // 
            this.tbxAdres.Location = new System.Drawing.Point(221, 27);
            this.tbxAdres.Name = "tbxAdres";
            this.tbxAdres.Size = new System.Drawing.Size(100, 20);
            this.tbxAdres.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(180, 61);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(221, 61);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(100, 20);
            this.tbxEmail.TabIndex = 14;
            // 
            // gbxEkle
            // 
            this.gbxEkle.Controls.Add(this.btnEkle);
            this.gbxEkle.Controls.Add(this.tbxDogumTarihi);
            this.gbxEkle.Controls.Add(this.lblDogumTarihi);
            this.gbxEkle.Controls.Add(this.tbxIkinciIsim);
            this.gbxEkle.Controls.Add(this.tbxEmail);
            this.gbxEkle.Controls.Add(this.lblMusteriID);
            this.gbxEkle.Controls.Add(this.lblEmail);
            this.gbxEkle.Controls.Add(this.tbxMusteriID);
            this.gbxEkle.Controls.Add(this.tbxAdres);
            this.gbxEkle.Controls.Add(this.lblIsim);
            this.gbxEkle.Controls.Add(this.lblAdres);
            this.gbxEkle.Controls.Add(this.tbxIsim);
            this.gbxEkle.Controls.Add(this.tbxTelNo);
            this.gbxEkle.Controls.Add(this.lblIkinciIsim);
            this.gbxEkle.Controls.Add(this.lblTelNo);
            this.gbxEkle.Controls.Add(this.lblSoyIsim);
            this.gbxEkle.Controls.Add(this.tbxSoyIsim);
            this.gbxEkle.Location = new System.Drawing.Point(793, 34);
            this.gbxEkle.Name = "gbxEkle";
            this.gbxEkle.Size = new System.Drawing.Size(338, 180);
            this.gbxEkle.TabIndex = 15;
            this.gbxEkle.TabStop = false;
            this.gbxEkle.Text = "Musteri Ekle";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(221, 150);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 17;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // tbxDogumTarihi
            // 
            this.tbxDogumTarihi.Location = new System.Drawing.Point(221, 93);
            this.tbxDogumTarihi.Name = "tbxDogumTarihi";
            this.tbxDogumTarihi.Size = new System.Drawing.Size(100, 20);
            this.tbxDogumTarihi.TabIndex = 16;
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(183, 93);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(41, 13);
            this.lblDogumTarihi.TabIndex = 15;
            this.lblDogumTarihi.Text = "Dogum";
            // 
            // gbxGuncelle
            // 
            this.gbxGuncelle.Controls.Add(this.btnGuncelle);
            this.gbxGuncelle.Controls.Add(this.tbxDogumTarihiUpdate);
            this.gbxGuncelle.Controls.Add(this.lblDogumTarihiUpdate);
            this.gbxGuncelle.Controls.Add(this.tbxIkinciIsimUpdate);
            this.gbxGuncelle.Controls.Add(this.tbxEmailUpdate);
            this.gbxGuncelle.Controls.Add(this.lblEmailUpdate);
            this.gbxGuncelle.Controls.Add(this.tbxAdresUpdate);
            this.gbxGuncelle.Controls.Add(this.lblIsimUpdate);
            this.gbxGuncelle.Controls.Add(this.lblAdresUpdate);
            this.gbxGuncelle.Controls.Add(this.tbxIsimUpdate);
            this.gbxGuncelle.Controls.Add(this.tbxTelNoUpdate);
            this.gbxGuncelle.Controls.Add(this.lblIkinciIsimUpdate);
            this.gbxGuncelle.Controls.Add(this.lblTelNoUpdate);
            this.gbxGuncelle.Controls.Add(this.lblSoyIsimUpdate);
            this.gbxGuncelle.Controls.Add(this.tbxSoyIsimUpdate);
            this.gbxGuncelle.Location = new System.Drawing.Point(1154, 34);
            this.gbxGuncelle.Name = "gbxGuncelle";
            this.gbxGuncelle.Size = new System.Drawing.Size(338, 180);
            this.gbxGuncelle.TabIndex = 16;
            this.gbxGuncelle.TabStop = false;
            this.gbxGuncelle.Text = "MusteriGuncelle";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(221, 150);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 17;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // tbxDogumTarihiUpdate
            // 
            this.tbxDogumTarihiUpdate.Location = new System.Drawing.Point(221, 93);
            this.tbxDogumTarihiUpdate.Name = "tbxDogumTarihiUpdate";
            this.tbxDogumTarihiUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxDogumTarihiUpdate.TabIndex = 16;
            // 
            // lblDogumTarihiUpdate
            // 
            this.lblDogumTarihiUpdate.AutoSize = true;
            this.lblDogumTarihiUpdate.Location = new System.Drawing.Point(183, 93);
            this.lblDogumTarihiUpdate.Name = "lblDogumTarihiUpdate";
            this.lblDogumTarihiUpdate.Size = new System.Drawing.Size(41, 13);
            this.lblDogumTarihiUpdate.TabIndex = 15;
            this.lblDogumTarihiUpdate.Text = "Dogum";
            // 
            // tbxIkinciIsimUpdate
            // 
            this.tbxIkinciIsimUpdate.Location = new System.Drawing.Point(74, 61);
            this.tbxIkinciIsimUpdate.Name = "tbxIkinciIsimUpdate";
            this.tbxIkinciIsimUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxIkinciIsimUpdate.TabIndex = 6;
            // 
            // tbxEmailUpdate
            // 
            this.tbxEmailUpdate.Location = new System.Drawing.Point(221, 61);
            this.tbxEmailUpdate.Name = "tbxEmailUpdate";
            this.tbxEmailUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxEmailUpdate.TabIndex = 14;
            // 
            // lblEmailUpdate
            // 
            this.lblEmailUpdate.AutoSize = true;
            this.lblEmailUpdate.Location = new System.Drawing.Point(180, 61);
            this.lblEmailUpdate.Name = "lblEmailUpdate";
            this.lblEmailUpdate.Size = new System.Drawing.Size(32, 13);
            this.lblEmailUpdate.TabIndex = 13;
            this.lblEmailUpdate.Text = "Email";
            // 
            // tbxAdresUpdate
            // 
            this.tbxAdresUpdate.Location = new System.Drawing.Point(221, 27);
            this.tbxAdresUpdate.Name = "tbxAdresUpdate";
            this.tbxAdresUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxAdresUpdate.TabIndex = 12;
            // 
            // lblIsimUpdate
            // 
            this.lblIsimUpdate.AutoSize = true;
            this.lblIsimUpdate.Location = new System.Drawing.Point(16, 29);
            this.lblIsimUpdate.Name = "lblIsimUpdate";
            this.lblIsimUpdate.Size = new System.Drawing.Size(25, 13);
            this.lblIsimUpdate.TabIndex = 3;
            this.lblIsimUpdate.Text = "Isim";
            // 
            // lblAdresUpdate
            // 
            this.lblAdresUpdate.AutoSize = true;
            this.lblAdresUpdate.Location = new System.Drawing.Point(180, 27);
            this.lblAdresUpdate.Name = "lblAdresUpdate";
            this.lblAdresUpdate.Size = new System.Drawing.Size(34, 13);
            this.lblAdresUpdate.TabIndex = 11;
            this.lblAdresUpdate.Text = "Adres";
            // 
            // tbxIsimUpdate
            // 
            this.tbxIsimUpdate.Location = new System.Drawing.Point(74, 29);
            this.tbxIsimUpdate.Name = "tbxIsimUpdate";
            this.tbxIsimUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxIsimUpdate.TabIndex = 4;
            // 
            // tbxTelNoUpdate
            // 
            this.tbxTelNoUpdate.Location = new System.Drawing.Point(74, 115);
            this.tbxTelNoUpdate.Name = "tbxTelNoUpdate";
            this.tbxTelNoUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxTelNoUpdate.TabIndex = 10;
            // 
            // lblIkinciIsimUpdate
            // 
            this.lblIkinciIsimUpdate.AutoSize = true;
            this.lblIkinciIsimUpdate.Location = new System.Drawing.Point(16, 61);
            this.lblIkinciIsimUpdate.Name = "lblIkinciIsimUpdate";
            this.lblIkinciIsimUpdate.Size = new System.Drawing.Size(50, 13);
            this.lblIkinciIsimUpdate.TabIndex = 5;
            this.lblIkinciIsimUpdate.Text = "IkinciIsim";
            // 
            // lblTelNoUpdate
            // 
            this.lblTelNoUpdate.AutoSize = true;
            this.lblTelNoUpdate.Location = new System.Drawing.Point(16, 118);
            this.lblTelNoUpdate.Name = "lblTelNoUpdate";
            this.lblTelNoUpdate.Size = new System.Drawing.Size(36, 13);
            this.lblTelNoUpdate.TabIndex = 9;
            this.lblTelNoUpdate.Text = "TelNo";
            // 
            // lblSoyIsimUpdate
            // 
            this.lblSoyIsimUpdate.AutoSize = true;
            this.lblSoyIsimUpdate.Location = new System.Drawing.Point(16, 92);
            this.lblSoyIsimUpdate.Name = "lblSoyIsimUpdate";
            this.lblSoyIsimUpdate.Size = new System.Drawing.Size(43, 13);
            this.lblSoyIsimUpdate.TabIndex = 7;
            this.lblSoyIsimUpdate.Text = "SoyIsim";
            // 
            // tbxSoyIsimUpdate
            // 
            this.tbxSoyIsimUpdate.Location = new System.Drawing.Point(74, 89);
            this.tbxSoyIsimUpdate.Name = "tbxSoyIsimUpdate";
            this.tbxSoyIsimUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxSoyIsimUpdate.TabIndex = 8;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(1515, 183);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgwKuafor
            // 
            this.dgwKuafor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwKuafor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKuafor.Location = new System.Drawing.Point(36, 255);
            this.dgwKuafor.Name = "dgwKuafor";
            this.dgwKuafor.Size = new System.Drawing.Size(727, 180);
            this.dgwKuafor.TabIndex = 18;
            this.dgwKuafor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKuafor_CellClick);
            // 
            // gbxEkle2
            // 
            this.gbxEkle2.Controls.Add(this.tbxKuaforDogumTarihi);
            this.gbxEkle2.Controls.Add(this.lblKuaforDogumTarihi);
            this.gbxEkle2.Controls.Add(this.tbxKuaforEmail);
            this.gbxEkle2.Controls.Add(this.lblKuaforEmail);
            this.gbxEkle2.Controls.Add(this.btnEkle2);
            this.gbxEkle2.Controls.Add(this.tbxIsletmeCikis);
            this.gbxEkle2.Controls.Add(this.lblIsletmeCikis);
            this.gbxEkle2.Controls.Add(this.tbxKuaforIkinciIsim);
            this.gbxEkle2.Controls.Add(this.tbxIsletmeGiris);
            this.gbxEkle2.Controls.Add(this.lblKuaforID);
            this.gbxEkle2.Controls.Add(this.lblIsletmeGiris);
            this.gbxEkle2.Controls.Add(this.tbxKuaforID);
            this.gbxEkle2.Controls.Add(this.tbxKuaforAdres);
            this.gbxEkle2.Controls.Add(this.lblKuaforIsim);
            this.gbxEkle2.Controls.Add(this.lblKuaforAdres);
            this.gbxEkle2.Controls.Add(this.tbxKuaforIsim);
            this.gbxEkle2.Controls.Add(this.tbxKuaforTelNo);
            this.gbxEkle2.Controls.Add(this.lblKuaforIkinciIsim);
            this.gbxEkle2.Controls.Add(this.lblKuaforTelNo);
            this.gbxEkle2.Controls.Add(this.lblKuaforSoyIsim);
            this.gbxEkle2.Controls.Add(this.tbxKuaforSoyIsim);
            this.gbxEkle2.Location = new System.Drawing.Point(794, 255);
            this.gbxEkle2.Name = "gbxEkle2";
            this.gbxEkle2.Size = new System.Drawing.Size(338, 219);
            this.gbxEkle2.TabIndex = 19;
            this.gbxEkle2.TabStop = false;
            this.gbxEkle2.Text = "Kuafor Ekle";
            // 
            // tbxKuaforDogumTarihi
            // 
            this.tbxKuaforDogumTarihi.Location = new System.Drawing.Point(220, 160);
            this.tbxKuaforDogumTarihi.Name = "tbxKuaforDogumTarihi";
            this.tbxKuaforDogumTarihi.Size = new System.Drawing.Size(100, 20);
            this.tbxKuaforDogumTarihi.TabIndex = 21;
            // 
            // lblKuaforDogumTarihi
            // 
            this.lblKuaforDogumTarihi.AutoSize = true;
            this.lblKuaforDogumTarihi.Location = new System.Drawing.Point(182, 160);
            this.lblKuaforDogumTarihi.Name = "lblKuaforDogumTarihi";
            this.lblKuaforDogumTarihi.Size = new System.Drawing.Size(41, 13);
            this.lblKuaforDogumTarihi.TabIndex = 20;
            this.lblKuaforDogumTarihi.Text = "Dogum";
            // 
            // tbxKuaforEmail
            // 
            this.tbxKuaforEmail.Location = new System.Drawing.Point(220, 124);
            this.tbxKuaforEmail.Name = "tbxKuaforEmail";
            this.tbxKuaforEmail.Size = new System.Drawing.Size(100, 20);
            this.tbxKuaforEmail.TabIndex = 19;
            // 
            // lblKuaforEmail
            // 
            this.lblKuaforEmail.AutoSize = true;
            this.lblKuaforEmail.Location = new System.Drawing.Point(182, 124);
            this.lblKuaforEmail.Name = "lblKuaforEmail";
            this.lblKuaforEmail.Size = new System.Drawing.Size(32, 13);
            this.lblKuaforEmail.TabIndex = 18;
            this.lblKuaforEmail.Text = "Email";
            // 
            // btnEkle2
            // 
            this.btnEkle2.Location = new System.Drawing.Point(221, 190);
            this.btnEkle2.Name = "btnEkle2";
            this.btnEkle2.Size = new System.Drawing.Size(75, 23);
            this.btnEkle2.TabIndex = 17;
            this.btnEkle2.Text = "Ekle";
            this.btnEkle2.UseVisualStyleBackColor = true;
            this.btnEkle2.Click += new System.EventHandler(this.btnEkle2_Click);
            // 
            // tbxIsletmeCikis
            // 
            this.tbxIsletmeCikis.Location = new System.Drawing.Point(221, 93);
            this.tbxIsletmeCikis.Name = "tbxIsletmeCikis";
            this.tbxIsletmeCikis.Size = new System.Drawing.Size(100, 20);
            this.tbxIsletmeCikis.TabIndex = 16;
            // 
            // lblIsletmeCikis
            // 
            this.lblIsletmeCikis.AutoSize = true;
            this.lblIsletmeCikis.Location = new System.Drawing.Point(183, 93);
            this.lblIsletmeCikis.Name = "lblIsletmeCikis";
            this.lblIsletmeCikis.Size = new System.Drawing.Size(29, 13);
            this.lblIsletmeCikis.TabIndex = 15;
            this.lblIsletmeCikis.Text = "Cikis";
            // 
            // tbxKuaforIkinciIsim
            // 
            this.tbxKuaforIkinciIsim.Location = new System.Drawing.Point(71, 93);
            this.tbxKuaforIkinciIsim.Name = "tbxKuaforIkinciIsim";
            this.tbxKuaforIkinciIsim.Size = new System.Drawing.Size(100, 20);
            this.tbxKuaforIkinciIsim.TabIndex = 6;
            // 
            // tbxIsletmeGiris
            // 
            this.tbxIsletmeGiris.Location = new System.Drawing.Point(221, 61);
            this.tbxIsletmeGiris.Name = "tbxIsletmeGiris";
            this.tbxIsletmeGiris.Size = new System.Drawing.Size(100, 20);
            this.tbxIsletmeGiris.TabIndex = 14;
            // 
            // lblKuaforID
            // 
            this.lblKuaforID.AutoSize = true;
            this.lblKuaforID.Location = new System.Drawing.Point(13, 27);
            this.lblKuaforID.Name = "lblKuaforID";
            this.lblKuaforID.Size = new System.Drawing.Size(49, 13);
            this.lblKuaforID.TabIndex = 1;
            this.lblKuaforID.Text = "KuaforID";
            // 
            // lblIsletmeGiris
            // 
            this.lblIsletmeGiris.AutoSize = true;
            this.lblIsletmeGiris.Location = new System.Drawing.Point(180, 61);
            this.lblIsletmeGiris.Name = "lblIsletmeGiris";
            this.lblIsletmeGiris.Size = new System.Drawing.Size(27, 13);
            this.lblIsletmeGiris.TabIndex = 13;
            this.lblIsletmeGiris.Text = "Giris";
            // 
            // tbxKuaforID
            // 
            this.tbxKuaforID.Location = new System.Drawing.Point(71, 27);
            this.tbxKuaforID.Name = "tbxKuaforID";
            this.tbxKuaforID.Size = new System.Drawing.Size(100, 20);
            this.tbxKuaforID.TabIndex = 2;
            // 
            // tbxKuaforAdres
            // 
            this.tbxKuaforAdres.Location = new System.Drawing.Point(221, 27);
            this.tbxKuaforAdres.Name = "tbxKuaforAdres";
            this.tbxKuaforAdres.Size = new System.Drawing.Size(100, 20);
            this.tbxKuaforAdres.TabIndex = 12;
            // 
            // lblKuaforIsim
            // 
            this.lblKuaforIsim.AutoSize = true;
            this.lblKuaforIsim.Location = new System.Drawing.Point(13, 61);
            this.lblKuaforIsim.Name = "lblKuaforIsim";
            this.lblKuaforIsim.Size = new System.Drawing.Size(25, 13);
            this.lblKuaforIsim.TabIndex = 3;
            this.lblKuaforIsim.Text = "Isim";
            // 
            // lblKuaforAdres
            // 
            this.lblKuaforAdres.AutoSize = true;
            this.lblKuaforAdres.Location = new System.Drawing.Point(180, 27);
            this.lblKuaforAdres.Name = "lblKuaforAdres";
            this.lblKuaforAdres.Size = new System.Drawing.Size(34, 13);
            this.lblKuaforAdres.TabIndex = 11;
            this.lblKuaforAdres.Text = "Adres";
            // 
            // tbxKuaforIsim
            // 
            this.tbxKuaforIsim.Location = new System.Drawing.Point(71, 61);
            this.tbxKuaforIsim.Name = "tbxKuaforIsim";
            this.tbxKuaforIsim.Size = new System.Drawing.Size(100, 20);
            this.tbxKuaforIsim.TabIndex = 4;
            // 
            // tbxKuaforTelNo
            // 
            this.tbxKuaforTelNo.Location = new System.Drawing.Point(71, 147);
            this.tbxKuaforTelNo.Name = "tbxKuaforTelNo";
            this.tbxKuaforTelNo.Size = new System.Drawing.Size(100, 20);
            this.tbxKuaforTelNo.TabIndex = 10;
            // 
            // lblKuaforIkinciIsim
            // 
            this.lblKuaforIkinciIsim.AutoSize = true;
            this.lblKuaforIkinciIsim.Location = new System.Drawing.Point(13, 93);
            this.lblKuaforIkinciIsim.Name = "lblKuaforIkinciIsim";
            this.lblKuaforIkinciIsim.Size = new System.Drawing.Size(50, 13);
            this.lblKuaforIkinciIsim.TabIndex = 5;
            this.lblKuaforIkinciIsim.Text = "IkinciIsim";
            // 
            // lblKuaforTelNo
            // 
            this.lblKuaforTelNo.AutoSize = true;
            this.lblKuaforTelNo.Location = new System.Drawing.Point(13, 150);
            this.lblKuaforTelNo.Name = "lblKuaforTelNo";
            this.lblKuaforTelNo.Size = new System.Drawing.Size(36, 13);
            this.lblKuaforTelNo.TabIndex = 9;
            this.lblKuaforTelNo.Text = "TelNo";
            // 
            // lblKuaforSoyIsim
            // 
            this.lblKuaforSoyIsim.AutoSize = true;
            this.lblKuaforSoyIsim.Location = new System.Drawing.Point(13, 124);
            this.lblKuaforSoyIsim.Name = "lblKuaforSoyIsim";
            this.lblKuaforSoyIsim.Size = new System.Drawing.Size(43, 13);
            this.lblKuaforSoyIsim.TabIndex = 7;
            this.lblKuaforSoyIsim.Text = "SoyIsim";
            // 
            // tbxKuaforSoyIsim
            // 
            this.tbxKuaforSoyIsim.Location = new System.Drawing.Point(71, 121);
            this.tbxKuaforSoyIsim.Name = "tbxKuaforSoyIsim";
            this.tbxKuaforSoyIsim.Size = new System.Drawing.Size(100, 20);
            this.tbxKuaforSoyIsim.TabIndex = 8;
            // 
            // gbxGuncelle2
            // 
            this.gbxGuncelle2.Controls.Add(this.tbxKuaforDogumTarihiUpdate);
            this.gbxGuncelle2.Controls.Add(this.lblKuaforDogumTarihiUpdate);
            this.gbxGuncelle2.Controls.Add(this.tbxKuaforEmailUpdate);
            this.gbxGuncelle2.Controls.Add(this.lblKuaforEmailUpdate);
            this.gbxGuncelle2.Controls.Add(this.btnGuncelle2);
            this.gbxGuncelle2.Controls.Add(this.tbxIsletmeCikisUpdate);
            this.gbxGuncelle2.Controls.Add(this.lblIsletmeCikisUpdate);
            this.gbxGuncelle2.Controls.Add(this.tbxKuaforIkinciIsimUpdate);
            this.gbxGuncelle2.Controls.Add(this.tbxIsletmeGirisUpdate);
            this.gbxGuncelle2.Controls.Add(this.lblIsletmeGirisUpdate);
            this.gbxGuncelle2.Controls.Add(this.tbxKuaforAdresUpdate);
            this.gbxGuncelle2.Controls.Add(this.lblKuaforIsimUpdate);
            this.gbxGuncelle2.Controls.Add(this.lblKuaforAdresUpdate);
            this.gbxGuncelle2.Controls.Add(this.tbxKuaforIsimUpdate);
            this.gbxGuncelle2.Controls.Add(this.tbxKuaforTelNoUpdate);
            this.gbxGuncelle2.Controls.Add(this.lblKuaforIkinciIsimUpdate);
            this.gbxGuncelle2.Controls.Add(this.lblKuaforTelNoUpdate);
            this.gbxGuncelle2.Controls.Add(this.lblKuaforSoyIsimUpdate);
            this.gbxGuncelle2.Controls.Add(this.tbxKuaforSoyIsimUpdate);
            this.gbxGuncelle2.Location = new System.Drawing.Point(1154, 255);
            this.gbxGuncelle2.Name = "gbxGuncelle2";
            this.gbxGuncelle2.Size = new System.Drawing.Size(338, 219);
            this.gbxGuncelle2.TabIndex = 20;
            this.gbxGuncelle2.TabStop = false;
            this.gbxGuncelle2.Text = "KuaforGuncelle";
            // 
            // tbxKuaforDogumTarihiUpdate
            // 
            this.tbxKuaforDogumTarihiUpdate.Location = new System.Drawing.Point(220, 160);
            this.tbxKuaforDogumTarihiUpdate.Name = "tbxKuaforDogumTarihiUpdate";
            this.tbxKuaforDogumTarihiUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxKuaforDogumTarihiUpdate.TabIndex = 21;
            // 
            // lblKuaforDogumTarihiUpdate
            // 
            this.lblKuaforDogumTarihiUpdate.AutoSize = true;
            this.lblKuaforDogumTarihiUpdate.Location = new System.Drawing.Point(182, 160);
            this.lblKuaforDogumTarihiUpdate.Name = "lblKuaforDogumTarihiUpdate";
            this.lblKuaforDogumTarihiUpdate.Size = new System.Drawing.Size(41, 13);
            this.lblKuaforDogumTarihiUpdate.TabIndex = 20;
            this.lblKuaforDogumTarihiUpdate.Text = "Dogum";
            // 
            // tbxKuaforEmailUpdate
            // 
            this.tbxKuaforEmailUpdate.Location = new System.Drawing.Point(220, 124);
            this.tbxKuaforEmailUpdate.Name = "tbxKuaforEmailUpdate";
            this.tbxKuaforEmailUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxKuaforEmailUpdate.TabIndex = 19;
            // 
            // lblKuaforEmailUpdate
            // 
            this.lblKuaforEmailUpdate.AutoSize = true;
            this.lblKuaforEmailUpdate.Location = new System.Drawing.Point(182, 124);
            this.lblKuaforEmailUpdate.Name = "lblKuaforEmailUpdate";
            this.lblKuaforEmailUpdate.Size = new System.Drawing.Size(32, 13);
            this.lblKuaforEmailUpdate.TabIndex = 18;
            this.lblKuaforEmailUpdate.Text = "Email";
            // 
            // btnGuncelle2
            // 
            this.btnGuncelle2.Location = new System.Drawing.Point(221, 190);
            this.btnGuncelle2.Name = "btnGuncelle2";
            this.btnGuncelle2.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle2.TabIndex = 17;
            this.btnGuncelle2.Text = "Guncelle";
            this.btnGuncelle2.UseVisualStyleBackColor = true;
            this.btnGuncelle2.Click += new System.EventHandler(this.btnGuncelle2_Click);
            // 
            // tbxIsletmeCikisUpdate
            // 
            this.tbxIsletmeCikisUpdate.Location = new System.Drawing.Point(221, 93);
            this.tbxIsletmeCikisUpdate.Name = "tbxIsletmeCikisUpdate";
            this.tbxIsletmeCikisUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxIsletmeCikisUpdate.TabIndex = 16;
            // 
            // lblIsletmeCikisUpdate
            // 
            this.lblIsletmeCikisUpdate.AutoSize = true;
            this.lblIsletmeCikisUpdate.Location = new System.Drawing.Point(183, 93);
            this.lblIsletmeCikisUpdate.Name = "lblIsletmeCikisUpdate";
            this.lblIsletmeCikisUpdate.Size = new System.Drawing.Size(29, 13);
            this.lblIsletmeCikisUpdate.TabIndex = 15;
            this.lblIsletmeCikisUpdate.Text = "Cikis";
            // 
            // tbxKuaforIkinciIsimUpdate
            // 
            this.tbxKuaforIkinciIsimUpdate.Location = new System.Drawing.Point(74, 59);
            this.tbxKuaforIkinciIsimUpdate.Name = "tbxKuaforIkinciIsimUpdate";
            this.tbxKuaforIkinciIsimUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxKuaforIkinciIsimUpdate.TabIndex = 6;
            // 
            // tbxIsletmeGirisUpdate
            // 
            this.tbxIsletmeGirisUpdate.Location = new System.Drawing.Point(221, 61);
            this.tbxIsletmeGirisUpdate.Name = "tbxIsletmeGirisUpdate";
            this.tbxIsletmeGirisUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxIsletmeGirisUpdate.TabIndex = 14;
            // 
            // lblIsletmeGirisUpdate
            // 
            this.lblIsletmeGirisUpdate.AutoSize = true;
            this.lblIsletmeGirisUpdate.Location = new System.Drawing.Point(180, 61);
            this.lblIsletmeGirisUpdate.Name = "lblIsletmeGirisUpdate";
            this.lblIsletmeGirisUpdate.Size = new System.Drawing.Size(27, 13);
            this.lblIsletmeGirisUpdate.TabIndex = 13;
            this.lblIsletmeGirisUpdate.Text = "Giris";
            // 
            // tbxKuaforAdresUpdate
            // 
            this.tbxKuaforAdresUpdate.Location = new System.Drawing.Point(221, 27);
            this.tbxKuaforAdresUpdate.Name = "tbxKuaforAdresUpdate";
            this.tbxKuaforAdresUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxKuaforAdresUpdate.TabIndex = 12;
            // 
            // lblKuaforIsimUpdate
            // 
            this.lblKuaforIsimUpdate.AutoSize = true;
            this.lblKuaforIsimUpdate.Location = new System.Drawing.Point(16, 27);
            this.lblKuaforIsimUpdate.Name = "lblKuaforIsimUpdate";
            this.lblKuaforIsimUpdate.Size = new System.Drawing.Size(25, 13);
            this.lblKuaforIsimUpdate.TabIndex = 3;
            this.lblKuaforIsimUpdate.Text = "Isim";
            // 
            // lblKuaforAdresUpdate
            // 
            this.lblKuaforAdresUpdate.AutoSize = true;
            this.lblKuaforAdresUpdate.Location = new System.Drawing.Point(180, 27);
            this.lblKuaforAdresUpdate.Name = "lblKuaforAdresUpdate";
            this.lblKuaforAdresUpdate.Size = new System.Drawing.Size(34, 13);
            this.lblKuaforAdresUpdate.TabIndex = 11;
            this.lblKuaforAdresUpdate.Text = "Adres";
            // 
            // tbxKuaforIsimUpdate
            // 
            this.tbxKuaforIsimUpdate.Location = new System.Drawing.Point(74, 27);
            this.tbxKuaforIsimUpdate.Name = "tbxKuaforIsimUpdate";
            this.tbxKuaforIsimUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxKuaforIsimUpdate.TabIndex = 4;
            // 
            // tbxKuaforTelNoUpdate
            // 
            this.tbxKuaforTelNoUpdate.Location = new System.Drawing.Point(74, 113);
            this.tbxKuaforTelNoUpdate.Name = "tbxKuaforTelNoUpdate";
            this.tbxKuaforTelNoUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxKuaforTelNoUpdate.TabIndex = 10;
            // 
            // lblKuaforIkinciIsimUpdate
            // 
            this.lblKuaforIkinciIsimUpdate.AutoSize = true;
            this.lblKuaforIkinciIsimUpdate.Location = new System.Drawing.Point(16, 59);
            this.lblKuaforIkinciIsimUpdate.Name = "lblKuaforIkinciIsimUpdate";
            this.lblKuaforIkinciIsimUpdate.Size = new System.Drawing.Size(50, 13);
            this.lblKuaforIkinciIsimUpdate.TabIndex = 5;
            this.lblKuaforIkinciIsimUpdate.Text = "IkinciIsim";
            // 
            // lblKuaforTelNoUpdate
            // 
            this.lblKuaforTelNoUpdate.AutoSize = true;
            this.lblKuaforTelNoUpdate.Location = new System.Drawing.Point(16, 116);
            this.lblKuaforTelNoUpdate.Name = "lblKuaforTelNoUpdate";
            this.lblKuaforTelNoUpdate.Size = new System.Drawing.Size(36, 13);
            this.lblKuaforTelNoUpdate.TabIndex = 9;
            this.lblKuaforTelNoUpdate.Text = "TelNo";
            // 
            // lblKuaforSoyIsimUpdate
            // 
            this.lblKuaforSoyIsimUpdate.AutoSize = true;
            this.lblKuaforSoyIsimUpdate.Location = new System.Drawing.Point(16, 90);
            this.lblKuaforSoyIsimUpdate.Name = "lblKuaforSoyIsimUpdate";
            this.lblKuaforSoyIsimUpdate.Size = new System.Drawing.Size(43, 13);
            this.lblKuaforSoyIsimUpdate.TabIndex = 7;
            this.lblKuaforSoyIsimUpdate.Text = "SoyIsim";
            // 
            // tbxKuaforSoyIsimUpdate
            // 
            this.tbxKuaforSoyIsimUpdate.Location = new System.Drawing.Point(74, 87);
            this.tbxKuaforSoyIsimUpdate.Name = "tbxKuaforSoyIsimUpdate";
            this.tbxKuaforSoyIsimUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxKuaforSoyIsimUpdate.TabIndex = 8;
            // 
            // btnSil2
            // 
            this.btnSil2.Location = new System.Drawing.Point(1515, 444);
            this.btnSil2.Name = "btnSil2";
            this.btnSil2.Size = new System.Drawing.Size(75, 23);
            this.btnSil2.TabIndex = 21;
            this.btnSil2.Text = "Sil";
            this.btnSil2.UseVisualStyleBackColor = true;
            this.btnSil2.Click += new System.EventHandler(this.btnSil2_Click);
            // 
            // dgwRandevu
            // 
            this.dgwRandevu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwRandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRandevu.Location = new System.Drawing.Point(36, 497);
            this.dgwRandevu.Name = "dgwRandevu";
            this.dgwRandevu.Size = new System.Drawing.Size(727, 170);
            this.dgwRandevu.TabIndex = 22;
            this.dgwRandevu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwRandevu_CellClick);
            // 
            // lblRandevuID
            // 
            this.lblRandevuID.AutoSize = true;
            this.lblRandevuID.Location = new System.Drawing.Point(6, 25);
            this.lblRandevuID.Name = "lblRandevuID";
            this.lblRandevuID.Size = new System.Drawing.Size(62, 13);
            this.lblRandevuID.TabIndex = 23;
            this.lblRandevuID.Text = "RandevuID";
            // 
            // tbxRandevuID
            // 
            this.tbxRandevuID.Location = new System.Drawing.Point(71, 25);
            this.tbxRandevuID.Name = "tbxRandevuID";
            this.tbxRandevuID.Size = new System.Drawing.Size(100, 20);
            this.tbxRandevuID.TabIndex = 24;
            // 
            // tbxRandevuTarihSaat
            // 
            this.tbxRandevuTarihSaat.Location = new System.Drawing.Point(71, 61);
            this.tbxRandevuTarihSaat.Name = "tbxRandevuTarihSaat";
            this.tbxRandevuTarihSaat.Size = new System.Drawing.Size(100, 20);
            this.tbxRandevuTarihSaat.TabIndex = 26;
            // 
            // lblRandevuTarihSaat
            // 
            this.lblRandevuTarihSaat.AutoSize = true;
            this.lblRandevuTarihSaat.Location = new System.Drawing.Point(6, 61);
            this.lblRandevuTarihSaat.Name = "lblRandevuTarihSaat";
            this.lblRandevuTarihSaat.Size = new System.Drawing.Size(65, 13);
            this.lblRandevuTarihSaat.TabIndex = 25;
            this.lblRandevuTarihSaat.Text = "RandevuTS";
            // 
            // tbxToplamFiyat
            // 
            this.tbxToplamFiyat.Location = new System.Drawing.Point(71, 105);
            this.tbxToplamFiyat.Name = "tbxToplamFiyat";
            this.tbxToplamFiyat.Size = new System.Drawing.Size(100, 20);
            this.tbxToplamFiyat.TabIndex = 28;
            // 
            // lblToplamFiyat
            // 
            this.lblToplamFiyat.AutoSize = true;
            this.lblToplamFiyat.Location = new System.Drawing.Point(6, 105);
            this.lblToplamFiyat.Name = "lblToplamFiyat";
            this.lblToplamFiyat.Size = new System.Drawing.Size(64, 13);
            this.lblToplamFiyat.TabIndex = 27;
            this.lblToplamFiyat.Text = "ToplamFiyat";
            // 
            // tbxHizmetSuresi
            // 
            this.tbxHizmetSuresi.Location = new System.Drawing.Point(259, 25);
            this.tbxHizmetSuresi.Name = "tbxHizmetSuresi";
            this.tbxHizmetSuresi.Size = new System.Drawing.Size(100, 20);
            this.tbxHizmetSuresi.TabIndex = 30;
            // 
            // lblHizmetSuresi
            // 
            this.lblHizmetSuresi.AutoSize = true;
            this.lblHizmetSuresi.Location = new System.Drawing.Point(189, 25);
            this.lblHizmetSuresi.Name = "lblHizmetSuresi";
            this.lblHizmetSuresi.Size = new System.Drawing.Size(68, 13);
            this.lblHizmetSuresi.TabIndex = 29;
            this.lblHizmetSuresi.Text = "HizmetSuresi";
            // 
            // tbxMusteriIDFK
            // 
            this.tbxMusteriIDFK.Location = new System.Drawing.Point(259, 61);
            this.tbxMusteriIDFK.Name = "tbxMusteriIDFK";
            this.tbxMusteriIDFK.Size = new System.Drawing.Size(100, 20);
            this.tbxMusteriIDFK.TabIndex = 32;
            // 
            // lblMusteriIDFK
            // 
            this.lblMusteriIDFK.AutoSize = true;
            this.lblMusteriIDFK.Location = new System.Drawing.Point(189, 61);
            this.lblMusteriIDFK.Name = "lblMusteriIDFK";
            this.lblMusteriIDFK.Size = new System.Drawing.Size(65, 13);
            this.lblMusteriIDFK.TabIndex = 31;
            this.lblMusteriIDFK.Text = "MusteriIDFK";
            // 
            // tbxKuaforIDFK
            // 
            this.tbxKuaforIDFK.Location = new System.Drawing.Point(259, 102);
            this.tbxKuaforIDFK.Name = "tbxKuaforIDFK";
            this.tbxKuaforIDFK.Size = new System.Drawing.Size(100, 20);
            this.tbxKuaforIDFK.TabIndex = 34;
            // 
            // lblKuaforIDFK
            // 
            this.lblKuaforIDFK.AutoSize = true;
            this.lblKuaforIDFK.Location = new System.Drawing.Point(189, 105);
            this.lblKuaforIDFK.Name = "lblKuaforIDFK";
            this.lblKuaforIDFK.Size = new System.Drawing.Size(62, 13);
            this.lblKuaforIDFK.TabIndex = 33;
            this.lblKuaforIDFK.Text = "KuaforIDFK";
            // 
            // gbxEkle3
            // 
            this.gbxEkle3.Controls.Add(this.btnEkle3);
            this.gbxEkle3.Controls.Add(this.tbxMusteriIDFK);
            this.gbxEkle3.Controls.Add(this.tbxKuaforIDFK);
            this.gbxEkle3.Controls.Add(this.lblRandevuID);
            this.gbxEkle3.Controls.Add(this.lblKuaforIDFK);
            this.gbxEkle3.Controls.Add(this.tbxRandevuID);
            this.gbxEkle3.Controls.Add(this.lblRandevuTarihSaat);
            this.gbxEkle3.Controls.Add(this.lblMusteriIDFK);
            this.gbxEkle3.Controls.Add(this.tbxRandevuTarihSaat);
            this.gbxEkle3.Controls.Add(this.tbxHizmetSuresi);
            this.gbxEkle3.Controls.Add(this.lblToplamFiyat);
            this.gbxEkle3.Controls.Add(this.lblHizmetSuresi);
            this.gbxEkle3.Controls.Add(this.tbxToplamFiyat);
            this.gbxEkle3.Location = new System.Drawing.Point(793, 497);
            this.gbxEkle3.Name = "gbxEkle3";
            this.gbxEkle3.Size = new System.Drawing.Size(365, 170);
            this.gbxEkle3.TabIndex = 35;
            this.gbxEkle3.TabStop = false;
            this.gbxEkle3.Text = "Randevu Ekle";
            // 
            // btnEkle3
            // 
            this.btnEkle3.Location = new System.Drawing.Point(259, 141);
            this.btnEkle3.Name = "btnEkle3";
            this.btnEkle3.Size = new System.Drawing.Size(75, 23);
            this.btnEkle3.TabIndex = 35;
            this.btnEkle3.Text = "Ekle";
            this.btnEkle3.UseVisualStyleBackColor = true;
            this.btnEkle3.Click += new System.EventHandler(this.btnEkle3_Click);
            // 
            // gbxGuncelle3
            // 
            this.gbxGuncelle3.Controls.Add(this.btnGuncelle3);
            this.gbxGuncelle3.Controls.Add(this.lblRandevuTarihSaatUpdate);
            this.gbxGuncelle3.Controls.Add(this.tbxRandevuTarihSaatUpdate);
            this.gbxGuncelle3.Controls.Add(this.tbxToplamFiyatUpdate);
            this.gbxGuncelle3.Controls.Add(this.lblToplamFiyatUpdate);
            this.gbxGuncelle3.Controls.Add(this.lblHizmetSuresiUpdate);
            this.gbxGuncelle3.Controls.Add(this.tbxHizmetSuresiUpdate);
            this.gbxGuncelle3.Location = new System.Drawing.Point(1173, 497);
            this.gbxGuncelle3.Name = "gbxGuncelle3";
            this.gbxGuncelle3.Size = new System.Drawing.Size(319, 170);
            this.gbxGuncelle3.TabIndex = 36;
            this.gbxGuncelle3.TabStop = false;
            this.gbxGuncelle3.Text = "RandevuGucelle";
            // 
            // btnGuncelle3
            // 
            this.btnGuncelle3.Location = new System.Drawing.Point(202, 141);
            this.btnGuncelle3.Name = "btnGuncelle3";
            this.btnGuncelle3.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle3.TabIndex = 35;
            this.btnGuncelle3.Text = "Guncelle";
            this.btnGuncelle3.UseVisualStyleBackColor = true;
            this.btnGuncelle3.Click += new System.EventHandler(this.btnGuncelle3_Click);
            // 
            // lblRandevuTarihSaatUpdate
            // 
            this.lblRandevuTarihSaatUpdate.AutoSize = true;
            this.lblRandevuTarihSaatUpdate.Location = new System.Drawing.Point(5, 32);
            this.lblRandevuTarihSaatUpdate.Name = "lblRandevuTarihSaatUpdate";
            this.lblRandevuTarihSaatUpdate.Size = new System.Drawing.Size(65, 13);
            this.lblRandevuTarihSaatUpdate.TabIndex = 25;
            this.lblRandevuTarihSaatUpdate.Text = "RandevuTS";
            // 
            // tbxRandevuTarihSaatUpdate
            // 
            this.tbxRandevuTarihSaatUpdate.Location = new System.Drawing.Point(71, 29);
            this.tbxRandevuTarihSaatUpdate.Name = "tbxRandevuTarihSaatUpdate";
            this.tbxRandevuTarihSaatUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxRandevuTarihSaatUpdate.TabIndex = 26;
            // 
            // tbxToplamFiyatUpdate
            // 
            this.tbxToplamFiyatUpdate.Location = new System.Drawing.Point(71, 65);
            this.tbxToplamFiyatUpdate.Name = "tbxToplamFiyatUpdate";
            this.tbxToplamFiyatUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxToplamFiyatUpdate.TabIndex = 30;
            // 
            // lblToplamFiyatUpdate
            // 
            this.lblToplamFiyatUpdate.AutoSize = true;
            this.lblToplamFiyatUpdate.Location = new System.Drawing.Point(5, 72);
            this.lblToplamFiyatUpdate.Name = "lblToplamFiyatUpdate";
            this.lblToplamFiyatUpdate.Size = new System.Drawing.Size(64, 13);
            this.lblToplamFiyatUpdate.TabIndex = 27;
            this.lblToplamFiyatUpdate.Text = "ToplamFiyat";
            // 
            // lblHizmetSuresiUpdate
            // 
            this.lblHizmetSuresiUpdate.AutoSize = true;
            this.lblHizmetSuresiUpdate.Location = new System.Drawing.Point(2, 105);
            this.lblHizmetSuresiUpdate.Name = "lblHizmetSuresiUpdate";
            this.lblHizmetSuresiUpdate.Size = new System.Drawing.Size(68, 13);
            this.lblHizmetSuresiUpdate.TabIndex = 29;
            this.lblHizmetSuresiUpdate.Text = "HizmetSuresi";
            // 
            // tbxHizmetSuresiUpdate
            // 
            this.tbxHizmetSuresiUpdate.Location = new System.Drawing.Point(71, 102);
            this.tbxHizmetSuresiUpdate.Name = "tbxHizmetSuresiUpdate";
            this.tbxHizmetSuresiUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxHizmetSuresiUpdate.TabIndex = 28;
            // 
            // btnSil3
            // 
            this.btnSil3.Location = new System.Drawing.Point(1515, 637);
            this.btnSil3.Name = "btnSil3";
            this.btnSil3.Size = new System.Drawing.Size(75, 23);
            this.btnSil3.TabIndex = 37;
            this.btnSil3.Text = "Sil";
            this.btnSil3.UseVisualStyleBackColor = true;
            this.btnSil3.Click += new System.EventHandler(this.btnSil3_Click);
            // 
            // dgwVW1
            // 
            this.dgwVW1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwVW1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwVW1.Location = new System.Drawing.Point(36, 734);
            this.dgwVW1.Name = "dgwVW1";
            this.dgwVW1.Size = new System.Drawing.Size(693, 150);
            this.dgwVW1.TabIndex = 38;
            // 
            // dgwVW2
            // 
            this.dgwVW2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwVW2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwVW2.Location = new System.Drawing.Point(793, 734);
            this.dgwVW2.Name = "dgwVW2";
            this.dgwVW2.Size = new System.Drawing.Size(699, 150);
            this.dgwVW2.TabIndex = 39;
            // 
            // VIEW1
            // 
            this.VIEW1.AutoSize = true;
            this.VIEW1.Location = new System.Drawing.Point(36, 715);
            this.VIEW1.Name = "VIEW1";
            this.VIEW1.Size = new System.Drawing.Size(41, 13);
            this.VIEW1.TabIndex = 40;
            this.VIEW1.Text = "VIEW1";
            // 
            // VIEW2
            // 
            this.VIEW2.AutoSize = true;
            this.VIEW2.Location = new System.Drawing.Point(793, 714);
            this.VIEW2.Name = "VIEW2";
            this.VIEW2.Size = new System.Drawing.Size(41, 13);
            this.VIEW2.TabIndex = 41;
            this.VIEW2.Text = "VIEW2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 919);
            this.Controls.Add(this.VIEW2);
            this.Controls.Add(this.VIEW1);
            this.Controls.Add(this.dgwVW2);
            this.Controls.Add(this.dgwVW1);
            this.Controls.Add(this.btnSil3);
            this.Controls.Add(this.gbxGuncelle3);
            this.Controls.Add(this.gbxEkle3);
            this.Controls.Add(this.dgwRandevu);
            this.Controls.Add(this.btnSil2);
            this.Controls.Add(this.gbxGuncelle2);
            this.Controls.Add(this.gbxEkle2);
            this.Controls.Add(this.dgwKuafor);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.gbxGuncelle);
            this.Controls.Add(this.gbxEkle);
            this.Controls.Add(this.dgwMusteri);
            this.Name = "Form1";
            this.Text = "HAIR MASTER DB";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteri)).EndInit();
            this.gbxEkle.ResumeLayout(false);
            this.gbxEkle.PerformLayout();
            this.gbxGuncelle.ResumeLayout(false);
            this.gbxGuncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKuafor)).EndInit();
            this.gbxEkle2.ResumeLayout(false);
            this.gbxEkle2.PerformLayout();
            this.gbxGuncelle2.ResumeLayout(false);
            this.gbxGuncelle2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRandevu)).EndInit();
            this.gbxEkle3.ResumeLayout(false);
            this.gbxEkle3.PerformLayout();
            this.gbxGuncelle3.ResumeLayout(false);
            this.gbxGuncelle3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVW1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVW2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMusteri;
        private System.Windows.Forms.Label lblMusteriID;
        private System.Windows.Forms.TextBox tbxMusteriID;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.TextBox tbxIsim;
        private System.Windows.Forms.Label lblIkinciIsim;
        private System.Windows.Forms.TextBox tbxIkinciIsim;
        private System.Windows.Forms.Label lblSoyIsim;
        private System.Windows.Forms.TextBox tbxSoyIsim;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.TextBox tbxTelNo;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox tbxAdres;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.GroupBox gbxEkle;
        private System.Windows.Forms.TextBox tbxDogumTarihi;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox gbxGuncelle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox tbxDogumTarihiUpdate;
        private System.Windows.Forms.Label lblDogumTarihiUpdate;
        private System.Windows.Forms.TextBox tbxIkinciIsimUpdate;
        private System.Windows.Forms.TextBox tbxEmailUpdate;
        private System.Windows.Forms.Label lblEmailUpdate;
        private System.Windows.Forms.TextBox tbxAdresUpdate;
        private System.Windows.Forms.Label lblIsimUpdate;
        private System.Windows.Forms.Label lblAdresUpdate;
        private System.Windows.Forms.TextBox tbxIsimUpdate;
        private System.Windows.Forms.TextBox tbxTelNoUpdate;
        private System.Windows.Forms.Label lblIkinciIsimUpdate;
        private System.Windows.Forms.Label lblTelNoUpdate;
        private System.Windows.Forms.Label lblSoyIsimUpdate;
        private System.Windows.Forms.TextBox tbxSoyIsimUpdate;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgwKuafor;
        private System.Windows.Forms.GroupBox gbxEkle2;
        private System.Windows.Forms.Button btnEkle2;
        private System.Windows.Forms.TextBox tbxIsletmeCikis;
        private System.Windows.Forms.Label lblIsletmeCikis;
        private System.Windows.Forms.TextBox tbxKuaforIkinciIsim;
        private System.Windows.Forms.TextBox tbxIsletmeGiris;
        private System.Windows.Forms.Label lblKuaforID;
        private System.Windows.Forms.Label lblIsletmeGiris;
        private System.Windows.Forms.TextBox tbxKuaforID;
        private System.Windows.Forms.TextBox tbxKuaforAdres;
        private System.Windows.Forms.Label lblKuaforIsim;
        private System.Windows.Forms.Label lblKuaforAdres;
        private System.Windows.Forms.TextBox tbxKuaforIsim;
        private System.Windows.Forms.TextBox tbxKuaforTelNo;
        private System.Windows.Forms.Label lblKuaforIkinciIsim;
        private System.Windows.Forms.Label lblKuaforTelNo;
        private System.Windows.Forms.Label lblKuaforSoyIsim;
        private System.Windows.Forms.TextBox tbxKuaforSoyIsim;
        private System.Windows.Forms.TextBox tbxKuaforDogumTarihi;
        private System.Windows.Forms.Label lblKuaforDogumTarihi;
        private System.Windows.Forms.TextBox tbxKuaforEmail;
        private System.Windows.Forms.Label lblKuaforEmail;
        private System.Windows.Forms.GroupBox gbxGuncelle2;
        private System.Windows.Forms.TextBox tbxKuaforDogumTarihiUpdate;
        private System.Windows.Forms.Label lblKuaforDogumTarihiUpdate;
        private System.Windows.Forms.TextBox tbxKuaforEmailUpdate;
        private System.Windows.Forms.Label lblKuaforEmailUpdate;
        private System.Windows.Forms.Button btnGuncelle2;
        private System.Windows.Forms.TextBox tbxIsletmeCikisUpdate;
        private System.Windows.Forms.Label lblIsletmeCikisUpdate;
        private System.Windows.Forms.TextBox tbxKuaforIkinciIsimUpdate;
        private System.Windows.Forms.TextBox tbxIsletmeGirisUpdate;
        private System.Windows.Forms.Label lblIsletmeGirisUpdate;
        private System.Windows.Forms.TextBox tbxKuaforAdresUpdate;
        private System.Windows.Forms.Label lblKuaforIsimUpdate;
        private System.Windows.Forms.Label lblKuaforAdresUpdate;
        private System.Windows.Forms.TextBox tbxKuaforIsimUpdate;
        private System.Windows.Forms.TextBox tbxKuaforTelNoUpdate;
        private System.Windows.Forms.Label lblKuaforIkinciIsimUpdate;
        private System.Windows.Forms.Label lblKuaforTelNoUpdate;
        private System.Windows.Forms.Label lblKuaforSoyIsimUpdate;
        private System.Windows.Forms.TextBox tbxKuaforSoyIsimUpdate;
        private System.Windows.Forms.Button btnSil2;
        private System.Windows.Forms.DataGridView dgwRandevu;
        private System.Windows.Forms.Label lblRandevuID;
        private System.Windows.Forms.TextBox tbxRandevuID;
        private System.Windows.Forms.TextBox tbxRandevuTarihSaat;
        private System.Windows.Forms.Label lblRandevuTarihSaat;
        private System.Windows.Forms.TextBox tbxToplamFiyat;
        private System.Windows.Forms.Label lblToplamFiyat;
        private System.Windows.Forms.TextBox tbxHizmetSuresi;
        private System.Windows.Forms.Label lblHizmetSuresi;
        private System.Windows.Forms.TextBox tbxMusteriIDFK;
        private System.Windows.Forms.Label lblMusteriIDFK;
        private System.Windows.Forms.TextBox tbxKuaforIDFK;
        private System.Windows.Forms.Label lblKuaforIDFK;
        private System.Windows.Forms.GroupBox gbxEkle3;
        private System.Windows.Forms.Button btnEkle3;
        private System.Windows.Forms.GroupBox gbxGuncelle3;
        private System.Windows.Forms.Button btnGuncelle3;
        private System.Windows.Forms.Label lblRandevuTarihSaatUpdate;
        private System.Windows.Forms.TextBox tbxRandevuTarihSaatUpdate;
        private System.Windows.Forms.TextBox tbxToplamFiyatUpdate;
        private System.Windows.Forms.Label lblToplamFiyatUpdate;
        private System.Windows.Forms.Label lblHizmetSuresiUpdate;
        private System.Windows.Forms.TextBox tbxHizmetSuresiUpdate;
        private System.Windows.Forms.Button btnSil3;
        private System.Windows.Forms.DataGridView dgwVW1;
        private System.Windows.Forms.DataGridView dgwVW2;
        private System.Windows.Forms.Label VIEW1;
        private System.Windows.Forms.Label VIEW2;
    }
}

