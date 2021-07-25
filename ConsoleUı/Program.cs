using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUı
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            /*foreach (var car in carManager.GetByUnitModal(2000,2010))
            {
                Console.WriteLine(car.Model + " -- " + car.CarYear);
            }*/
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Category);
            }
        }
    }
}
