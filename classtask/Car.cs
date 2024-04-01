using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtask
{
    internal class Car
    {
        private static int _id;
        public string Name;
        public int Speed;
        public string Carcode;
        
         
        public int ID
        {
            get {return _id; }
            set { 
                if(value > 0)
                {
                    _id = value;
                }
                else
                {
                    Console.WriteLine("Duzgun id daxil edin");
                }
            }
        }

     
        public Car(string name,int speed,string carcode)
        {
            _id++;
            ID = _id;
            Name = name;
            Speed = speed;
            Carcode = carcode;
        }

        public void ShowAllCar()
        {
            Console.WriteLine($"{ID}, Adi: {Name}, Sureti: {Speed}, Masinkodu: {Carcode} ");
        }
    }
}
