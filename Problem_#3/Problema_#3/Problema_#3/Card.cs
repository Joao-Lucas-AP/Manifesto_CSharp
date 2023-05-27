using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema__3
{
    public class Card
    {
        public string Type { get; set; }
        public string Name { get; set; }

        public Card(string type, string name)
        {
            Type = type;
            Name = name;
        }
    }
}
