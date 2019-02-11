using System;
using ListData;
using ListDataManager;
using System.Collections.Generic;

namespace ListDataTemplate
{
    public class Pokemon
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public string Type { get; set; }
        public Pokemon EvolveInto { get; set; }
    }
}