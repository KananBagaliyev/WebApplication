﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class VideoContent
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
    }
}
