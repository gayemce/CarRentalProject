﻿namespace CarRentalProject
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
                else if (cevap.ToLower() == "Araç Ekle".ToLower() || cevap == "3")
                {
                    Console.WriteLine("* Araç Ekle *\n");
                    Console.WriteLine("Markayı yazın:");
                    string marka = Console.ReadLine();

                tekrar1:;
                    Console.WriteLine("Modeli yazın;");
                    string modelString = Console.ReadLine();
                    int model = 0;
                    if (!int.TryParse(modelString, out model))
                    {
                        Console.WriteLine(" *** Model değeri sayı olmalıdır. ***");
                        goto tekrar1;
                    }

                tekra2:;
                    Console.WriteLine("Motor gücünü yazın");
                    string motorGucuString = Console.ReadLine();
                    int motorGucu = 0;
                    if (!int.TryParse(motorGucuString, out motorGucu))
                    {
                        Console.WriteLine(" *** Motor gücü değeri sayı olmalıdır. ***");
                        goto tekra2;
                    }

                    //instance alındı.
                    Car car = new();
                    car.marka = marka;
                    car.model = model;
                    car.motorGucu = motorGucu;
                    //cars listesine eklenir.
                    cars.Add(car);

                    Console.WriteLine("\n");

                }

            }
        }
    }
}