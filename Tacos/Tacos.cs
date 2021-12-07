using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tacos
{
    public class Tacos
    {
        public int Id { get; set; }
        [Required, StringLength(50, MinimumLength = 1)]
        public string Name { get; set; }
        public List<Composition> Ingredients { get; set; }

        public override string ToString()
        {
            return $"{Name} ({String.Join(",", Ingredients ?? new List<Composition>())})";
        }
    }
}