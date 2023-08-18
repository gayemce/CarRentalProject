namespace CarRentalProject
{
    public class Car
    {
        public string marka;
        public int model;
        public int motorGucu;
    }

    internal class Program
    {
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

                else if (cevap.ToLower() == "Araç Kirala".ToLower() || cevap == "4")
                {
                    Console.WriteLine("* Araç Kirala *\n");
                    
                    for (int i = 0; i < cars.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {cars[i].marka}");
                    }

                tekrar3:;
                    Console.WriteLine("Araç Seçimi Yapın:");
                    string secilenAracString = Console.ReadLine();
                    int secilenArac = 0;
                    if(int.TryParse(secilenAracString, out secilenArac) == false)
                    {
                        Console.WriteLine("Lütfen sayı değeri giriniz");
                        goto tekrar3;
                    }

                    if(secilenArac > cars.Count)
                    {
                        Console.WriteLine("Seçtiğiniz araç filodo bulunmuyor");
                    }

                    Console.WriteLine("Kiralamak istediğniz tarih:");
                    string kiralamaTarih = Console.ReadLine();

                    Console.WriteLine("Kiralamak istediğiniz saat:");
                    string kiralamaSaat = Console.ReadLine();

                    Console.WriteLine("Teslim edeceğiniz tarih:");
                    string teslimTarih = Console.ReadLine();

                    Console.WriteLine($"Seçilen Araç: {cars[secilenArac - 1].marka}" +
                        $" Kiralama Tarihi: {kiralamaTarih}" +
                        $" Kiralama Saati: {kiralamaSaat}" +
                        $" Teslim Tarihi: {teslimTarih}");
                    Console.WriteLine("Aracı zamanında teslim etmezseniz cezai işlem uygulanacaktır.\n\n Bizi Tercih Ettiğiniz İçin Teşekkürler!\n\n");
                }   

                 else if (cevap.ToLower() == "İşlemleri Göster".ToLower() || cevap == "5")
                {
                    ıslemler();
                } 

                 else if (cevap.ToLower() == "Çıkış".ToLower() || cevap == "6")
                {
                    Console.WriteLine("Ziyaretiniz için teşekkürler. Tekrar görüşmek üzere.");
                    break;
                }

                else
                {
                    Console.WriteLine("Lütfen listedeki işlemlerden birini seçin!");
                }
            }
        }
    }
}