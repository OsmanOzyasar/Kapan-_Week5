using Kapanış_Week5;
using System;

namespace Week5
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            do
            {
                Console.WriteLine("Bir araba üretmek istter misiniz? (e/h)");

                userInput = Console.ReadLine().ToLower();
                if (!(userInput == "h" || userInput == "e"))
                    Console.WriteLine("Geçersiz ifade.");
            } while (!(userInput == "h" || userInput == "e"));

            List<Car> cars = new List<Car>();
            if (userInput == "e")
            {
            start2:
               
                Car car = new Car();
                Console.Write("Üretmek istediğiniz arabanın markası: ");
                string userInput1 = Console.ReadLine();
                car.Brand = userInput1;

                Console.Write("Üretmek istediğiniz arabanın modeli: ");
                string userInput2 = Console.ReadLine();
                car.Model = userInput2;

                Console.Write("Üretmek istediğiniz arabanın rengi: ");
                string userInput3 = Console.ReadLine();
                car.Color = userInput3;

                Console.Write("Üretmek istediğiniz arabanın seri numarası: ");
                string userInput4 = Console.ReadLine();
                car.SerialNumber = userInput4;

            start:
                Console.WriteLine("Üretmek istediğiniz arabanın kaç kapısı vardır?");
                int userInput5 = 0;
                try
                {
                    userInput5 = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("geçerli bir değer giriniz");
                    goto start;
                }
                car.DoorNumber = userInput5;

                car.Time = DateTime.Now;

                cars.Add(car);

                Console.WriteLine("Tekrar bir araba üretmek istermisiniz? (e/h)");
                string userInput6 = Console.ReadLine().ToLower();
                if (userInput6 == "e")
                    goto start2;
                else if (userInput6 == "h")
                    Console.WriteLine("uygulamamızı kullandığınız için teşekkürler");

            }
            int number = 1;
            foreach (var item in cars)
            {
                Console.WriteLine($"{number}. arabanızın markası: " + item.Brand + "\nmodeli: " + item.Model + "\nrengi: "+ item.Color + "\nkapı sayısı: " + item.DoorNumber + "\nüretim tarihi: " + item.Time);
                number++;
            }
        }
    }
}