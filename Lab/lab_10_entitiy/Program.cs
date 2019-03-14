using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace lab_10_entitiy
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();
        static void Main(string[] args)
        {
            // Insert New Customer
            using (var db = new NorthwindEntities())
            {
                var customeToCreate = new Customer
                {
                    CustomerID = "ABCDE",
                    ContactName = "Great Name",
                    City = "Some Town",
                    CompanyName = "Bedrock"
                };

                // Add new customer to local Database 
                db.Customers.Add(customeToCreate);
                // Write changes permanantly to databse
                db.SaveChanges();
            }
            DisplayAll();


            // CRUD Create, Read, Update Delete : R-READ
            // Selext one customer
            using (var db = new NorthwindEntities())
            {
                // Linq Query: Microsoft : Language Independent Query
                var customerToUpdate =
                    // Select all Customers in Northwind
                    (from customer in db.Customers
                    // Choose where ID matches
                    where customer.CustomerID == "ALFKI"
                    // Output this one selected
                    select customer).FirstOrDefault();
                Console.WriteLine("\n\nFinding One Customer\n");
                Console.WriteLine($"{customerToUpdate.ContactName} lives in {customerToUpdate.City}\n\n");
            }

            //using (var db = new NorthwindEntities())
            //{
            //    // Linq Query: Microsoft : Language Independent Query
            //    var customerToUpdate2 =
            //        db.Customers.Where(c => c.CustomerID == "ALFKI").FirstOrDefault();
            //    Console.WriteLine("\n\nFinding another Customer\n");
            //    Console.WriteLine($"{customerToUpdate2.ContactName} lives in {customerToUpdate2.City}");

            //    // UPDATE
            //    customerToUpdate2.ContactName = "Fred Flinstone";
            //    // Update database on permenantly
            //    db.SaveChanges();
            //}

            using (var db = new NorthwindEntities())
            {
                var customerToDelete = db.Customers.Where(C=>C.CustomerID== "ABCDE").FirstOrDefault();
                db.Customers.Remove(customerToDelete);
                db.SaveChanges();
            }
            DisplayAll();
        }

        static void DisplayAll()
        {
            // encapsulate data to protect it
            ; using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList<Customer>();
            }
            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.ContactName} as ID " +
                    $"{customer.CustomerID} from { customer.City}");
            }
        }
    }
}
