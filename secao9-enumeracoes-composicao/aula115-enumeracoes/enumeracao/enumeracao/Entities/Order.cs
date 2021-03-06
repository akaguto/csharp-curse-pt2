using System;
using System.Collections.Generic;
using System.Text;
using enumeracao.Entities.Enums;

namespace enumeracao.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; } //enum

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}
