﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory.RestAPI.Entities
{
    public class RawMaterialInventoryItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Percentage { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
