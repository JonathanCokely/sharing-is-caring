﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SharingIsCaring.Models
{
    public class Message
    {
        public int Id { get; set; }
        [Required]
        public string User { get; set; }
        [Required]
        public string Text { get; set; }
        public DateTime When { get; set; }
    }
}