using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketUygulama
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TC { get; set; }
        public string Phone { get; set; }
        public string CreatedTime { get; set; }
        public string UpdatedTime { get; set; }
        public string Birthdate { get; set; }
        public string Hobbies { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}
