using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string MoreInfo { get; set; }
        

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
        public string FullName
        {
            get
            {
                return FirstName + " " + MiddleName + " " + LastName;
            }
        }
    }
}
