﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    internal interface IEmployee
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal Getsalery();
    }
}
