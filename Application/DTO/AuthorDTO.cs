﻿using BookAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAPI.Application.DTO
{
    public class UpdateAuthorDTO
    {
        public string Name { get; set; }
        public string Surename { get; set; }
        public Country country { get; set; }
        public int CountryID { get; set; }
            
    }
}