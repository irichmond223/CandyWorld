using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyWorld.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order Order);
    }
}
