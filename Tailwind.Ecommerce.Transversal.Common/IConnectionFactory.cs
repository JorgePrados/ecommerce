using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Tailwind.Ecommerce.Transversal.Common
{
    public interface IConnectionFactory
    {
        IDbConnection GetConnection { get; }
    }
}
