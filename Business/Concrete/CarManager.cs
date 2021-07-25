using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarServices
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

     

        public List<Car> GetAllByCategory(string category)
        {
            return _carDal.GetAll(p => p.Category == category);
        }

       

        public List<Car> GetByUnitModal(int minYear, int maxYear)
        {
            return _carDal.GetAll(p => p.CarYear>= minYear && p.CarYear < maxYear);
        }
    }
}
