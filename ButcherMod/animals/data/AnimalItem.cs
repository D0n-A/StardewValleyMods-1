﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButcherMod.animals
{
    public interface AnimalItem
    {
        int MinimalNumberOfMeat { get; set; }
        int MaximumNumberOfMeat { get; set; }
    }
}
