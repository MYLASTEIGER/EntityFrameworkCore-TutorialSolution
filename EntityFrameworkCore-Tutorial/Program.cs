using EntityFrameworkCore_Tutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkCore_Tutorial {
    class Program {

        static void Main(string[] args) {

            AppDbContext context = new AppDbContext();

            var max = context.Customers.Find(1);
            max.Sales += 5000;
            context.SaveChanges();


            //adding new data doesnt actually add to database must use the context.save changes to add
            //var newCustomer = new Customer() {
              //  Id = 0, Name = "Kroger", Active = true,
                //Sales = 3000000, Updated = new DateTime(2022, 2, 11)
            //};
            //context.Customers.Add(newCustomer);
            //context.SaveChanges();


            //read customer by primary key
            //var customer = context.Customers.Find(2);
            //Console.WriteLine($"{customer.Name} {customer.Sales:c}");


            //this below is Query syntax
            var customers = from cust in context.Customers
                                //where cust.Sales < 100000
                            select cust;


            //this below is method syntax
            //List<Customer> customers = context.Customers
            //    .Where(cust => cust.Sales < 100000)                    
            //    .ToList();
            foreach (var customer in customers) {
                Console.WriteLine($"{customer.Name, 20} {customer.Sales, 10:c}");
            }

        }
    }
}

    

