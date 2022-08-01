using System;
using System.Collections.Generic;
using System.Text;

namespace G006_Sinema
{
    class Sinema
    {
        public string Adi { get; set; }
        public int Kapasite { get; set; }

        private float _tamBiletFiyati;
        public float TamBiletFiyati
        {
            get
            {
                return _tamBiletFiyati;
            }
            set
            {
                if (value > 0)
                {
                    _tamBiletFiyati = value;
                }
            }
        }
        private float _yarimBiletFiyati;
        public float YarimBiletFiyati
        {
            get
            {
                return _yarimBiletFiyati;
            }
            set
            {
                if (value > 0)
                {
                    _yarimBiletFiyati = value;
                }
            }
        }
        


  
        public double Bakiye 
        { 
            get
            {
                return this.TamBiletFiyati * this.ToplamTamBiletAdedi + this.YarimBiletFiyati * this.ToplamYarimBiletAdedi;
            }
        }
        public int BosKoltukAdedi 
        { 
            get
            {
                return this.Kapasite = (this.ToplamTamBiletAdedi + this.ToplamYarimBiletAdedi);
            }
        }
        public int ToplamTamBiletAdedi { get; set; }
        public int ToplamYarimBiletAdedi { get; set; }

        public Sinema()
        {

        }

        public Sinema(string adi)
        {
            this.Adi = adi;
        }

        public Sinema(string adi, int kapasite, float tamBiletFiyati, float yarimBiletFiyati)
        {
            this.Adi = adi;
            this.Kapasite = kapasite;
            this.TamBiletFiyati = tamBiletFiyati;
            this.YarimBiletFiyati = yarimBiletFiyati;
           // this.BosKoltukAdedi = kapasite;
        }

        public void BiletSat(int tamBiletAdedi, int yarimBiletAdedi)
        {
            if (this.BosKoltukAdedi >= (tamBiletAdedi + yarimBiletAdedi))
            {

                this.ToplamTamBiletAdedi += tamBiletAdedi;// this.ToplamTamBiletAdedi = this.ToplamTamBiletAdedi + tamBiletAdedi;
                this.ToplamYarimBiletAdedi += yarimBiletAdedi;// this.ToplamYarimBiletAdedi = this.ToplamYarimBiletAdedi + yarimBiletAdedi;
                BakiyeBosKotukHesapla();
                Console.WriteLine("İşlem gerçekleştirildi.");
            }
            else
            {
                Console.WriteLine("Yeterli sayıda koltuk yok. Kalan boş koltuk sayısı: " + this.BosKoltukAdedi);
            }
        }
        public void BiletIade(int tamBiletAdedi, int yarimBiletAdedi)
        {
            if (tamBiletAdedi <= this.ToplamTamBiletAdedi && yarimBiletAdedi <= this.ToplamYarimBiletAdedi)
            {
                this.ToplamTamBiletAdedi -= tamBiletAdedi;
                this.ToplamYarimBiletAdedi -= yarimBiletAdedi;
                BakiyeBosKotukHesapla();
                Console.WriteLine("İşlem gerçekleştirildi.");
            }
            else
            {
                Console.WriteLine("İşlem gerçekleştirilmedi. Girilen değerleri kontrol edin.");
            }
        }
        private void BakiyeBosKotukHesapla()
        {
          //  this.BosKoltukAdedi = this.Kapasite - (this.ToplamTamBiletAdedi + this.ToplamYarimBiletAdedi);
          //    this.Bakiye = this.TamBiletFiyati * this.ToplamTamBiletAdedi + this.YarimBiletFiyati * this.ToplamYarimBiletAdedi;
        }



    }
}
