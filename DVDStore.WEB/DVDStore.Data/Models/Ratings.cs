﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DVDStore.Data.Models
{
    public class Ratings
    {
        public int Id { get; set; }
        [Required]
        public string Rating { get; set; }

    }
}
