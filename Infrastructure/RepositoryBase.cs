using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using Tosin_WGCNDDNE_WebServices.Domain;
using Tosin_WGCNDDNE_WebServices.Presentation.Model;

namespace Tosin_WGCNDDNE_WebServices.Infrastructure
{
    public class RepositoryBase
    {
        private readonly IConfiguration _configuration;

        public RepositoryBase(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }
        protected string GetConnectionString() => _configuration.GetConnectionString("Main");

        public Phone[] GetData<Phone, PhoneMappingService>(string sql)
            where Phone : class, new()
            where PhoneMappingService : IMappingService<Phone>, new()
        {
            List<Phone> result = new List<Phone>();
            var mappingService = new PhoneMappingService();

            using (var connection = new SqlConnection(this.GetConnectionString()))
            {
                connection.Open();
                using (var command = new SqlCommand(sql, connection))
                {
                    var reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        result.Add(mappingService.Map(reader));
                    }
                }
            }

            return result.ToArray();
        }

        protected void ExecSql(string sql)
        {
            if (string.IsNullOrWhiteSpace(sql))
                throw new ArgumentNullException(nameof(sql));

            using (var connection = new SqlConnection(this.GetConnectionString()))
            {
                connection.Open();
                using (var command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
