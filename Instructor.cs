using System;

namespace Inheritance
{
    public class Instructor : Person
    // this is an example of inheritance. By adding ": Person" it gives instructor access to all of the properties contained in Person.cs
    {
        public string Specialty { get; set; }
        public string Email { get; set; }
    }
}