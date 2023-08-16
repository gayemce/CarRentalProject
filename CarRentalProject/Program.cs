namespace CarRentalProject
{
    internal class Program
    {
        public class Car
        {
            public string marka;
            public int model;
            public int motorGucu;
        }

         private static void ıslemler()
        {
            Console.WriteLine("*** İşlemler *** ");
            Console.WriteLine("1 - Araç Listesi");
            Console.WriteLine("2 - Araç Sayısı");
            Console.WriteLine("3 - Araç Ekle");
            Console.WriteLine("4 - Araç Kirala");
            Console.WriteLine("5 - İşlemleri Göster");
            Console.WriteLine("6 - Çıkış\n\n");
        }

        static void Main(string[] args)
        {
            
        }
    }
}