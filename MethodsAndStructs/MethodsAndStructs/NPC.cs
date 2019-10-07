using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndStructs
{
    //constructors
    struct NPC
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public NPC(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public NPC(string name) : this(name, 200)
        {

        }
    }
}
