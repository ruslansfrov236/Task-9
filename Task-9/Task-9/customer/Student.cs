using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9.customer
{
    public class Student
    {
        public string Name { get; set; }
        private static byte ageCounter = 0;
        private byte age;

        public byte Age
        {
            get { return age; }
        }

        public Student()
        {
            ageCounter++;
            age = ageCounter;
        }
    }
}
