﻿using Neon.FinanceBridge.Data.SQL.Entities.Impl;
using System;
using System.Collections.Generic;
using System.Text;

namespace Neon.FinanceBridge.Domain.Models
{
  public  class Item: BaseEntity<int>
    {
       
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int MinimumQuantity  { get; set; }
    }
}
