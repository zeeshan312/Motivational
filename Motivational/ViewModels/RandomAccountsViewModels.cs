using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Motivational.Models;

namespace Motivational.ViewModels
{
    public class RandomAccountsViewModels
    {
        public Accounts Salesman { get; set; }
        public List<Customer> Customer { get; set; }
    }
}