using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreEf
{
    public class Order
    {
        public int Id { get; set; }
        public string MyProperty { get; set; }
        public int GoodId { get; set; }
        public virtual Good good { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public DateTime DateTimeSend { get; set; }
    }
}
