using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public class DataModel
    {
        public Guid ID { get; set; }
        public int Counter { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
    }
}
