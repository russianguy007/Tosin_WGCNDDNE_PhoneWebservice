using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Tosin_WGCNDDNE_WebServices.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tosin_WGCNDDNE_WebServices.Infrastructure
{
    public class PhonesRepository
    {
        private readonly IConfiguration _configuration;

        public PhonesRepository(IConfiguration configuration) :
            base(configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public Guid Insert(Phone phone)
        {
            if (phone == null)
                throw new ArgumentNullException(nameof(phone));

            var id = Guid.NewGuid();

            this.ExecSql($"INSERT INTO Books (id, name, author) VALUES ('{id}','{phone.Name}','{phone.Brand}')");

            return id;
        }

        public void Update(Phone phone)
        {
            if (phone == null)
                throw new ArgumentNullException(nameof(Phone));

            this.ExecSql($"UPDATE Books SET name='{phone.Name}', author='{phone.Brand}' WHERE id='{phone.id}'");
        }
    }
}
