using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tosin_WGCNDDNE_PhoneWebservice_Order.Domain;
namespace Tosin_WGCNDDNE_PhoneWebservice_Order.Infrastructure
{
    public class OrdersMappingService : IMappingService<Order>
    {
        public Order Map(SqlDataReader Buyer)
        {
            return new Order
            {
                Id = int.Parse(Buyer["id"].ToString()),
                Phoneid = int.Parse(Buyer["phone_id"].ToString()),
                Buyer = Buyer["reader"].ToString()
            };
        }
    }
}
