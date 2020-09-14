using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyWorld.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        //link to our actual order
        public int OrderId { get; set; }

        //what candy is being ordered
        public int CandyId { get; set; }
        public Candy Candy { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }

        //link to the order itself, it will create a relationship between Order and Order Details
        public Order Order { get; set; }

    }

}
