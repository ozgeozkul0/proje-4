using System;
namespace ConsoleApp2
{ 
    class bir
    {
        static void Main()
        {
            double ucgen = ucgenalani();
            Console.WriteLine("ucgenin alani: " + ucgen);
        }
            //1. matematiksel hesaplama yapan parametresiz ve geriye deger döndüren metot
            //soru: bir metot yazın; kullanıcıdan üçgenin taban uzunluğunu ve yüksekliğini alıp
            //üçgenin alanını hesaplayarak geri döndürsün. taban * yükseklik / 2 formülünü kullanın.
            //ipucu: double türünde dönen bir metod tanımlanmalı ve kullanıcıdan alınan değerlerle hesap yapmalısınız 
            static double ucgenalani()
            {
                Console.WriteLine("ucgenin tabanini giriniz: ");
                double taban = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("ucgenin yuksekligini giriniz: ");
                double h = Convert.ToDouble(Console.ReadLine());
                double alan = taban * h / 2;
                return alan;
            }
        } 
    class iki
    {
        static void Main()
        {
            int[] dizi = { 3, 5, 8, 2, 4 };
            Console.ReadKey();
        }

        static int maxBul(int[] sayilar)
        {
            int maxDeger = sayilar[0];
                // 2.Dizideki En Büyük Değeri Bulan Parametreli ve Geriye Değer Döndüren Metot

                //Soru: int türünde bir dizi parametresi alan ve bu dizideki en büyük değeri bulan bir metot yazın.
                //İpucu: int dönen bir metot tanımlayıp, foreach döngüsü ile diziyi dolaşarak en büyük değeri bulabilirsiniz.
            foreach (int sayi in sayilar)
            {
                if (sayi > maxDeger)
                {
                    maxDeger = sayi;
                }
            }
            return maxDeger;
            
        }
    }
    class üç
    {
        //3.Aşırı Yüklenmiş(Overloaded) Metot ile Farklı Türdeki Verilerin Toplamını Bulma
        //Soru: Aynı isimle üç farklı CalculateSum metodu yazın.İlk metot iki int sayıyı toplasın, ikinci metot iki double sayıyı toplasın, üçüncü metot ise üç int sayıyı toplasın.
        //İpucu: Metot isimleri aynı olmalı fakat parametre türleri farklı olmalıdır.

        static void Main()
        {
            int sumint = CalculateSum(2, 4);
            double sumdouble = CalculateSum(33, 44);
            int sumthreeint = CalculateSum(8, 5);
            Console.WriteLine("iki int toplami: " + sumint);
            Console.WriteLine("iki double sayi toplami: " + sumdouble);
            Console.WriteLine("uc sayi toplami: " + sumthreeint);
        }

        static int CalculateSum(int a, int b)
        {
            return a + b;
        }
        static double CalculateSum(double a, double b)
        {
            return a + b;
        }
        static double CalculateSum(int a, int b, int c)
        {
            return a + b + c;
        }

    } 
    class dört
    {
        //4. Recursive Metot ile Fibonacci Dizisi Hesaplama
        //Soru: Bir sayının Fibonacci dizisindeki karşılığını hesaplayan özyinelemeli(recursive) bir metot yazın.fibonacci(5) çağrısı, dizideki 5. Fibonacci sayısını döndürmelidir.
        //İpucu: int dönen ve kendini çağırarak Fibonacci dizisi üreten bir metot yazmalısınız.
         static int Fibonacci(int n)
         {
             if (n == 0)
                 return 0;
             else if (n == 1)
                 return 1;

             return Fibonacci(n - 1) + Fibonacci(n - 2);
         }
         static void Result()
         {
             int n = 5;
             int result = Fibonacci(n);
             Console.WriteLine($"{n}. Fibonacci sayısı: " + result);
         }
    }
    class beş
    {
        //5.Params ile Sınırsız Sayıda Parametre Alarak Ortalama Hesaplama
        //Soru: params anahtar kelimesini kullanarak sınırsız sayıda double parametre alabilen ve bu sayılar arasındaki ortalamayı hesaplayan bir metot yazın.
        //İpucu: params ile dizi gibi parametre alabilir ve döngü kullanarak ortalamayı hesaplayabilirsiniz.

