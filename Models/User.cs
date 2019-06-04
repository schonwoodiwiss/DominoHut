﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DominoHut.Models
{
    public class User
    {
        public int UserId { get; set; }
        public bool IsAdmin { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        ICollection<Order> UserOrders { get; set; }
    }
}