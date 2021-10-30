using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Space
    {
        public int Position { get; set; }
        public string Type { get; set; }

        public Space(int position, string type)
        {
            Position = position;
            Type = type;
        }
    }
}
