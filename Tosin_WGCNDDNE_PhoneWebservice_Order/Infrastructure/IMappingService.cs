using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Tosin_WGCNDDNE_PhoneWebservice_Order.Infrastructure
{
    public interface IMappingService<Phone>
        where Phone : class, new()
    {
        Phone Map(SqlDataReader Buyer);
    }

}
