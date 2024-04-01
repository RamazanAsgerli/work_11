using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtask
{
    internal class Gallery
    {


         Car[] Cars = new Car[0];

        public void AddCar(Car car)
        {
            Array.Resize(ref Cars, Cars.Length+1);
            Cars[Cars.Length-1] = car;
        }
        
        public Car[] GetAllCars()
        {
            Car[] allCars = new Car[0];
            for(int i = 0; i < Cars.Length; i++)
            {
                Array.Resize(ref allCars, allCars.Length + 1);
                allCars[allCars.Length - 1] = Cars[i];
            }
            return allCars;
        }

        public void FindCarByld(int id)
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i].ID == id)
                {
                    Cars[i].ShowAllCar();
                }
            }
        }
        public Car[] FindCarByCarCode(string carcode)
        {
            Car[] searchCarcode = new Car[0];
            for(int i = 0;i<Cars.Length;i++)
            {
                if (Cars[i].Carcode == carcode)
                {
                    Array.Resize(ref searchCarcode, searchCarcode.Length + 1);
                    searchCarcode[Cars.Length - 1] = Cars[i];
                }
            }
            return searchCarcode;
        }

        public Car[] FindCarsBySpeedInterval(int minSpeed,int maxSpeed)
        {
            Car[] cars = { };
            for(int i = 0;i < Cars.Length;i++)
            {
                if (Cars[i].Speed >= minSpeed && Cars[i].Speed <= maxSpeed)
                {
                    Array.Resize(ref cars, cars.Length+1);
                    cars[Cars.Length - 1] = Cars[i];
                }
            }
            return cars;
        }


    }
}
