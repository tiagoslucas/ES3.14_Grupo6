﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestorHorarioG6.Models
{
    public class Bloco
    {
        [Key]
        public int BlocoId { get; set; }

        [Required]
        public string Nome { get; set; }
    }
}