        static double ortHesapla(params double[] sayilar)
        {
            double toplam = 0;
            foreach (double sayi in sayilar)
            {
                toplam += sayi;
            }
            double ortalama = toplam / sayilar.Length;
            return ortalama;
            static void Main(string[] args) {
                double ortalama1 = ortHesapla(2, 4, 6);
                double ortalama2 = ortHesapla(5, 4, 77, 30);
                Console.WriteLine("ortalama 1: " + ortalama1);
                Console.WriteLine("ortalama 2: " + ortalama2);
            }

        }
        class altı
        {
            //6.Dizi Elemanlarını Toplayan ve Filtreleme Şartı Ekleyen Metot
            //Soru: int türünde bir dizi ve bir filtre değeri(int) alan bir metot yazın. Bu metot, filtre değerinden büyük olan tüm elemanları toplasın ve toplamı döndürsün.
            //İpucu: int türünde bir metot tanımlayıp foreach döngüsü ile filtreyi uygulayarak toplamı hesaplayabilirsiniz.
            // Dizi elemanlarını filtre değerine göre toplayan metot
            static int SumFilteredElements(int[] sayilar, int filtreDeger)
            {
                int toplam = 0;

                foreach (int sayi in sayilar)
                {
                    if (sayi > filtreDeger)
                    {
                        toplam += sayi;
                    }
                }

                return toplam;
            }

            static void Main()
            {
                int[] sayilar = { 1, 5, 8, 12, 3, 7, 10 };

                int filtreDeger = 5;

                int result = SumFilteredElements(sayilar, filtreDeger);

                Console.WriteLine("Filtre değerinden büyük elemanların toplamı: " + result);
            }

        }
        class yedi
        {
            //7.Seçmeli(Optional) Parametre ile Belirli Yaştan Sonraki Yılları Sayma
            //Soru: Bir yaş değeri alan bir metot yazın.Eğer yaş belirtilmezse varsayılan olarak 18 olsun ve metot, verilen yaşın 18’den ne kadar fazla olduğunu döndürsün.
            //İpucu: int türünde bir metot tanımlayıp varsayılan parametre kullanarak yaşı hesaplayabilirsiniz.
            static void Main()
            {
                int sonuc = yıllar(28);
                Console.WriteLine("yaş farkı: " + sonuc);
                Console.ReadKey();
            }
            static int yıllar(int yas = 18)
            {
                return yas - 18;
            }

        }
        class sekiz
        {
            //8.Geriye Koleksiyon Döndüren ve Veriyi Filtreleyen Metot
            //Soru: string türünde bir dizi alan bir metot yazın. Bu metot, sadece uzunluğu 5 karakterden büyük olan elemanları içeren bir List<string> döndürsün.
            //İpucu: List<string> türünde bir metot tanımlayarak döngü ile filtreleme yapabilirsiniz.
            public static List<string> FiltreleUzunStringler(string[] dizi)
            {
                List<string> uzunStringler = new List<string>();

                foreach (var eleman in dizi)
                {
                    if (eleman.Length > 5)
                    {
                        uzunStringler.Add(eleman);
                    }
                }
                return uzunStringler;
            }
            static void Main(string[] args)
            {
                string[] dizi = { "merhaba", "kedi", "köpek", "aağaç", "dünya", "programlama" };

                List<string> sonuc = FiltreleUzunStringler(dizi);

                Console.WriteLine("Uzunluğu 5'ten büyük olan kelimeler:");
                foreach (var kelime in sonuc)
                {
                    Console.WriteLine(kelime);
                }
            }
        }

}