﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.Model
{
    public abstract class NamedEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Name must be at least 3 characters long")]
        public string Name { get; set; }

        [MinLength(10, ErrorMessage = "Description must be at least 10 characters long")]
        public string? Description { get; set; }
    }
}
