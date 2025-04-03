﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission90.Dal.Models
{
    public class Category
    {
        [Key]
        public int Category_Id { get; set; }

        public string CategoryName { get; set; }

        public int? DisplayOrder { get; set; }
    }
}
