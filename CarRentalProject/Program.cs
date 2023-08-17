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
            //Car sınıfından nesnelerin listesini temsil eden cars adında bir liste oluşturulur.
            List<Car> cars = new();
            cars.Add(new Car() { marka = "BMW", model = 2023, motorGucu = 5000 });
            cars.Add(new Car() { marka = "Mercedes", model = 2020, motorGucu = 6000 });

            Console.WriteLine("Araba Kiralama Projesine Hoş Geldiniz! \n Size Nasıl Yardımcı Olabilirim?\n");
            ıslemler();

            while (true)
            {
                string cevap = Console.ReadLine();

                if (cevap.ToLower() == "Araç Listesi".ToLower() || cevap == "1")
                {
                    Console.WriteLine("* Araç Listesi *\n");
                    foreach (Car item in cars)
                    {
                        Console.WriteLine($"Marka: {item.marka} - Model: {item.model} - Motor Gücü: {item.motorGucu}");
                    }
                    Console.WriteLine("\n");
                }

                 else if (cevap.ToLower() == "Araç Sayısı".ToLower() || cevap == "2")
                {
                    Console.WriteLine("* Araç Sayısı *\n");
                    Console.WriteLine($"Toplam Araç Sayısı: {cars.Count()}\n\n");
                }

            }
        }
    }
}