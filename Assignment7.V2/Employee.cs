using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7.V2
{
    class Employee:IComparable<Employee>
    {
        public string lastName;
        public int priority; // larger values are higher priority
        public string now;

        public Employee(string lastName, int priority, string now)
        {
            this.lastName = lastName;
            this.priority = priority;
            this.now = now;
        }

        public override string ToString()
        {
            return lastName + "\t"+"\t" + priority.ToString("F1")+"\t"+ now;
        }

        public int CompareTo(Employee other)
        {
            if (this.priority > other.priority) return -1;
            else if (this.priority < other.priority) return 1;
            else return 0;
        }

    }
}
