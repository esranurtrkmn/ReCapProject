using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EFCarDal());

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName+" / "+car.BrandName+" / "+car.ColorName);

            }

            //ColorManager colorManager = new ColorManager(new EFColorDal());

            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.ColorName);

            //}


        }
    }
}
