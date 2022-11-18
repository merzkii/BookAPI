using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAPI.Application.DTO
{
    public class UpdateAuthorsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }
        public int CountryID { get; set; }
    }
}
