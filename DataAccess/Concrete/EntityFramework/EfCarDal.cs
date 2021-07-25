using Core.DataAccess;
using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, SofiaCarRental1Context>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using(SofiaCarRental1Context sofiaCar = new SofiaCarRental1Context())
            {
                var result = from p in sofiaCar.Cars
                             join c in sofiaCar.RentalOrders on
                             p.CarID equals c.CarID
                             select new CarDetailDto
                             { CarID = p.CarID, CarYear = p.CarYear, CustomerID = c.CustomerID, Model = p.Model };
                return result.ToList();
            }
        }
    }
}
