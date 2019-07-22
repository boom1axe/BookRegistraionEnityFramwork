﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRegistraionEnityFramwork
{
    static class CustomerDB
    {
        /// <summary>
        /// Returns all customers from the database
        /// </summary>
        /// <returns></returns>
        public static List<Customer> GetCustomers()
        {
            //Create instance of DB Context
            var db = new BookRegistrationEntities();

            // Use DB Context to retreive all customers
            // Use LINQ (Language INtegrated Query)
            // to query database

            // LINQ Query Syntax
            //List<Customer> customers =
            //    (from c in db.Customer
            //    select c).ToList();

            // LINQ Method Syntax - Same query as above
            List<Customer> customers =
                db.Customer
                    //.where(cust => cust.LastName)
                    //.orderByDescending(c => c.LastName)
                    .ToList();

            return customers;
        }

        /// <summary>
        /// Adds a customer. returns the newly added customer
        /// with the CustomerId populated
        /// </summary>
        /// <param name="c">The new Customer to be added</param>
        /// <returns></returns>
        public static Customer AddCustomer(Customer c)
        {
            throw new NotImplementedException();
        }
    }
}
