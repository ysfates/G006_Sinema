using System;

namespace G006_Sinema
{
    class Uygulama
    {
        Sinema Sinema { get; set; }
        public void Calistir()
        {
            Giris();
            Menu();
            while (true)
            {
                string secim = Secim();
                switch (secim)
                {
                    case "1":
                    case "D":
                        SonDurumGor();
                        break;
                    case "2":
                    case "S":
                        BiletSat();
                        break;
                    case "3":
                    case "I":
                    case "İ":
                        BiletIade();
                        break;
                    case "4":
                    case "C":
                    case "Ç":
                        Console.WriteLine("Program sonlandırılıyor.");
                        return;
                }
            }
        }
        public void Giris()
        {
            Console.WriteLine("-------Sinema Uygulaması------ -");
            Console.Write("Sinema adı: ");
            string ad = Console.ReadLine();
            Console.Write("Kapasite: ");
            int kapasite = int.Parse(Console.ReadLine());
            Console.Write("Tam Bilet Fiyatı:");
            float tFiyat = float.Parse(Console.ReadLine());
            Console.Write("Yarım Bilet Fiyatı:");
            float yFiyat = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Sinema = new Sinema(ad, kapasite, tFiyat, yFiyat);


        }
        public void Menu()
        {
            Console.WriteLine("1 - Son Durum Gör(D)");
            Console.WriteLine("2 - Bilet Sat(S)    ");
            Console.WriteLine("3 - Bilet İade(İ)   ");
            Console.WriteLine("4 - Çıkış(Ç)        ");
            Console.WriteLine();
        }
        public string Secim()
        {
            Console.WriteLine();
            Console.Write("Yapmak istediğiniz işlem kodunu girin:");
            string secim = Console.ReadLine();
            Console.WriteLine();
            return secim;
        }
        public void BiletSat()
        {
            int t;
            int y;
            Console.WriteLine("Bilet Sat:");
            Console.Write("Tam Bilet Adedi:");
            t = int.Parse(Console.ReadLine());
            Console.Write("Yarım Bilet Adedi:");
            y = int.Parse(Console.ReadLine());
            Sinema.BiletSat(t, y);

        }
        public void BiletIade()
        {
            int t;
            int y;
            Console.WriteLine("Bilet Iade:");
            Console.Write("Tam Bilet Adedi:");
            t = int.Parse(Console.ReadLine());
            Console.Write("Yarım Bilet Adedi:");
            y = int.Parse(Console.ReadLine());
            Sinema.BiletIade(t, y);


        }
        public void SonDurumGor()
        {
            Console.WriteLine("Kapasite: " + Sinema.Kapasite);
            Console.WriteLine("Bakiye: " + Sinema.Bakiye);
            Console.WriteLine("Boş Koltuk Adedi: " + Sinema.BosKoltukAdedi);
            Console.WriteLine("Tam Bilet Adedi : " + Sinema.ToplamTamBiletAdedi);
            Console.WriteLine("Yarım Bilet Adedi : " + Sinema.ToplamYarimBiletAdedi);
            Console.WriteLine("Tam Bilet Fiyatı : " + Sinema.TamBiletFiyati);
            Console.WriteLine("Yarım Bilet Fiyatı : " + Sinema.YarimBiletFiyati);

        }

    }
}
