using Domain.Abstract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class EFItemRepository: IItemRepository
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<item> items
        {
            get { return context.items;  }
        }
    }
}
