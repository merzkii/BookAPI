using BookAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAPI.Application.Interfaces
{
    public interface IAuthor2BooksRepository
    {
        Task<ICollection<Author2Books>>

    }
}
