using System;
using System.Collections.Generic;
using System.Text;

namespace Exer
{
    class Hora
    {
        public string Name { get; set; }
        public int Height { get; set; }

        public Hora(string name, int height)
        {
            Name = name;
            Height = height;
        }

        public override string ToString()
        {
            return Name + ", " + Height;
        }
    }
}
