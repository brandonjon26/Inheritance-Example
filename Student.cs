using System;

namespace Inheritance
{
    public class Student : Person
    {
        public int StudentNumber { get; set; }
        public string Major { get; set; }
        public decimal GPA { get; set; }

        public override void Talk()
        // overriding(changing) method of the person class
        {
            base.Talk();
            // calls the original Talk method
            Console.WriteLine($"My GPA is {GPA}.");
            // calls the new Talk method
        }
    }
}
