using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tosin_WGCNDDNE_WebServices.Domain;
using System.Linq;
using System.Threading.Tasks;

namespace Tosin_WGCNDDNE_WebServices.Infrastructure
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
