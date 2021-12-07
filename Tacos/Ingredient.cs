using System;
using System.Collections.Generic;

namespace Tacos
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Composition> Tacos { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}