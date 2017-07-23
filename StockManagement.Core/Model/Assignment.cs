using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Depot.SharedKernel;

namespace StockManagement.Core.Model
{
    public class Assignment : Entity<Guid>
    {
        public int ItemId { get; set; }
        public int ContainerId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
