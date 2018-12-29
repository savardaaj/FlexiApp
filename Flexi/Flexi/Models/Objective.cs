using System;
using System.Collections.Generic;
using System.Text;

namespace Flexi.Models
{
    public class Objective
    {
        public int ID { get; set; }
        public String title { get; set; }
        public String description { get; set; }
        public String location { get; set; }
        public String fk_blockID { get; set; }
        public int duration { get; set; }
        public int frequency { get; set; }

    }
}
