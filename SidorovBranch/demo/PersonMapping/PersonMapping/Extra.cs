﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonMapping
{
    public class Extra
    {
        public virtual int Id { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public virtual int PersonId { get; set; }
    }
}
