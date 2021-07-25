using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (SofiaCarRental1Context sofiaCarRental = new SofiaCarRental1Context())
            {
                var addedEntity = sofiaCarRental.Entry(entity);
                addedEntity.State = EntityState.Added;
                sofiaCarRental.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (SofiaCarRental1Context sofiaCarRental = new SofiaCarRental1Context())
            {
                var deletedEntity = sofiaCarRental.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                sofiaCarRental.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (SofiaCarRental1Context context = new SofiaCarRental1Context())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }
        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (SofiaCarRental1Context context = new SofiaCarRental1Context())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car entity)
        {
            using (SofiaCarRental1Context sofiaCarRental = new SofiaCarRental1Context())
            {
                var updatedEntity = sofiaCarRental.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                sofiaCarRental.SaveChanges();
            }
        }
    }
}
