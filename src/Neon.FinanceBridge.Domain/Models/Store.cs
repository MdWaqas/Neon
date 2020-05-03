using Neon.FinanceBridge.Data.SQL.Entities.Impl;
using System;
using System.Collections.Generic;
using System.Text;

namespace Neon.FinanceBridge.Domain.Models
{
  public  class Store : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Logo { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int City { get; set; }
        public int State { get; set; }
        public string PostCode { get; set; }
        public int Country { get; set; }
        public string RecieptHeader { get; set; }
        public string RecieptFooter { get; set; }
    }
}
