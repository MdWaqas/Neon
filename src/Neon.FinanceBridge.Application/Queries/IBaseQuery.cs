using System;
using System.Collections.Generic;
using System.Text;

namespace Neon.FinanceBridge.Application.Queries
{
    public interface IBaseQuery
    {
        T GetById<T>(string sql, Dictionary<string, object> parameters = null);
        IEnumerable<T> GetAll<T>(string sql, Dictionary<string, object> parameters = null);
    }
}
