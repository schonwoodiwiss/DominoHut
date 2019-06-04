using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DominoHut.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string Name { get; set; }
        public bool IsKosher { get; set; }
        public bool IsVegan { get; set; }
        public bool IsSpicy { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}