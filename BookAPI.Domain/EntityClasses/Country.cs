using BookAPI.Domain.EntityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAPI.Domain
{
    public class Country: BaseEntity
    {
        public string Name { get; set; }
        public List<Author> Authors { get; set; }
    }
}
