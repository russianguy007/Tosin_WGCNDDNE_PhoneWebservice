using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tosin_WGCNDDNE_WebServices.Domain;

namespace Tosin_WGCNDDNE_WebServices.Infrastructure
{
    public interface PhonesMappingService : IMappingService<Phone>
    {
        public Order Map(SqlDataReader Buyer)
        {
            return new Order
            {
                Id = int.Parse(Buyer["id"].ToString()),
                Phoneid = (Buyer["phoneid"].ToString(),
                Phone = Buyer["Name"].ToString())
        };
        }
    }
}
