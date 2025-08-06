
using Bulky.DataAccess.Repository.IRepository;
using Bulky.DataAcess.Data;
using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
        private ApplicationDbContext _db;
        public OrderHeaderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(OrderHeader obj)
        {
            _db.OrderHeaders.Update(obj);
        }

        public void UpdateStatus(int id, string statusCancelled1, string statusCancelled2)
        {
            throw new NotImplementedException();
        }

        public void UpdateStatus(int id, string? statusInprocess)
        {
            var orderFromDb = _db.OrderHeaders.FirstOrDefault(o => o.Id == id);
            if (orderFromDb != null)
            {
                orderFromDb.OrderStatus = statusInprocess;
                _db.OrderHeaders.Update(orderFromDb);
            }

        }
    }
}
