﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHusbandryMod.animals.data
{
    public interface FeatherAnimalItem : MeatAnimalItem
    {
        int MinimumNumberOfFeatherChances { get; set; }
        int MaximumNumberOfFeatherChances { get; set; }
    }
}
