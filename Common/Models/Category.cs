﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string  CategoryName { get; set; }
        public string CreatedUser { get; set; }
        public string UpdatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
