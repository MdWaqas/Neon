using System;
using System.Collections.Generic;
using System.Text;

namespace Neon.FinanceBridge.Application.Commands.Item
{
   public class ItemCommand
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int MinimumQuantity { get; set; }
    }
}
