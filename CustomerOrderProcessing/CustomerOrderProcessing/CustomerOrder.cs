using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderProcessing
{
    public class CustomerOrder
    {
        public int OrderId;
        public DateTime OrderDate;

        private static Queue<CustomerOrder> customerOrdersQueue = new Queue<CustomerOrder>();

        public CustomerOrder(int orderId, DateTime orderDate)
        {
            OrderDate = orderDate;
            OrderId = orderId;
        }

        public static void ReceiveOrder(CustomerOrder customerOrder)
        {
            customerOrdersQueue.Enqueue(customerOrder);
        }

        public static void ShowOrder()
        {
            Console.WriteLine("Customer Orders:");

            foreach (var item in customerOrdersQueue)
            {
                Console.WriteLine($"orderId: {item.OrderId}, orderDate: {item.OrderDate}");
            }
        }

        public static void DequeueOrders()
        {
            while (customerOrdersQueue.Count > 0)
            {
                var customerOrder = customerOrdersQueue.Dequeue();
                Console.WriteLine($"orderId: {customerOrder.OrderId}, orderDate: {customerOrder.OrderDate} has being processed");
            }
        }
    }
}
