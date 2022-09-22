using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample.Models
{
        public class Snake : Animal
        {
            public Snake(string name)
            {
                Name = name;
            }

            public Snake()
            {
                Name = "Diamond";
            }

            public override void MakeNoise()
            {
                Console.WriteLine($"{Name} says hiss");
            }
        }
    
}
