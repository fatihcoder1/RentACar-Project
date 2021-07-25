using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OrderManager : IOrderServices
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public List<RentalOrders> GetAll()
        {
            return _orderDal.GetAll();
        }
    }
}
