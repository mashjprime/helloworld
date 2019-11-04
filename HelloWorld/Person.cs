using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        string middleName = "Jungalist";

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
        public string FullName
        {
            get
            {
                return FirstName + " " + middleName + " " + LastName;
            }
        }
    }
}
