using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Tosin_WGCNDDNE_WebServices.Infrastructure
{
        public interface IMappingService<Phone>
            where Phone : class, new()
        {
            Phone Map(SqlDataReader Buyer);
        }

}