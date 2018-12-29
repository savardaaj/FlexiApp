using System;
using System.Collections.Generic;
using System.Text;

namespace Flexi.Models
{
    public class Block
    {
        public int ID { get; set; }
        public String title { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
    }
}
