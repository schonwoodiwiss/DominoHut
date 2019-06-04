using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DominoHut.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}