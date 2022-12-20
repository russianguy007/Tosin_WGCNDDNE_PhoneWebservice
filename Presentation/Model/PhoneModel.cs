using Tosin_WGCNDDNE_WebServices.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Tosin_WGCNDDNE_WebServices.Presentation.Model
{
    public class PhoneModel
    {
        public string Brand { get; set; }
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public int Id { get; set; }

        public Phone ToDomainObject()
        {
            return new Phone
            {
                id = this.Id,
                Brand = this.Brand,
                ReleaseYear = this.ReleaseYear,
                Name = this.Name
            };
        }
    }
}
