﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Entity_Layer.Concrete
{
    public class Experience
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}