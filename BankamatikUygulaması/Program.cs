namespace AtmUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 5000;
            int vergi = 2;
            Console.WriteLine("Şifre Giriniz\n");
            string sifre;
            sifre = "1234";
            string kullanicisifre;
            kullanicisifre = Console.ReadLine();

            if (kullanicisifre == sifre)
            {
                Console.WriteLine("\nŞifre Doğru\n");
            }
            else
            {
                Console.WriteLine("Şifre yanlış");
                Environment.Exit(0);
            }

            Console.WriteLine("Mevcut Bakiyeniz = " + bakiye);
            Console.WriteLine("\n--------Lütfen Birden Dörde Kadar Olan İslemi Seciniz--------\n");
            Console.WriteLine("1. Para Yatırma");
            Console.WriteLine("2. Para Çekme");
            Console.WriteLine("3. Bakiye sorgulama");
            Console.WriteLine("4. Kart İade");

            Console.Write("\nYapılmak İstenen İsleminizi Seciniz: (1,2,3,4) ");
            int islem = Convert.ToInt32(Console.ReadLine());

            switch (islem)
            {
                case 1:
                    Console.WriteLine(" Bakiyeniz = " + bakiye);
                    Console.Write(" Yatırmak istediğiniz tutarı giriniz: ");
                    int tutar = Convert.ToInt32(Console.ReadLine());
                    if (tutar > bakiye)
                    {
                        Console.Write(" Yetersiz bakiye. Tekrar giriniz: ");
                        tutar = Convert.ToInt32(Console.ReadLine());
                    }
                    bakiye += tutar;
                    Console.WriteLine(" Yeni bakiyeniz = " + bakiye);
                    break;
                case 2:
                    Console.WriteLine("Çekmek İstediginiz Tutarı Giriniz ");
                    int toppara = int.Parse(Console.ReadLine());
                    int kalan1 = (bakiye - toppara) - vergi;
                    if (toppara > (bakiye - vergi) && toppara < bakiye)
                    {
                        Console.WriteLine(" " + vergi + " Vergiyi Unutmayınz");
                    }
                    else if (toppara <= 4998 && toppara > 5)
                    {
                        Console.WriteLine("Alınan vergi " + vergi + " Lira ");
                        Console.WriteLine("Kalan para : " + kalan1);
                    }

                    else if (toppara >= 5000)
                    {
                        Console.WriteLine("Bakiyenizden fazla çekemezsiniz ");
                    }
                    else
                    {
                        Console.WriteLine("Alınan vergi " + vergi + " Lira ");
                        Console.WriteLine("Kalan para : " + kalan1);
                    }

                    break;
                case 3:
                    Console.WriteLine(" Bakiyeniz = " + bakiye);
                    break;
                case 4:
                    Console.WriteLine(" Kartınızı Unutmayınız. ");
                    break;
                default:
                    Console.WriteLine(" Hatalı İşlem Tekrar Deneyiniz. ");
                    break;
            }
            Console.ReadLine();
        }
    }
}


