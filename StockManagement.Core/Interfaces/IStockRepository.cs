using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Core.Model;

namespace StockManagement.Core.Interfaces
{
    public interface IStockRepository
    {
        IReadOnlyCollection<Container> GetStock(ItemFilter itemFilter);
    }
}
