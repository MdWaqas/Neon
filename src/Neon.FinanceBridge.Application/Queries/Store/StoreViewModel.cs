using System;
using System.Collections.Generic;
using System.Text;

namespace Neon.FinanceBridge.Application.Queries.Store
{
    public class StoreViewModel
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Logo { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
