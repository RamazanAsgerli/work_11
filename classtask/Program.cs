namespace classtask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW",320,"AA2000");
            Car car1 = new Car("Merc", 300, "AA2122");

            Gallery galery = new Gallery();

            galery.AddCar(car);
            galery.AddCar(car1);

            bool check = true;
            string answer;

            do
            {
                Console.WriteLine("0.Butun melumatlari goster" +
                                   "\n1.Teze Car Elave et" +
                                   "\n2.Id daxil et ona uygun cari tap" +
                                   "\n3.Carcodeni daxil et ona uygun Cari tap"+
                                   "\n4.Minspeed ve Maxspeed daxil et" + 
                                   "\n5.Proqram bitdi");

                answer = Console.ReadLine();

                switch(answer)
                {
                    case "0":
                        {
                            Car[] all = galery.GetAllCars();
                            for (int i = 0; i < all.Length; i++)
                            {
                                all[i].ShowAllCar();
                            }
                            break;
                        }

                    case "1":
                        {
                            Console.WriteLine("Teze Carin melumatlarini daxil edin");
                            Console.WriteLine("Ad Daxil et:");
                            string name = Console.ReadLine();
                            int speed;
                            do
                            {
                                Console.WriteLine("Sureti daxil et:");
                            } while (!int.TryParse(Console.ReadLine(), out speed) && speed > 0);
                            Console.WriteLine("Carcodeni daxil edin");
                            string carcode = Console.ReadLine();
                            Car newCar = new Car(name,speed,carcode);
                            galery.AddCar(newCar);
                            break;
                        }
                        
                      case "2":
                        int id;
                        do
                        {
                            Console.WriteLine("id daxil edin: ");
                        } while (!int.TryParse(Console.ReadLine(), out id) && id > 1000);
                        galery.FindCarByld(id);
                        break;

                        case "3":
                        Console.WriteLine("Carcodeye uygun olanlari tap");
                        string searchCode = Console.ReadLine();
                        Car[] search = galery.FindCarByCarCode(searchCode);
                        for(int i = 0;i < search.Length; i++)
                        {
                            search[i].ShowAllCar();
                        }
                        break;
                        case "4":
                        int minspeed,maxspeed;
                        do
                        {
                            Console.WriteLine("Minimum suret:");
                        }while(!int.TryParse(Console.ReadLine(), out minspeed) && minspeed > 0);
                        do
                        {
                            Console.WriteLine("Maks suret:");
                        } while (!int.TryParse(Console.ReadLine(), out maxspeed) && maxspeed > 0);
                        Car[] Speed = galery.FindCarsBySpeedInterval(minspeed, maxspeed);
                        for(int i = 0;i < Speed.Length; i++)
                        {
                            Speed[i].ShowAllCar();
                        }
                        break;
                        case "5":
                        Console.WriteLine("proqram bitdi");
                        check = true;
                        break;
                    default:
                        Console.WriteLine("Bele secim yoxdur!!!");
                        break;

                }



            } while (check);
        }
    }
}
