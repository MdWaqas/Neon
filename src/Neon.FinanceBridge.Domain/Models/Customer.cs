using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Neon.FinanceBridge.Data.SQL.Entities.Impl;

namespace Neon.FinanceBridge.Domain.Models
{
    public class Customer : BaseEntity<int>
    {
        [Required(ErrorMessage = "The First Name is Required")]
        [StringLength(100)]
        [MinLength(2)]
        [MaxLength(100)]
        public string FirstName { get;  set; }
        [Required(ErrorMessage = "The Last Name is Required")]
        [StringLength(100)]
        [MinLength(2)]
        [MaxLength(100)]
        public string LastName { get;  set; }
        [Required(ErrorMessage = "The E-mail is Required")]
        [StringLength(320)]
        [EmailAddress]
        public string Email { get;  set; }
        [Required(ErrorMessage = "The NIC is Required")]
        [StringLength(15)]
        [MinLength(15)]
        [MaxLength(15)]
        public string NIC { get;  set; }
    }
}
