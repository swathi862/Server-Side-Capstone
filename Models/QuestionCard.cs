﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CardGame.Models
{
    public class QuestionCard
    {
        [Key]
        public int QuestionCardId { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
