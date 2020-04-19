using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Neon.FinanceBridge.Common.Utils.Enums;

namespace Neon.FinanceBridge.Data.SQL.Entities.Impl
{
    public abstract class BaseEntity<T> : IBaseEntity<T>
    {
        object IBaseEntity.Id
        {
            get => Id;
            set => Id = (T)Convert.ChangeType(value, typeof(T));
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Status Status { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}