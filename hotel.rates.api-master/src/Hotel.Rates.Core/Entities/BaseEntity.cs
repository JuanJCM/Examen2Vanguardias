using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Rates.Core.Entities
{
    public abstract class BaseEntity<TKey>
    {
        public virtual TKey Id { get; set; }
    }
}
