using System;

namespace methodall
{
    //nottt methodlarımızı static oluşturursak nesne oluşturmamıza gerek yok
    //methodalrı static yapmazsak nesne oluşturarak kullanmalıyız zaten nesne oluşturmadan kullanıma izin vermez
    class sinif1
    {
        public int topla(int a, int b)
        {
            return a + b;
        }
        public int alanhesapla(int alan)
        {
            int sonuc;
            sonuc = alan * alan;
            return sonuc;
        }
    }
    class Program
    {
        public  int topla1(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            sinif1 sinif1 = new sinif1();
            Console.WriteLine("sinif1 klası topla metodu"+sinif1.topla(12,5));
            Program topla1 = new Program();
            Console.WriteLine("program klası topla1 metodu" + topla1.topla1(11, 5));
            Console.WriteLine("sinif1 klası alan hesaplama metodu" + sinif1.alanhesapla(5));
            Console.ReadLine();
        }
    }
}
