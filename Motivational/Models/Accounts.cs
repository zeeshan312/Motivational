using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Motivational.Models
{
    public class Accounts
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string  Employees { get; set; }

        public static implicit operator Accounts(Accounts v)
        {
            throw new NotImplementedException();
        }
    }
}