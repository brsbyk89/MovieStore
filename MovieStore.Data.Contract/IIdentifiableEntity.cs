using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Data.Contract
{
    public interface IIdentifiableEntity<TEntityKey>
    {
        TEntityKey EntityId { get; set; }
    }
}
