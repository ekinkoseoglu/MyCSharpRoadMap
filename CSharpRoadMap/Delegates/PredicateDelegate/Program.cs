using System;
using System.Collections.Generic;

namespace PredicateDelegate
{
    class Program
    {
        /* A Predicate delegate is typically used to search items in a collection or a set of data.Here is the syntax for a Predicate delegate.

          "Predicate<T>"

             Note that Predicate<T> is basically equivalent to    "Func<T, bool>"          .*/
        static void Main(string[] args)
        {
            // Next, create a list of customers and store objects of type Customer into it.
            List<Customer> custList = new List<Customer>();
            custList.Add(new Customer { Id = 1, FirstName = "Joydip", LastName = "Kanjilal", State = "Telengana", City = "Hyderabad", Address = "Begumpet", Country = "India" });
            custList.Add(new Customer { Id = 2, FirstName = "Steve", LastName = "Jones", State = "OA", City = "New York", Address = "Lake Avenue", Country = "US" });

            //The following is the complete code listing that shows how we can use a Predicate delegate to search data.
            // 1-) Created a Predicate Delegate which has a Customer as a parameter called "hydCustomers"
            Predicate<Customer> hydCustomers = (x => x.Id == 1); // We're creating a filter and giving a name to this filter as "hydCustomers" using Predicate Delegate
            Customer customer = custList.Find(hydCustomers);  // Find the customer from list which suits for hydCustomers filter
            Console.WriteLine(customer.FirstName); // Write the customer from list which suits for hydCustomers filter
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        


    }
    /* Points to Remember:

      -Note that Predicate<T> is basically equivalent to    "Func<T, bool>" 
      -Predicate delegate takes one input parameter and boolean return type.
      -Anonymous method and Lambda expression can be assigned to the predicate delegate.   */
}
