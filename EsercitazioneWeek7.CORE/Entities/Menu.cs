﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneWeek7.CORE.Entities
{
    public class Menu
    {
        public int Id { get; set; }
        public string Nome { get; set; }    
        public ICollection<Piatto>? Piatti { get; set; } = new List<Piatto>();

    }
}
