﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDBahia.NET.SRP
{
    public class CustomerManager
    {

        //public static List<Customer> GetCustomers(int startRowIndex, int maximumRows)
        //{
        //    List<Customer> customers = null;
        //    string key = "Customers_Customers_" + startRowIndex + "_" + maximumRows;

        //    if (HttpContext.Current.Cache[key] != null)
        //    {
        //        customers = (List<Customer>)HttpContext.Current.Cache[key];
        //    }
        //    else
        //    {
        //        customers =
        //            (
        //                from
        //                    c in DataGateway.Context.Customers
        //                orderby
        //                    c.CustomerID descending
        //                select
        //                    c
        //            ).Skip(startRowIndex).Take(maximumRows).ToList();

        //        if ((customers != null) && (customers.Count > 0))
        //            HttpContext.Current.Cache.Insert(key, customers, null, DateTime.Now.AddDays(1), TimeSpan.Zero);
        //    }

        //    return customers;
        //}
    }

}
