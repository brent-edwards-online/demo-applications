using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_groupby_demo
{
    class Program
    {
        

        static void Main(string[] args)
        {
             //using(var context = new StoreDbContext())
             //{
             //   var data = context.Customers.Join(context.Orders, c => c.Id, o => o.CustomerId, (c,o) => new { Customer = c, Orders = o })
             //              .Join(context.OrderItems, o => o.Orders.Id, i => i.OrderId, (o, i ) => new { Customer = o.Customer, Orders = o.Orders, OrderItems = i });


             //   foreach(var d in data)
             //   {
             //       Console.WriteLine(d.Customer.FirstName + " " + d.Customer.LastName + "\nOrder Id: " + d.Orders.Id);
             //   }

             //}

            using (var context = new StoreDbContext())
            {
                var data = context.Customers
                    .GroupJoin(context.Orders, c => c.Id, o => o.CustomerId, (c, o) => new { Customer = c, Orders = o });
                           


                foreach (var d in data)
                {

                    Console.WriteLine(d.Customer.FirstName + " " + d.Customer.LastName + " " + d.Orders.Count());
                }

            }

            Console.ReadKey();

        }
    }
}
