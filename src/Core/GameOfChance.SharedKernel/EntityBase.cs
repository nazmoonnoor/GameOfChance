﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfChance.SharedKernel
{
    public abstract class EntityBase
    {
        public Guid Id { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? CreatedBy { get; set; }
    }
}