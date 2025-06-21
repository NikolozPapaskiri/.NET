using System;

namespace CustomerOrderProcessing
{
    public class Program
    {
        public static void Main()
        {
            var customerOrder1 = new CustomerOrder(1, DateTime.Now);
            var customerOrder2 = new CustomerOrder(2, DateTime.Now);

            CustomerOrder.ReceiveOrder(customerOrder1);
            CustomerOrder.ReceiveOrder(customerOrder2);

            Console.WriteLine("___Show All The Customer Orders____");
            CustomerOrder.ShowOrder();

            Console.WriteLine("___Dequeue Customer Orders____");
            CustomerOrder.DequeueOrders();

            Console.WriteLine("___Show All The Customer Orders After Dequeue____");
            CustomerOrder.ShowOrder();
        }
    }
}
