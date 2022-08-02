using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzMVC.Models
{
    public class FBModel
    {
        public int FizzNum { get; set; }
        public int BuzzNum { get; set; }
        public int StartNum { get; set; }
        public int EndNum { get; set; }
        public List<string> Results { get; set; } = new List<string>();
    }
}
