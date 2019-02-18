using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Collections.Generic;

namespace lab_10_entity
{
    class Program
    {

        static List<Customer> customers = new List<Customer>();

        static void Main(string[] args)
        {


            // insert new customer

            using (var db = new NorthwindEntities())
            {
                var customerToCreate = new Customer
                {
                    CustomerID = "PHIL4",
                    ContactName = "Great Name",
                    City = "Some Town",
                    CompanyName = "I work here"
                };

                // Now add new customer to local database
                db.Customers.Add(customerToCreate);
                // write changes permanently to real database
                db.SaveChanges();
            }




            // CRUD    R=READ   

            // select one customer



            using (var db = new NorthwindEntities())
            {
                // LINQ query : Microsoft : Language Independent Query
                var customerToUpdate =
                       db.Customers.Where(c => c.CustomerID == "PHIL4").FirstOrDefault();     
                Console.WriteLine("\n\nfinding one customer\n");
                Console.WriteLine($"{customerToUpdate.ContactName} " +
                    $"lives in {customerToUpdate.City}");

                // Update customer
                customerToUpdate.ContactName = "Fred Flintstone";
                customerToUpdate.City = "Bedrock";
                // Update DB permanently
                db.SaveChanges();
            }

            // have a look at customers after INSERT AND UPDATE
            Console.WriteLine("\n\nView customers after INSERT and UPDATE\n\n");
            DisplayAll();

            // delete
            using (var db = new NorthwindEntities())
            {
                var customerToDelete = db.Customers
                    .Where(c => c.CustomerID == "PHIL4")
                    .FirstOrDefault();
                db.Customers.Remove(customerToDelete);
                db.SaveChanges();
            }

            // have a look at customers after DELETE
            Console.WriteLine("\n\nView customers after DELETE\n\n");
            DisplayAll();

        }

        static void DisplayAll()
        {
            // encapsulates database connection so it's closed cleanly
            using (var db = new NorthwindEntities())
            {
                // customers list = (read from northwind).
                //              (pull out all customers)
                //             (send to list of customers)
                customers = db.Customers.ToList<Customer>();
            }

            // use list!!!
            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.ContactName} has ID " +
                    $"{customer.CustomerID} from {customer.City}");

            }
        }
    }
}
