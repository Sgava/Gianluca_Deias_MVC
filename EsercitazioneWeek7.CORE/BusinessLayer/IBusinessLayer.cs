﻿using EsercitazioneWeek7.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneWeek7.CORE.BusinessLayer
{
    internal interface IBusinessLayer
    {
        List<Piatto> GetAllPiatti();
        
    }
}
