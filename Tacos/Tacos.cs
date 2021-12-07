using System;
using System.Collections.Generic;

namespace Tacos
{
    public class Tacos
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
    }
}