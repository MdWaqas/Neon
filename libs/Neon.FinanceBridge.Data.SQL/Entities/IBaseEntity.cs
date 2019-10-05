using System;
using Neon.FinanceBridge.Common.Utils.Enums;

namespace Neon.FinanceBridge.Data.SQL.Entities
{
    public interface IBaseEntity
    {
        object Id { get; set; }
        DateTime CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime? ModifiedDate { get; set; }
        string ModifiedBy { get; set; }
        Status Status { get; set; }
        byte[] RowVersion { get; set; }
    }

    public interface IBaseEntity<TId> : IBaseEntity
    {
        new TId Id { get; set; }
    }
}