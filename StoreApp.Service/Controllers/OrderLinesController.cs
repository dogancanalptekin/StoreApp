using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using StoreApp.Data.Abstract;
using StoreApp.Data.Concrete.EntityFramework;
using StoreApp.Entity;

namespace StoreApp.Service.Controllers
{
    public class OrderLinesController : ApiController
    {
        IOrderLineRepository _orderLineRepository;

        public OrderLinesController()
        {
            _orderLineRepository = new EfOrderLineRepository();
        }

        public IEnumerable<OrderLine> GetOrderLines()
        {
            return _orderLineRepository.OrderLines;
        }

        public OrderLine GetOrderLine(int id)
        {
            return _orderLineRepository.OrderLines.Where(i => i.Id == id).FirstOrDefault();
        }

        public async Task PostOrderLine(OrderLine entity)
        {
            await _orderLineRepository.SaveOrderLineAsync(entity);
        }

        public async Task DeleteOrderLine(int id)
        {
            await _orderLineRepository.DeleteOrderLineAsync(id);
        }
    }
}
