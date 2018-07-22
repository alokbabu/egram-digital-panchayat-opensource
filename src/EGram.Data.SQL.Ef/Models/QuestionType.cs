﻿using System;
using System.ComponentModel.DataAnnotations;

namespace EGram.Data.EF.Models
{
    public class QuestionType
    {
        [Key]
        public int QuestionId { get; set; }
        public string Type { get; set; }
    }
}
