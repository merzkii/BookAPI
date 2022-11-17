using BookAPI.Domain.EntityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAPI.Domain
{
    public class Book: BaseEntity
    {
        public string Title { get; set; }
        public ICollection<Author2Books> Author2Book { get; set; }
    }
}
