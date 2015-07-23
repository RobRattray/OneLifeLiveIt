﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebVideoPortal.Constants.Enums
{
    public enum ActivityLevel
    {
        Sedentary = 0,
        Moderate = 1,
        Active = 2,
        [Description("Very Active")]
        VeryActive = 3
    }
}
