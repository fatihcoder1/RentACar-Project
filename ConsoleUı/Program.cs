using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs;
using System;

namespace ConsoleUı
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetail())
            {
                Console.WriteLine(car.CarYear);
            }


            /*CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            foreach (var customer in customerManager.GetAll())
            {
               Console.WriteLine(customer.Address);
            }*/

            //CarManager
            /*CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetByUnitModal(2000,2010))
            {
                Console.WriteLine(car.Model + " -- " + car.CarYear);
            }
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Category);
            }*/

        }
    }
}
