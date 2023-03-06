using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToroslarCam.Domain.Data;
using ToroslarCam.Domain.Entities;

namespace ToroslarCam.Domain.Repositories
{
    public class OrderRepository
    {
        public Order GetById(string id)
        {
            var context = new ToroslarCamContext();
            var order = context.Orders.FirstOrDefault(x=>x.Id==id);

            return order;
        }
        public List<Order> List()
        {
            var context = new ToroslarCamContext();
            var list = context.Orders.ToList();

            return list;
        }
        public void Add(Order order)
        {
            var context = new ToroslarCamContext();
            context.Orders.Add(order);
            context.SaveChanges();
        }

        public void Update(Order order)
        {
            var context = new ToroslarCamContext();
            var entity = context.Entry<Order>(order);
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(string id)
        {
            var context = new ToroslarCamContext();
            var order = context.Orders.FirstOrDefault(x => x.Id == id);
            if (order == null) return;

            var entity = context.Entry<Order>(order);
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
