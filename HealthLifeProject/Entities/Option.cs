﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Entities
{
    public class Option
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }

        public string Relation { get; set; }

        public int Order { get; set; }
    }
}
