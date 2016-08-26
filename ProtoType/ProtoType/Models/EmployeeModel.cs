using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProtoType.Models
{
    public class EmployeeModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Contact { get; set; }
        public string EmailId { get; set; }
    }
}