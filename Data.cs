using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Candy
{
    public class Data
    {
        public string asin { set; get; }
        public List<detail> list { set; get; }
    }
    public class detail
    {
        public string size_name { set; get; }
        public string ASIN { set; get; }
        public string color_name { set; get; }
    }
}
