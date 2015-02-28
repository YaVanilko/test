using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MappingTest.Entities
{
    public class Order
    {
        public virtual int Id { get; set; }

        public virtual string Description { get; set; }

        public virtual int SenderId { get; set; }

        public virtual int RecipientId { get; set; }
        
        public virtual int SendingStoreId { get; set; }

        public virtual int ReceivingStoreId { get; set; }

        public virtual DateTime ShipingDate { get; set; }

        public virtual DateTime ReceivingDate { get; set; }

        public virtual Store SendingStore { get; set; }

        public virtual IList<Pack> Packs { get; set; }

    }
}
