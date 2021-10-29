using enumeracao.Entities;
using enumeracao.Entities.Enums;
using System;

namespace enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //convert enum => string
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            //convert string => enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);

        }
    }
}
