namespace linq_optimisation
{
    using System;
    using System.Data.Linq;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            using(var context = new NorthwindDBContext())
            {
                context.Database.Log = Console.Write;

                //var data = context.Customers
                //    .GroupJoin(context.Orders, c => c.CustomerID, o => o.CustomerID, (c, o) => new { Customer = c.CompanyName, Orders = o.FirstOrDefault() });

                //foreach (var c in data)
                //{
                //    Console.WriteLine(c.Customer + " " + c.Orders);
                //}

                var newData = context.Customers.Join(context.Orders, c => c.CustomerID, o => o.CustomerID, (c, o) => new { Customer = c.CompanyName, Orders = o });
                foreach (var c in newData)
                {
                    Console.Write(c.Customer);
                    if(c.Orders != null)
                    {
                        Console.Write(" : " + c.Orders.OrderID);
                    }
                    else
                    {
                        Console.Write(" : No Order");
                    }
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
